using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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

        }

        // function for the save button
        private void btnSaveRecipe_Click(object sender, RoutedEventArgs e)
        {
            using (AppDbContext context = new())
            {
                UnitOfWork uow = new(context);
                
                Recipe nRecipe = new()
                {
                    Name = txtName.Text,

                    Ingridients = IngrediensList(),
                    
                    Tags = TagsList(),
                };

                uow.RecipeRepo.NewRecipe(nRecipe);


                uow.SaveChanges();
            }

              UpdateUi();
        }

        // List for ingedients
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

        // Llist of the tags
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

        // add ingerdient 
        private void btnAddIngredient_Click(object sender, RoutedEventArgs e)
        {
            ListViewItem lvOfIngredient = new();
            lvOfIngredient.Content = $"{txtIngridients.Text} / {txtQuantity.Text}";
            lvOfIngredient.Tag = new Ingredient()
            {
                Name = txtIngridients.Text,
                Quantity = txtQuantity.Text
            };

            lvIngredients.Items.Add(lvOfIngredient);

            txtIngridients.Clear();
            txtQuantity.Clear();

        }
        // add tag
        private void btnAddTag_Click(object sender, RoutedEventArgs e)
        {
            ListViewItem lvOfTags = new();
            lvOfTags.Content = txtTags.Text;
            lvOfTags.Tag = new Tags()
            {
                Name = txtTags.Text,
            };
            lvTags.Items.Add(lvOfTags);
            txtTags.Clear();
        
           
        }

        // Cancel button that takes you to the recipe window
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            RecipeWindow recipeWindow = new();
            recipeWindow.Show();

            Close();
        }

        // update ui method that clears all the txtblocks and listviews
        private void UpdateUi()
        {
            txtName.Clear();
            txtIngridients.Clear();
            txtTags.Clear();
            txtQuantity.Clear();
            lvIngredients.Items.Clear();
            lvTags.Items.Clear();

        }
    }
}
