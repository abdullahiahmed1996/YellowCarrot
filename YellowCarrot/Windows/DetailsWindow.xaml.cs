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
    /// Interaction logic for DetailsWindow.xaml
    /// </summary>
    public partial class DetailsWindow : Window
    {

        private int _recipeId;
        public DetailsWindow(int selectedRecipe)
        {
            InitializeComponent();

            this._recipeId = selectedRecipe;


            using (AppDbContext context = new())
            {
               
                UnitOfWork uow = new(context);
                TagsRepository tagsRepository = new(context);
                Recipe? recipe = uow.RecipeRepo.GetRecipeId(selectedRecipe);
                txtName.Text = recipe.Name;
                List <Ingredient> ingredients = uow.IngredientRepo.GetIngredientsList();
                List<Tags> _tag = tagsRepository.GetTags();
                foreach (Ingredient ingre in recipe.Ingridients)
                {
                    ListViewItem item = new();
                    item.Content = $"{ingre.Quantity} / {ingre.Name}";
                    item.Tag = ingre;

                    lvIngridients.Items.Add(item);
                }
                foreach(Tags tags in recipe.Tags)
                {
                    ListViewItem sItem = new ();
                    sItem.Content = $"{tags.Name}";
                    sItem.Tag = tags;
                    txtTags.Items.Add(sItem); 
                }

            }
        }

        // selection changed when something is selected in the listview
        private void lvIngridients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnDeleteIngredient.IsEnabled = true;
        }

        // delete a selcted ingredient button
        private void btnDeleteIngredient_Click(object sender, RoutedEventArgs e)
        {
            //btnDeleteIngredient.IsEnabled = true;

            ListViewItem selectedItem = lvIngridients.SelectedItem as ListViewItem;
            Ingredient ingredient = selectedItem.Tag as Ingredient;

            using (AppDbContext context = new())
            {
                UnitOfWork uow = new(context);
                Ingredient ingredientToDelete = uow.IngredientRepo.GetIngredient(ingredient.IngridientId);
                uow.IngredientRepo.DeleteIngredient(ingredientToDelete);

                uow.SaveChanges();
            }
            lvIngridients.Items.Remove(lvIngridients.SelectedItem);

            MessageBox.Show("Ingredient has been deleted!");
            UpdateUi();

        }

        // unlock button that enables textblocks, button and listview
        private void btnUnlock_Click(object sender, RoutedEventArgs e)
        {
            btnSave.Visibility = Visibility.Visible;
            txtName.IsEnabled = true;
            lvIngridients.IsEnabled = true;
            txtTags.IsEnabled = true;
            txtnewRecipeName.IsEnabled = true;
            txtNewIngredient.IsEnabled = true;
            btnAddNewIngredient.IsEnabled = true;
            btnNewRecipeName.IsEnabled =true;
        }

        // exit button
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            RecipeWindow recipeWindow = new();
            recipeWindow.Show();
            Close();

        }
        // save button that save the updates recipe 
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
   
            using (AppDbContext context = new())
            {
                UnitOfWork uow = new(context);

                Recipe recipe = uow.RecipeRepo.GetRecipeId(_recipeId);

                recipe.Name = txtName.Text;
                recipe.Ingridients = GetListViewIngredients();
                uow.RecipeRepo.UpdateRecipe(recipe);
                uow.SaveChanges();
                
                UpdateUi();
            }

            MessageBox.Show("New recipe details has been added!");
        }
        // adds new ingredients
        private void btnAddNewIngredient_Click(object sender, RoutedEventArgs e)
        {
            Ingredient newIngredient = new()
            {
                Name = txtNewIngredient.Text,
                Quantity = txtNewIngredient.Text

            };

            ListViewItem nItem = new();
            nItem.Content = $"{newIngredient.Name} / {newIngredient.Quantity}";
            nItem.Tag = newIngredient;
            lvIngridients.Items.Add(nItem);
            txtNewIngredient.Clear();
            
        }
        // chnage the recipe name
        private void btnNewRecipeName_Click(object sender, RoutedEventArgs e)
        {
            Recipe newRecipeName = new()
            {
                Name = txtNewIngredient.Text
            };

            string newName = txtnewRecipeName.Text;
            txtName.Text = newName;

            UpdateUi();

        }


        private void UpdateUi()
        {
            txtnewRecipeName.Clear();
            txtNewIngredient.Clear();
        }

        private List<Ingredient> IngredientList()
        {
            List<Ingredient> list = new();

            foreach (ListViewItem item in lvIngridients.Items)
            {
                Ingredient ingredient = item.Tag as Ingredient;
                list.Add(ingredient);
            }
            return list;
        }

        private List<Ingredient> GetListViewIngredients()
        {
            List<Ingredient> result = new();

            foreach (ListViewItem lvItem in lvIngridients.Items)
            {
                result.Add((Ingredient)lvItem.Tag);
            }

            return result;
        }


    }
}
