
// TYPE INVERSIONS

var t1 = 123.GetType(); // Type : [System.Int32]

var t2 = "123".GetType(); // Type : [System.String]



var x = new System.Text.StringBuilder(); // [System.Text.StringBuilder]
var t3 = x.GetType();


//Converting strings to an integer

var i1 = int.Parse("123"); // Parses provided value to determine integer
i1.GetType();



var i1 = int.Parse("12ab3"); // Will NOT work as provided value is a string, not an integer.
i1.GetType();

var i1 = int.TryParse("123");
i1.GetType();

// ---

int i1;
var success = int.TryParse("1ab23", out i1); // checks the provided value to determine whether integer or not.


123.ToString(); // sends the front value too a string.



short sh = 32767;
byte by = 255;

by = (short)sh; // CANNOT convert an object from a 32bit short, into a byte
sh = (short)by;// CAN convert a byte into a 32bit short. 











