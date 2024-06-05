using ControlzEx.Standard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AppUsers
{
    public partial class AuthWindows : Window
    {
        public AuthWindows()
        {
            InitializeComponent();
        }
        //кнопка для авторизации пользователя
        private void Button_Auth_Click(object sender, RoutedEventArgs e)
        {
            string login = TextBoxLogin.Text.Trim();
            // Проверка логина
            if (login.Length < 5)
            {
                TextBoxLogin.ToolTip = "Логин должен быть не меньше 5 символов!";
                TextBoxLogin.Background = Brushes.DarkRed;
                return;
            }
            else
            {
                TextBoxLogin.ToolTip = " ";
                TextBoxLogin.Background = Brushes.Transparent;
                User authUser = null;
                using (ApplicationContext db = new ApplicationContext())
                {
                    authUser = db.Users.Where(b => b.Name == login).FirstOrDefault();
                }
                if(authUser != null)
                {
                    MessageBox.Show($"Добро пожаловать {login} !");
                    PersonWindow windowPerson = new PersonWindow(authUser);
                    windowPerson.Show();
                    this.Close();
                }
                else MessageBox.Show("Авторизация не успешна!");
            }
        }
        // Кнопка для перехода на страницу регестрации
        private void Reg_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow windowReg = new MainWindow();
            windowReg.Show();
            this.Close();
        }
    }
}
