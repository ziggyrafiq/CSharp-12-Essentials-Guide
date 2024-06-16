Console.WriteLine("Hello, from Ziggy Rafiq");
Console.WriteLine("This Code Example Project is for Chapter 6");

/**********************************************************************
* Single-Dimensional Arrays Code Examples                             *
***********************************************************************/

// Declaration and initialization
int[] numbers = new int[5]; 
numbers[0] = 10;
numbers[1] = 20;

// Accessing elements and Output: 10
Console.WriteLine(numbers[0]);

/**********************************************************************
* Multi-Dimensional Arrays Code Example                               *
***********************************************************************/
// Declaration and initialization
int[,] matrix = new int[2, 3];
matrix[0, 0] = 1;
matrix[0, 1] = 2;
// Accessing elements Output: 1
Console.WriteLine(matrix[0, 0]); 

/**********************************************************************
* List Code Example                                                   *
***********************************************************************/
// Declaration and initialization
List<int> numbersList = new List<int>();
numbersList.Add(10);
numbersList.Add(20);
// Accessing elements Output: 10
Console.WriteLine(numbers[0]); 

/**********************************************************************
* Dictionaries Code Examples                                          *
***********************************************************************/
// Declaration and initialization
Dictionary<string, int> ages = new Dictionary<string, int>(); 
ages["Alice"] = 30;
ages["Bob"] = 25;

// Accessing elements Output: 30
Console.WriteLine(ages["Alice"]);


/**********************************************************************
* Iteration, Manipulation, Sorting Code Examples                      *
***********************************************************************/
List<int> numbersListLoop = new List<int>() { 3, 1, 2 };

// Iterating over elements
foreach (int num in numbersListLoop)
{
    Console.WriteLine(num);
}
// Sorting
numbersListLoop.Sort();

/**********************************************************************
* Declaring and Initializing Arrays Code Examples                     *
***********************************************************************/
// Declaration and initialization
int[] numbers1 = new int[3];

// Initialization with explicit values
int[] numbers2 = new int[] { 1, 2, 3 };

// Implicit initialization
int[] numbers3 = { 1, 2, 3 };


/**********************************************************************
* Working with Multidimensional Arrays Code Examples                  *
***********************************************************************/

// Declaration and initialization
int[,] matrixMultidimensional = new int[2, 3];
matrixMultidimensional[0, 0] = 1;
matrixMultidimensional[0, 1] = 2;

// Accessing elements Output: 1
Console.WriteLine(matrixMultidimensional[0, 0]);


/**********************************************************************
* Introduction to Collections Code Example                            *
***********************************************************************/
// Initialize the collections
List<string> names = new List<string>();
Dictionary<string, int> agesCollection = new Dictionary<string, int>();
Queue<int> queue = new Queue<int>();
Stack<int> stack = new Stack<int>();

// Add elements to the List
names.Add("Alice");
names.Add("Bob");
names.Add("Charlie");

// Display elements in the List
Console.WriteLine("Names in the List:");
foreach (string name in names)
{
    Console.WriteLine(name);
}

// Add elements to the Dictionary
agesCollection["Alice"] = 30;
agesCollection["Bob"] = 25;
agesCollection["Charlie"] = 35;

// Display elements in the Dictionary
Console.WriteLine("\nAges in the Dictionary:");
foreach (KeyValuePair<string, int> entry in agesCollection)
{
    Console.WriteLine($"{entry.Key}: {entry.Value}");
}

// Add elements to the Queue
queue.Enqueue(10);
queue.Enqueue(20);
queue.Enqueue(30);

// Display elements in the Queue
Console.WriteLine("\nElements in the Queue:");
while (queue.Count > 0)
{
    Console.WriteLine(queue.Dequeue());
}

// Add elements to the Stack
stack.Push(100);
stack.Push(200);
stack.Push(300);

// Display elements in the Stack
Console.WriteLine("\nElements in the Stack:");
while (stack.Count > 0)
{
    Console.WriteLine(stack.Pop());
}
