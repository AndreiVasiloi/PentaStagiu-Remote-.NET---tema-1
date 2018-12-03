using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
            Console.WriteLine("Do you want to play a game?");
            string answer = Console.ReadLine();

            if (answer == "yes")
            {
                Console.WriteLine("Ok, let`s play GUESS THE NUMBER.");
            }
            else
            {
                Console.WriteLine("Ok, Have a nice day!");
                Console.ReadLine();
                return;
            }


            Random rng = new Random();
            int randomNumber = rng.Next(1, 100);

            int userNumber = randomNumber;

            Console.WriteLine("Please enter a number between 1 and 100 and press enter.");

            do
            {

                string str = Console.ReadLine();

                if (string.IsNullOrEmpty(str))
                {
                    Console.WriteLine("You must enter a value between 1 and 100.");
                    continue;
                }

                userNumber = int.Parse(str);
                if (userNumber < randomNumber)
                {
                    Console.WriteLine("The number is shorter!");
                }
                else if (userNumber == randomNumber)
                {
                    Console.WriteLine("The number is correct!");
                    Console.WriteLine("You won the game!");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("The number is greater!");
                }
            } while (userNumber >= 0);
        }
    }
}
