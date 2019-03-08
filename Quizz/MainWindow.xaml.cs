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
using System.Data.Sql;

namespace Quizz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LinqQuizzDataContext MyDB = new LinqQuizzDataContext();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            var user = from us in MyDB.users
                       where us.id_u == txtLogin.Text && us.mdp == txtPassword.Password
                       select us;


            if (user.Any())
            {
                quizzWindow dashboard = new quizzWindow();
                dashboard.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("login ou mot de passe est incorrect");
            }
        }
    }
}
