internal class Program
{
    private static void Main()
    {
        try
        {

            Console.WriteLine("Enter First Number:");
            decimal firstNumber = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter Secound Number:");
            decimal secoundNumber = Convert.ToDecimal(Console.ReadLine());

            
            decimal result = firstNumber / secoundNumber;

           
            Console.WriteLine($"Result: {firstNumber} / {secoundNumber} = {result}");
        }
        catch (DivideByZeroException)
        {
            
            Console.WriteLine("Error: Division by zero is not possible.");
        }
        catch (FormatException)
        {
            
            Console.WriteLine("Error: Incorrect value entered. Enter the numbers.");
        }
        catch (Exception ex)
        {
            
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        finally
        {
            
            Console.WriteLine("The operation is complete.");
        }
    }
}
    
