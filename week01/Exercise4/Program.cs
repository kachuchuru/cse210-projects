using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");


       List<int> numbers=new List<int>();
       int number= -1;
       int sum = 0;
       int count = 0;
       double average = 0.0;
       
         Console.WriteLine("Enter a list of numbers, type 0 when finished");
       while(number!=0)
        {
            
            Console.Write("Enter the number ");
            string userInput=Console.ReadLine();
            number =int.Parse(userInput);
            numbers.Add(number);
            sum+=number;
            count++;
            
            
        }
        int largest = numbers[0];
        foreach (int value in numbers)  
        {
            if (value > largest)
            {
                largest = value;
            }
        }   
            Console.WriteLine($"The Sum is: {sum}");
            average=(double)sum/(count-1);
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {largest}");

        


    }
}