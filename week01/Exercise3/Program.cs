using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {

        //Requirement 1
          
         // Console.Write("What is the magic number? ");
          //int magicNumber = int.Parse(Console.ReadLine());
          
          //Console.Write("What is your guess? ");
          //int guess=int.Parse(Console.ReadLine());
    //if (magicNumber > guess)
            {
               //Console.WriteLine("Higher");
            }
         //else if (magicNumber < guess)
            {
              // Console.WriteLine("Lower");
            }
         //else
            {
               // Console.WriteLine(" You guessed it");
            }
        //Requirement2
         //int guess=-1;
         //int magicNumber=-1;
        
        //Console.Write("What is the magic number? ");
        //magicNumber =int.Parse(Console.ReadLine());
        
        //while (guess!=magicNumber)
        {
        //Console.Write("What is your guess? ");
        //guess =int.Parse(Console.ReadLine());
        
        //if (magicNumber > guess)
            {
               //Console.WriteLine("Higher");
            }
         //else if (magicNumber < guess)
            {
               //Console.WriteLine("Lower");
            }
         //else
            {
                //Console.WriteLine(" You guessed it");
            }
        }
        // Requirement 3
       Random randomGenerator=new Random();
       int magicNumber = randomGenerator.Next(1,101);
       int guess =-1;
       while(guess!=magicNumber)
       {
         Console.Write(" What is your guess?" );
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