namespace JogoDaVelha
{
    internal class Program
    {
        static char[,] board = new char[3, 3];
        static char actualPlayer = 'X';
        static void Main(string[] args)
        {
            bool endGame = false;

            Console.WriteLine("     ██╗ ██████╗  ██████╗  ██████╗     ██████╗  █████╗     ██╗   ██╗███████╗██╗     ██╗  ██╗ █████╗ \r\n     ██║██╔═══██╗██╔════╝ ██╔═══██╗    ██╔══██╗██╔══██╗    ██║   ██║██╔════╝██║     ██║  ██║██╔══██╗\r\n     ██║██║   ██║██║  ███╗██║   ██║    ██║  ██║███████║    ██║   ██║█████╗  ██║     ███████║███████║\r\n██   ██║██║   ██║██║   ██║██║   ██║    ██║  ██║██╔══██║    ╚██╗ ██╔╝██╔══╝  ██║     ██╔══██║██╔══██║\r\n╚█████╔╝╚██████╔╝╚██████╔╝╚██████╔╝    ██████╔╝██║  ██║     ╚████╔╝ ███████╗███████╗██║  ██║██║  ██║\r\n ╚════╝  ╚═════╝  ╚═════╝  ╚═════╝     ╚═════╝ ╚═╝  ╚═╝      ╚═══╝  ╚══════╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝\r\n                                                                                                    \r\n\r\n");
            Console.Write("Você deseja jogar contra o computador (digite C) ou contra uma amizade (digite A)? ");
            string startGame = Console.ReadLine().ToUpper();
            if (startGame == "C")
            {
                StartGameAgainstComputer(endGame);
            }
            else if (startGame == "A")
            {
                StartGameAgainstFriend(endGame);
            }



        }

        static void StartBoard()
        {

            for (int line = 0; line < 3; line++)
            {
                for (int column = 0; column < 3; column++)
                {
                    board[line, column] = ' ';

                }
            }

        }

        static void ShowBoard()
        {
            Console.Clear();
            for (int line = 0; line < 3; line++)
            {
                Console.Write((line + 1) + " ");
                for (int column = 0; column < 3; column++)
                {
                    Console.Write(board[line, column]);
                    if (column < 2)
                    {
                        Console.Write(" | ");
                    }
                }
                Console.WriteLine();
                if (line < 2)
                {
                    Console.WriteLine("  --+---+--");
                }
            }
            Console.WriteLine("  A   B   C");
        }


        static bool ValidateMove(string move)
        {
            if (move.Length != 2)
            {
                return false;
            }

            char column = move[1];
            if (column < 'A' || column > 'C')
            {
                return false;
            }

            int line = move[0] - '1';
            if (line < 0 || line > 2)
            {
                return false;
            }

            if (board[line, column - 'A'] != 'X' && board[line, column - 'A'] != 'O')
            {
                board[line, column - 'A'] = actualPlayer;
                return true;
            }

            return false;
        }

        static bool CheckVictory()
        {
            for (int line = 0; line < 3; line++)
            {
                if (board[line, 0] == actualPlayer && board[line, 1] == actualPlayer && board[line, 2] == actualPlayer)
                {
                    Console.WriteLine($"Jogador {actualPlayer} venceu!");
                    return true;
                }
            }

            for (int column = 0; column < 3; column++)
            {
                if (board[0, column] == actualPlayer && board[1, column] == actualPlayer && board[2, column] == actualPlayer)
                {
                    Console.WriteLine($"Jogador {actualPlayer} venceu!");
                    return true;
                }
            }

            if ((board[0, 0] == actualPlayer && board[1, 1] == actualPlayer && board[2, 2] == actualPlayer) ||
                (board[0, 2] == actualPlayer && board[1, 1] == actualPlayer && board[2, 0] == actualPlayer))
            {
                Console.WriteLine($"Jogador {actualPlayer} venceu!");
                return true;
            }

            return false;
        }

        static bool CheckDraw()
        {

            int count = 0;
            for (int line = 0; line < 3; line++)
            {
                for (int column = 0; column < 3; column++)
                {
                    if (board[line, column] != 'X' && board[line,column] != 'O')
                    {
                        return false;
                    }
                }
            }
            Console.WriteLine("Ocorreu um empate. Jogo terminado!");
            return true;

        }

        static void StartGameAgainstFriend(bool endGame)
        {
            actualPlayer = 'X';

            StartBoard();
            ShowBoard();

            while (!endGame)
            {
                bool validMove = false;

                while (!validMove)
                {
                    Console.WriteLine($"Jogador {actualPlayer}, escolha sua move (por exemplo, 1A ou 2B):");
                    string move = Console.ReadLine().ToUpper();

                    if (ValidateMove(move))
                    {
                        validMove = true;
                    }
                    else
                    {
                        Console.WriteLine("move inválida. Tente novamente.");
                    }
                }
                ShowBoard();

                if (CheckVictory() || CheckDraw())
                {
                    endGame = true;

                }

                actualPlayer = (actualPlayer == 'X') ? 'O' : 'X';
            }
            CheckNewGame();
        }

        static void CheckNewGame()
        {
            Console.Write("Deseja jogar novamente? (S/N): ");
            string continueGame = Console.ReadLine().ToUpper();
            if (continueGame == "S")
            {
                StartGameAgainstFriend(false);
            }
        }

        static void StartGameAgainstComputer(bool endGame)
        {
            actualPlayer = 'X';

            StartBoard();
            ShowBoard();

            while (!endGame)
            {
                bool validMove = false;

                while (!validMove)
                {
                    if (actualPlayer == 'X')
                    {
                        ComputerMove();
                        validMove = true;

                    }
                    else
                    {
                        Console.WriteLine($"Jogador {actualPlayer}, escolha sua move (por exemplo, 1A ou 2B):");
                        string move = Console.ReadLine().ToUpper();

                        if (ValidateMove(move))
                        {
                            validMove = true;
                        }
                        else
                        {
                            Console.WriteLine("move inválida. Tente novamente.");
                        }
                    }
                }
                ShowBoard();

                if (CheckVictory() || CheckDraw())
                {
                    endGame = true;

                }

                actualPlayer = (actualPlayer == 'X') ? 'O' : 'X';
            }
            CheckNewGame();
        }

        static void ComputerMove()
        {
            Random random = new Random();
            int line, column;

            do
            {
                line = random.Next(3);
                column = random.Next(3);
            } while (board[line, column] != ' ');

            board[line, column] = actualPlayer;
        }
    }
}