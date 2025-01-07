public class FullName
{
    public string First { get; init; }
    public string Last { get; init; }

    public override string ToString() => $"{First} {Last}";

    public override bool Equals(object? obj)
    {
        return obj is FullName fullname &&
            First == fullname.First && 
            Last == fullname.Last;
    }
}