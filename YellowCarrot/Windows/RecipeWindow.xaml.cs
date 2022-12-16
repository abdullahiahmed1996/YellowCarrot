using Microsoft.EntityFrameworkCore;
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
    /// Interaction logic for RecipeWindow.xaml
    /// </summary>
    public partial class RecipeWindow : Window
    {
        public RecipeWindow()
        {
            InitializeComponent();


            using (AppDbContext context = new())
            {
                List<Recipe> recipes = new RecipeRepository(context).AllRecipes();

                recipes.ForEach(r => lvRecipes.Items.Add(new ListViewItem()
                {
                    Content = r.Name,
                    Tag = r
                }));
            }
        }
        // button to open the add recipe window
        private void btnAddRecipe_Click(object sender, RoutedEventArgs e)
        {
            AddRecipeWindow addRecipeWindow = new ();

            addRecipeWindow.Show();

            Close();
        }
        //button to open the details window
        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {
            using (AppDbContext context = new())
            {
                Recipe? selectedRecipe = (Recipe)((ListViewItem)lvRecipes.SelectedItem).Tag;

                DetailsWindow detailsWindow = new DetailsWindow(selectedRecipe.RecipeId);
                detailsWindow.Show();
                Close();
            }

        }
        // button that allows you to delete a recipe
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

            if(MessageBox.Show("Are you sure you want to delete this recipe?","Delete",MessageBoxButton.YesNo,MessageBoxImage.Warning)==MessageBoxResult.No)
            {

            }
            else
            {
                btnDelete.IsEnabled = true;
                ListViewItem selectedItem = lvRecipes.SelectedItem as ListViewItem;
                Recipe recipe = selectedItem.Tag as Recipe;

                using(AppDbContext context = new())
                {
                    UnitOfWork uow = new(context);
                    uow.RecipeRepo.DeleteRecipe(recipe);
                    uow.SaveChanges();
                }

                UpDateUi();
            }
        }

        // update UI and clear the listview and populate with the saved recipes
        private void UpDateUi()
        {
            lvRecipes.Items.Clear();

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

        private void lvRecipes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnDetails.IsEnabled = true;
            btnDelete.IsEnabled = true;

        }
    }
}
