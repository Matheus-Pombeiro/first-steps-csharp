class Character
{
    private List<Items> items = new();
    private List<Spells> spells = new();
    private List<Skills> skills = new();

    public Character(string name, string race, string charClass, int id)
    {
        Name = name;
        Race = race;
        CharClass = charClass;
        Id = id;
    }

    public string Name { get; }
    public string Race { get; }
    public string CharClass { get; }
    public int Id { get; }
    public string description => $"\n{Id}. Name: {Name} - Race: {Race} - Class {CharClass}";

    public void AddItem(Items item)
    {
        items.Add(item);
    }

    public void AddSpell(Spells spell)
    {
        spells.Add(spell);
    }

    public void AddSkill(Skills skill)
    {
        skills.Add(skill);
    }

    public void Underline(string text)
    {
        int length = text.Length;
        string underline = string.Empty.PadLeft(length, '-');
        Console.WriteLine(underline);
    }

    public void DescribeCharSheet()
    {
        Console.WriteLine($"{Name}'s Sheet");
        Underline($"{Name}'s Sheet");

        if (items.Count > 0)
        {
            Console.WriteLine("\nItems:");
            Underline("Items:");
            foreach (Items item in items.OrderBy(e => - e.Value))
            {
                Console.WriteLine(item.description);
            }
        }

        if (spells.Count > 0)
        {
            Console.WriteLine("\nSpells:");
            Underline("Spells:");
            foreach (Spells spell in spells)
            {
                Console.WriteLine(spell.description);
            }
        }

        if (skills.Count > 0)
        {
            Console.WriteLine("\nSkills:");
            Underline("Skills:");
            foreach (Skills skill in skills)
            {
                Console.WriteLine(skill.description);
            }
        }
        
        Console.WriteLine("\n");
    }
}