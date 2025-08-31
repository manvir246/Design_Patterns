class Game
{
    LinkedList<Player> players;
    Board board;
    public Game()
    {
        InitializeGameComponents();
    }

    void InitializeGameComponents()
    {
        players = new LinkedList<Player>();

        //Created board pieces (Scalable)
        PlayingPiece pieceX = new PlayingPieceX();
        PlayingPiece pieceO = new PlayingPieceO();

        //Creating players
        var player1 = new Player("Player1", pieceX);
        var player2 = new Player("Player2", pieceO);

        players.AddLast(player1);
        players.AddLast(player2);

        //Size of the board
        board = new Board(3);
    }
    public void StartGame()
    {
        bool noWinner = true;
        while (noWinner)
        {
            board.DisplayBoard();
            var player = players.First();
            players.RemoveFirst();
            Console.WriteLine("Its your turn: " + player.name);
            string[] input = Console.ReadLine().Trim(' ').Split(",").Select(x => x.Trim(' ', '(', ')')).ToArray();
            if (!board.AddPiece(int.Parse(input[0]), int.Parse(input[1]), player.piece))
            {
                Console.WriteLine("That move was wrong!!");
                players.AddFirst(player);
            }
            else
            {
                if (board.CheckVictory(int.Parse(input[0]), int.Parse(input[1])))
                {
                    Console.WriteLine("The winner is : " + player.name);
                    return;
                }
                players.AddLast(player);
                if (!board.GetFreeCells())
                {
                    noWinner = false;
                    Console.WriteLine("Ooops! Nobody won!, its a draw ;)");
                    return;
                }

            }
        }
    }
    
}