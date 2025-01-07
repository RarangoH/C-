using cookieApp.Recipes;
using static cookieApp.Recipes.Recipe;
using static cookieApp.Recipes.Recipe.RecipesRepository;

namespace cookieApp.App
{

public class CookiesRecipeApp()
    {

        private readonly IRecipesRepository _recipesRepository;
        private readonly IRecipesUserInteraction _recipesInteraction;

        public CookiesRecipeApp(IRecipesRepository recipesrepository, IRecipesUserInteraction recipesUserInteraction) : this()
        {
            _recipesRepository = recipesrepository;
            _recipesInteraction = recipesUserInteraction;
        }
        public void Run(string filePath)
        {
            //load Existing recipes
            var allRecipes = _recipesRepository.Read(filePath);
            //print existing recipes
            _recipesInteraction.PrintExistingRecipes(allRecipes);

            //prompt to create recipe
            _recipesInteraction.PromtToCreateRecipe();

            //reading ingredients from user
            var ingredients = _recipesInteraction.ReadIngredientsFromUser();

            //validate if the user selected any ingredient
            if (ingredients.Count() > 0)
            {
                //create a new recipe with the ingredients added to the collection
                var recipe = new Recipe(ingredients);
                //save all old recipes plus new one to a file
                allRecipes.Add(recipe);
                //save
                _recipesRepository.Write(filePath, allRecipes);

                _recipesInteraction.ShowMessage("Recipe added:");
                _recipesInteraction.ShowMessage(recipe.ToString());
            }
            else
            {
                _recipesInteraction.ShowMessage("No ingredients have been selected. " + "Recipe will not be saved.");
                _recipesInteraction.Exit();
            }
        }
    }


}
