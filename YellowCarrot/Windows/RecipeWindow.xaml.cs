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

namespace YellowCarrot.Windows
{
    /// <summary>
    /// Interaction logic for RecipeWindow.xaml
    /// </summary>
    public partial class RecipeWindow : Window
    {
        public RecipeWindow()
        {
            InitializeComponent();

            using (AppDbContext context = new())
            {
                List<Recipe> recipes = context.Recipes.ToList();

                recipes.ForEach(r => lvRecipes.Items.Add(new ListViewItem()
                {
                    Content = r.Name,
                    Tag = r
                }));
            }
        }

        private void btnAddRecipe_Click(object sender, RoutedEventArgs e)
        {
            AddRecipeWindow addRecipeWindow = new ();

            addRecipeWindow.Show();

            Close();
        }

        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {
            DetailsWindow detailsWindow = new DetailsWindow();
            detailsWindow.Show();
            Close();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void lvRecipes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnDetails.IsEnabled = true; 
            btnDelete.IsEnabled = true;

        }
    }
}
