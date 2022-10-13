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
            defaultText = "Vem är bäst?";
            Fråga.Text = defaultText;
        }


        private void click_Next(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button btn)
            {
                Fråga.Text = "";
                Fråga.Text = defaultText;
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
