using System;
using System.Formats.Asn1;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    // As part of execeeding requirements, I have introduced a code that would take care of user's input of lowercase and uppercase for the word 'quit'
    {
        Reference reference = new 
        Reference("Proverbs",3,5,6);        
        Console.WriteLine();   
        Scripture scripture = new Scripture(reference,"Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths");
        
        Console.WriteLine(scripture.GetDisplayText());

        Console.WriteLine("");
        Console.WriteLine("Press enter to continue or type 'quit' to finish");
             
        Console.ReadLine();
        Console.Clear();      
        scripture.HideRandomWords(3);    
        Console.WriteLine(scripture.GetDisplayText());
        
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or 'quit' to finish");
            string answer = Console.ReadLine();
               
        if (answer.ToLower() == "quit")//user input of lowercase and uppercase taken care by this code
            {
                return;
            }
            scripture.HideRandomWords(3);
        }
    
    }




    }


