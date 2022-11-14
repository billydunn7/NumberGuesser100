using System;

namespace Number_Guesser_100
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates variables.
            Random randomNum = new Random();
            bool playAgain = true;
            int number;
            int guess;
            int min = 1;
            int max = 100;
            int guesses;
            
            //loop for when user chooses play again.
            while (playAgain == true)
            {
                guess = 0;
                guesses = 0;
                //generates the random number between min (1) and max (100).
                number = randomNum.Next(min, max);

                Console.Clear();
                Console.WriteLine("Welcome to Number Guesser 100!");
                Console.WriteLine("Guess a number between " + min + " and " + max + " ... it's that simple, try it.");

                //runs this loop until user guesses the number.
                while (guess != number)
                {
                    //converts users guess string to int.
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Your guess: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is too high... Try guessing lower.");
                        Console.WriteLine();
                    }

                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is too low... Try guessing lower.");
                        Console.WriteLine();
                    }
                    //adds +1 onto the users guesses.
                    guesses++;
                }

                //clears console and gives user options.
                Console.Clear();
                Console.WriteLine("YOU WIN! The number was " + number + ".");
                Console.WriteLine("You had " + guesses + " guesses.");
                Console.WriteLine("");
                Console.WriteLine("Press any key to play again.");
                Console.WriteLine("Press ESC to quit.");

                var keyPress = Console.ReadKey();

                if (keyPress.Key == ConsoleKey.Escape)
                {
                    playAgain = false;
                }

                else
                {
                    playAgain = true;
                }
                
            }

            //ends the game if user presses ESC key after winning.
            Console.Clear();
            Console.WriteLine("Thank you for playing Number Guesser 100!");
            Console.WriteLine("Created by Billy Dunn.");
            Console.WriteLine();
            Console.WriteLine("Press any key to quit.");
            Console.ReadKey();
        }
    }
}
