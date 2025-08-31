class Board
{
    Pieces?[,] board;
    public int size { get; set; }
    public int availableCells {get;set;}
    public Board(int size)
    {
        board = new Pieces?[size, size];
        this.size = size;
        availableCells = size * size;
    }
    public bool AddPiece(int i, int j, PlayingPiece playingPieces)
    {
        if (board[i, j] != null)
        {
            return false;
        }
        board[i, j] = playingPieces.piece;
        availableCells--;
        return true;
    }
    public void DisplayBoard()
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (board[i, j] == null)
                {
                    Console.Write("  ");
                }
                else
                {
                    Console.Write(" " + board[i, j]);
                }
                if (j != (size - 1))
                {
                    Console.Write(" |");
                }
            }
            Console.WriteLine();
        }
    }
    public bool CheckVictory(int i, int j)
    {
        int count = 0;
        //Check column
        for (int k = 0; k < size; k++)
        {
            if (board[k, j] == board[i, j])
            {
                count++;
            }
        }
        if (count == size)
            return true;
        count = 0;

        //Check Row
        for (int k = 0; k < size; k++)
        {
            if (board[i, k] == board[i, j])
            {
                count++;
            }
        }
        if (count == size)
            return true;
        count = 0;

        //Check diagonal
        for (int k = 0; k < size; k++)
        {
            if (board[k, k] == board[i, j])
            {
                count++;
            }
        }
        if (count == size)
            return true;
        count = 0;

        //Check cross-diagonal
        for (int k = 0; k < size; k++)
        {
            if (board[k, size - k - 1] == board[i, j])
            {
                count++;
            }
        }
        if (count == size)
            return true;

        return false;
    }

    public bool GetFreeCells()
    {
        if (availableCells == 0)
        {
            return false;
        }
        return true;
    }
}