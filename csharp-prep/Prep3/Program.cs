using System;

class Program
{
    static void Main(string[] args)
    {
      Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 101);

        int guess = 0;
        int guesses = 0;

        while (guess != magicNum)
        {
            guesses = guesses +1;
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNum > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNum < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"You got it in {guesses} guesses.");
            }
        }
    }
}