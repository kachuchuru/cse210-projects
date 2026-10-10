using System;

class Program

//To meet extremely requirement I have coded the ShowBalloon()for the breathing activity
{
    static void Main(string[] args)
    {

        Console.WriteLine("Menu options");

        int x = -1;
        while (x != 4)
        {
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start Listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu:");

            string userInput = Console.ReadLine();
            x = int.Parse(userInput);

            if (x == 1)


            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();

            }


            else if (x == 2)


            {


                ReflectingActivity activity = new ReflectingActivity();
                activity.Run();

            }
            else if (x == 3)

            {
                ListingActivity activity = new ListingActivity();
                activity.Run();

            }
        }

    }
}