// Exercise 3

// the first value is the 'key' you will call on to retrieve the 'value' (which is a string in this instance)
var award1 =
    new Dictionary<int, string>  
    {
        {2000, "Russell Crowe"},
        {2001, "Denzel Washington"},
        {2002, "Adrien Brody"},
        {2003, "Sean Penn"},
        {2004, "Jamie Foxx"},
        {2005, "Philip Seymour Hoffman"}

    };
Console.WriteLine(award1); // calls entire index/dictionary
award1 // standalone to call entire index using C# interactive

award1[2000] // putting a defined "key" in brackets, calls on that specific key entry within the dictionary object





// ==============================================================================================

    var winners =
    new Dictionary<string, int[]> // reference 'key' is a string, 'value' data is an array of integers
    {
        {"Russell Crowe", new [] {2003, 2005} },
        {"Nicholas Cage", new int[0] }, // OR  {"Nicholas Cage", new int[]{}}
    };


winners["Russell Crowe"] // would return int[2] { 2003, 2005 }
winners["Nicholas Cage"] // would return int[0] { }



// ==============================================================================================




var winners2 =
    new Dictionary<int, string[]> // reference 'key' is an integer, 'value' data is a string
    {
        {2003, new [] {"Russell", "Nic"} },
        {2005, new [] {"Russell"} }
    };

winners2[2003] // would return string[2] { "Russell", "Nic" }



// ==============================================================================================

var nom =
    new Dictionary<int, string[]>
    {
        {2000, new [] {"Chocolat", "Crouching Tiger, Hidden Dragon", "Erin Brockovich", "Gladiator", "Traffic"} },
        {2001, new [] {"A Beautiful Mind", "Gosford Park", "In the Bedroom", "The Lord of the Rings: The Fellowship of the Ring", "Moulin Rouge"} },
        {2002, new [] {"Chicago, Gangs of New York, The Hours, The Lord of the Rings: The Two Towers, The Pianist"} },
        {2003, new [] {"The Lord of the Rings: The Return of the King", "Lost in Translation", "Master and Commander:", "Mystic River", "Seabiscuit"} },
        {2004, new [] {"The Aviator", "Finding Neverland", "Million Dollar Baby", "Ray", "Sideways"} },
        {2005, new [] {"Brokeback Mountain", "Capote", "Crash", "Good Night, and Good Luck", "Munich"} }
    };