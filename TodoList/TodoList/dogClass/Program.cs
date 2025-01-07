



public class Dog
{
    private string _name;
    private string _breed;
    private int _weight;
    private string[] sizes = { "tiny", "medium", "large" };

    public Dog(string name, int weight)
    {
        _name = name;
        _weight = weight;
        _breed = "mixed-breed";
    }
    public Dog(string name, string breed, int weight)
    {
        _name = name;
        _breed = breed;
        _weight = weight;
    }
    

    public string Describe()
    {
        if (_weight < 5)
        {
            return $"This dog is named {_name}, it's a {_breed}, and it weighs {_weight} kilograms, so it's a {sizes[0]} dog.";
        }
        else if (_weight >= 5 && _weight < 30)
        {
            return $"This dog is named {_name}, it's a {_breed}, and it weighs {_weight} kilograms, so it's a {sizes[1]} dog.";
        }
        else
        {
            return $"This dog is named {_name}, it's a {_breed}, and it weighs {_weight} kilograms, so it's a {sizes[2]} dog.";
        }
        
    }
}