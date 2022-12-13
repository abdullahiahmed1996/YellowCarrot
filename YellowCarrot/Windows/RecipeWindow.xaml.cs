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

            //using (AppDbContext context = new())
            //{
            //    List<Recipe> recipes = context.Recipes.ToList();

            //    ListViewItem item = new();
            //    item.Content = recipes;
            //    item.Tag = recipes;

            //    lvRecipes.Items.Add(item);
            //}
        }

        private void btnAddRecipe_Click(object sender, RoutedEventArgs e)
        {
            AddRecipeWindow addRecipeWindow = new ();

            addRecipeWindow.Show();
        }

        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {
            DetailsWindow detailsWindow = new DetailsWindow();
            detailsWindow.Show();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
