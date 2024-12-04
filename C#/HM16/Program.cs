try
{
    Console.Write("Enter the path to the source file: ");
    string sourceFilePath = Console.ReadLine()!;

    if (!File.Exists(sourceFilePath))
    {
        Console.WriteLine("\r\nSource file not found. Please check the path");
        return;
    }

    Console.Write("Enter the path to the file to which you want to copy the data: ");
    string destinationFilePath = Console.ReadLine()!;

    File.Copy(sourceFilePath, destinationFilePath, overwrite: true);

    Console.WriteLine("File copied successfully!");
}
catch (UnauthorizedAccessException)
{
    Console.WriteLine("File access error. Check access rights.");
}
catch (IOException ex)
{
    Console.WriteLine($"An error occurred while working with files: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Unexpected error: {ex.Message}");
}
    