namespace Program;
public class Item
{
    public string Name { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }

    public Item(string name, int attack, int defense)
    {
        Name = name;
        Attack = attack;
        Defense = defense;
    }
}