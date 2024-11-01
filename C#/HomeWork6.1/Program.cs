

using System;
using System.Text.RegularExpressions;
using System.Numerics;
using System.Threading.Channels;
using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        //Task 1
        decimal TotalSeleri = 0;

        Console.WriteLine("Enter the number of workers: ");
        int numberOfWorker = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfWorker; i++)
        {
            Console.WriteLine($"Enter Worker {i} Seleri: ");
            decimal workersSalary = decimal.Parse(Console.ReadLine());
            TotalSeleri += workersSalary;
        }
        Console.WriteLine($"Avarage Salary: {TotalSeleri / numberOfWorker}");

        //Task 6
        const int hoursInDay = 24; ;


        while (true)
        {
            Console.WriteLine("Enter money pear hour: ");
            decimal moneyPearHour = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter hours worked per day: ");
            decimal hoursPearDay = Convert.ToDecimal(Console.ReadLine());
            if (hoursPearDay > hoursInDay)
            {
                Console.Clear();
                Console.WriteLine($"Invalid input! Please enter a valid number of hours (1 to {hoursInDay}).");
                continue;
            }

            decimal moneyPearDay = moneyPearHour * hoursPearDay;
            Console.WriteLine($"Your daily salaty is : {moneyPearDay}\n");

            Console.WriteLine("type exit to quit or type continue to restart program: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                break;
            }
            else if (input.ToLower() == "continue")
            {
                Console.Clear();
                continue;
            }
        }

        //Task 8

        Console.WriteLine("Enter a number to check if it's simple: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsSimple(number))
        {
            Console.WriteLine($"{number} is simple");
        }
        else
        {
            Console.WriteLine($"{number} is not simple");
        }
    }

    static bool IsSimple(int number)
    {
        if (number < 2)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
        // Task 4

        while (true)
        {
            Console.WriteLine("Enter a password:");
            string password = Console.ReadLine();

            bool isLongEnough = password.Length >= 8;
            bool hasDigit = false;
            foreach (char c in "0123456789")
            {
                if (password.Contains(c))
                {
                    hasDigit = true;
                    break;
                }

            }
            bool hasSpecialChar = false;
            string specialChar = "!@#$%^&*(),.?\":{}|<>";
            foreach (char c in specialChar)
            {
                if (password.Contains(c))
                {
                    hasSpecialChar = true;
                    break;
                }
            }
            Console.Clear();
            if (isLongEnough && hasSpecialChar && hasDigit)
            {
                Console.WriteLine("Password is vaid");
            }
            else
            {
                Console.WriteLine("Password is not valid");
            }
        }
        //Task 3

        Console.WriteLine("Enter range of number starst 1: ");
        string input = Console.ReadLine();

        if (int.Parse(input) >= 2)
        {
            int limit = int.Parse(input);
            Console.WriteLine($"Simle numbers from 1 to {limit}: ");
            for (int i = 2; i <= limit; i++)
            {
                if (IsSimple(i))
                {
                    Console.Write(i + " ");
                }
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid integer greater than or equal to 2.");
        }

        static bool IsSimple(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        //Task 2
        Console.Write("Enter the number of rows for the graph: ");

        string input = Console.ReadLine();
        int rows = int.Parse(input);

        Console.WriteLine("Generated graph:");


        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        //Task 5
        Console.Write("Enter the number of Fibonacci numbers to generate: ");
        int numberOfFibonacci = int.Parse(Console.ReadLine());

        if (numberOfFibonacci <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        int firstNumber = 0, secondNumber = 1;
        Console.WriteLine("Fibonacci sequence:");
        for (int i = 0; i < numberOfFibonacci; i++)
        {
            Console.Write(firstNumber + " ");
            int next = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = next;
        }

        //Task 7
        Console.Write("Enter a number to generate its multiplication table: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nMultiplication table for {number}:");

        for (int i = 1; i <= 10; i++)
        {
            int result = number * i;
            Console.WriteLine($"{number} x {i} = {result}");
        }
    }
}

  