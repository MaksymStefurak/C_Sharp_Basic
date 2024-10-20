using System;
using System.Security.Cryptography;
internal class Program
{
    private static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter Number of Day (1-7) or 'exit' to quit: ");
            string? input = Console.ReadLine();

            if (input?.ToLower() == "exit")
            {
                break; 
            }

            if (int.TryParse(input, out int NumberOfDay))
            {
                string NameOfDay = GetDayNumber(NumberOfDay);

                if (NameOfDay != null)
                {
                    Console.WriteLine($"{NameOfDay}");

                }
                else
                {
                    Console.WriteLine("incorect number, enter(1-7)");
                }
            }
            else
            {
                Console.WriteLine("incorect number, enter(1-7)");
            }
        }
    }
        private static string GetDayNumber(int NumberOfDay)
    {
        switch (NumberOfDay)
        {
            case 1: return "Monday";
            case 2: return "Tuesday";
            case 3: return "Wednesday";
            case 4: return "Thursday";
            case 5: return "Friday";
            case 6: return "Saturday";
            case 7: return "Sunday";
            default: return null;


        }
    }
}

      