namespace cookieApp.Recipes.Ingredients;

public class WheatFlour : Ingredient
{
    public override int id => 1;
    public override string name => "Wheat Flour";
    public override string description => $"Sieve.{base.description}";
}


