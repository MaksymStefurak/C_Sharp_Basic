using System;
//Task 1,2
var rand = new Random();
int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-10, 11);
    Console.WriteLine(array[i]);
}
Console.WriteLine("Random array value: ");

for (int i = 0; i < array.Length; i += 2)
{
    Console.WriteLine($"Index {i}: {array[i]}");
}

// Task 3

int[,] multiplicationTable = new int[9, 9];


for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        multiplicationTable[i, j] = (i + 1) * (j + 1);
    }
}


Console.WriteLine("Table (9x9):");
for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        Console.Write(multiplicationTable[i, j].ToString().PadLeft(4));
    }
    Console.WriteLine();
}

//Task 4
int[,] array = new int[5, 5];
var rand = new Random();


for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        array[i, j] = rand.Next(-100, 101);
        Console.Write(array[i, j].ToString().PadLeft(5));
    }
    Console.WriteLine();
}


int maxElement = array[0, 0];
int minElement = array[0, 0];
int maxRow = 0, maxCol = 0;
int minRow = 0, minCol = 0;

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (array[i, j] > maxElement)
        {
            maxElement = array[i, j];
            maxRow = i;
            maxCol = j;
        }

        if (array[i, j] < minElement)
        {
            minElement = array[i, j];
            minRow = i;
            minCol = j;
        }
    }
}


Console.WriteLine($"\nMax element: {maxElement} (Kordination: [{maxRow}, {maxCol}])");
Console.WriteLine($"Min element: {minElement} (Kordination: [{minRow}, {minCol}])");

// Task 5

Console.Write("Enter the number of days: ");
if (int.TryParse(Console.ReadLine(), out int inputDays))
{
    
    DaysOfWeek startDay = DaysOfWeek.Monday; 
    int resultDayIndex = (int)startDay + (inputDays % 7); 
    resultDayIndex %= 7; 

    
    DaysOfWeek resultDay = (DaysOfWeek)resultDayIndex;
    Console.WriteLine($"In {inputDays} days, it will be: {resultDay}");
}
else
{
    Console.WriteLine("Please enter a valid integer.");
}

enum DaysOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

