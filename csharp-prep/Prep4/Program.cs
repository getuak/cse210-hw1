using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Serialization;


class Program
{
    static void Main(string[] args)
    {
       List<int> numbers = new List<int>();

       int chosenNumber = -1;
       while (chosenNumber != 0){
        Console.Write("Enter the number and choose 0 to quit"); // prompts the user to choos numbers
        string choice = Console.ReadLine(); // read from the input
        chosenNumber = int.Parse(choice);

        if(chosenNumber != 0) {
            numbers.Add(chosenNumber); //add numbers to the list of numbers
        }

        int sum = 0;

        foreach(int number in numbers)
        {
            sum += number;

            Console.WriteLine($"The sum is: {sum}");

        }
// computes the max value 
        int max = numbers[0];
        foreach(int number in numbers)
        {
            if (number > max){

                max = number;
              Console.Write($" The maximum number is: {max}\n");

              int average = sum/numbers.Count; // computes average values (we can cast this to be a float )

              Console.Write($" The Average value is: {average}\n");
            }


        }


       }
    }
}