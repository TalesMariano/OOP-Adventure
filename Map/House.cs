namespace OOPAdventure;

public partial class House
{
    public Player Player { get; }
    
    private readonly Random rnd = new (1234);

    public House(Player player)
    {
        Player = player;
    }
}