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
using System.Xml.Linq;

namespace AppUsers
{
    /// <summary>
    /// Логика взаимодействия для AddTask.xaml
    /// </summary>
    public partial class AddTask : Window
    {
        private string _table_now;
        public AddTask(string table_now)
        {
            InitializeComponent();
            _table_now = table_now;

            var db = new ApplicationContext();

            switch (_table_now)
            {
                case "Role":
                    show_cores();
                    break;
                case "Performance":
                    show_places();
                    break;
                case "Actor":
                    show_cores_places();
                    break;
            }
        }



        private void show_cores()
        {
            one.Text = "Код роли";
            two.Text = "Название роли";
            three.Text = "Пьеса";
        }

        private void show_places()
        {
            one.Text = "Код роли";
            two.Text = "Табельный номер";
            three.Text = "Дата назначения";
            forr.Text = "Дата снятия";
        }

        private void show_cores_places()
        {
            one.Text = "ФИО";
            two.Text = "ПОЛ";
            three.Text = "Звание";
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            var db = new ApplicationContext();

            MessageBox.Show(_table_now);
            switch (_table_now)
            {
                case "Role":
                    Role user = new Role(two_input.Text, Convert.ToInt16(one_input.Text), three_input.Text);
                    db.Roles.Add(user);
                    db.SaveChanges();

                    PersonWindow windowAuth = new PersonWindow(PersonWindow._user_now);
                    windowAuth.Show();
                    this.Close();
                    break;
                case "Actor":
                    Actor user1 = new Actor(one_input.Text, two_input.Text, three_input.Text);
                    db.Actors.Add(user1);
                    db.SaveChanges();

                    PersonWindow windowAuth2 = new PersonWindow(PersonWindow._user_now);
                    windowAuth2.Show();
                    this.Close();
                    break;
                case "Performance":
                    // string finish, string start, int roleid, int tableid, int number
                    Performance user2 = new Performance(for_input.Text, three_input.Text, Convert.ToInt16(one_input.Text), Convert.ToInt16(two_input.Text), 1);
                    db.Performances.Add(user2);
                    db.SaveChanges();

                    PersonWindow windowAuth3 = new PersonWindow(PersonWindow._user_now);
                    windowAuth3.Show();
                    this.Close();
                    break;
            }

        }
    }
}
