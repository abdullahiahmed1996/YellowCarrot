using Azure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace YellowCarrot.Models
{
    internal class Recipe
    {
        [Key]
        public int RecipeId { get; set; }
        public string Name { get; set; } = null!;
        public List<Ingredient> Ingridients { get; set; } = new();
        public List<Tags> Tags { get; set; } = new();


    }
}
