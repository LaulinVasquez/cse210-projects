using System;

class Program
{
    static void Main(string[] args)
    {
        // Here I declared the random function between 1 - 100
        Random rnd = new Random();
        int magicNumber = rnd.Next(1,100);
        
        // I declared my guess variable so that I can make the question in the 
        // while loop
        int guessNumber = 0;
        int counter = 0;
        string user = "";
        while (user != "no")
        {
            // you can increase an int variable using "++" that will add one value each
            // time the while loop repeats
            counter++;
            Console.Write("What is your guess? ");
            guessNumber = Convert.ToInt32(Console.ReadLine());
            
            if (guessNumber < magicNumber)
        {
            Console.WriteLine("Higher");
        }
        else if (guessNumber > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine($"you guess it, that took you {counter} times");
            Console.Write("Do you want to play again? ");
            user = Console.ReadLine();
        }
        }
    }
}