﻿
namespace cookieApp.App
{

    using cookieApp.Recipes;
    using cookieApp.Recipes.Ingredients;

    public class RecipesConsoleUserInteraction : IRecipesUserInteraction
    {
        private readonly IIngredientsRegister _ingredientsRegister;

        public RecipesConsoleUserInteraction(IIngredientsRegister ingredientsRegister)
        {
            _ingredientsRegister = ingredientsRegister;
        }

        public void Exit()
        {
            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }

        public void PromtToCreateRecipe()
        {
            Console.WriteLine("Create a new cookie recipe!" + "Available ingredients are:");
            //foreach (var ingredient in _ingredientsRegister.All)
            //{
            //    Console.WriteLine(ingredient);
            //}
            var ingredientsPrint = _ingredientsRegister.All.Select(ingredient => ingredient);
            Console.WriteLine(string.Join(Environment.NewLine,ingredientsPrint));
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void PrintExistingRecipes(IEnumerable<Recipe> allRecipes)
        {
            if (allRecipes.Count() > 0)
            {
                Console.WriteLine("Existing recipes are: " + Environment.NewLine);
                //var counter = 1;


                //foreach (var recipe in allRecipes)
                //{

                //    Console.WriteLine($"***{counter}***");
                //    Console.WriteLine(recipe);
                //    Console.WriteLine();
                //    counter++;
                //}
                var allRecipesAsStrings = allRecipes.Select((recipe,index) => $@"***{index+1}***
{recipe}");
                Console.WriteLine(string.Join(Environment.NewLine, allRecipesAsStrings));
            }
        }

        public IEnumerable<Ingredient> ReadIngredientsFromUser()
        {
            bool shallStop = false;
            var ingredients = new List<Ingredient>();
            while (!shallStop)
            {
                Console.WriteLine("Add an ingredient by its ID, " + "or type anything else if finished");
                var userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int id))
                {
                    var selectedIngredient = _ingredientsRegister.GetById(id);
                    if (selectedIngredient is not null)
                    {
                        ingredients.Add(selectedIngredient);
                    }
                }
                else
                {
                    shallStop = true;
                }
            }
            return ingredients;
        }
    }


}
