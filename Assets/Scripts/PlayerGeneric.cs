public class PlayerGeneric
{
    private string PlayerName;
    private string ArmyName;
    private string Country;
    private string MainWeapon;
    private double Lead;
    private double Force;
    private double Intellect;
    private double Politics;
    private double Appearance;

    public PlayerGeneric(string name, string armyName, string country, string weapon, double leadership, double strength,
        double intellect, double politics, double appearance)
    {
        PlayerName = name;
        ArmyName = armyName;
        Country = country;
        MainWeapon = weapon;
        Lead = leadership;
        Force = strength;
        Intellect = intellect;
        Politics = politics;
        Appearance = appearance;
    }
}
