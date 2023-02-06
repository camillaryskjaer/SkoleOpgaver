public class Superhero
{
    private string _name;
    private string _mask;
    private string _outfit;
    private List<Abilities> _abilities;
    private List<Enamy> _enamy;


    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
}

internal class Abilities
{
    private string _invisibility;
    private string _strenght;
    private string _teleport;
}

internal class Enamy
{
    private string _name;
    private string _mask;
    private string _outfit;
    private List<Superhero> _enamy;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
}