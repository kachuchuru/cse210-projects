using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;


class Program
{
    static void Main(string[] args)
    //As exceeding requirement, I have add another item to be saved in the journal which is the body weight. 
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator= new PromptGenerator();
       int x =-1;  
       while(x!=5)
       {
          Console.WriteLine("Please select one of the following choices:");
          Console.WriteLine("1. Write");
          Console.WriteLine("2. Display");
          Console.WriteLine("3. Load");
          Console.WriteLine("4. Save");
          Console.WriteLine("5. Quit");
          Console.Write("What would you like to do? ");
        
          string userInput=Console.ReadLine();
          x = int.Parse(userInput);

        if (x == 1)
           {
            Entry newEntry = new Entry();

            Console.Write("Enter the date: ");
            newEntry._date = Console.ReadLine();

            Console.Write("Enter your body weight in Kg: ");
            newEntry._bodyWeight =int.Parse(Console.ReadLine());
            
            newEntry._promptText=promptGenerator.GetRandomPrompt();
            Console.WriteLine($"Prompt:{newEntry._promptText}");
            
            Console.Write("Your response:> ");
            newEntry._entryText=Console.ReadLine();

            myJournal._entries.Add(newEntry);
            
           }
        
        
        if (x==2)


            {
        
            myJournal.DisplayAll();
            
           }
        if (x==3)

            {
              myJournal.LoadFromFile();
                
            }

        if (x==4)
           
           {
            myJournal.SaveToFile();

           }
        }

    }
}

            
        
            
        
       
    

