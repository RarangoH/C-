
var items = new List<FullName>
{
    new FullName { FirstName = "John", LastName = "Doe" },
    new FullName { FirstName = "Jane", LastName = "Smith" },
    new FullName { FirstName = "Alice", LastName = "Brown" }
};

SortedList<FullName> s = new SortedList<FullName> (items);
public class SortedList<T> where T : IComparable<T>
{
    public IEnumerable<T> Items { get; }

    public SortedList(IEnumerable<T> items) 
    {
        var asList = items.ToList();
        asList.Sort();
        Items = asList;
    }
}

public class FullName : IComparable<FullName>
{
    public string FirstName { get; init; }
    public string LastName { get; init; }

    public int CompareTo(FullName? other)
    {
        if(LastName.CompareTo(other.LastName) > 0)
        {
            return 1;
        }
        else
        {
            return -1;
        }
    }

    public override string ToString() => $"{FirstName} {LastName}";

    
}


//lambda functions

public class Exercise
{
    
    public Func<string, int> GetLength = (param) => param.Length;
    public Func<int> GetRandomNumberBetween1And10 = () => new Random().Next(1, 11);
}


