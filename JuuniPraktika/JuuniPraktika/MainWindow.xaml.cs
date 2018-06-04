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

namespace JuuniPraktika
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            int dateall = 0;
            InitializeComponent();
            List<Planner> items = new List<Planner>();
            //items.Add(new Planner() { Date = 1, Limit = 10, Used = 7, Leftover = 3 });
            for (int i = 0; i < 31; i++)
            {
                dateall += 1;
                items.Add(new Planner() { Date = dateall });
            }
            //items[1-31].Limit = MonthMoney.wholemonth;
            int numbbs = 0;
            //for (int i = 0; i < 30; i++)
            //{
            //    numbbs += 1;
            //    items[numbbs].Limit = MonthMoney.wholemonth;
            //}
            items[7].Limit = MonthMoney.wholemonth;
            PlannerListBox.ItemsSource = items;
        }

        public class Planner
        {
            public int Date { get; set; }
            public double Limit { get; set; }
            public double Used { get; set; }
            public double Leftover { get; set; }
        }

        private void MonthlyMoney_Click(object sender, RoutedEventArgs e)
        {
            MonthMoney monthmoney = new MonthMoney();
            monthmoney.Show();
        }

        private void Ref_Click(object sender, RoutedEventArgs e)
        {
            PlannerListBox.Items.Refresh();
        }
    }
}
