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
            return _context.Recipes.Include(r => r.Tags).ToList();
        }

        public void NewRecipe(Recipe newRecipe)
        {
            _context.Recipes.Add(newRecipe);
        }
    }
}
