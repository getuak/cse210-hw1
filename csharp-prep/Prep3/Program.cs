using System;

class Program
{
    static void Main(string[] args)
    {
        // Generate random number between 1 and 101
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
// initialize guess
        int guess = 0;
        // while do loop, loops through untill the conditon is met.
        while (guess != magicNumber){

        
        //Console.Write("What is the magic number? ");
        //int response = Console.ReadLine();
        //Console.Write(response);
// prompt the user to input the guess and displays the response
        Console.Write("What is your guess? ");
        guess = int.Parse( Console.ReadLine());

        if (guess == magicNumber)
        {
            Console.Write("Good Job, You got it");
        }
        else if (guess > magicNumber){
            Console.Write("Lower");
        }
        else{
            Console.Write("Higher");
        }


        

        }
    }
}