namespace cookieApp.Recipes.Ingredients;
public abstract class Ingredient
{


    public abstract int id { get; }
    public abstract string name { get; }
    public virtual string description => "Add to other ingredients";

    public override string ToString()
    {
        return $"{id}.{name}";
    }

}


