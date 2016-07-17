using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.Text;

//PART ONE: The Basics

int thisIsAnInteger = 23;
bool thisIsABoolean = true;
double thisIsADouble = 3.3;
decimal thisIsADecimal = 4.32m;

//simplified version
string buildString(int thisIsAnInteger, decimal thisIsADecimal)
{
    return $"Heres the result of simplified combining to a string... {thisIsAnInteger}-{thisIsADecimal}";
}
var talky = buildString(thisIsAnInteger, thisIsADecimal);
Console.WriteLine(talky);

//still works tho
string stuffToString()
{
    string ab = Convert.ToString(thisIsAnInteger);
    string ba = Convert.ToString(thisIsADouble);

    var stringSum = ($"{ab}" + "" + $"{ba}");
    return ($"{stringSum}");
    Console.WriteLine("stringSum");
}
Console.WriteLine(stuffToString());


var myArray = new string[5];
myArray[0] = "Pat";
myArray[1] = "Matt";
myArray[2] = "Blake";
myArray[3] = "Tim";
myArray[4] = "Dave";

for (var x = 0; x < 5; x++)
Console.WriteLine($"Name: {myArray[x]}");