// Basic Classes
using System;

public class Person
{
    private string _firstName;
    private string _lastName;

    public Person(string firstName, string lastName)  // Constructor
    {
        Console.WriteLine("Making people... giggity...");
        FirstName = firstName;
        LastName = lastName;

    }

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value.Trim(); } // .Trim() removes whitespace bloat.
    }
    public string LastName
    {
        get { return _lastName;}
        set { _lastName = value.Trim(); }
    }

    public char MiddleInitial { get; set; }

    public override string ToString()
    {
//        return $"{base.ToString()} [{StudentId}]";
        return $"{LastName}, {FirstName}";
    
    }
};




//var p = new Person();
//p.FirstName = "Pat";
//p.LastName = "Dobson";



//Object Initialization Syntax
//var p2 =
//   new Person
//   {
//       FirstName = "Pat";
//LastName = "Dobson";

//    };

//p2.FirstName = "AnotherPat"

// =================================================================

var p = new Person("Dave", "Fancher")
{
    MiddleInitial = 'W'
};

p.MiddleInitial = 'W';

public class Student
    : Person
{
    public Student(
        int studentId,
        string firstName,
        string lastName)
        : base(firstName, lastName)
    {
        Console.WriteLine("Creating a student.");
        StudentId = studentId;
    }
    public int StudentId { get; set; }

}

var s = new Student("Nadia", "Fancher");


string WhatIsIt(object o)
{
    if (o is Student) return "Student";
    if (o is Person) return "MyClass";
    if (o is string) return "This is just filler string.";
    return "Object";
}