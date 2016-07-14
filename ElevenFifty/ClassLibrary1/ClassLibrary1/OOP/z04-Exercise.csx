using System;
using System.Collections;


public class MobPhone
{
    private string _make;
    private string _model;



         public MobPhone(string make, string model)
    {
        Console.WriteLine("Logging the MAKE and MODEL...");
        Make = make;
        Model = model;

    }
    public string Make
    {
        get { return _make; }
        set { _make = value.Trim(); }
    }
    public string Model
    {
        get { return _model; }
        set { _model = value.Trim(); }
    }
    public override string ToString()
    {
        return $"{Make}, {Model}";

    }
};



var p = new MobPhone("Apple", "Iphone 6");
var pp = new MobPhone("Apple", "Iphone 5s");
var ppp = new MobPhone("Apple", "Iphone 5c");
var pppp = new MobPhone("Apple", "Iphone 5");
var ppppp = new MobPhone("Apple", "Iphone 4");

Console.WriteLine(p);
Console.WriteLine(pp);
Console.WriteLine(ppp);
Console.WriteLine(pppp);
Console.WriteLine(ppppp);

var phones =
    new DictionaryBase<string, MobPhone>
    {
        {"Pat", new MobPhone("Samsung", "Note 5") },
        {"Sally", new MobPhone("Samsung", "Note 4") },
        {"Amna", new MobPhone("Apple", "Iphone 6") },
        {"Matt", new MobPhone("Apple", "Iphone 5s") }
    };