namespace ReaderWriterLocksSample.Core;

/// <summary>
/// Reader-writer lock synchronization primitives.
/// </summary>
public class Handler
{
    public string Process() => "Reader-writer locks synchronized";
}

public class SimpleReaderWriterLock
{
    private int _activeReaders;
    private int _waitingWriters;
    private bool _activeWriter;
    private readonly object _lockObj = new();
    
    public void AcquireRead()
    {
        lock (_lockObj)
        {
            while (_activeWriter || _waitingWriters > 0)
                Monitor.Wait(_lockObj);
            _activeReaders++;
        }
    }
    
    public void ReleaseRead()
    {
        lock (_lockObj)
        {
            _activeReaders--;
            if (_activeReaders == 0)
                Monitor.PulseAll(_lockObj);
        }
    }
    
    public void AcquireWrite()
    {
        lock (_lockObj)
        {
            _waitingWriters++;
            while (_activeReaders > 0 || _activeWriter)
                Monitor.Wait(_lockObj);
            _waitingWriters--;
            _activeWriter = true;
        }
    }
    
    public void ReleaseWrite()
    {
        lock (_lockObj)
        {
            _activeWriter = false;
            Monitor.PulseAll(_lockObj);
        }
    }
}

public class ProtectedData
{
    private readonly SimpleReaderWriterLock _lock = new();
    private int _value;
    
    public int Read()
    {
        _lock.AcquireRead();
        try { return _value; }
        finally { _lock.ReleaseRead(); }
    }
    
    public void Write(int value)
    {
        _lock.AcquireWrite();
        try { _value = value; }
        finally { _lock.ReleaseWrite(); }
    }
}
