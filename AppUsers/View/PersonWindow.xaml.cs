using ControlzEx.Standard;
using MahApps.Metro.Controls;
using System;
using System.Collections;
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
using System.Xml.Linq;

namespace AppUsers
{
    public partial class PersonWindow : Window
    {
        private ApplicationContext db;
        public static User _user_now;
        public PersonWindow(User user_now)
        {
            InitializeComponent();
            DataContext = this;
            db = new ApplicationContext();

            CurrentLoginTextBox.Text += user_now.Name;
            _user_now = user_now;
        }
        //Кнопка назад для перехода на главную страницу
        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            AuthWindows windowAuth = new AuthWindows();
            windowAuth.Show();
            this.Close();
        }
        //кнопки для перехода на другие страницы
        private void WorkflowBtn(object sender, RoutedEventArgs e)
        {
            switch (((Button)sender).Content)
            {
                case "Роли":
                    RoleView windowAuth = new RoleView(_user_now);
                    windowAuth.Show();
                    this.Close();
                    break;
                case "Актеры":
                    ActorsView windowAuth1 = new ActorsView(_user_now);
                    windowAuth1.Show();
                    this.Close();
                    break;
                case "Пьесы":
                    PerfomanceView windowAuth2 = new PerfomanceView(_user_now);
                    windowAuth2.Show();
                    this.Close();
                    break;
            }
        }
    }
}
