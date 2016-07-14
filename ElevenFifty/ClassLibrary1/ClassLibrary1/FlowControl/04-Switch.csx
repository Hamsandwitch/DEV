// Switch

var x = 20;

switch (x)
{
    case 10:
        Console.WriteLine("x is 10");
        break;
    case 20:
    case 30:
        Console.WriteLine("x is 20");
        break;

    default:
        Console.WriteLine("X is not 10 or 20");
        break;
}

Console.WriteLine("Done");

var str = "Hello";

switch (str)
{
    case "Hello":
        Console.WriteLine("World");
        break;

    default "World":
        Console.WriteLine("Nevermind, this is default.");
        break;
        

}