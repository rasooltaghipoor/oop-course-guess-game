using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, check;
            GuessGame guessGame = new GuessGame();
            Console.WriteLine("Welcome...\nThis is a guess number game.");
            while (true)
            {
                Console.Write("Enter: ");
                x = int.Parse(Console.ReadLine());

                check = guessGame.CheckUserInput(x);

                if (check == -1)

                    break;
            }

            guessGame.PrintResult();
            Console.ReadKey();
        }
    }
}
