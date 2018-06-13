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
using System.IO;
using Newtonsoft.Json;

namespace JuuniPraktika
{
    /// <summary>
    /// Interaction logic for Money.xaml
    /// </summary>
    public partial class Money : Window
    {
        //Variables to make the textbox clear if clicked on.
        private string MonthMoneyEX = "ex. 500";
        private string BigName = "ex. Rent";
        private string BigCost = "ex. 350";
        public double MonthlyMoney;
        //Creates the listbox list.
        public List<Planner> items = new List<Planner>();
        public Money()
        {
            InitializeComponent();
            //Adds 31 lines of the list, every line inceasing the
            //date number by one.
            int dateall = 0;
            for (int i = 0; i < 31; i++)
            {
                dateall += 1;
                items.Add(new Planner() { Date = dateall });
            }
            //Reads in saved list.
            var tmpitems = ReadDataFromFile();
            items = tmpitems.ToList();
            PlannerListBox.ItemsSource = items;
        }


        private void OneMonthMoney_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BigOutGoesCost_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BigOutGoesName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        /// <summary>
        /// Calculates off the inserted big outgoes of the month and divides
        /// leftover money for the whole month.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BIgOutGoesOK_Click(object sender, RoutedEventArgs e)
        {
            double Remaining = double.Parse(OneMonthMoney.Text) - double.Parse(BigOutGoesCost.Text);
            textBox.Text = Remaining.ToString();
            double OneMonth = Remaining / 31;
            int numbbs = 0;
            for (int i = 0; i < 31; i++)
            {
                items[numbbs].Limit = OneMonth;
                numbbs += 1;
            }
            PlannerListBox.Items.Refresh();
            MoneyUsed.UsedBiggies += int.Parse(BigOutGoesCost.Text);
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void MoneyUsedThisDay_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        /// <summary>
        /// User selects a day and inserts how much they have used that month.
        /// It will calculate and give the leftover column a value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoneyUsedOK_Click(object sender, RoutedEventArgs e)
        {
            double MoneyUsedThatDay = double.Parse(MoneyUsedThisDay.Text);
            PlannerListBox.Items.Refresh();
            (PlannerListBox.SelectedItem as Planner).Used = MoneyUsedThatDay;
            double Remaining = double.Parse(OneMonthMoney.Text) - double.Parse(BigOutGoesCost.Text);
            double OneMonth = Remaining / 31;
            (PlannerListBox.SelectedItem as Planner).Leftover = OneMonth - MoneyUsedThatDay;
        }
        /// <summary>
        /// Opens the shoplist window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenList_Click(object sender, RoutedEventArgs e)
        {
            ShopList shoplist = new ShopList();
            shoplist.Show();
            shoplist.ShopListDay.Text = 0.ToString();
        }
        /// <summary>
        /// Refreshes the listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ref_Click(object sender, RoutedEventArgs e)
        {
            PlannerListBox.Items.Refresh();
        }
        /// <summary>
        /// Saves everything and closes the window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void save_Click_1(object sender, RoutedEventArgs e)
        {
            SaveDataToFile();
            this.Close();
        }
        /// <summary>
        /// Saves listbox data to a file.
        /// </summary>
        private void SaveDataToFile()
        {
            var json = JsonConvert.SerializeObject(PlannerListBox.Items);
            File.WriteAllText("PlannerListBoxData.txt", json);
        }
        /// <summary>
        /// Reads the saved data from a file.
        /// </summary>
        /// <returns></returns>
        private IEnumerable<Planner> ReadDataFromFile()
        {
            var json = File.ReadAllText("PlannerListBoxData.txt");
            var data = JsonConvert.DeserializeObject<IEnumerable<Planner>>(json);
            return data;
        }
        /// <summary>
        /// Items for the listbox list.
        /// </summary>
        public class Planner
        {
            public int Date { get; set; }
            public double Limit { get; set; }
            public double Used { get; set; }
            public double Leftover { get; set; }
        }
        /// <summary>
        /// Make textbox empty when clicked on it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OneMonthMoney_Got(object sender, RoutedEventArgs e)
        {
            if (OneMonthMoney.Text == MonthMoneyEX)
                OneMonthMoney.Text = "";
        }
        /// <summary>
        /// Make textbox regain it's text when clicked elsewhere.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OneMonthMoney_Lost(object sender, RoutedEventArgs e)
        {
            if (OneMonthMoney.Text == "")
                OneMonthMoney.Text = MonthMoneyEX;
        }
        /// <summary>
        /// Make textbox empty when clicked on it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BigOutGoesName_GotFocus(object sender, RoutedEventArgs e)
        {
            if (BigOutGoesName.Text == BigName)
                BigOutGoesName.Text = "";
        }
        /// <summary>
        /// Make textbox regain it's text when clicked elsewhere.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BigOutGoesName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (BigOutGoesName.Text == "")
                BigOutGoesName.Text = BigName;
        }
        /// <summary>
        /// Make textbox empty when clicked on it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BigOutGoesCost_GotFocus(object sender, RoutedEventArgs e)
        {
            if (BigOutGoesName.Text == BigCost)
                BigOutGoesName.Text = "";
        }
        /// <summary>
        /// Make textbox regain it's text when clicked elsewhere.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BigOutGoesCost_LostFocus(object sender, RoutedEventArgs e)
        {
            if (BigOutGoesName.Text == "")
                BigOutGoesName.Text = BigCost;
        }
        /// <summary>
        /// Opens a window where are 5 types of spendings shown for the month.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThisMonth_Click(object sender, RoutedEventArgs e)
        {
            ThisMonth1 thismonth = new ThisMonth1();
            thismonth.Show();
        }
    }
}
