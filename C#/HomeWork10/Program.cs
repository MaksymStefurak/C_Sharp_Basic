using System;
using System.Text;
//Task 10.1
Console.WriteLine("Enter first Name");
string firstName = Console.ReadLine()!.Trim();

Console.WriteLine("Enter Second Name");
string lastName = Console.ReadLine()!.Trim();

if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName) &&
           char.ToUpper(firstName[0]) == char.ToUpper(lastName[0]))
{
    Console.WriteLine("The same firs letter");
}
else
{
    Console.WriteLine("First letter not the same letter");
}

//Task 10.3
Console.WriteLine("Enter some Text with , after words: ");
string? Text = Console.ReadLine();
string? Result = Text.Replace(" ", "");
Console.Clear();

Console.WriteLine("Result without spaces:");
Console.Write(Result);

//Task 10.2

StringBuilder sb = new StringBuilder();

sb.AppendLine("==== Text sb ====");
sb.AppendLine($"Date:{DateTime.Now.ToShortDateString()}");
sb.AppendLine();

Console.WriteLine("Enter your events or type exit to finish");
while (true)
{
    Console.WriteLine("Enter an event: ");
    string userText = Console.ReadLine()!;

    if (userText == "exit")
    {
        break;
    }
    sb.AppendLine($"- {userText}");
}
Console.Clear();
Console.WriteLine("\nGenerated Report:");
Console.WriteLine(sb.ToString());





