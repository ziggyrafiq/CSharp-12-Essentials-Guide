using OOPExplorer;

Console.WriteLine("Hello, from Ziggy Rafiq");
Console.WriteLine("This Code Example Project is for Chapter 8");


/**********************************************************************
* Classes and Objects Code Example                                    *
***********************************************************************/
// Creating object
Car myCar = new Car("Toyota", "Camry", 2022);
Console.WriteLine($"My car is {myCar.Make}, Model is{myCar.Model} and the year is {myCar.Year}");

/**********************************************************************
* Encapsulation and Inheritance Code Example                          *
***********************************************************************/
// Creating object
Student student = new Student();
Console.WriteLine($"The Student ID is {student.StudentID}/n");
Console.WriteLine($"The Student name is {student.Name}/n");

/**********************************************************************
* Polymorphism Code Example                                          *
***********************************************************************/

Animal animal = new Animal();
Console.WriteLine($"Animal sound is {animal.MakeSound}/n");

Dog dog = new Dog();
Console.WriteLine($"Dog sound is {dog.MakeSound}/n");

/**********************************************************************
* Constructors and Destructors Code Example                           *
***********************************************************************/
Person person = new Person();
// Explicitly trigger garbage collection for demonstration purposes
// Dereference the object to make it eligible for garbage collection
person = null; 

// Force garbage collection
GC.Collect();
GC.WaitForPendingFinalizers(); // Wait for the destructor to be called

