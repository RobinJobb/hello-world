using System;

public class Program
{
    public static void Fizzbuzz(int Number)
    {
        if (Number % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (Number % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else if (Number % 3 == 0 && Number % 5 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else
        {
            Console.WriteLine(Number);
        }
    }

    public static void Main(string[] args)
    {
        // Call the Fizzbuzz function with an example number
        Fizzbuzz(15);
    }
}
