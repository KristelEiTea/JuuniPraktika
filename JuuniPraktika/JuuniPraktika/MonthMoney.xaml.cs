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

namespace JuuniPraktika
{
    /// <summary>
    /// Interaction logic for MonthMoney.xaml
    /// </summary>
    public partial class MonthMoney : Window
    {
        public static int wholemonth;
        public MonthMoney()
        {
            InitializeComponent();
        }

        private void MonthlyMoneyInsert_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        public void CompMonthlyMoney_Click(object sender, RoutedEventArgs e)
        {
            int monthly = int.Parse(MonthlyMoneyInsert.Text);
            double wholemonth = monthly / 31;
            this.Close();
        }
    }
}
