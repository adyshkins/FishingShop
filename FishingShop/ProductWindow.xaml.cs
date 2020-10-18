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

namespace FishingShop
{
    /// <summary>
    /// Логика взаимодействия для ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        public ProductWindow()
        {
            InitializeComponent();
        }
        public ProductWindow(int idUser)
        {
            InitializeComponent();
        }

        private void btn1_Selected(object sender, RoutedEventArgs e)
        {
            framePage.Navigate(new ProductCategoryPage() );
        }

        private void btn2_Selected(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("1");
        }

        private void btn3_Selected(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("2");
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            MainGrid.Opacity = 0.1;
            authorizationWindow.ShowDialog();
            
            
        }
    }
}
