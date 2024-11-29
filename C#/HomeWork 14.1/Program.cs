Account heikkisAccount = new Account("Heikki's account", 100.00);

Console.WriteLine($"{heikkisAccount.NameOfAccount} : {heikkisAccount.TotalAmountOfAccount}");

Console.WriteLine(heikkisAccount.Withdrawal(130.00));
Console.WriteLine("The balance of Heikki's account is now: " + heikkisAccount.TotalAmountOfAccount);

Console.WriteLine(heikkisAccount.Deposit(200.00));
Console.WriteLine("The balance of Heikki's account is now: " + heikkisAccount.TotalAmountOfAccount);

Console.WriteLine(heikkisAccount.Withdrawal(100.00));
Console.WriteLine("The balance of Heikki's account is now: " + heikkisAccount.TotalAmountOfAccount);

Console.WriteLine(heikkisAccount.Withdrawal(-10.00));

internal class Account
{
    public string NameOfAccount { get; private set; }
    public double TotalAmountOfAccount { get; private set; }

    public Account(string nameOfAccount, double totalAmountOfAccount)
    {
        NameOfAccount = nameOfAccount;
        TotalAmountOfAccount = totalAmountOfAccount;
    }
    public string Withdrawal(double amount)
    {
        if (amount <= 0)
        {
            return "The sum for the concept must be greater than 0";
        }
        if (amount > TotalAmountOfAccount)
        {
            return "Can Withdrawal this sum becouse the amount is greater than your balance ";
        }
        else
        {
            TotalAmountOfAccount -= amount;
            return $"Successfully removed {amount}. Remainder: {TotalAmountOfAccount}";
        }
    }
    public string Deposit(double amount)
    {
        if (amount <= 0)
        {
            return "The sum for the concept must be greater than 0";
        }

        TotalAmountOfAccount += amount;
        return $"Add successfully {amount}. Remainder: {TotalAmountOfAccount}";
    }
}