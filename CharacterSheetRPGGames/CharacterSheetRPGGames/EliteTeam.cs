using System.Globalization;

class EliteTeam
{
    private List<Character> characters = new();

    public EliteTeam(string name, string kingdom, int id, string speciality)
    {
        Name = name;
        Kingdom = kingdom;
        Id = id;
        Speciality = speciality;
    }

    public string Name { get; }
    public string Kingdom { get; }
    public int Id { get; }
    public string Speciality { get; }
    public int numberOfMembers => characters.Count();
    public string description => $"\nName: {Name} - Kingdom: {Kingdom} - Speciality: {Speciality} - Number of Members: {numberOfMembers}\n";

    public void AddChar(Character character)
    {
        characters.Add(character);
    }

    public void Underline(string text)
    {
        int length = text.Length;
        string underline = string.Empty.PadLeft(length, '-');
        Console.WriteLine(underline);
    }
    
    public void DescribeTeam()
    {
        Console.WriteLine("Elite Team");
        Underline("Elite Team");
        Console.WriteLine(description);
        foreach (Character character in characters.OrderBy(e => e.Id))
        {
            Console.WriteLine(character.description);
        }
        Console.WriteLine("\n");
    }
}