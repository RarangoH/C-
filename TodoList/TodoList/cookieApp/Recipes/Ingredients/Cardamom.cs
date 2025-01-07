namespace cookieApp.Recipes.Ingredients;

public class Cardamom : Ingredient
{
    public override int id => 6;
    public override string name => "Cardamom";
    public override string description => $"Take half a teaspoon.{base.description}";
}


