using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string color, double length, double width) : base ("Blue")
    {
       _length= 4;
       _width = 5;
    }
    
    
    public override double GetArea()
    {
         return _length * _width;
         
    }
    

}