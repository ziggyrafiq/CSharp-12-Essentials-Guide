
/**********************************************************************
* Encapsulation Code Example                                          *
***********************************************************************/

namespace OOPExplorer;
public class Person
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Person()
    {
        Console.WriteLine("Constructor called");
    }

    ~Person()
    {
        Console.WriteLine("Destructor called");
    }

}


