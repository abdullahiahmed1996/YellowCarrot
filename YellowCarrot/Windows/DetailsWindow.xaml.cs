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
    /// Interaction logic for DetailsWindow.xaml
    /// </summary>
    public partial class DetailsWindow : Window
    {
        public DetailsWindow()
        {
            InitializeComponent();
            
            using (AppDbContext context = new())
            {

                List<Ingredient> ingredients = context.Ingredients.ToList();
                foreach (Ingredient ingre in ingredients)
                {
                    ListViewItem item = new();
                    item.Content = $"{ingre.Name}";
                    item.Tag = ingre;

                    lvIngridients.Items.Add(item);
                }
            }

        }

        private void lvIngridients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnDeleteIngredient.IsEnabled = true;
        }

        private void btnDeleteIngredient_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnUnlock_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
