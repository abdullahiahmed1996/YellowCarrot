using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YellowCarrot.Models
{
    internal class Tags
    {
        [Key]
        public int TagId { get; set; }
        public string Name { get; set; } = null!;
    }
}
