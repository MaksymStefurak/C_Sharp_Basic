var products = new List<Product>()
        {
            new Carrot(15),
            new Potato(20, 4),
            new Cucumber(14, 2),
            new Tomato(10)
        };

VegetableShop shop = new VegetableShop();
shop.AddProducts(products);

shop.PrintProductsInfo();

public abstract class Product
{
    public string Name { get; }
    public virtual decimal Price { get; }

    protected Product(string name, decimal basePrice)
    {
        Name = name;
        Price = basePrice;
    }

    public abstract void PrintInfo();
}

public class Carrot : Product
{
    public Carrot(decimal basePrice)
        : base(name: "Carrot", basePrice)
    {

    }
    public override void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Price: {Price}");
    }
}

public class Potato : Product
{
    public Potato(decimal basePrice, int count)
        : base(name: "Potato", basePrice)
    {
        Count = count;
    }
    public int Count { get; }
    public override decimal Price => base.Price * Count;

    public override void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Price: {base.Price}, count: {Count}, Total Price: {Price}");
    }
}

public class Cucumber : Product
{
    public Cucumber(decimal basePrice, int count)
        : base(name: "Cucumber", basePrice)
    {
        Count = count;
    }
    public int Count { get; }
    public override decimal Price => base.Price * Count;

    public override void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Price: {base.Price}, count: {Count}, Total Price: {Price}");
    }
}

public class Tomato : Product
{
    public Tomato(decimal basePrice)
        : base(name: "Tomato", basePrice)
    {

    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Product: {Name}, Price: {Price}");
    }
}

public class VegetableShop
{
    private readonly List<Product> products = new List<Product>();

    public void AddProducts(IEnumerable<Product> product)
    {
        products.AddRange(product);
    }

    public void PrintProductsInfo()
    {
        decimal total = 0;
        foreach (var product in products)
        {
            product.PrintInfo();
            total += product.Price;
        }
        Console.WriteLine($"Total Price is: {total}");
    }
}