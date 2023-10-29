class Skills
{
    public Skills(string type, string name, string rareness, int damage, int defense, int suport)
    {
        Type = type;
        Name = name;
        Damage = damage;
        Defense = defense;
        Suport = suport;
        Rareness = rareness;
    }

    public string Type { get; }
    public string Name { get; }
    public int Damage { get; }
    public int Defense { get; }
    public int Suport { get; }
    public string Rareness { get; }
    public string description => $"Type: {Type} - Name: {Name} - Damage: {Damage} - Defense: {Defense} - Suport: {Suport} - Rareness: {Rareness}";
}