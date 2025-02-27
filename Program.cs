﻿using System;
using Mission4;

class Driver
{
    static void Main()
    {
        Console.WriteLine("Welcome to Tic-Tac-Toe!");

        // 2D array, but swag    Initialize game board
        string[,] board = new string[3, 3];
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                board[i, j] = "-";

        Support support = new Support(); // Create an instance of Support

        while (true) // Loop until a winner or draw
        {
            // Print board using Support class
            support.printBoard(board);

            // Player X move
            Console.WriteLine("Player X, choose your space.");
            (int row, int column) = GetValidMove(board);
            board[row, column] = "X";

            // Check for a winner
            var (winnerExists, winner, full) = support.checkWinner(board);
            if (winnerExists || full)
            {
                support.printBoard(board);
                Console.WriteLine(winnerExists ? $"Player {winner} wins!" : "It's a tie!");
                break;
            }

            // Player O move
            support.printBoard(board);
            Console.WriteLine("Player O, choose your space.");
            (row, column) = GetValidMove(board);
            board[row, column] = "O";

            // Check for a winner
            (winnerExists, winner, full) = support.checkWinner(board);
            if (winnerExists || full)
            {
                support.printBoard(board);
                Console.WriteLine(winnerExists ? $"Player {winner} wins!" : "It's a tie!");
                break;
            }
        }
    }

    // Method to get a valid move
    static (int, int) GetValidMove(string[,] board)
    {
        int row, column;
        while (true)
        {
            Console.WriteLine("Enter the row coordinate (0 for the top, 1 for the center, 2 for the bottom):");
            if (!int.TryParse(Console.ReadLine(), out row) || row < 0 || row > 2)
            {
                Console.WriteLine("Invalid input. Try again.");
                continue;
            }

            Console.WriteLine("Enter the column coordinate (0 for the left, 1 for the middle, 2 for the right):");
            if (!int.TryParse(Console.ReadLine(), out column) || column < 0 || column > 2)
            {
                Console.WriteLine("Invalid input. Try again.");
                continue;
            }

            if (board[row, column] != "-")
            {
                Console.WriteLine("That space is take. Please choose a different space.");
            }
            else
            {
                return (row, column);
            }
        }
    }
}
