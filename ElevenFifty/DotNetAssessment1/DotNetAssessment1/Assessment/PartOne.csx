using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
System.Text;

//PART ONE: The Basics

int thisIsAnInteger = 23;
bool thisIsABoolean = true;
double thisIsADouble = 3.3;
decimal thisIsADecimal = 4.32m;

// 

public class Example
{
        public stuffToString()
    {
        Example convertStuff = new Example();
        var abcd = Convert.ToString(thisIsAnInteger);
        var dcba = Convert.ToString(thisIsADouble);
        //return ($"{abcd}" + "" + $"{dcba}");

        var stringSum = ($"{abcd}" + "" + $"{dcba}");
        Console.WriteLine(stringSum); //still tells me i need to return a value ?
    }
}




var myArray = new string[5];
myArray[0] = "Pat";
myArray[1] = "Matt";
myArray[2] = "Blake";
myArray[3] = "Tim";
myArray[4] = "Dave";

for (var x = 0; x < 5; x++)

    Console.WriteLine($"Name: {myArray[x]}");


// I just wanted to see the damn thing work..
//int thisIsAnInteger = 23;
//bool thisIsABoolean = true;
//double thisIsADouble = 3.3;
//decimal thisIsADecimal = 4.32m;


//var abcd = Convert.ToString(thisIsAnInteger);
//var dcba = Convert.ToString(thisIsADouble);
//var stringSum = ($"{abcd}" + "" + $"{dcba}");
//Console.WriteLine(stringSum);