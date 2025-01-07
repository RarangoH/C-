using cookieApp.Recipes.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cookieApp.Recipes.Ingredients
{
    public static class IngredientList
    {
        public static IEnumerable<Ingredient> All { get; } = new List<Ingredient>

{
    new WheatFlour(),
    new CoconutFlour(),
    new Butter(),
    new Chocolate(),
    new Sugar(),
    new Cardamom(),
    new Cinnamon(),
    new CocoaPowder(),
};
    }
}
