namespace cookieApp.Recipes.Ingredients;

public class Chocolate : Ingredient
{
    public override int id => 4;
    public override string name => "Chocolate";
    public override string description => $"Melt in water bath.{base.description}";
}


