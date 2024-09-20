using System;

namespace readFromConsole
{
    class Programm
    {
        static void Main(string[] args)
        {
            int userInput = 0;

            while(userInput != 1)
            {
                Console.Write("Please enter a number or type 1 to stop: ");

                userInput = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Your input was: " + userInput);
            }

        }

    }

}
