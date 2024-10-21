internal class Program
{
    private static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter First Number");
            int? FirstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Secound Number");
            int? SecondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Chose operation (+, -, *, /) ");
            string Calculation = Console.ReadLine();
           


            switch (Calculation)
            {
                case "+":
                    Console.WriteLine($"Result: {FirstNumber + SecondNumber}");
                    break;
                case "-":
                    Console.WriteLine($"Result: {FirstNumber - SecondNumber}");
                    break;
                case "*":
                    Console.WriteLine($"Result: {FirstNumber * SecondNumber}");
                    break;
                case "/":
                    if (SecondNumber != 0)
                    {
                        Console.WriteLine($"Result: {FirstNumber / SecondNumber}");
                    }
                    else
                    {
                        Console.WriteLine("Cannot be divided by 0");
                    }
                    break;
                default:
                    Console.WriteLine("Unknown operatiom");
                    break;
            }

        }
    }
}