/**********************************************************************
* Interface Classes Blocks Code Example                               *
**********************************************************************/
namespace AdvanceXpert;
public class Rectangle : IShape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    // Implementing interface method
    public double Area() 
    {
        return width * height;
    }
}
