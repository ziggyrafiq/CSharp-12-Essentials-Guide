using System.Net.NetworkInformation;

Console.WriteLine("Hello, from Ziggy Rafiq");
Console.WriteLine("This Code Example Project is for Chapter 4");

/**********************************************************************
* Arithmetic Operators  Code Examples                                 *
***********************************************************************/
int a = 10;
int b = 5;

// Addition
int sum = a + b;
Console.WriteLine($"The result for Addition is {sum}");

// Subtraction
int difference = a - b;
Console.WriteLine($"The result for Subtraction is {difference}");

// Multiplication
int product = a * b;
Console.WriteLine($"The result for Multiplication is {product}");

// Division
int quotient = a / b;
Console.WriteLine($"The result for Division is {quotient}");


// Modulus
int remainder = a % b;
Console.WriteLine($"The result for Modulus is {remainder}");

/**********************************************************************
* Relational Operators  Code Examples                                 *
***********************************************************************/

int x = 10;
int y = 20;

// Equal to
bool isEqual = x == y; 
Console.WriteLine($"The result for  Equal to is {isEqual}");

// Not equal to
bool isNotEqual = x != y;
Console.WriteLine($"The result for  Not equal to is {isNotEqual}");

// Greater than
bool isGreater = x > y; 
Console.WriteLine($"The result for Greater than is {isGreater}");

// Less than
bool isLess = x < y;    
Console.WriteLine($"The result for Less than is {isLess}");

// Greater than or equal to
bool isGreaterOrEqual = x >= y;
Console.WriteLine($"The result for Greater than or equal to is {isGreaterOrEqual}");

// Less than or equal to
bool isLessOrEqual = x <= y;   
Console.WriteLine($"The result for Less than or equal to is {isLessOrEqual}");

/**********************************************************************
* Logical Operators Code Examples                                     *
***********************************************************************/
bool isTrue = true;
bool isFalse = false;

// Logical AND
bool logicalAnd = isTrue && isFalse;
Console.WriteLine($"The result forLogical AND is {logicalAnd}");

// Logical OR
bool logicalOr = isTrue || isFalse; 
Console.WriteLine($"The result for Logical OR is {logicalOr}");

// Logical NOT
bool logicalNot = !isTrue;           
Console.WriteLine($"The result for Logical NOT is {logicalNot}");

/**********************************************************************
* Bitwise Operators Code Examples                                     *
***********************************************************************/
// Binary representation: 0101
int p = 5;

// Binary representation: 0011
int q = 3;

// Bitwise AND (result: 1)
int bitwiseAnd = p & q;
Console.WriteLine($"The result for Bitwise AND is {bitwiseAnd}");


// Bitwise OR (result: 7)
int bitwiseOr = p | q;
Console.WriteLine($"The result for Bitwise OR  is {bitwiseOr}");

// Bitwise XOR (result: 6)
int bitwiseXor = p ^ q;
Console.WriteLine($"The result for Bitwise XOR is {bitwiseXor}");

// Bitwise complement (result: -6)
int bitwiseComplement = ~p;
Console.WriteLine($"The result for Bitwise complement is {bitwiseComplement}");


// Left shift (result: 10)
int leftShift = p << 1;
Console.WriteLine($"The result for  Left shift is {leftShift}");

// Right shift (result: 2)
int rightShift = p >> 1;
Console.WriteLine($"The result for  Right shift is {rightShift}");

/**********************************************************************
* Precedence and Associativity Rules Code Examples                    *
***********************************************************************/
// Result: 14
int result = 2 + 3 * 4; 
Console.WriteLine($"The result is {result}");

// Result: 20
result = (2 + 3) * 4;
Console.WriteLine($"The result is {result}");

/**********************************************************************
*Using Expressions in C# Programs                                     *
***********************************************************************/
x = 10;
y = 5;

// Expression
result = (x + y) * (x - y);

// Output: 75
Console.WriteLine($"The result is {result}");

/**********************************************************************
*Best Practices for Working with Operators and Expressions            *
***********************************************************************/
int c = 3;
int d = 15;
int e = 50;
x = 10;
y = 5;

result = (a + b) * c - (d / e);
Console.WriteLine($"The result is {result}");
