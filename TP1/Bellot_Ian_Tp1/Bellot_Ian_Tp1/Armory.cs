using System.Runtime.CompilerServices;

namespace Bellot_Ian_Tp1;

public class Armory
{
    private List<Weapon> weapons = new List<Weapon>();

    public List<Weapon> Weapons
    {
        get
        {
            return weapons;
        }
        set
        {
            weapons = value;
        }
    }

    public void Init()
    {
        Weapons = new List<Weapon>();
        
        Weapon weapon1 = new Weapon("Electrical Shock", 5, 15, Weapon.EWeaponType.Direct);
        Weapon weapon2 = new Weapon("Infernal Storm", 20, 50, Weapon.EWeaponType.Explosive);
        Weapon weapon3 = new Weapon("Precision Tracker", 10, 25, Weapon.EWeaponType.Guided);
        
        Weapons.Add(weapon1);
        Weapons.Add(weapon2);
        Weapons.Add(weapon3);
    }
    
    public void AddWeapon(Weapon weapon)
    {
        Weapons.Add(weapon);
    }

    public void RemoveWeapon(Weapon oWeapon)
    {
        Weapons.Remove(oWeapon);
    }

    public void ClearWeapon()
    {
        Weapons.Clear();
    }

    public void ViewArmory()
    {
        Console.WriteLine("Liste des armes dans l'armurerie : ");
        Console.WriteLine();
        foreach (Weapon w in Weapons)
        {
            Console.WriteLine(w.ToString());
        }
    }
}