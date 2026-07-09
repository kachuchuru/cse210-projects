using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        //Requirement 1
        //Console.Write("What is the magic number? ");
        //string magicNumber =Console.ReadLine();
        //int x =int.Parse(magicNumber);
        //Console.Write("What is your guess?  ");
        //string guess = Console.ReadLine();
        //int y =int.Parse(guess);
        //if (x > y)
        {
            Console.WriteLine("Higher");
        }
        //else if (x < y)
        {
            Console.WriteLine("Lower");
        }
        //else
        {
            Console.WriteLine("You guessed it");
        }
        //Requirement2
     //Console.Write("What is the magic number? ");
     //string magikNumber =Console.ReadLine();
     //int x =int.Parse(magikNumber);
        
     
     //int y = -1;
     //while (y!=x)

     {
        //Console.Write("What is your guess?  ");
         //y= int.Parse(Console.ReadLine());
        
        //if (y < x)
        {
            //Console.WriteLine("Higher");
        }
        //else if (y > x)
        {
            Console.WriteLine("Lower");
        }
        //else
        {
            //Console.WriteLine("You guessed it");
        }
     }
        

      
      // Requirement 3
       Random randomGenerator=new Random();
       int magicNumber = randomGenerator.Next(1,101);
       int guess =-1;
       while(guess!=magicNumber)
       {
            Console.Write(" What is your guess");
            guess=int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
               Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
               Console.WriteLine("Lower");
            }
            else
            {
            Console.WriteLine(" You guessed it");
            }

        }
    }
}