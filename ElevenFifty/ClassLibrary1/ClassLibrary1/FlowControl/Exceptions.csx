using System;
using System.Text;

public string Reverse(string str)
{
    if (str.Length == 0)
    {
        throw new ArgumentException("Nothing to reverse.");
    }
    var reversed = new StringBuilder();
    for(var p = str.Length - 1; p >= 0; p--)
    {
        reversed.Append(str[p]);
    }

    return reversed.ToString();
}

try
{
    var reversed = Reverse("");
    Console.WriteLine(reversed);
}
catch(ArgumentException ex)
{
    Console.WriteLine("String was empty");
    throw;
}
catch(NullReferenceException ex)
{
    Console.WriteLine($"An error occurred {ex}");
    throw;
}
finally
{
    Console.WriteLine("Done");
}