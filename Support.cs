namespace Mission4;

public class Support
{
//This prints the board for the players to see blah blah
    public void printBoard(string[,] board)
    {
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                if (col == 2)
                {
                    Console.Write(board[row, col]);
                }
                else
                {
                    Console.Write(board[row, col] + " | ");
                }

            }

            Console.WriteLine();

        }
    }

    public (bool winnerExists, string winner, bool full) checkWinner(string[,] board)
    {
        int full = 0;

        // Check rows for winner
        string results;
        for (int row = 0; row < 3; row++)
        {
            results = "";
            for (int col = 0; col < 3; col++)
            {
                results += board[row, col];

            }
            if (results.Equals("XXX"))
            {
                return (true, "X", false);
            }
            else if (results.Equals("OOO"))
            {
                return (true, "O", false);
            }

            if (!results.Contains("-"))
            {
                full++;
            }
        }

        // Check columns for winner
        for (int col = 0; col < 3; col++)
        {
            results = "";
            for (int row = 0; row < 3; row++)
            {
                results += board[row, col];

            }

            if (results.Equals("XXX"))
            {
                return (true, "X", false);
            }
            else if (results.Equals("OOO"))
            {
                return (true, "O", false);
            }

        }

        //Check Diagonals for winner
        results = board[0, 0] + board[1, 1] + board[2, 2];

        if (results.Equals("XXX"))
        {
            return (true, "X", false);
        }
        else if (results.Equals("OOO"))
        {
            return (true, "O", false);
        }

        //Check other diagonal
        results = board[0, 2] + board[1, 1] + board[2, 0];

        if (results.Equals("XXX"))
        {
            return (true, "X", false);
        }
        else if (results.Equals("OOO"))
        {
            return (true, "O", false);
        }

        //Check to see if the board is full
        if (full == 3)
        {
            return (false, "CAT'S GAME", true);
        }
        else
        {
            return (false, "NA", false);
        }

    }
}