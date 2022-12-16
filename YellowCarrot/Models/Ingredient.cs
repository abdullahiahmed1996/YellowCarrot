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
    public class Ingredient
    {
        // Primary key
        [Key]

        // Props
        public int IngridientId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; } = null!;
        [MaxLength(100)]
        public string? Quantity { get; set; }
        public int? RecipeId { get; set; }
        public Recipe? Recipe { get; set; }
    }
}
