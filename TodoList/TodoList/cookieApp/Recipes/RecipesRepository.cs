using cookieApp.DataAccess;
using cookieApp.Recipes.Ingredients;

namespace cookieApp.Recipes
{
    public partial class Recipe
    {
        public class RecipesRepository : IRecipesRepository
        {
            private readonly IStringsTextualRepository _stringsRepo;
            private readonly IIngredientsRegister _ingredientsRegister;
            private const string Separator = ",";

            public RecipesRepository(IStringsTextualRepository stringsRepo, IIngredientsRegister ingredientsRegister)
            {
                _stringsRepo = stringsRepo;
                _ingredientsRegister = ingredientsRegister;
            }

            public void Write(string filepath, List<Recipe> allRecipes)
            {
                //var recipesAsStrings = new List<string>();
                var allIds = new List<int>();
                //foreach (var recipe in allRecipes)
                //
                    //var allIds = new List<int>();

                    
                    //first LINQ each loop refatored, then both loops joined at the bottom of this method
                    //allIds = recipe.Ingredients.Select(ingredient => ingredient.id).ToList();
                    //
                    


                    //foreach (var ingredient in recipe.Ingredients)
                    //{
                    //    allIds.Add(ingredient.id);
                    //}
                    //recipesAsStrings.Add(string.Join(Separator, allIds));
                //}
                var recipesAsStrings = allRecipes.Select(recipe => string.Join(Separator, recipe.Ingredients.Select(ingredient => ingredient.id).ToList())).ToList();
               
                _stringsRepo.Write(filepath, recipesAsStrings);
            }

            public List<Recipe> Read(string filepath)
            {
                //returns a list
                //List<string> recipesFromFile = _stringsRepo.Read(filepath);
                //var recipes = new List<Recipe>();
                //foreach (var recipeFromFile in recipesFromFile)
                //{
                //    var recipe = RecipeFromString(recipeFromFile);
                //    recipes.Add(recipe);
                //}
                //return recipes;
                return _stringsRepo.Read(filepath).Select(recipe => RecipeFromString(recipe)).ToList();
            }

            private Recipe RecipeFromString(string recipeFromFile)
            {
                //var textualIds = recipeFromFile.Split(Separator);
                //var ingredients = new List<Ingredient>();


                //foreach (var textualId in textualIds)
                //{
                //    var id = int.Parse(textualId);
                //    var ingredient = _ingredientsRegister.GetById(id);
                //    ingredients.Add(ingredient);
                //}
                //return new Recipe(ingredients);
                return new Recipe(recipeFromFile.Split(Separator).Select(textualId => _ingredientsRegister.GetById(int.Parse(textualId))));
            }
        }
    }
   
}
