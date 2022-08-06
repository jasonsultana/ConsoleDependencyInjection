namespace ConsoleDependencyInjection.Library;

public class MyService : IMyService
{
    public void DoTheThing() { Console.WriteLine("The thing is done!"); }
}

public interface IMyService
{
    void DoTheThing();
}

