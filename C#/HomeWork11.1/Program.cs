using System.Text;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine(
    """
    Вітаємо! Спробуйте вгадати зашифроване слово! 
    Кількість літер у слові: 6
    Кількість можливих невірних спроб: 6
    Також пишіть букви на Українській мові!
    """
    );
const int MaxAttempts = 6;
int attempts = 0;
const string randomWord = "Собака";
char[] guessedWord = new string('_', randomWord.Length).ToCharArray();

while (attempts < MaxAttempts)
{
    Console.WriteLine($"Поточний стан слова: {new string(guessedWord)}");
    Console.WriteLine("Введіть вашу літеру: ");
    string Letter = (Console.ReadLine()!);

    if (Letter.Length != 1)
    {
        Console.WriteLine("Будь ласка, введіть лише одну букву.");
        continue;
    }
    char letter = char.ToLower(Letter[0]);

    bool correctAnswer = false;

    for (int i = 0; i < randomWord.Length; i++)
    {
        if (char.ToLower(randomWord[i]) == letter && guessedWord[i] == '_')
        {
            guessedWord[i] = letter;
            correctAnswer = true;
        }
    }
    if (!correctAnswer)
    {
        attempts++;
        Console.WriteLine($"Невірна спроба. Залишилось спроб: {MaxAttempts - attempts}");
    }
    else
    {
        Console.WriteLine("Правильна літера!");
    }

    if (new string(guessedWord) == randomWord.ToLower())
    {
        Console.WriteLine($"Вітаємо! Ви відгадали слово: {randomWord}");
        break;
    }
}
if (new string(guessedWord) != randomWord.ToLower())
{
    Console.WriteLine($"На жаль, ви не вгадали слово. Правильна відповідь: {randomWord}");
}