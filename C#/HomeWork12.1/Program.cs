// Task 12.1
//Це вже правильний варіант
while (true)
{ 
    Console.WriteLine("Enter the number of Fibonacci or type exit for finished: ");
    string input = Console.ReadLine()!;

    if(input?.ToLower() == "exit")
    {
        break;
    }

    if (int.TryParse(input, out int number))
    {
        try
        {
            int result = NumberOfFibonacci.Fibonacci(number);
            Console.WriteLine($"Fibonacci number for {number}:{result}");
        }
        catch(ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    else
    {
        Console.WriteLine("Type corect number");
    }   
}
public static class NumberOfFibonacci
{
    public static int Fibonacci(int number)
    {
        if(number <= 0)
        {
            throw new ArgumentException("Number must be positive");
        }

        if (number == 1)
            return 0;
        if (number == 2)
            return 1;

        return Fibonacci(number - 1) + Fibonacci(number - 2);
    }
}


// Task 13.1
List<string> todoList = new List<string>();
List<bool> performList = new List<bool>();
while (true)
{
    Console.WriteLine("List of cases");
    Console.WriteLine("1. View the list of cases");
    Console.WriteLine("2. Add a new case");
    Console.WriteLine("3. Performance note");
    Console.WriteLine("4. Delete the case");
    Console.WriteLine("5. Exit");

    Console.WriteLine("Choose an action: ");
    string choise = Console.ReadLine()!;

    switch (choise)
    {
        case "1":
            ViewTasks(todoList, performList);
            break;
        case "2":
            AddTask(todoList, performList);
            break;
        case "3":
            PerformanceTasks(todoList, performList);
            break;
        case "4":
            RemoveTask(todoList, performList);
            break;
        case "5":
            Console.WriteLine("Program finished");
            return;
        default:
            Console.WriteLine("Eror of choise, try again");
            break;
    }
}

static void ViewTasks(List<string> todoList, List<bool> performList)
{
    if (todoList.Count == 0)
    {
        Console.WriteLine("The to-do list is empty");
    }
    else
    {
        Console.WriteLine("To-do list is:");
        for (int i = 0; i < todoList.Count; i++)
        {
            string status = performList[i] ? "Compled" : "Not compled";
            Console.WriteLine($"{i + 1}: {todoList[i]} {status}");
        }
    }
}

static void AddTask(List<string> todoList, List<bool> performList)
{
    Console.WriteLine("Add a new case:");
    string newCase = Console.ReadLine()!;
    if (!string.IsNullOrEmpty(newCase))
    {
        todoList.Add(newCase);
        performList.Add(false);
        Console.WriteLine("Case is aded");
    }
    else
    {
        Console.WriteLine("Case is not aded because the string is empty");
    }
}

static void PerformanceTasks(List<string> todoList, List<bool> performList)
{
    if (todoList.Count == 0)
    {
        Console.WriteLine("The to-do list is empty");
        return;
    }

    Console.WriteLine("What case you are wanna perform?: ");
    ViewTasks(todoList, performList);

    if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= todoList.Count)
    {
        performList[index - 1] = true;
        Console.WriteLine("Case is performed");
    }
    else
    {
        Console.WriteLine("Incorect number, try again");
    }
}

static void RemoveTask(List<string> todoList, List<bool> performList)
{
    if (todoList.Count == 0)
    {
        Console.WriteLine("The to-do list is empty");
        return;
    }

    Console.WriteLine("Enter number of case you are wanna remove: ");
    ViewTasks(todoList, performList);

    if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= todoList.Count)
    {
        todoList.RemoveAt(index - 1);
        performList.RemoveAt(index - 1);
        Console.WriteLine("Case is removed");
    }
    else
    {
        Console.WriteLine("Incorect number try again");
    }
}

