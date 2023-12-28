using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuessGame
{
    class GuessGame
    {
        private int rndNumber;
        private int chances;
        private int score;

        public GuessGame()
        {
            GenerateRandomNumber();
            chances = 4;
            score = 0;
        }

        private void GenerateRandomNumber()
        {
            Random rn = new Random();
            rndNumber = rn.Next(100);
            // Console.WriteLine("number: " + rndNumber);
        }

        public int CheckUserInput(int number)
        {
            if (number == rndNumber)
            {
                GoToNextNumber();
                return 1;  
            }
            chances--;
            if (chances > 0)
            {
                if (rndNumber > number)
                    Console.WriteLine("Enter a bigger number");
                else
                    Console.WriteLine("Enyer a smaller number");
                return 0;  
            }
            return -1;     
        }

        private void GoToNextNumber()
        {
            Console.WriteLine("Correct!");
            score += chances * 10;
            Console.WriteLine("Current Score: " + score);
            Console.WriteLine("Next Number");
            GenerateRandomNumber();
            chances = 4;
        }

        private void ContinueGuessing()
        {
            Console.WriteLine("Remained Chances: " + chances);
            Console.WriteLine("Guess Again: ");
        }

        public void PrintResult()
        {
            Console.WriteLine("You lost!");
            Console.WriteLine("Your score: " + score);
            Console.WriteLine("Press any key to exit");
        }

    }
}