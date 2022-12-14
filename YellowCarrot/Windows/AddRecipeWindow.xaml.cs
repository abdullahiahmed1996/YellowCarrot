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

        }

        private void btnSaveRecipe_Click(object sender, RoutedEventArgs e)
        {
            using(AppDbContext context = new())
            {
                UnitOfWork uow = new(context);
                
                Recipe newRecipe = new()
                {
                    Name = txtName.Text,
                    Ingridients = new List<Ingredient>()
                    {
                        new Ingredient()
                        {
                            Name = txtIngridients.Text,
                        },
                    },
                    Tags = new List<Tags>()
                    {
                        new Tags()
                        {
                            Name = txtTags.Text
                        }
                    }
                };

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

        private void btnAddIngredient_Click(object sender, RoutedEventArgs e)
        {
            ListViewItem lvOfIngredient = new();
            lvOfIngredient.Content =  $"{txtIngridients.Text} / {txtQuantity.Text}";
            lvOfIngredient.Tag = new Ingredient()
            {
                Name = txtIngridients.Text,
                //Quantity = txtQuantity.Text
            };

            lvIngredients.Items.Add(lvOfIngredient);
            
        }

        private void btnAddTag_Click(object sender, RoutedEventArgs e)
        {
            ListViewItem lvOfTags = new();
            lvOfTags.Content = txtTags.Text;
            lvOfTags.Tag = new Tags()
            {
                Name = txtTags.Text,
            };
            lvTags.Items.Add(lvOfTags);
        
           
        }
    }
}
