using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YellowCarrot.Data;
using YellowCarrot.Models;

namespace YellowCarrot.Repositories
{
    internal  class IngredientRepository
    {
        private readonly AppDbContext _context;
        public IngredientRepository(AppDbContext context)
        {
            _context = context;
        }

        public void CreateNewIngredien(Ingredient newIngredients)
        {
            _context.Ingredients.Add(newIngredients);
            
        }

        public Ingredient? GetIngredient(int id)
        {
            return _context.Ingredients.FirstOrDefault(i => i.IngridientId == id);
        }

        public void DeleteIngredient(Ingredient ingredientToRemove)
        {
            _context.Ingredients.Remove(ingredientToRemove);
        }

        public List<Ingredient>? GetIngredientsList()
        {
            return _context.Ingredients.ToList();
        }
    }
}
