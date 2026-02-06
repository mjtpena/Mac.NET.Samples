namespace ActorsSample.Core;

public class Handler { public string Process() => "Actor model ready"; }

public record ActorMessage(int Id, object Data);

public class SimpleActor
{
    private readonly Channel<ActorMessage> _channel = Channel.CreateUnbounded<ActorMessage>();
    public int MessageCount { get; private set; }

    public async Task SendAsync(ActorMessage msg)
    {
        await _channel.Writer.WriteAsync(msg);
        MessageCount++;
    }

    public async IAsyncEnumerable<ActorMessage> ReceiveAsync()
    {
        await foreach (var msg in _channel.Reader.ReadAllAsync())
            yield return msg;
    }
}