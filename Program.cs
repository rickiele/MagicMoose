using System;

namespace MagicMoose
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Magic Moose";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Something troubling you? Ask me a question.");

            string UserQuestion = Console.ReadLine();

            // Generate a random number
            Random Number = new Random();
            // Add minimum and max values
            int RandomNumber = Number.Next(0, 19);

            // Switch statement to have ints correspond to output
            switch (RandomNumber)
            {
                case 0:
                    Console.WriteLine("As I see it, yes.");
                    break;
                case 1:
                    Console.WriteLine("Ask again later.");
                    break;
                case 2:
                    Console.WriteLine("Better not tell you now.");
                    break;
                case 3:
                    Console.WriteLine("Cannot predict now.");
                    break;
                case 4:
                    Console.WriteLine("Concentrate and ask again.");
                    break;
                case 5:
                    Console.WriteLine("Don’t count on it.");
                    break;
                case 6:
                    Console.WriteLine("It is certain.");
                    break;
                case 7:
                    Console.WriteLine("It is decidedly so.");
                    break;
                case 8:
                    Console.WriteLine("Most likely.");
                    break;
                case 9:
                    Console.WriteLine("My reply is no.");
                    break;
                case 10:
                    Console.WriteLine("My sources say no.");
                    break;
                case 11:
                    Console.WriteLine("Outlook not so good.");
                    break;
                case 12:
                    Console.WriteLine("Outlook good.");
                    break;
                case 13:
                    Console.WriteLine("Reply hazy, try again.");
                    break;
                case 14:
                    Console.WriteLine("Signs point to yes.");
                    break;
                case 15:
                    Console.WriteLine("Very doubtful.");
                    break;
                case 16:
                    Console.WriteLine("Without a doubt.");
                    break;
                case 17:
                    Console.WriteLine("Yes.");
                    break;
                case 18:
                    Console.WriteLine("Yes – definitely..");
                    break;
                case 19:
                    Console.WriteLine("You may rely on it.");
                    break;
            }
        }
    }
};
