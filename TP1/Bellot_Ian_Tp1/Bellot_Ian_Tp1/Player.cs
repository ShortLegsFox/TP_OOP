namespace Bellot_Ian_Tp1;

public class Player
{
    private string FirstName { get; }
    private string LastName { get; }
    public string Alias { get; set; }
    
    public Spaceship SpaceShip { get; set; }
    
    public string Name
    {
        get
        {
            return FirstName + " " + LastName;
        }
    }

    public Player(string firstName, string lastName,  string alias)
    {
        FirstName = FormatName(firstName);
        Alias = alias;
        LastName = FormatName(lastName);
        SpaceShip = new Spaceship();
    }
    
    private static string FormatName(string stringToFormat)
    {
        string stringFormated = char.ToUpper(stringToFormat[0]) + stringToFormat.Substring(1);

        return stringFormated;
    }

    public override string ToString()
    {
        return Alias + " (" + Name + ")";
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Player player = (Player)obj;
        return Alias == player.Alias;
    }
}