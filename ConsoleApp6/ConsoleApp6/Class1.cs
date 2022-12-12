public class Class1
{
    private int v;
    private string[] strings;

    public int Number { get; }
public string Origin { get; }
public string Destination
    {
        get;
    }
    public Class1(int number, string origin, string destination)
    {
        this.Number = number;
    this.Origin = origin;
        this.Destination = destination;
    }

    public Class1(int v, string[] strings)
    {
        this.v = v;
        this.strings = strings;
    }

    public override string ToString() => $"{Number}: {Origin} ->{Destination}";
    }