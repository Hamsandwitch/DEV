// Conditionals

var x = 20;

if (x==10)
{
    Console.WriteLine("x is 10");
}
else if(x==20)
{
    Console.Writeline("x is 20");
}
else
{
    Console.WriteLine("x is not 10 or 20");
}

//    The above operation can be condensed into:
// Console.WriteLine(x == 10 ? "x is 10" : "x is not 10")

    
    
    
// ============================================

object o = null;


object o2;
if (o == null)
{
    o2 = new object();
}
else
{
    o2 = o;
}

// The above operation can be condensed into:
//      object o2 = o ?? new object