using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using YellowCarrot.Data;
using YellowCarrot.Models;
using YellowCarrot.Repositories;

namespace YellowCarrot.Windows
{
    /// <summary>
    /// Interaction logic for AddRecipeWindow.xaml
    /// </summary>
    public partial class AddRecipeWindow : Window
    {
        public AddRecipeWindow()
        {
            InitializeComponent();

            using (AppDbContext context = new())
            {

            }
        }

        private void btnSaveRecipe_Click(object sender, RoutedEventArgs e)
        {
            Recipe newRecipe = new()
            {
                Name = txtName.Text,
                Ingridients = IngrediensList(),
                Tags = TagsList()
            };
            using (AppDbContext context = new())
            {
                UnitOfWork uow = new(context);
                uow.RecipeRepo.NewRecipe(newRecipe);
                uow.SaveChanges();
            }
            
            Close();
        }

        private List<Ingredient> IngrediensList()
        {
            List<Ingredient> ingredientsList = new();

            foreach(ListViewItem item in lvIngredients.Items)
            {
                Ingredient ingredient = item.Tag as Ingredient;

                ingredientsList.Add(ingredient);
            }
            return ingredientsList;
        }

        private List<Tags> TagsList()
        {
            List<Tags> tagsList = new();

            foreach(ListViewItem item in lvTags.Items)
            {
                Tags tags = item.Tag as Tags;
                
                tagsList.Add(tags);
            }
            return tagsList;
        }
    }
}
