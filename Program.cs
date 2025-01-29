

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
        bool ugh = true;
         do
        {

            // ignore our superior print
            for (int i = 0; i < 3; i++)
            {
                string silliness = "";
                for (int j = 0; j < 3; j++)
                {
                    silliness = silliness + " " + i + "," + j + board[i, j];

                    if (j == 2)
                    {
                        Console.WriteLine(silliness);
                    }
                }
            }


            // ask each player in turn for input

            Console.WriteLine("Player X, choose your space.");
        bruh:
            Console.WriteLine("Left coordinate:");
            int left = int.Parse(Console.ReadLine());
            Console.WriteLine("Right coordinate:");
            int right = int.Parse(Console.ReadLine());

            if (board[left, right] != "-")
            {
                Console.WriteLine("Choose a different space.");
                goto bruh;
            }
            else
            {
                board[left, right] = "X";
            }

            //    //print board with support class' method
            //      sus.PrintBoard(board);

            Console.WriteLine("Player O, choose your space.");
        cringe:
            Console.WriteLine("Left coordinate:");
            left = int.Parse(Console.ReadLine());
            Console.WriteLine("Right coordinate:");
            right = int.Parse(Console.ReadLine());

            if (board[left, right] != "-")
            {
                Console.WriteLine("Choose a different space.");
                goto cringe;
            }
            else
            {
                board[left, right] = "O";
            }

            //    //check for (and notify) winner using support method
            //    sus.CheckWinner();
        } while (ugh == true) ;
    }
}