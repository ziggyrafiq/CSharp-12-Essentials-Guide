/**********************************************************************
* Method Overriding and Virtual Methods Code Example                  *
**********************************************************************/
namespace AdvanceXpert;
public class Dog : Animal
{
    // Override virtual method
    public override void MakeSound() 
    {
        Console.WriteLine("Dog barks");
    }
}
