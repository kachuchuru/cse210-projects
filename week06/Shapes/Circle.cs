using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base ("Green")
    {
       _radius = 6;
    }
    
    
    public override double GetArea()
    {
         return _radius*_radius*Math.PI;
         
    }
    

}