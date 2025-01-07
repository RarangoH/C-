
namespace cookieApp.App
{

    using cookieApp.Recipes;
    using cookieApp.Recipes.Ingredients;

    public interface IRecipesUserInteraction
    {
        void ShowMessage(string message);
        void Exit();
        void PrintExistingRecipes(IEnumerable<Recipe> allRecipes);
        void PromtToCreateRecipe();
        IEnumerable<Ingredient> ReadIngredientsFromUser();
    }


}
