class Player
{
    public PlayingPiece piece { get; set; }
    public string name { get; set; }
    public Player(string name, PlayingPiece piece)
    {
        this.piece = piece;
        this.name = name;
    }
}