using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YellowCarrot.Data;
using YellowCarrot.Models;

namespace YellowCarrot.Repositories
{
    internal  class RecipeRepository
    {
        private readonly AppDbContext _context;
        public RecipeRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Recipe> AllRecipes()
        {
            return _context.Recipes.Include(r => r.Ingridients).Include(r => r.Tags).ToList();
        }

        public void NewRecipe(Recipe newRecipe)
        {
            _context.Recipes.Add(newRecipe);
        }

        public void DeleteRecipe(Recipe selectedRecipe)
        {
            _context.Recipes.Remove(selectedRecipe);
        }

        public void UpdateRecipe(Recipe recipeToUpdate)
        {
            _context.Recipes.Update(recipeToUpdate);
        }

        public  Recipe? GetRecipeId(int id)
        {

            return _context.Recipes.FirstOrDefault(r => r.RecipeId == id);
        }
    }
}
