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
    /// Interaction logic for ThisMonth1.xaml
    /// </summary>
    public partial class ThisMonth1 : Window
    {
        /// <summary>
        /// Represents money used on 5 categories this month.
        /// </summary>
        public ThisMonth1()
        {
            InitializeComponent();
            UsedOnFoodTextbox.Text = MoneyUsed.UsedFood.ToString() + " €";
            UsedOnClothesTextbox.Text = MoneyUsed.UsedClothes.ToString() + " €";
            UsedOnTransportTextbox.Text = MoneyUsed.UsedClothes.ToString() + " €";
            UsedOnOtherTextbox.Text = MoneyUsed.UsedOther.ToString() + " €";

            UsedOverallTextbox.Text = (MoneyUsed.UsedBiggies + MoneyUsed.UsedFood + MoneyUsed.UsedClothes + MoneyUsed.UsedTransport + MoneyUsed.UsedOther).ToString();
            //biggies.Add(new Biggies() { BiggieName = });
        }
        //public List<Biggies> biggies = new List<Biggies>();
        //public class Biggies
        //{
        //    public string BiggieName { get; set; }
        //    public double BiggieCost { get; set; }
        //}
        
        
    }
}


