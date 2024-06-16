using MethodMastery;

Console.WriteLine("Hello, from Ziggy Rafiq");
Console.WriteLine("This Code Example Project is for Chapter 7");

/**********************************************************************
* Declaring and Calling Methods Example                                                   *
***********************************************************************/
// Calling the method
Calculator calc = new Calculator();

// Output: 8
int sum = calc.Add(5, 3);

Console.WriteLine($"The result of this is {sum}");

int number = 5;
calc.ModifyValue(number);

// Output: 5 (unchanged)
Console.WriteLine($"The result of this is {number}");

calc.ModifyReference(ref number);

// Output: 10 (modified)
Console.WriteLine($"The result of this is {number}");

// Output: 12
int result = calc.Multiply(4, 3);
Console.WriteLine($"The result of this is {result}");

/**********************************************************************
* Handling Method Overloading Code Example                                                   *
***********************************************************************/

Printer printer = new Printer();
// Output: Hello
printer.Print("Hello");

// Output: 5
printer.Print(5);
