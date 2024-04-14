//write console app to calculate area and perimeter of different 20 shapes.
class Rectangle:IShape2D
{
    //deafult parameterless constructor
    // public rectangle()
    // {

    // }
    //parameterized constructor
    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }
    
    double length;
    double width;

    public double GetArea() => length * width;
    public double GetPerimeter() => 2 * (length + width);
    
}