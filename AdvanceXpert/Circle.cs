/**********************************************************************
* Abstract Classes Blocks Code Example                               *
**********************************************************************/
using AdvanceXpert;

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Implementing abstract method
    public override double Area() 
    {
        return Math.PI * radius * radius;
    }
}