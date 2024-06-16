using CSharp12Innovate;
using System.Collections;

Console.WriteLine("Hello, from Ziggy Rafiq");
Console.WriteLine("This Code Example Project is for Chapter 14");


/**********************************************************************
* Pattern Matching Enhancements Code Example                          *
**********************************************************************/

// Relational patterns
int value = 10;
string result = value switch
{
    < 0 => "Negative",
    > 0 => "Positive",
    _ => "Zero"
};


// Recursive patterns
bool IsEmpty(object obj) => obj is null || (obj is IEnumerable enumerable && !enumerable.Cast<object>().Any());


//Record Types
var person1 = new Person("Lisa", "Hills");
var person2 = new Person("Lisa", "Hills");

// The result is true
Console.WriteLine(person1 == person2);


string operation = "+";
string result2 = operation switch
{
    "+" => "Addition",
    "-" => "Subtraction",
    _ => "Unknown"
};
Console.WriteLine($"The Result2 is {result2}");