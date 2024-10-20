internal class Program
{
    private static void Main(string[] args)
    {
        
        const decimal PriceOfSmartfone = 305.99m, PriceOfLaptop = 570.95m, PriceOfKeyboard = 5.50m;

        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"Order No {i}");

            Console.Write("Name of Client: ");
            string? NameOfClient = Console.ReadLine();

            Console.Write("What you are want to by (smartphone, laptop, keyboard): ");
            string? Client_Product = Console.ReadLine();

            Console.Write("Give your adress: ");
            string? AdressOfClient = Console.ReadLine();

            decimal FinalPrice = 0;
            if (Client_Product == "smartphone")
            {
                FinalPrice = PriceOfSmartfone;
            }
            else if (Client_Product == "laptop")
            {
                FinalPrice = PriceOfLaptop;
            }
            else if (Client_Product == "keyboard")
            {
                FinalPrice = PriceOfKeyboard;
            }
            else
            {
                Console.WriteLine("Product not recognized");
                i--;
                continue;
            }
            Console.Clear();

            Console.WriteLine($"Order No {i}\nClient: {NameOfClient}.\nProduct: {Client_Product}, {FinalPrice} EUR.\nAdress: {AdressOfClient}");




        }


    }
}
