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

namespace ListBox_WPF_MiniProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Match> matches = new List<Match>() 
            {
                new Match() { 
                    Team1 = "Bayern Munich", 
                    Team2 = "Real Madrid", 
                    Score1 = 3, Score2 = 2, 
                    Completion = 85 
                },
                new Match() {
                    Team1 = "PSG",
                    Team2 = "Barca",
                    Score1 = 3, Score2 = 22,
                    Completion = 23
                },
                new Match() {
                    Team1 = "BVB Dortmund",
                    Team2 = "AS Roma",
                    Score1 = 1, Score2 = 2,
                    Completion = 66
                },
                new Match() {
                    Team1 = "Man United",
                    Team2 = "La Galaxy",
                    Score1 = 100, Score2 = 2,
                    Completion = 5
                }
            };
            lbMatches.ItemsSource = matches;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(lbMatches.SelectedItem != null)
            {
                MessageBox.Show("Selected Match: "
                    + (lbMatches.SelectedItem as Match).Team1 + " "
                    + (lbMatches.SelectedItem as Match).Score1 + " "
                    + (lbMatches.SelectedItem as Match).Score2 + " "
                    + (lbMatches.SelectedItem as Match).Team2);
            }
        }
    }

    public class Match
    {
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public int Completion { get; set; }
    }
}
