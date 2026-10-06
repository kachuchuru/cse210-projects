using System;

class Program
{
    static void Main(string[] args)
    {
        

     Assignment a1= new Assignment("John Heche", "Fractions");
     Console.WriteLine(a1.GetSummary());

     MathAssignment a2 = new MathAssignment("Tundu Lissu", "Multiplication", "7.3", "8-19");
     Console.WriteLine(a2.GetSummary());
     Console.WriteLine(a2.GetHomeworkList());

     WritingAssignment a3 = new WritingAssignment("Mary Water","European History", "The causes of World War II");
     Console.WriteLine(a3.GetSummary());
     Console.WriteLine(a3.GetWritingInformation());
    }
}