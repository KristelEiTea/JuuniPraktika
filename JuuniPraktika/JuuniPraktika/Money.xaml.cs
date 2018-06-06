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
        public List<Planner> items = new List<Planner>();
        public MainWindow()
        {
            int dateall = 0;
            InitializeComponent();
            //List<Planner> items = new List<Planner>();
            for (int i = 0; i < 31; i++)
            {
                dateall += 1;
                items.Add(new Planner() { Date = dateall });
            }
            //for (int i = 0; i < 31; i++)
            //{
            //    items[numbbs].Limit = OneMonth;
            //    numbbs += 1;
            //}

            PlannerListBox.ItemsSource = items;
        }

        public class Planner
        {
            public int Date { get; set; }
            public double Limit { get; set; }
            public double Used { get; set; }
            public double Leftover { get; set; }
        }

        private void Ref_Click(object sender, RoutedEventArgs e)
        {
            PlannerListBox.Items.Refresh();
        }

        private void PlannerListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void OneMonthOK_Click(object sender, RoutedEventArgs e)
        {
            double OneMonth = double.Parse(OneMonthMoney.Text) / 31;
            textBox.Text = OneMonth.ToString();
            int numbbs = 0;
            for (int i = 0; i < 31; i++)
            {
                items[numbbs].Limit = OneMonth;
                numbbs += 1;
            }
        }

        private void MoneyUsedOK_Click(object sender, RoutedEventArgs e)
        {
            //string NimiTootel = (TootedListBox.SelectedItem as LisaSeeToode).Nimi
            double MoneyUsedThatDay = double.Parse(MoneyUsedThisDay.Text);
            //MoneyUsedThatDay = (PlannerListBox.SelectedItem as Planner).Used;
            PlannerListBox.Items.Refresh();
            (PlannerListBox.SelectedItem as Planner).Used = MoneyUsedThatDay;
            double OneMonth = double.Parse(OneMonthMoney.Text) / 31;
            (PlannerListBox.SelectedItem as Planner).Leftover = OneMonth - MoneyUsedThatDay;

        }

        private void SelectDayListOpen_Click(object sender, RoutedEventArgs e)
        {
            ShopList shoplist = new ShopList();
            shoplist.Show();
            shoplist.ShopListDay.Text = 0.ToString(); ;
        }
    }
}
