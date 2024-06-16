/**********************************************************************
* Declaring and Calling Methods Example                                                   *
***********************************************************************/
namespace MethodMastery;
public class Calculator
{    // Method declaration
    public int Add(int a, int b)
    {
        return a + b;
    }

    public void ModifyValue(int x)
    {
        x = 10;
    }

    public void ModifyReference(ref int x)
    {
        x = 10;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

}
