using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using static MaterialDesignThemes.Wpf.Theme.ToolBar;

namespace AppUsers
{
    public partial class ActorsView : Window
    {
        ApplicationContext db;
        User _user_now;
        public ActorsView(User user_now)
        {
            InitializeComponent();
            DataContext = this;
            db = new ApplicationContext();
            _user_now = user_now;
            DGridActors.ItemsSource = db.Actors.ToList();
        }
        //Кнопка назад для выхода на главную страницу
        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            PersonWindow windowAuth = new PersonWindow(_user_now);
            windowAuth.Show();
            this.Close();
        }
        //Кнопка для добавления новых актёров
        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddTask windowAuth = new AddTask("Actor");
            windowAuth.Show();
            this.Close();
        }
    }
}
