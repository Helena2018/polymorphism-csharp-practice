using System.Collections.Generic;

namespace MyFirstProgramCSharp;
class Program
{
    static void Main(string[] args)
    {
        List < Player > players = new List<Player>();

        Player player1 = new Player("Alex");
        Player player2 = new Player("Elisa");
        Player player3 = new Player("Helen");

        players.Add(player1);
        players.Add(player2);
        players.Add(player3);


        foreach (Player player in players)
        {
            Console.WriteLine(player);
        }

        Console.ReadKey();
    }

}
class Player
{
    public String userName;

    public Player(String userName)
    {
        this.userName = userName;
    }
    public override string ToString()
    {
        return userName;
    }
}
