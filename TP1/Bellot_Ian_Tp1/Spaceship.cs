namespace Bellot_Ian_Tp1;

public class Spaceship
{
    public int MaxStructure { get; set; }
    public int MaxShield { get; set; }

    private int currentStructure;
    public int CurrentStructure
    {
        get
        {
            return currentStructure;
        }
        set
        {
            if (value > MaxStructure)
                currentStructure = MaxStructure;
            else
            {
                currentStructure = value;
            }
        }
    }

    private int currentShield;
    public int CurrentShield
    {
        get
        {
            return currentShield;
        }
        set
        {
            if (value > MaxShield)
                currentShield = MaxShield;
            else
            {
                currentShield = value;
            }
        }
    }

    private bool isDestroyed;
    public bool IsDestroyed
    {
        get
        {
            return isDestroyed;
        }
        set
        {
            if (CurrentStructure == 0)
            {
                isDestroyed = true;
            }
            else
            {
                isDestroyed = value;
            }
        }
    }

    private List<Weapon> weapons = new List<Weapon>();
    public List<Weapon> Weapons
    {
        get { return weapons; }
        set
        {
            if (weapons.Count() > 3)
            {
                Console.WriteLine("Trop d'armes pour ce véhicule !");
            }
            else
            {
                weapons = value;
            }
        }
    }

    public Spaceship()
    {
        MaxStructure = 10;
        MaxShield = 10;
        CurrentStructure = 5;
        CurrentShield = 5;
    }
    
    public Spaceship(int maxStructure, int maxShield, int currentStructure, int currentShield)
    {
        Weapons = new List<Weapon>();
        MaxStructure = maxStructure;
        MaxShield = maxShield;
        CurrentStructure = currentStructure;
        CurrentShield = currentShield;
    }

    public void AddWeapon(Weapon weapon, Armory armory)
    {
        if (Weapons.Count() < 3)
        {
            Weapons.Add(weapon);
        }
        else if (!armory.Weapons.Contains(weapon))
        {
            throw new ArmurerieException("Cette arme n'est pas dans l'armurerie !");
        }
        else
        {
            Console.WriteLine("Ce vaisseau contient déjà le nombre maximum d'armes !");
        }
    }

    public void RemoveWeapon(Weapon oWeapon)
    {
        Weapons.Remove(oWeapon);
    }

    public void ClearWeapon()
    {
        Weapons.Clear();
    }

    public void ViewWeapons()
    {
        Console.WriteLine("Armes du vaisseau actuel : ");
        Console.WriteLine();
        foreach (Weapon w in Weapons)
        {
            w.ToString();
        }
    }

    public double AverageDamages()
    {
        double cumul = 0;
        foreach (Weapon w in Weapons)
        {
            cumul += ((w.MaxDamage + w.MinDamage) / 2);
        }

        return Math.Round(cumul/3, 2);
    }

    public void ViewShip()
    {
        Console.WriteLine("Structure Max : " + MaxStructure);
        Console.WriteLine("Bouclier Max : " + MaxShield);
        Console.WriteLine("Structure Actuelle : " + CurrentStructure);
        Console.WriteLine("Bouclier Actuel : " + CurrentShield);
        Console.WriteLine("Dégats moyen : " + AverageDamages());
    }
    
}