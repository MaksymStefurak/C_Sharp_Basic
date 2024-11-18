//Task 1
int[] numbers = { 12, 45, 7, 34, 23, 45, 56, 2, 90 };

if (numbers.Length < 2)
{
    Console.WriteLine("An array must contain at least two elements.");
    return;
}

int largest = int.MinValue;
int secondLargest = int.MinValue;

foreach (int number in numbers)
{
    if (number > largest)
    {
        secondLargest = largest;
        largest = number;
    }
    else if (number > secondLargest && number != largest)
    {
        secondLargest = number;
    }
}

if (secondLargest == int.MinValue)
{
    Console.WriteLine("There is no second largest element.");
}
else
{
    Console.WriteLine($"The second largest element in the array: {secondLargest}");
}
//Task 2
int[,] matrix =
    {
       { 5, 12, 9 },
       { 8, 2, 14 },
       { 4, 7, 3 }
    };

Console.WriteLine("The original array:");
PrintMatrix(matrix);

    
SortMatrix(matrix);

Console.WriteLine("Sorted array by growth:");
PrintMatrix(matrix);
static void SortMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    int totalElements = rows * cols;

    int[] tempArray = new int[totalElements];
    int index = 0;

    foreach (int element in matrix)
    {
        tempArray[index++] = element;
    }

    Array.Sort(tempArray);

    index = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = tempArray[index++];
        }
    }
}

static void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
//Task 3
int[] array = { 10, 20, 30, 40, 50, 60 };

Console.WriteLine("Initial array:");
PrintArray(array);

Console.WriteLine("Enter the index of the item to delete:");
int index;
bool isValid = int.TryParse(Console.ReadLine(), out index);

if (!isValid || index < 0 || index >= array.Length)
{
    Console.WriteLine("Invalid index.");
    return;
}

array = RemoveAt(array, index);
Console.WriteLine("The array after removing the element:");
PrintArray(array);
static int[] RemoveAt(int[] array, int index)
{

    int[] newArray = new int[array.Length - 1];


    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (i == index) continue;
        newArray[j++] = array[i];
    }

    return newArray;
}

static void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}
//Task 4
int[,] matrix =
    {
        { 1, 6, 3 },
        { 4, 5, 6 },
        { 4, 3, 9 }
    };
Console.WriteLine("Array:");
PrintMatrix(matrix);

int sum = CalculateDiagonalSum(matrix);

Console.WriteLine($"The sum of elements along the main diagonal: {sum}");
static int CalculateDiagonalSum(int[,] matrix)
{
    int sum = 0;
    int size = Math.Min(matrix.GetLength(0), matrix.GetLength(1)); 

    for (int i = 0; i < size; i++)
    {
        sum += matrix[i, i]; 
    }

    return sum;
}
static void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
