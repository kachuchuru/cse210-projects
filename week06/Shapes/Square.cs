

using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class Square : Shape
{
    private double _side;

    public Square(string color, double side) : base ("Red")
    {
       _side = 3;
    }
    
    //private double side = 4.5;
    public override double GetArea()
    {
         return _side * _side;
         
    }
    

}