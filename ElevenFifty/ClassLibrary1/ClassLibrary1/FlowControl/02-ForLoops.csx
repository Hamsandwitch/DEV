// For Loops run a specific amount of times.

for(x = 0; x < 10; x++) //x = 0, when x is less than 10, increment by 1. (will run 9 iterations.)
{
    Console.WriteLine(x);
}


// ========================================================================



var doctors =
    new List<string>
    {
        "Strax",
        "Rose",
        "Hurt",
        "Smith"
    };

for (var x = 0; x < doctors.Count; x++)

    Console.WriteLine($"Name: {doctors[x]}");

// ========================================================================



for (var x = 0; x < doctors.Count; x++)
{
    var name = doctors[x];
    Console.WriteLine($"Name: {name}");
}

foreach (var c in "Hello World") 
{
Console.Write(c);
};

// ========================================================================


    foreach(var name in doctors)
{
    Console.WriteLine($"Name: {name}");
}


// ========================================================================
// IEnumerable


var enumerator = doctors.GetEnumerator();
while (enumerator.MoveNext())
{
    Console.WriteLine($"Item= {enumerator.Current}");
}


Console.Write