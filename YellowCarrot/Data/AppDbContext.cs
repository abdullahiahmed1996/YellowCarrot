using Azure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YellowCarrot.Models;

namespace YellowCarrot.Data
{
    internal class AppDbContext : DbContext
    {
       
        public AppDbContext()
        {
                
        }
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Tags> Tags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=YellowCarrotDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>().HasMany(i => i.Ingridients).WithOne(r => r.Recipe).OnDelete(DeleteBehavior.Cascade);

            // add a repice
            modelBuilder.Entity<Recipe>().HasData(new Recipe()
            {
                Name = "Lasagna",
                RecipeId = 1,
            });
            modelBuilder.Entity<Ingredient>().HasData(new Ingredient()
            {
                IngridientId = 1,
                Name = "Lasagna noodles",
                Quantity = "9",
                RecipeId = 1
            }, new Ingredient
            {
                IngridientId = 2,
                Name = "Italian sausage",
                Quantity = "450 g",
                RecipeId = 1
            }, new Ingredient
            {
                IngridientId = 3,
                Name = "Groud beef",
                Quantity = "340 g",
                RecipeId = 1
            }, new Ingredient
            {
                IngridientId = 4,
                Name = "Onion",
                RecipeId = 1
            }, new Ingredient
            {
                IngridientId = 5,
                Name = "Garlic",
                Quantity = "3 cloves",
                RecipeId = 1

            }, new Ingredient
            {
                IngridientId = 6,
                Name = "Crushed tomatoes",
                Quantity = "2 can",
                RecipeId = 1
            }, new Ingredient
            {
                IngridientId = 7,
                Name = "Tomatoe paste",
                Quantity = "2 cans",
                RecipeId = 1
            }, new Ingredient
            {
                IngridientId = 8,
                Name = "Parsley",
                Quantity = "300 g",
                RecipeId = 1
            }, new Ingredient
            {
                IngridientId = 9,
                Name = "Basil",
                Quantity = "2 teaspoons",
                RecipeId = 1
            }, new Ingredient
            {
                IngridientId = 10,
                Name = "Salt",
                Quantity = "300 g",
                RecipeId = 1
            }, new Ingredient
            {
                IngridientId = 11,
                Name = "Egg",
                Quantity = "1 lasge",
                RecipeId = 1
            }, new Ingredient
            {
                IngridientId = 12,
                Name = "Ricotta cheese",
                Quantity = "1 carton",
                RecipeId = 1
            }, new Ingredient
            {
                IngridientId = 13,
                Name = "Mozzarella cheese",
                Quantity = "4 cups",
                RecipeId = 1
            }, new Ingredient
            {
                IngridientId = 14,
                Name = "Parmesan cheese",
                Quantity = "300 g",
                RecipeId = 1
            });

            modelBuilder.Entity<Tags>().HasData(new Tags()
            {
                Name = "Italian",
            });
        }

 

    }
}
