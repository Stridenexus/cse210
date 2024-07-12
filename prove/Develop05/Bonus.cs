public class Bonus
{
    private readonly string _name;
    private readonly int _points;

    public string Name { get { return _name; } }
    public int Points { get { return _points; } }

    public Bonus(string name, int points)
    {
        _name = name;
        _points = points;
    }
}