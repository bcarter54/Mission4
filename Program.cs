
using Mission4;
internal class Program
{
    private static void Main(string[] args)
    {
        Support sus = new Support();

        // welcome the user
        Console.WriteLine("Welcome to Tic-Tac-Toe!");
        // 2D array, but swag
        string[,] board = new string[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                board[i, j] = "-";
            }
        }
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine(board[i, j]);
            }
        }
        // ask each player in turn for input

        //print board with support class' method

        //check for (and notify) winner using support method
    }
}