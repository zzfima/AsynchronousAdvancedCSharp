//from https://www.youtube.com/watch?v=RqJESGHEMDY&ab_channel=FullStackAmigo


internal class ChannelStateMachineProgram
{
    public static async Task Main(string[] args)
    {
        Amigo amigo = new Amigo();
        await amigo;
    }
}

public class Amigo
{
    public bool IsSubscribed { get; set; }

    private async Task WatchVideoAsync()
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
    }

    public AmigoAwaiter GetAwaiter()
    {
        return new AmigoAwaiter(this);
    }

    public class AmigoAwaiter : INotifyCompletion
    {
        private readonly Task task;
        public AmigoAwaiter(Amigo channel)
        {
            task = channel.WatchVideoAsync();
        }

        public bool IsCompleted => task.IsCompleted;

        public void GetResult() => task.GetAwaiter().GetResult();

        public void OnCompleted(Action continuation)
        {
            task.ContinueWith(c => continuation);
        }
    }
}
