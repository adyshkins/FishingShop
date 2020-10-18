using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
    /// Логика взаимодействия для RememberLoginPasswordWindow.xaml
    /// </summary>
    public partial class RememberLoginPasswordWindow : Window
    {
        public RememberLoginPasswordWindow()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Отправка сообщения если забыли пароль
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMessage_Click(object sender, RoutedEventArgs e)
        {
            //MailAddress from = new MailAddress("Email отправителя", "Имя отправителя");

            //MailAddress to = new MailAddress("Email получателя");

            //MailMessage msg = new MailMessage(from, to);

            //msg.Subject = "Заголовок письма";

            //msg.Body = txtMessage.Text; // текст письма

            //SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587); // smtp и порт. Смотреть в инете
            //smtp.Credentials = new NetworkCredential("Логин для почты", "Пароль для почты");
            //smtp.EnableSsl = true;
            //smtp.Send(msg);

            MessageBox.Show("Ваше сообщение отправлено. Ждите дальнейших инструкций");
            this.Close();


           
        }
    }
}
