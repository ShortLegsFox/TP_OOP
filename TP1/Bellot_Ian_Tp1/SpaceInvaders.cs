namespace Bellot_Ian_Tp1;

public class SpaceInvaders
{
    private List<Player> playerList = new List<Player>();

    public List<Player> PlayerList
    {
        get
        {
            return playerList;
        }
        set
        {
            playerList = value;
        }
    }

    public SpaceInvaders()
    {
        Init();
    }

    private void Init()
    {
        Player player1 = new Player("ian", "bellot", "shortlegsfox");
        Player player2 = new Player("jeff", "bezos", "jeffy67");
        Player player3 = new Player("robert", "downey", "warmachine");
        
        PlayerList.Add(player1);
        PlayerList.Add(player2);
        PlayerList.Add(player3);
    }
    
    public static void Main()
    {
        SpaceInvaders spaceInvaders = new SpaceInvaders();

        Console.WriteLine("Liste des joueurs : ");
        Console.WriteLine();
        foreach (Player p in spaceInvaders.PlayerList)
        {
            Console.WriteLine(p.ToString());
        }
        
        Console.WriteLine();

        Armory armory = new Armory();
        armory.Init();
        armory.ViewArmory();
        
        Console.WriteLine();

        Spaceship spaceship = new Spaceship(50, 50, 40, 35);
        
        // -- Oups je l'ai mis deux fois
        spaceship.AddWeapon(armory.Weapons[0], armory);
        spaceship.AddWeapon(armory.Weapons[0], armory);
        
        // -- Cool je peux l'enlever
        spaceship.RemoveWeapon(armory.Weapons[0]);
        
        spaceship.AddWeapon(armory.Weapons[1], armory);
        spaceship.AddWeapon(armory.Weapons[2], armory);
        
        spaceInvaders.PlayerList[0].SpaceShip = spaceship;
        
        Console.WriteLine("Informations sur le vaisseau de " + spaceInvaders.PlayerList[0] + " : ");
        Console.WriteLine();
        
        spaceInvaders.PlayerList[0].SpaceShip.ViewShip();
    }
}