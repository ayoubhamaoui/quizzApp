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

namespace Quizz
{
    /// <summary>
    /// Interaction logic for quizzWindow.xaml
    /// </summary>
    public partial class quizzWindow : Window
    {
        private LinqQuizzDataContext MyDB = new LinqQuizzDataContext();
        public quizzWindow()
        {
            InitializeComponent();
            string matiere = "POO CSharp";
            txtMatiere.Text = "Matière: "+matiere;
            int i = 0;
            var question = (from qst in MyDB.questions
                               where qst.id_m == matiere.ToString()
                               select qst).First();
            txtQuestion.Text = question.question1+"?";
        }
        private void btnSuivant(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("button suivant");
        }

        private void btnPrecedent(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("button Precedent");
        }
    }
}
