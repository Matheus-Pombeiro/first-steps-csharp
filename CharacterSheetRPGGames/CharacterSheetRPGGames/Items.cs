using System.Globalization;

class Items
{
    public Items(string type, string name, int value, int damage, int defense, int suport)
    {
        Type = type;
        Name = name;
        Damage = damage;
        Defense = defense;
        Suport = suport;
        Value = value;
    }

    public string Type { get; }
    public string Name { get; }
    public int Damage { get; }
    public int Defense { get; }
    public int Suport { get; }
    public int Value { get; }
    public string description => $"Type: {Type} - Name: {Name} - Damage: {Damage} - Defense: {Defense} - Suport: {Suport} - Value: {Value}";
}