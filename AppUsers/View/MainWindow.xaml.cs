using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace AppUsers
{
    public partial class MainWindow : Window
    {
        ApplicationContext db;
        List<string> logins;
        public MainWindow()
        {
            InitializeComponent();
            db = new ApplicationContext();
            List<User> users = db.Users.ToList();
            logins = new List<string>() { };
            foreach (User user in users)
            {
                logins.Add(user.Name);
            }
        }
        // Кнопка для регистрации пользователей
        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string login = TextBoxLogin.Text.Trim();
            string password1 = TextBoxPassword1.Text.Trim();
            string password2 = TextBoxPassword2.Text.Trim();
            //Проверка логина и пароля
            if (login.Length < 5)
            {
                TextBoxLogin.ToolTip = "Логин должен быть не меньше 5 символов!";
                TextBoxLogin.Background = Brushes.DarkRed;
                return;
            }
            else if (password1.Length < 5)
            {
                TextBoxPassword1.ToolTip = "Пароль должен быть не меньше 5 символов!";
                TextBoxPassword1.Background = Brushes.DarkRed;
                return;
            }
            else if (password1 != password2)
            {
                MessageBox.Show("Пароли не совпадают!");
            }
            else
            {
                TextBoxLogin.ToolTip = " ";
                TextBoxLogin.Background = Brushes.Transparent;
                TextBoxPassword1.ToolTip = " ";
                TextBoxPassword1.Background = Brushes.Transparent;

                MessageBox.Show("Вы успешно зарегистрировались!");

                User user = new User(login, password1);
                db.Users.Add(user);
                db.SaveChanges();
            }
        }
        // Кнопка для перехода на страницу авторизации
        private void Auth_Button_Click(object sender, RoutedEventArgs e)
        {
            AuthWindows windowAuth = new AuthWindows();
            windowAuth.Show();
            this.Close();
        }
    }
}
