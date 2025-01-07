namespace cookieApp.Recipes.Ingredients;
public class Butter : Ingredient
{
    public override int id => 3;
    public override string name => "Butter";
    public override string description => $"Melt on low heat.{base.description}";
}


