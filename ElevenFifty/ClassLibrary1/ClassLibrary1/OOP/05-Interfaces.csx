#r "System.Windows.Forms.dll"
using System;
using System.Windows.Forms;

public interface IGreeter
{
    void SayHello(string name);
    //void SayGoodbye(string name);

}

public class ConsoleGreeter
    :IGreeter
{
    public void SayHello(string name)
    {
        Console.WriteLine($"Hello, {name}");
    }
    public void SayGoodbye(string name)
    {
        Console.WriteLine($"Goodbye, {name}");
    }
}
IGreeter cg = new ConsoleGreeter();

public class WindowsGreeter
    : IGreeter
{
    void IGreeter.SayHello(string name)
    {
        MessageBox.Show($"Hello, {name}", "Greetings!");
    }

}
IGreeter wg = new WindowsGreeter();
//wg.SayHello("pikachu");

public class Person
{

    private readonly IGreeter _greeter;

    public Person(IGreeter greeter)
    {
        _greeter = greeter;
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public void Greet(IGreeter greeter)
    {
        greeter.SayHello($"{FirstName} {LastName}")
    }
}
var p =
    new Person(cg)
    {
        FirstName = "Pikachu",
        LastName = "Pokemon"
    };
p.Greet();

public interface IDateTimeService
{
    DateTime GetCurrentLocalTime();
}

public class RealDateTimeService
    : IDateTimeService
{
    public DateTime GetCurrentLocalTime()
    {
        return DateTime.Now            
    }
}

public class FakeDateTimeService
    : IDateTimeService
{
    private readonly DateTime _testDate;

    public FakeDateTimeService(DateTime testDate)
    { }

}