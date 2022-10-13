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

namespace TextEditor
{
    /// <summary>
    /// Interaction logic for QuizView.xaml
    /// </summary>
    public partial class QuizView : UserControl
    {


        private readonly string defaultText = String.Empty;
        public QuizView()
        {
            InitializeComponent();
            CreateQues();
            defaultText = "Vem är bäst?";
            Fråga.Text = defaultText;
            
        }


        public List<string> QuestionList = new List<string>();

        
        public void CreateQues()
        {

            QuestionList.Add("1. In 1768, Captain James Cook set out to explore which ocean?\n" +
                             "A. Pacific Ocean\n" +
                             "B. Atlantic Ocean\n" +
                             "C. Indian Ocean\n" +
                             "D. Arctic Ocean");
            QuestionList.Add("2. What is actually electricity?\n" +
                             "A. A flow of water\n" +
                             "B. A flow of air\n" +
                             "C. A flow of electrons\n" +
                             "D. A flow of atoms");
            QuestionList.Add("3. Which of the following is not an international organisation?\n" +
                             "A. FIFA\n" +
                             "B. NATO\n" +
                             "C. ASEAN\n" +
                             "D. FB");
            QuestionList.Add("4. Which of the following disorders is the fear of being alone?\n" +
                             "A. Agoraphobia\n" +
                             "B. Aerophobia\n" +
                             "C. Acrophobia\n" +
                             "D. Arachnophobia");
            

        }




        private void click_Next(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button btn)
            {
                
                Random random = new Random();
                int nextQ=random.Next(0, QuestionList.Count);
                Fråga.Text = "";
                Fråga.Text = QuestionList[nextQ];
                
            }
        }

        private void One_OnClick(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button btn)
            {
                Fråga.Text = "Rätt";
            }
        }

        private void Two_OnClick(object sender, RoutedEventArgs e)
        {
            Fråga.Text = "Fel";
        }

        private void Three_OnClick(object sender, RoutedEventArgs e)
        {
            Fråga.Text = "Fel";
        }

        private void Four_OnClick(object sender, RoutedEventArgs e)
        {
            Fråga.Text = "Fel";
        }
    }
}
