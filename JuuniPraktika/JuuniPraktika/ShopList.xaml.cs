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
    /// Interaction logic for ShopList.xaml
    /// </summary>
    public partial class ShopList : Window
    {
        public string tyyp;
        public string varierity;
        public double varcost;
        #region Ugly lot of lists
        public List<ShopListDaily> ShopsList0 = new List<ShopListDaily>();
        public List<ShopListDaily> ShopsList1 = new List<ShopListDaily>();
        public List<ShopListDaily> ShopsList2 = new List<ShopListDaily>();
        public List<ShopListDaily> ShopsList3 = new List<ShopListDaily>();
        public List<ShopListDaily> ShopsList4 = new List<ShopListDaily>();
        public List<ShopListDaily> ShopsList5 = new List<ShopListDaily>();
        public List<ShopListDaily> ShopsList6 = new List<ShopListDaily>();
        public List<ShopListDaily> ShopsList7 = new List<ShopListDaily>();
        public List<ShopListDaily> ShopsList8 = new List<ShopListDaily>();
        public List<ShopListDaily> ShopsList9 = new List<ShopListDaily>();
        public List<ShopListDaily> ShopsList10 = new List<ShopListDaily>();
        public List<ShopListDaily> ShopsList11 = new List<ShopListDaily>();
        public List<ShopListDaily> ShopsList12 = new List<ShopListDaily>();
        public List<ShopListDaily> ShopsList13 = new List<ShopListDaily>();
        public List<ShopListDaily> ShopsList14 = new List<ShopListDaily>();
        public List<ShopListDaily> ShopsList15 = new List<ShopListDaily>();
        public List<ShopListDaily> ShopsList16 = new List<ShopListDaily>();
        public List<ShopListDaily> ShopsList17 = new List<ShopListDaily>();
        public List<ShopListDaily> ShopsList18 = new List<ShopListDaily>();
        public List<ShopListDaily> ShopsList19 = new List<ShopListDaily>();
        public List<ShopListDaily> ShopsList20 = new List<ShopListDaily>();
        public List<ShopListDaily> ShopsList21 = new List<ShopListDaily>();
        public List<ShopListDaily> ShopsList22 = new List<ShopListDaily>();
        public List<ShopListDaily> ShopsList23 = new List<ShopListDaily>();
        public List<ShopListDaily> ShopsList24 = new List<ShopListDaily>();
        public List<ShopListDaily> ShopsList25 = new List<ShopListDaily>();
        public List<ShopListDaily> ShopsList26 = new List<ShopListDaily>();
        public List<ShopListDaily> ShopsList27 = new List<ShopListDaily>();
        public List<ShopListDaily> ShopsList28 = new List<ShopListDaily>();
        public List<ShopListDaily> ShopsList29 = new List<ShopListDaily>();
        public List<ShopListDaily> ShopsList30 = new List<ShopListDaily>();
        #endregion
        public ShopList()
        {
            InitializeComponent();
            //string Day = ShopListDay.Text;
            //#region Ugly Lot of if's
            //if (Day == "1")
            //{
            //    ShopListBox.ItemsSource = ShopsList0;
            //}
            //if (Day == "2")
            //{
            //    ShopListBox.ItemsSource = ShopsList1;
            //}
            //if (Day == "3")
            //{
            //    ShopListBox.ItemsSource = ShopsList2;
            //}
            //if (Day == "4")
            //{
            //    ShopListBox.ItemsSource = ShopsList3;
            //}
            //if (Day == "5")
            //{
            //    ShopListBox.ItemsSource = ShopsList4;
            //}
            //if (Day == "6")
            //{
            //    ShopListBox.ItemsSource = ShopsList5;
            //}
            //if (Day == "7")
            //{
            //    ShopListBox.ItemsSource = ShopsList6;
            //}
            //if (Day == "8")
            //{
            //    ShopListBox.ItemsSource = ShopsList7;
            //}
            //if (Day == "9")
            //{
            //    ShopListBox.ItemsSource = ShopsList8;
            //}
            //if (Day == "10")
            //{
            //    ShopListBox.ItemsSource = ShopsList9;
            //}
            //if (Day == "11")
            //{
            //    ShopListBox.ItemsSource = ShopsList10;
            //}
            //if (Day == "12")
            //{
            //    ShopListBox.ItemsSource = ShopsList11;
            //}
            //if (Day == "13")
            //{
            //    ShopListBox.ItemsSource = ShopsList12;
            //}
            //if (Day == "14")
            //{
            //    ShopListBox.ItemsSource = ShopsList13;
            //}
            //if (Day == "15")
            //{
            //    ShopListBox.ItemsSource = ShopsList14;
            //}
            //if (Day == "16")
            //{
            //    ShopListBox.ItemsSource = ShopsList15;
            //}
            //if (Day == "17")
            //{
            //    ShopListBox.ItemsSource = ShopsList16;
            //}
            //if (Day == "18")
            //{
            //    ShopListBox.ItemsSource = ShopsList17;
            //}
            //if (Day == "19")
            //{
            //    ShopListBox.ItemsSource = ShopsList18;
            //}
            //if (Day == "20")
            //{
            //    ShopListBox.ItemsSource = ShopsList19;
            //}
            //if (Day == "21")
            //{
            //    ShopListBox.ItemsSource = ShopsList20;
            //}
            //if (Day == "22")
            //{
            //    ShopListBox.ItemsSource = ShopsList21;
            //}
            //if (Day == "23")
            //{
            //    ShopListBox.ItemsSource = ShopsList22;
            //}
            //if (Day == "24")
            //{
            //    ShopListBox.ItemsSource = ShopsList23;
            //}
            //if (Day == "25")
            //{
            //    ShopListBox.ItemsSource = ShopsList24;
            //}
            //if (Day == "26")
            //{
            //    ShopListBox.ItemsSource = ShopsList25;
            //}
            //if (Day == "27")
            //{
            //    ShopListBox.ItemsSource = ShopsList26;
            //}
            //if (Day == "28")
            //{
            //    ShopListBox.ItemsSource = ShopsList27;
            //}
            //if (Day == "29")
            //{
            //    ShopListBox.ItemsSource = ShopsList28;
            //}
            //if (Day == "30")
            //{
            //    ShopListBox.ItemsSource = ShopsList29;
            //}
            //if (Day == "31")
            //{
            //    ShopListBox.ItemsSource = ShopsList30;
            //}
            //#endregion
            //ShopListBox.Items.Refresh();
        }

        private void ShopListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public class ShopListDaily
        {
            public string ShopName { get; set; }
            public double Cost { get; set; }
            public string Type { get; set; }
        }

        //private void AddToTheShopListButton_Click(object sender, RoutedEventArgs e)
        //{
        //    if (FoodStoreNameTextbox != null && FoodStoreCostTextbox != null)
        //    {
        //        tyyp = "Food";
        //        varierity = FoodStoreNameTextbox.Text;
        //        varcost = double.Parse(FoodStoreCostTextbox.Text);
        //        UglyLotOfIfs();
        //        ShopListBox.Items.Refresh();
        //    }
        //    if (ClothesStoreNameTextbox != null && ClothesStoreCostTextbox != null)
        //    {
        //        tyyp = "Clothes";
        //        varierity = ClothesStoreNameTextbox.Text.ToString();
        //        varcost = double.Parse(ClothesStoreCostTextbox.Text);
        //        UglyLotOfIfs();
        //        ShopListBox.Items.Refresh();
        //    }
        //    if (VehicleNameTextbox != null && VehicleCostTextbox != null)
        //    {
        //        tyyp = "Vehicle";
        //        varierity = VehicleNameTextbox.Text;
        //        varcost = double.Parse(VehicleCostTextbox.Text);
        //        UglyLotOfIfs();
        //        ShopListBox.Items.Refresh();
        //    }
        //    if (OtherNameTextbox != null && OtherCostTextbox != null)
        //    {
        //        tyyp = "Other";
        //        varierity = OtherNameTextbox.Text;
        //        varcost = double.Parse(OtherCostTextbox.Text);
        //        UglyLotOfIfs();
        //        ShopListBox.Items.Refresh();
        //    }
        //    else
        //    {
        //        error eror = new error();
        //        eror.Show();
        //    }
        //}

        private void refresh1_Click(object sender, RoutedEventArgs e)
        {
            ShopListBox.Items.Refresh();
        }

        private void oktestbuttonfood_Click(object sender, RoutedEventArgs e)
        {
            if (FoodStoreNameTextbox != null && FoodStoreCostTextbox != null)
            {
                tyyp = "Food";
                varierity = FoodStoreNameTextbox.Text;
                varcost = double.Parse(FoodStoreCostTextbox.Text);
                UglyLotOfIfs();
                ShopListBox.Items.Refresh();
            }
            else
            {
                error eror = new error();
                eror.Show();
            }
        }

        private void okclothes_Click(object sender, RoutedEventArgs e)
        {
            if (ClothesStoreNameTextbox != null && ClothesStoreCostTextbox != null)
            {
                tyyp = "Clothes";
                varierity = ClothesStoreNameTextbox.Text.ToString();
                varcost = double.Parse(ClothesStoreCostTextbox.Text);
                UglyLotOfIfs();
                ShopListBox.Items.Refresh();
            }
            else
            {
                error eror = new error();
                eror.Show();
            }
        }

        private void TextboxtestOK_Click(object sender, RoutedEventArgs e)
        {
            string Day = ShopListDay.Text;
            string Today = Day;
            #region Ugly Lot of if's
            if (Day == "1")
            {
                ShopListBox.ItemsSource = ShopsList0;
            }
            if (Day == "2")
            {
                ShopListBox.ItemsSource = ShopsList1;
            }
            if (Day == "3")
            {
                ShopListBox.ItemsSource = ShopsList2;
            }
            if (Day == "4")
            {
                ShopListBox.ItemsSource = ShopsList3;
            }
            if (Day == "5")
            {
                ShopListBox.ItemsSource = ShopsList4;
            }
            if (Day == "6")
            {
                ShopListBox.ItemsSource = ShopsList5;
            }
            if (Day == "7")
            {
                ShopListBox.ItemsSource = ShopsList6;
            }
            if (Day == "8")
            {
                ShopListBox.ItemsSource = ShopsList7;
            }
            if (Day == "9")
            {
                ShopListBox.ItemsSource = ShopsList8;
            }
            if (Day == "10")
            {
                ShopListBox.ItemsSource = ShopsList9;
            }
            if (Day == "11")
            {
                ShopListBox.ItemsSource = ShopsList10;
            }
            if (Day == "12")
            {
                ShopListBox.ItemsSource = ShopsList11;
            }
            if (Day == "13")
            {
                ShopListBox.ItemsSource = ShopsList12;
            }
            if (Day == "14")
            {
                ShopListBox.ItemsSource = ShopsList13;
            }
            if (Day == "15")
            {
                ShopListBox.ItemsSource = ShopsList14;
            }
            if (Day == "16")
            {
                ShopListBox.ItemsSource = ShopsList15;
            }
            if (Day == "17")
            {
                ShopListBox.ItemsSource = ShopsList16;
            }
            if (Day == "18")
            {
                ShopListBox.ItemsSource = ShopsList17;
            }
            if (Day == "19")
            {
                ShopListBox.ItemsSource = ShopsList18;
            }
            if (Day == "20")
            {
                ShopListBox.ItemsSource = ShopsList19;
            }
            if (Day == "21")
            {
                ShopListBox.ItemsSource = ShopsList20;
            }
            if (Day == "22")
            {
                ShopListBox.ItemsSource = ShopsList21;
            }
            if (Day == "23")
            {
                ShopListBox.ItemsSource = ShopsList22;
            }
            if (Day == "24")
            {
                ShopListBox.ItemsSource = ShopsList23;
            }
            if (Day == "25")
            {
                ShopListBox.ItemsSource = ShopsList24;
            }
            if (Day == "26")
            {
                ShopListBox.ItemsSource = ShopsList25;
            }
            if (Day == "27")
            {
                ShopListBox.ItemsSource = ShopsList26;
            }
            if (Day == "28")
            {
                ShopListBox.ItemsSource = ShopsList27;
            }
            if (Day == "29")
            {
                ShopListBox.ItemsSource = ShopsList28;
            }
            if (Day == "30")
            {
                ShopListBox.ItemsSource = ShopsList29;
            }
            if (Day == "31")
            {
                ShopListBox.ItemsSource = ShopsList30;
            }
            #endregion
            ShopListBox.Items.Refresh();
        }
        public void UglyLotOfIfs()
        {
            string Day = ShopListDay.Text;
            #region Ugly Lot of if's
            if (Day == "1")
            {
                ShopsList0.Add(new ShopListDaily() { ShopName = varierity, Cost = varcost, Type = tyyp });
            }
            if (Day == "2")
            {
                ShopsList1.Add(new ShopListDaily() { ShopName = varierity, Cost = varcost, Type = tyyp });
            }
            if (Day == "3")
            {
                ShopsList2.Add(new ShopListDaily() { ShopName = varierity, Cost = varcost, Type = tyyp });
            }
            if (Day == "4")
            {
                ShopsList3.Add(new ShopListDaily() { ShopName = varierity, Cost = varcost, Type = tyyp });
            }
            if (Day == "5")
            {
                ShopsList4.Add(new ShopListDaily() { ShopName = varierity, Cost = varcost, Type = tyyp });
            }
            if (Day == "6")
            {
                ShopsList5.Add(new ShopListDaily() { ShopName = varierity, Cost = varcost, Type = tyyp });
            }
            if (Day == "7")
            {
                ShopsList6.Add(new ShopListDaily() { ShopName = varierity, Cost = varcost, Type = tyyp });
            }
            if (Day == "8")
            {
                ShopsList7.Add(new ShopListDaily() { ShopName = varierity, Cost = varcost, Type = tyyp });
            }
            if (Day == "9")
            {
                ShopsList8.Add(new ShopListDaily() { ShopName = varierity, Cost = varcost, Type = tyyp });
            }
            if (Day == "10")
            {
                ShopsList9.Add(new ShopListDaily() { ShopName = varierity, Cost = varcost, Type = tyyp });
            }
            if (Day == "11")
            {
                ShopsList10.Add(new ShopListDaily() { ShopName = varierity, Cost = varcost, Type = tyyp });
            }
            if (Day == "12")
            {
                ShopsList11.Add(new ShopListDaily() { ShopName = varierity, Cost = varcost, Type = tyyp });
            }
            if (Day == "13")
            {
                ShopsList12.Add(new ShopListDaily() { ShopName = varierity, Cost = varcost, Type = tyyp });
            }
            if (Day == "14")
            {
                ShopsList13.Add(new ShopListDaily() { ShopName = varierity, Cost = varcost, Type = tyyp });
            }
            if (Day == "15")
            {
                ShopsList14.Add(new ShopListDaily() { ShopName = varierity, Cost = varcost, Type = tyyp });
            }
            if (Day == "16")
            {
                ShopsList15.Add(new ShopListDaily() { ShopName = varierity, Cost = varcost, Type = tyyp });
            }
            if (Day == "17")
            {
                ShopsList16.Add(new ShopListDaily() { ShopName = varierity, Cost = varcost, Type = tyyp });
            }
            if (Day == "18")
            {
                ShopsList17.Add(new ShopListDaily() { ShopName = varierity, Cost = varcost, Type = tyyp });
            }
            if (Day == "19")
            {
                ShopsList18.Add(new ShopListDaily() { ShopName = varierity, Cost = varcost, Type = tyyp });
            }
            if (Day == "20")
            {
                ShopsList19.Add(new ShopListDaily() { ShopName = varierity, Cost = varcost, Type = tyyp });
            }
            if (Day == "21")
            {
                ShopsList20.Add(new ShopListDaily() { ShopName = varierity, Cost = varcost, Type = tyyp });
            }
            if (Day == "22")
            {
                ShopsList21.Add(new ShopListDaily() { ShopName = varierity, Cost = varcost, Type = tyyp });
            }
            if (Day == "23")
            {
                ShopsList22.Add(new ShopListDaily() { ShopName = varierity, Cost = varcost, Type = tyyp });
            }
            if (Day == "24")
            {
                ShopsList23.Add(new ShopListDaily() { ShopName = varierity, Cost = varcost, Type = tyyp });
            }
            if (Day == "25")
            {
                ShopsList24.Add(new ShopListDaily() { ShopName = varierity, Cost = varcost, Type = tyyp });
            }
            if (Day == "26")
            {
                ShopsList25.Add(new ShopListDaily() { ShopName = varierity, Cost = varcost, Type = tyyp });
            }
            if (Day == "27")
            {
                ShopsList26.Add(new ShopListDaily() { ShopName = varierity, Cost = varcost, Type = tyyp });
            }
            if (Day == "28")
            {
                ShopsList27.Add(new ShopListDaily() { ShopName = varierity, Cost = varcost, Type = tyyp });
            }
            if (Day == "29")
            {
                ShopsList28.Add(new ShopListDaily() { ShopName = varierity, Cost = varcost, Type = tyyp });
            }
            if (Day == "30")
            {
                ShopsList29.Add(new ShopListDaily() { ShopName = varierity, Cost = varcost, Type = tyyp });
            }
            if (Day == "31")
            {
                ShopsList30.Add(new ShopListDaily() { ShopName = varierity, Cost = varcost, Type = tyyp });
            }
            #endregion
            ShopListBox.Items.Refresh();
        }

        private void OKvehicle_Click(object sender, RoutedEventArgs e)
        {
            if (VehicleNameTextbox != null && VehicleCostTextbox != null)
            {
                tyyp = "Vehicle";
                varierity = VehicleNameTextbox.Text.ToString();
                varcost = double.Parse(VehicleCostTextbox.Text);
                UglyLotOfIfs();
                ShopListBox.Items.Refresh();
            }
            else
            {
                error eror = new error();
                eror.Show();
            }
        }

        private void OtherOK_Click(object sender, RoutedEventArgs e)
        {
            if (OtherNameTextbox != null && OtherCostTextbox != null)
            {
                tyyp = "Other";
                varierity = OtherNameTextbox.Text.ToString();
                varcost = double.Parse(OtherCostTextbox.Text);
                UglyLotOfIfs();
                ShopListBox.Items.Refresh();
            }
            else
            {
                error eror = new error();
                eror.Show();
            }
        }
    }
}
