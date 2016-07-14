var firstName = "Dave";
var lastName = "Fancher";

// Concatenation

var s1 = firstName + " " + lastName;

// StringBuilder

var s2 =
    new System.text.StringBuilder()
        .Append(firstName)
        .Append(" ")
        .Append(lastName)
        .ToString();



// method2
using System.Text; // Qualifier to enable System.Text for the entire codefile.

var s2 =
new StringBuilder()
    .Append(firstName)
    .Append(" ")
    .Append(lastName)
    .ToString()
    
    ;



// Format String

var s3 = string.Format(
    "{0} {1}"  // Essentially a formatting template for the associated string values that follow.
    firstName, // this would be position 0
    lastName // this would be position 1
    );



//String Interpolation
var s4 = $"{firstName} {lastName}"; // Essentially last function, with string values placed in format brackets, rather than function references.