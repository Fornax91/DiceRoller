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
            string diceOutputString = "";
            int result = 0;
            int diceValue = GetDiceValue();
            int nDice = (int)NumberOfDice.Value;
            Console.Write(NumberOfDice.Value);
            int diceTotal = 0;
            int bonus = (int)DiceBonus.Value;

            if (nDice == 1)
            {
                result = r.Next(1, diceValue);
                diceOutputString += "The number rolled was: " + result + "\n";
            }
            else
            {
                result = r.Next(1, diceValue);
                diceTotal += result;
                diceOutputString += "The numbers rolled were: " + result + ", ";

                for (int a = 1; a < nDice; a++)
                {
                    result = r.Next(1, diceValue);
                    diceTotal += result;
                    diceOutputString += result + ", ";
                }
                diceOutputString += "\n" + "The sum of all the dice rolls was: " + diceTotal;
            }

            if (bonus == 0)
            {
                diceOutputString += "\n";
                DiceValue.Text = diceOutputString + DiceValue.Text;
            }
            else
            {
                diceTotal += bonus;
                diceOutputString += " with a modifyer of " + bonus + " the new total is: " + diceTotal + "\n\n";
                DiceValue.Text = diceOutputString + DiceValue.Text;
            }
        }

        private int GetDiceValue()
        {
            int diceValue = 0;
            if ((bool)D4.IsChecked) { diceValue = 4; }
            else if ((bool)D6.IsChecked) { diceValue = 6; }
            else if ((bool)D8.IsChecked) { diceValue = 8; }
            else if ((bool)D10.IsChecked) { diceValue = 10; }
            else if ((bool)D12.IsChecked) { diceValue = 12; }
            else if ((bool)D20.IsChecked) { diceValue = 20; }
            else if ((bool)D100.IsChecked) { diceValue = 100; }
            return diceValue;
        }

        private int RollDie()
        {

            return 0;
        }
        
    }
}
