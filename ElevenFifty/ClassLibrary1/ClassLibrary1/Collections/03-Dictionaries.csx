// DICTIONARIES

using System.Collections.Generic; // Qualifier to enable System.Text for the entire codefile.

var myDictionary = //wrapped to next line for readability
    new Dictionary<string, int>(); // <TKey, TValue>

myDictionary.Add("Sunday", 1); //string key, int value
myDictionary.Add("Monday", 2); // ^^^^^^^^^^^^^^^^^^^

myDictionary["Sunday"] // int value is 1
myDictionary["Sunday"] = 7; // int value changed to 7


var myDictionary2 = // this is an index, similar to how we listed contents of an array
    new Dictionary<string, int>
    {
        {"Sunday", 1},
        {"Monday", 2},
        {"Tuesday", 3}

    };
