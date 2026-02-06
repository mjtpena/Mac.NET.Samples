namespace RwLockSample.Core;
public class Handler { public string Process() => "Reader-writer locks ready"; }
public class RwLock {
    private ReaderWriterLockSlim _lock = new();
    public void ReadLock(Action action) { _lock.EnterReadLock(); try { action(); } finally { _lock.ExitReadLock(); } }
}