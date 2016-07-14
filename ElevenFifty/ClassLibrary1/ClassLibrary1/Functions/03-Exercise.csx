using System;
using System.Linq;


// ========================================================


var i = 0;
for (i = 0; x <= 100; x++)
{
    if (i % 15 == 0)
        {
        Console.WriteLine("FizzBuzz");
        }
    else if (i % 3 == 0)
        {
        Console.WriteLine("fizz");
        }
    else if (i % 5 == 0)
        {
        Console.WriteLine("buzz");
        }
    else
        {
        Console.WriteLine(i);
        }
}

// ====================================================





string GetFizzBuzzValue(int i)
{
    if (i % 15 == 0)
    {
        return "FizzBuzz";
    }
    else if (i % 3 == 0)
    {
        return "Fizz";
    }
    else if (i % 5 == 0)
    {
        return "buzz";
    }
    return i.ToString();
}

void FizzBuzz()
{
    for (var i = 1; i <= 100; i++)
    {
        var fb = GetFizzBuzzValue(i);
        Console.WriteLine(fb);

    }
}

// ===========================================



Enumerable
    .Range(1, 100)
    .Select(GetFizzBuzzValue)
    .ToList()
    .ForEach(Console.WriteLine);

