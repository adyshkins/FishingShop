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
using System.Windows.Navigation;
using System.Windows.Shapes;
using static FishingShop.AppData;
namespace FishingShop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var userResult = context.User.Where(u => u.Login == txtLogin.Text && u.Password == txtPassword.Password).FirstOrDefault();
            if (userResult != null)
            {
                ProductWindow productWindow = new ProductWindow(userResult.IdUser);
                this.Hide();
                productWindow.ShowDialog();
                
            }
            else
            {
                tbError.Visibility = Visibility.Visible;
            }

        }
    }
}
