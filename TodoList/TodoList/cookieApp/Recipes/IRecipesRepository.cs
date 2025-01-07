namespace cookieApp.Recipes
{
    public partial class Recipe
    {
        public interface IRecipesRepository
        {
            List<Recipe> Read(string filepath);
            void Write(string filepath, List<Recipe> allRecipes);
        }
    }
   
}
