using System;
using System.Collections.Generic;
using System.Collections;


var names = new[] { "Pat", "Matt", "Blake", "Amna", "Dave", "Json" };

//var namesStartingWithD = new List<string>();
//foreach(var name in names)
//{
//       if(name.StartsWith("D"))
//    {
//        namesStartingWithD.Add(name);

//    }
//}


//var namesStartingWithJ = new List<string>();
//foreach (var name in names)
//{
//    if (name.StartsWith("J"))
//    {
//        namesStartingWithJ.Add(name);

//    }
//}

IEnumerable<string> GetNamesStartingWith(IEnumerable<string> names, string startingWith )
{
    var result = new List<string>();
    foreach (var name in names)
    {
        if(name.StartsWith(startingWith))
        {
            result.Add(name);
        }
    }
    return result;
}
var namesStartingWithD = GetNamesStartingWith(names, "D");
var namesStartingWithJ = GetNamesStartingWith(names, "J");
var namesStartingWithN = GetNamesStartingWith(names, "N");

