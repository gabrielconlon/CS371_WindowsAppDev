using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX02_05
{
    class GuessTest
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int answer = randomNumber.Next(1, 1001);

            bool game = true;
            do
            {
                bool correct = false;
                int guess;
                int count = 0;
                while (correct == false)
                {
                    Console.WriteLine("Guess a number between 1 to 1000: ");
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess == answer)
                    {
                        correct = true;
                        count++;
                    }
                    else if (guess < answer)
                    {
                        Console.WriteLine("Too Low. Try again.");
                        count++;
                    }
                    else if (guess > answer)
                    {
                        Console.WriteLine("Too high. Try again.");
                        count++;
                    }
                }

                if(count < 10)
                    Console.WriteLine("Congratulation! You guessed the number in {0} guesses.\n Either you know the secret, or you got lucky.\nPlay again(Y/N)?", count);
                else if(count == 10)
                    Console.WriteLine("Congratulation! You guessed the number in {0} guesses.\n Aha! You know the secret.\nPlay again(Y/N)?", count);
                else if(count > 10)
                    Console.WriteLine("Congratulation! You guessed the number in {0} guesses.\n You should be able to do better. \nPlay again(Y/N)?", count);
                if (Console.ReadLine() == "N")
                    game = false;
                else
                {
                    answer = randomNumber.Next(1, 1001);
                    correct = false;
                }
            } while (game == true);
        }
    }
}
