using System;

class TicTacToe
{
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static char currentPlayer = 'X'; 
    static int moveCount = 0;        

    static void Main()
    {
        bool gameWon = false;

        while (!gameWon && moveCount < 9)
        {
            Console.Clear();
            PrintBoard();
            PlayerMove();
            gameWon = CheckWin();

            if (!gameWon)
            {
                
                currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
            }
        }

        Console.Clear();
        PrintBoard();
        if (gameWon)
        {
            Console.WriteLine($"Player {currentPlayer} wins!");
        }
        else
        {
            Console.WriteLine("It's a draw!");
        }
    }

    static void PrintBoard()
    {
        Console.WriteLine("Tic Tac Toe");
        Console.WriteLine();
        Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
        Console.WriteLine();
    }

    static void PlayerMove()
    {
        int choice;
        bool validInput = false;

        while (!validInput)
        {
            Console.WriteLine($"Player {currentPlayer}, enter a number (1-9) to place your mark:");
            string input = Console.ReadLine()!;

            
            if (int.TryParse(input, out choice) && choice >= 1 && choice <= 9 && board[choice - 1] != 'X' && board[choice - 1] != 'O')
            {
                board[choice - 1] = currentPlayer;
                validInput = true;
                moveCount++;
            }
            else
            {
                Console.WriteLine("Invalid input, please try again.");
            }
        }
    }

    static bool CheckWin()
    {
        int[,] winningCombinations = new int[,]
        {
            { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, 
            { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, 
            { 0, 4, 8 }, { 2, 4, 6 }              
        };

        for (int i = 0; i < winningCombinations.GetLength(0); i++)
        {
            if (board[winningCombinations[i, 0]] == currentPlayer &&
                board[winningCombinations[i, 1]] == currentPlayer &&
                board[winningCombinations[i, 2]] == currentPlayer)
            {
                return true;
            }
        }

        return false;
    }
}