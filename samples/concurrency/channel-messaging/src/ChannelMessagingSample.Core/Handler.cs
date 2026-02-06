namespace ChannelMessagingSample.Core;

using System.Threading.Channels;

/// <summary>
/// Inter-task communication using channels.
/// </summary>
public class Handler
{
    public string Process() => "Channel messaging system initialized";
}

public record Message(string Id, string Content, DateTime Timestamp);

public class MessageBroker
{
    private readonly Channel<Message> _channel = Channel.CreateUnbounded<Message>();
    private int _processedCount;
    
    public async Task PublishAsync(Message message) => 
        await _channel.Writer.WriteAsync(message);
    
    public async IAsyncEnumerable<Message> ConsumeAsync()
    {
        await foreach (var msg in _channel.Reader.ReadAllAsync())
        {
            Interlocked.Increment(ref _processedCount);
            yield return msg;
        }
    }
    
    public int GetProcessedCount() => _processedCount;
    public void CompleteWriter() => _channel.Writer.Complete();
}
