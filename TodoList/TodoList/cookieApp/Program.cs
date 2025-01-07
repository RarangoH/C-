
using cookieApp.DataAccess;
using cookieApp.FileAccess;
using cookieApp.Recipes;
using cookieApp.App;
using cookieApp.Recipes.Ingredients;
using static cookieApp.Recipes.Recipe;


internal class Program
{
    private static void Main(string[] args)
    {
        const FileFormat Format = FileFormat.Json;
        IStringsTextualRepository stringsRepository = Format == FileFormat.Json ?
            new StringsJsonRepository() :
            new StringsTextualRepository();
        const string FileName = "recipes";
        var fileMetadata = new FileMetadata(FileName, Format);
        var ingredientsRegister = new IngredientsRegister();

        var cookieRecipesApp = new CookiesRecipeApp(
            new RecipesRepository(new StringsJsonRepository(), ingredientsRegister),
            new RecipesConsoleUserInteraction(ingredientsRegister));
        cookieRecipesApp.Run(fileMetadata.ToPath());
        Console.ReadKey();
    }
}
