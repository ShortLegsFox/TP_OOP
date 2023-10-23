namespace Bellot_Ian_Tp1;

public class Weapon
{
    public string Name { get; set; }
    public int MinDamage { get; set; }
    public int MaxDamage { get; set; }
    public EWeaponType WeaponType { get; set; }

    public enum EWeaponType
    {
        Direct,
        Explosive,
        Guided
    }
    
    public Weapon(string name, int minDamage, int maxDamage, EWeaponType weaponType)
    {
        Name = name;
        MinDamage = minDamage;
        MaxDamage = maxDamage;
        WeaponType = weaponType;
    }

    public override string ToString()
    {
        return Name + " - " + " Degats :  " + MinDamage + " a " + MaxDamage + " | Type : " + WeaponType;
    }
}