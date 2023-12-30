//from https://www.youtube.com/watch?v=RqJESGHEMDY&ab_channel=FullStackAmigo

internal class ChannelStateMachineProgram
{
    public static async Task Main(string[] args)
    {
        ChannelStateMachine channelStateMachine = new ChannelStateMachine();
        var r = await channelStateMachine;
        Console.WriteLine(r);
    }
}

public class ChannelStateMachine
{
    public bool IsSubscribed { get; set; }

    private async Task<string> WatchVideoAsync()
    {
        Console.WriteLine("start watching");
        await Task.Delay(5000);
        Console.WriteLine("finish watching");
        Console.WriteLine("like video");
        if (!IsSubscribed)
        {
            IsSubscribed = true;
            Console.WriteLine("subscribed to the channel");
        }
        return "watched, liked, subscribed";
    }

    public TaskAwaiter<string> GetAwaiter()
    {
        return WatchVideoAsync().GetAwaiter();
    }
}
