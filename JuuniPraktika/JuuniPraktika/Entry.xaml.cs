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
using Vacation;
using Hangman;

namespace JuuniPraktika
{
    /// <summary>
    /// Interaction logic for Entry.xaml
    /// </summary>
    public partial class Entry : Window
    {
        public Entry()
        {
            InitializeComponent();
        }

        private void EntryMoney_Click(object sender, RoutedEventArgs e)
        {
            Money moneyplanner = new Money();
            moneyplanner.Show();
        }

        private void EntryHangman_Click(object sender, RoutedEventArgs e)
        {
            Poomine aken2 = new Poomine();
            aken2.Show();
        }

        private void EntryVacation_Click(object sender, RoutedEventArgs e)
        {
            Puhkused aken = new Puhkused();
            aken.Show();
            
        }

        private void EntryEvent_Click(object sender, RoutedEventArgs e)
        {
            EventPlanner eventplanner = new EventPlanner();
            eventplanner.Show();
        }
    }
}
