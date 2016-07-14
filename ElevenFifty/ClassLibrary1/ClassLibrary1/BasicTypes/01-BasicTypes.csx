// Double slash indicates end of line comment.
/*
 *  or block out lines with slash n asterisk
 *  ---------------------------------------------
 *
 * These are basic specific value types that will be placed on the stack.
 * 
 */
int i = 0;
short sh = 32767;
long l = 0;
byte b;
b = 255;
char c = 'i';
bool b2 = true;
// ------
decimal d = 7.8m;
double dbl = 7.80f;
float f = 10.8f; //suffix 'f' on end of number, forces the type. 'float' in this instance


enum DayOfWeek // Enumeration, based on integers.
{
    Sunday = 0,
    Monday = 1,
    Tuesday = 2,
    Wednesday = 3,
    Thursday = 4,
    Friday = 5,
    Saturday = 6,
}

//DayOfWeek day = DayOfWeek.Tuesday;

// Reference Types
object 0 = new object();

string s1 = "a string"; // normal string

string s2 = "This is a \r\nmulti-line string"; // \r \n are return-line

string s3 = @"This is a \r\nverbatim-line string"; // @ character before string, prints exact

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);

//System.Nullable<int> nullInt = null;


var x = 8;
