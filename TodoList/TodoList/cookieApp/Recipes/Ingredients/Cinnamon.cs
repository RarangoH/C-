namespace cookieApp.Recipes.Ingredients
{
    public class Cinnamon : Ingredient
    {
        public override int id => 7;
        public override string name => "Cinnamon";
        public override string description => $"Take half a teaspoon.{base.description}";
    }
}



