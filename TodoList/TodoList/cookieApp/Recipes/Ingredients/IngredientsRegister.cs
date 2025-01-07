namespace cookieApp.Recipes.Ingredients;

public class IngredientsRegister : IIngredientsRegister
{
    public IEnumerable<Ingredient> All { get; } = new List<Ingredient>
    {
        new WheatFlour(),
        new Sugar(),
        new Butter(),
        new Cardamom(),
        new Chocolate(),
        new Cinnamon(),
        new CocoaPowder(),
        new CoconutFlour()


    };

    public Ingredient GetById(int id)
    {

        //Code without LINQ
        //foreach (var ingredient in All)
        //{
        //    if (ingredient.id == id)
        //    {
        //        return ingredient;
        //    }
        //}
        //return null;
        
        //Code with LINQ
        var AllIngredientsWithGivenId = All.Where(ingredient => ingredient.id == id);
        if (AllIngredientsWithGivenId.Count() > 1)
        {

            throw new InvalidOperationException($"More than one ingredient have ID equal to {id}.");
        }

        //This should not be done here, it is not this method's responsability

        //if(All.Select(ingredient => ingredient.id).Distinct().Count() != All.Count())
        //{
        //    throw new InvalidOperationException($"Some ingredients have duplicated IDs.");
        //}
        return AllIngredientsWithGivenId.FirstOrDefault();
        
    }
}

