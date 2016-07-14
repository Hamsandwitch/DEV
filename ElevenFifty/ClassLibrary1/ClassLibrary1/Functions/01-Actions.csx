using System;


void SayHello()
{
    Console.WriteLine("Hello, World!");
}

void SayHello(string name)
{
    Console.WriteLine($"Hello, {name}");
}

SayHello();

var name = "Dave";
SayHello(name);