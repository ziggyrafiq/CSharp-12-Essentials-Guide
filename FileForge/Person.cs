/**********************************************************************
* Serialization and Deserialization of Objects  Code Example                                           *
* ***********************************************************************/
namespace FileForge;

[Serializable]
public class Person
{
    public string Name { get; set; }=string.Empty;
    public int Age { get; set; } = 0; 

}
