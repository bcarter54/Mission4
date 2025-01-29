// See https://aka.ms/new-console-template for more information
using Mission4;

Support su = new Support();

string[,] board = new string[3, 3];

board[0, 0] = "O";
board[0, 1] = "X";
board[0, 2] = "X";
board[1, 0] = "O";
board[1, 1] = "X";
board[1, 2] = "X";
board[2, 0] = "X";
board[2, 1] = "O";
board[2, 2] = "O";

su.printBoard(board);
var result = su.checkWinner(board);

Console.WriteLine("And the winner is: " + result.winner);



