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
using System.Net.Sockets;

namespace Roller
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>dice
    public partial class MainWindow : Window
    {
        Random r;

        public MainWindow()
        {
            r = new Random();
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int result = 0;
            int diceValue = 0;
          

            if ((bool)D4.IsChecked) { diceValue = 4; }
            else if ((bool)D6.IsChecked) { diceValue = 6; }
            else if ((bool)D8.IsChecked) { diceValue = 8; }
            else if ((bool)D10.IsChecked) { diceValue = 10; }
            else if ((bool)D12.IsChecked) { diceValue = 12; }
            else if ((bool)D20.IsChecked) { diceValue = 20; }

            result = r.Next(1, diceValue);

            DiceValue.Text = "The number rolled was: " + result + "\n";


        }
    }
}
