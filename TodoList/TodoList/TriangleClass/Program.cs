

public class Triangle
{
    private int @base;
    private int height;

    public Triangle(int @Base, int Height)
    {
        @base = @Base;
        height = Height;

    }
    public int CalculateArea()
    {
        return ((@base * height)/2);
    }

    public string AsString()
    {
        return $"Base is {@base}, height is {height}";
    }
}