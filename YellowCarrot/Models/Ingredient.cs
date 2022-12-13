using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace YellowCarrot.Models
{
    internal class Ingredient
    {
        // Primery key
        [Key]

        // Props
        public int IngridientId { get; set; }
        public string Name { get; set; } = null!;
        public int? Quantity { get; set; } = null!;
        [ForeignKey(nameof(Recipe))]
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; } = null!;
    }
}
