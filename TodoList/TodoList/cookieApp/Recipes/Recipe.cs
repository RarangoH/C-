using cookieApp.Recipes.Ingredients;

namespace cookieApp.Recipes
{
    public partial class Recipe
    {




        public IEnumerable<Ingredient> Ingredients { get; }

        public Recipe(IEnumerable<Ingredient> ingredients)
        {
            Ingredients = ingredients;
        }

        public override string ToString()
        {
            //var steps = new List<string>();
            //foreach(var ingredient in Ingredients)
            //{
            //    steps.Add($"{ingredient.name}. {ingredient.description}");
            //}
            //return string.Join(Environment.NewLine, steps);  
            
            return string.Join(Environment.NewLine, Ingredients.Select(ingredient => $"{ingredient.name}. {ingredient.description}").ToList());
        }
    }
   
}
