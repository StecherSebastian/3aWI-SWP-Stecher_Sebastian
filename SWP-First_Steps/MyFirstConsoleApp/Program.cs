using System;

namespace readFromConsole
{
    class Programm
    {
        static void Main(string[] args)
        {
            string userInput = " ";

            while(userInput != "Beenden")
            {
                Console.Write("Please enter a string or type Beenden to stop: ");

                userInput = Console.ReadLine();

                Console.WriteLine("Your input was: " + userInput);
            }

        }

    }

}
