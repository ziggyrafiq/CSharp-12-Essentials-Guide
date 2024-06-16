using FileForge;
using System.IO;
using System.Text.Json;
using System.Text;

Console.WriteLine("Hello, from Ziggy Rafiq");
Console.WriteLine("This Code Example Project is for Chapter 10");

/**********************************************************************
* Writing data to a text file Code Example                            *
***********************************************************************/

using (StreamWriter writer = new StreamWriter("dummy-file.txt"))
{
    writer.WriteLine("Hello, from Ziggy Rafiq!");
}

/**********************************************************************
*  Reading data from a text file Code Example                         *
***********************************************************************/
using (StreamReader reader = new StreamReader("dummy-file.txt"))
{
    string line = reader.ReadLine();
    Console.WriteLine(line); // Output:  Ziggy Rafiq!!
}


/**********************************************************************
*  Writing data to a binary file using FileStream Code Example        *
***********************************************************************/
using (FileStream stream = new FileStream("dummy-file.bin", FileMode.Create))
{
    // Hello
    byte[] data = { 0x48, 0x65, 0x6C, 0x6C, 0x6F };
    stream.Write(data, 0, data.Length);
}

/**********************************************************************
* Reading data from a binary file using FileStream  Code Example      *
***********************************************************************/
using (FileStream stream = new FileStream("dummy-file.bin", FileMode.Open))
{
    byte[] buffer = new byte[5];
    stream.Read(buffer, 0, buffer.Length);
    string text = Encoding.ASCII.GetString(buffer);
    // Output: Hello
    Console.WriteLine(text);
}


/**********************************************************************
* Serialization  Code Example                                           *
* ***********************************************************************/
// Create a Person object
Person person = new Person { Name = "Alice", Age = 30 };

try
{
    // Serialize the Person object to JSON and write it to the file
    File.WriteAllText("dummy-file.json", JsonSerializer.Serialize(person));

    Console.WriteLine("Serialization successful.");
}
catch (Exception ex)
{
    Console.WriteLine("Error occurred during serialization: " + ex.Message);
}

/**********************************************************************
* Deserialization  Code Example                                       *
* *********************************************************************/
try
{
    // Read the JSON string from the file and deserialize it to a Person object
    Person deserializedPerson = JsonSerializer.Deserialize<Person>(File.ReadAllText("dummy-file.json"));

    // Output the deserialized Person object
    Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
}
catch (Exception ex)
{
    Console.WriteLine("Error occurred during deserialization: " + ex.Message);
}

/**********************************************************************
* Handling Exceptions in File I/O Operations  Code Example                                       *
* *********************************************************************/

try
{
    using (StreamWriter writer = new StreamWriter("nonexistent.txt"))
    {
        writer.WriteLine("Hello");
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"File not found: {ex.Message}");
}
catch (IOException ex)
{
    Console.WriteLine($"An I/O error occurred: {ex.Message}");
}
catch (UnauthorizedAccessException ex)
{
    Console.WriteLine($"Unauthorized access: {ex.Message}");
}
