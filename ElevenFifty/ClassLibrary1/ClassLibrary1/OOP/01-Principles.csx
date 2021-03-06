﻿// Object Oriented Programing

// Encapsulation

public class MyClass
{
    private string _value = "";

    public string Value
    {
        get { return _value; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                _value = value;
            }
            else
            {
                throw new ArgumentException("Value is meh");


            }



        }
    }

    public int AddTwoIntegers(int a, int b)
    {
        return a + b;
    }


};

var mc = new MyClass();
mc.Value = "Hello!";
mc.AddTwoIntegers(3, 2)


// Inheritance
var mc2 = new MyClass();
mc2.ToString();

// Polymorphism

string WhatIsIt(object o)
{
    if (o is MyClass) return "MyClass";
    if (o is string) return "string";
    return "Object";
}

WhatIsIt(mc);
WhatIsIt("Hello");
WhatIsIt(new object());
WhatIsIt(null);
