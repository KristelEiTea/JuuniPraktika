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
    /// Interaction logic for ShopList.xaml
    /// </summary>
    public partial class ShopList : Window
    {
        //Creates variables so the used can input names and costs and it would show up in a list.
        public string tyyp;
        public string varierity;
        public double varcost;
        //Creates a list for every day.
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
            //Reads the correct list to the listbox.
            #region Ugly data reading
            var tmpshoplist0 = ReadDataFromFile0();
            ShopsList0 = tmpshoplist0.ToList();
            var tmpshoplist1 = ReadDataFromFile1();
            ShopsList1 = tmpshoplist1.ToList();
            var tmpshoplist2 = ReadDataFromFile2();
            ShopsList2 = tmpshoplist2.ToList();
            var tmpshoplist3 = ReadDataFromFile3();
            ShopsList3 = tmpshoplist3.ToList();
            var tmpshoplist4 = ReadDataFromFile4();
            ShopsList4 = tmpshoplist4.ToList();
            var tmpshoplist5 = ReadDataFromFile5();
            ShopsList5 = tmpshoplist5.ToList();
            var tmpshoplist6 = ReadDataFromFile6();
            ShopsList6 = tmpshoplist6.ToList();
            var tmpshoplist7 = ReadDataFromFile7();
            ShopsList7 = tmpshoplist7.ToList();
            var tmpshoplist8 = ReadDataFromFile8();
            ShopsList8 = tmpshoplist8.ToList();
            var tmpshoplist9 = ReadDataFromFile9();
            ShopsList9 = tmpshoplist9.ToList();
            var tmpshoplist10 = ReadDataFromFile10();
            ShopsList10 = tmpshoplist10.ToList();
            var tmpshoplist11 = ReadDataFromFile11();
            ShopsList11 = tmpshoplist11.ToList();
            var tmpshoplist12 = ReadDataFromFile12();
            ShopsList12 = tmpshoplist12.ToList();
            var tmpshoplist13 = ReadDataFromFile13();
            ShopsList13 = tmpshoplist13.ToList();
            var tmpshoplist14 = ReadDataFromFile14();
            ShopsList14 = tmpshoplist14.ToList();
            var tmpshoplist15 = ReadDataFromFile15();
            ShopsList15 = tmpshoplist15.ToList();
            var tmpshoplist16 = ReadDataFromFile16();
            ShopsList16 = tmpshoplist16.ToList();
            var tmpshoplist17 = ReadDataFromFile17();
            ShopsList17 = tmpshoplist17.ToList();
            var tmpshoplist18 = ReadDataFromFile18();
            ShopsList18 = tmpshoplist18.ToList();
            var tmpshoplist19 = ReadDataFromFile19();
            ShopsList19 = tmpshoplist19.ToList();
            var tmpshoplist20 = ReadDataFromFile20();
            ShopsList20 = tmpshoplist20.ToList();
            var tmpshoplist21 = ReadDataFromFile21();
            ShopsList21 = tmpshoplist21.ToList();
            var tmpshoplist22 = ReadDataFromFile22();
            ShopsList22 = tmpshoplist22.ToList();
            var tmpshoplist23 = ReadDataFromFile23();
            ShopsList23 = tmpshoplist23.ToList();
            var tmpshoplist24 = ReadDataFromFile24();
            ShopsList24 = tmpshoplist24.ToList();
            var tmpshoplist25 = ReadDataFromFile25();
            ShopsList25 = tmpshoplist25.ToList();
            var tmpshoplist26 = ReadDataFromFile26();
            ShopsList26 = tmpshoplist26.ToList();
            var tmpshoplist27 = ReadDataFromFile27();
            ShopsList27 = tmpshoplist27.ToList();
            var tmpshoplist28 = ReadDataFromFile28();
            ShopsList28 = tmpshoplist28.ToList();
            var tmpshoplist29 = ReadDataFromFile29();
            ShopsList29 = tmpshoplist29.ToList();
            var tmpshoplist30 = ReadDataFromFile30();
            ShopsList30 = tmpshoplist30.ToList();
            #endregion
        }
        /// <summary>
        /// Adds item to shoplist as type "Food".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void oktestbuttonfood_Click(object sender, RoutedEventArgs e)
        {
            if (FoodStoreNameTextbox != null && FoodStoreCostTextbox != null)
            {
                tyyp = "Food";
                varierity = FoodStoreNameTextbox.Text;
                varcost = double.Parse(FoodStoreCostTextbox.Text);
                UglyLotOfIfs();
                ShopListBox.Items.Refresh();
                MoneyUsed.UsedFood += varcost;
            }
            else
            {
                error eror = new error();
                eror.Show();
            }
        }
        /// <summary>
        /// Adds item to shoplist as type "Clothes".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okclothes_Click(object sender, RoutedEventArgs e)
        {
            if (ClothesStoreNameTextbox != null && ClothesStoreCostTextbox != null)
            {
                tyyp = "Clothes";
                varierity = ClothesStoreNameTextbox.Text.ToString();
                varcost = double.Parse(ClothesStoreCostTextbox.Text);
                UglyLotOfIfs();
                ShopListBox.Items.Refresh();
                MoneyUsed.UsedClothes += varcost;
            }
            else
            {
                error eror = new error();
                eror.Show();
            }
        }
        /// <summary>
        /// Adds item to shoplist as type "Vehicle".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OKvehicle_Click(object sender, RoutedEventArgs e)
        {
            if (VehicleNameTextbox != null && VehicleCostTextbox != null)
            {
                tyyp = "Vehicle";
                varierity = VehicleNameTextbox.Text.ToString();
                varcost = double.Parse(VehicleCostTextbox.Text);
                UglyLotOfIfs();
                ShopListBox.Items.Refresh();
                MoneyUsed.UsedTransport += varcost;
            }
            else
            {
                error eror = new error();
                eror.Show();
            }
        }
        /// <summary>
        /// Adds item to shoplist as type "Other".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OtherOK_Click(object sender, RoutedEventArgs e)
        {

            if (OtherNameTextbox != null && OtherCostTextbox != null)
            {
                tyyp = "Other";
                varierity = OtherNameTextbox.Text.ToString();
                varcost = double.Parse(OtherCostTextbox.Text);
                UglyLotOfIfs();
                ShopListBox.Items.Refresh();
                MoneyUsed.UsedOther += varcost;
            }
            else
            {
                error eror = new error();
                eror.Show();
            }

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

        }
        /// <summary>
        /// Saves all lists and closes the window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitWindow_Click(object sender, RoutedEventArgs e)
        {
            SaveDataToFile();
            this.Close();
        }
        /// <summary>
        /// Reads the list of the correct date.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Adds shoplist items to the correct date.
        /// </summary>
        public void UglyLotOfIfs()
        {
            string Day = ShopListDay.Text;
            #region Ugly Lot of if's
            if (Day == "1")
            {
                ShopsList0.Add(new ShopListDaily() { ShopName = varierity, Cost = varcost, Type = tyyp, Day = 1 });
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
        /// <summary>
        /// Items for the shoplist list.
        /// </summary>
        public class ShopListDaily
        {
            public string ShopName { get; set; }
            public double Cost { get; set; }
            public string Type { get; set; }
            public int Day { get; set; }
        }
        /// <summary>
        /// Saves each day list to it's own file.
        /// </summary>
        private void SaveDataToFile()
        {
            #region Ugly lot of savings
            var json0 = JsonConvert.SerializeObject(ShopsList0);
            File.WriteAllText("ShopListBoxData0.txt", json0);
            var json1 = JsonConvert.SerializeObject(ShopsList1);
            File.WriteAllText("ShopListBoxData1.txt", json1);
            var json2 = JsonConvert.SerializeObject(ShopsList2);
            File.WriteAllText("ShopListBoxData2.txt", json2);
            var json3 = JsonConvert.SerializeObject(ShopsList3);
            File.WriteAllText("ShopListBoxData3.txt", json3);
            var json4 = JsonConvert.SerializeObject(ShopsList4);
            File.WriteAllText("ShopListBoxData4.txt", json4);
            var json5 = JsonConvert.SerializeObject(ShopsList5);
            File.WriteAllText("ShopListBoxData5.txt", json5);
            var json6 = JsonConvert.SerializeObject(ShopsList6);
            File.WriteAllText("ShopListBoxData6.txt", json6);
            var json7 = JsonConvert.SerializeObject(ShopsList7);
            File.WriteAllText("ShopListBoxData7.txt", json7);
            var json8 = JsonConvert.SerializeObject(ShopsList8);
            File.WriteAllText("ShopListBoxData8.txt", json8);
            var json9 = JsonConvert.SerializeObject(ShopsList9);
            File.WriteAllText("ShopListBoxData9.txt", json9);
            var json10 = JsonConvert.SerializeObject(ShopsList10);
            File.WriteAllText("ShopListBoxData10.txt", json10);
            var json11 = JsonConvert.SerializeObject(ShopsList11);
            File.WriteAllText("ShopListBoxData11.txt", json11);
            var json12 = JsonConvert.SerializeObject(ShopsList12);
            File.WriteAllText("ShopListBoxData12.txt", json12);
            var json13 = JsonConvert.SerializeObject(ShopsList13);
            File.WriteAllText("ShopListBoxData13.txt", json13);
            var json14 = JsonConvert.SerializeObject(ShopsList14);
            File.WriteAllText("ShopListBoxData14.txt", json14);
            var json15 = JsonConvert.SerializeObject(ShopsList15);
            File.WriteAllText("ShopListBoxData15.txt", json15);
            var json16 = JsonConvert.SerializeObject(ShopsList16);
            File.WriteAllText("ShopListBoxData16.txt", json16);
            var json17 = JsonConvert.SerializeObject(ShopsList17);
            File.WriteAllText("ShopListBoxData17.txt", json17);
            var json18 = JsonConvert.SerializeObject(ShopsList18);
            File.WriteAllText("ShopListBoxData18.txt", json18);
            var json19 = JsonConvert.SerializeObject(ShopsList19);
            File.WriteAllText("ShopListBoxData19.txt", json19);
            var json20 = JsonConvert.SerializeObject(ShopsList20);
            File.WriteAllText("ShopListBoxData20.txt", json20);
            var json21 = JsonConvert.SerializeObject(ShopsList21);
            File.WriteAllText("ShopListBoxData21.txt", json21);
            var json22 = JsonConvert.SerializeObject(ShopsList22);
            File.WriteAllText("ShopListBoxData22.txt", json22);
            var json23 = JsonConvert.SerializeObject(ShopsList23);
            File.WriteAllText("ShopListBoxData23.txt", json23);
            var json24 = JsonConvert.SerializeObject(ShopsList24);
            File.WriteAllText("ShopListBoxData24.txt", json24);
            var json25 = JsonConvert.SerializeObject(ShopsList25);
            File.WriteAllText("ShopListBoxData25.txt", json25);
            var json26 = JsonConvert.SerializeObject(ShopsList26);
            File.WriteAllText("ShopListBoxData26.txt", json26);
            var json27 = JsonConvert.SerializeObject(ShopsList27);
            File.WriteAllText("ShopListBoxData27.txt", json27);
            var json28 = JsonConvert.SerializeObject(ShopsList28);
            File.WriteAllText("ShopListBoxData28.txt", json28);
            var json29 = JsonConvert.SerializeObject(ShopsList29);
            File.WriteAllText("ShopListBoxData29.txt", json29);
            var json30 = JsonConvert.SerializeObject(ShopsList30);
            File.WriteAllText("ShopListBoxData30.txt", json30);
            #endregion
        }
        //Reads data out of files.
        #region Ugly data reading
        private IEnumerable<ShopListDaily> ReadDataFromFile0()
        {
            var json = File.ReadAllText("ShopListBoxData0.txt");
            var data0 = JsonConvert.DeserializeObject<IEnumerable<ShopListDaily>>(json);
            return data0;
        }
        private IEnumerable<ShopListDaily> ReadDataFromFile1()
        {
            var json = File.ReadAllText("ShopListBoxData1.txt");
            var data1 = JsonConvert.DeserializeObject<IEnumerable<ShopListDaily>>(json);
            return data1;
        }
        private IEnumerable<ShopListDaily> ReadDataFromFile2()
        {
            var json = File.ReadAllText("ShopListBoxData2.txt");
            var data2 = JsonConvert.DeserializeObject<IEnumerable<ShopListDaily>>(json);
            return data2;
        }
        private IEnumerable<ShopListDaily> ReadDataFromFile3()
        {
            var json = File.ReadAllText("ShopListBoxData3.txt");
            var data3 = JsonConvert.DeserializeObject<IEnumerable<ShopListDaily>>(json);
            return data3;
        }
        private IEnumerable<ShopListDaily> ReadDataFromFile4()
        {
            var json = File.ReadAllText("ShopListBoxData4.txt");
            var data4 = JsonConvert.DeserializeObject<IEnumerable<ShopListDaily>>(json);
            return data4;
        }
        private IEnumerable<ShopListDaily> ReadDataFromFile5()
        {
            var json = File.ReadAllText("ShopListBoxData5.txt");
            var data5 = JsonConvert.DeserializeObject<IEnumerable<ShopListDaily>>(json);
            return data5;
        }
        private IEnumerable<ShopListDaily> ReadDataFromFile6()
        {
            var json = File.ReadAllText("ShopListBoxData6.txt");
            var data6 = JsonConvert.DeserializeObject<IEnumerable<ShopListDaily>>(json);
            return data6;
        }
        private IEnumerable<ShopListDaily> ReadDataFromFile7()
        {
            var json = File.ReadAllText("ShopListBoxData7.txt");
            var data7 = JsonConvert.DeserializeObject<IEnumerable<ShopListDaily>>(json);
            return data7;
        }
        private IEnumerable<ShopListDaily> ReadDataFromFile8()
        {
            var json = File.ReadAllText("ShopListBoxData8.txt");
            var data8 = JsonConvert.DeserializeObject<IEnumerable<ShopListDaily>>(json);
            return data8;
        }
        private IEnumerable<ShopListDaily> ReadDataFromFile9()
        {
            var json = File.ReadAllText("ShopListBoxData9.txt");
            var data9 = JsonConvert.DeserializeObject<IEnumerable<ShopListDaily>>(json);
            return data9;
        }
        private IEnumerable<ShopListDaily> ReadDataFromFile10()
        {
            var json = File.ReadAllText("ShopListBoxData10.txt");
            var data10 = JsonConvert.DeserializeObject<IEnumerable<ShopListDaily>>(json);
            return data10;
        }
        private IEnumerable<ShopListDaily> ReadDataFromFile11()
        {
            var json = File.ReadAllText("ShopListBoxData11.txt");
            var data11 = JsonConvert.DeserializeObject<IEnumerable<ShopListDaily>>(json);
            return data11;
        }
        private IEnumerable<ShopListDaily> ReadDataFromFile12()
        {
            var json = File.ReadAllText("ShopListBoxData12.txt");
            var data12 = JsonConvert.DeserializeObject<IEnumerable<ShopListDaily>>(json);
            return data12;
        }
        private IEnumerable<ShopListDaily> ReadDataFromFile13()
        {
            var json = File.ReadAllText("ShopListBoxData13.txt");
            var data13 = JsonConvert.DeserializeObject<IEnumerable<ShopListDaily>>(json);
            return data13;
        }
        private IEnumerable<ShopListDaily> ReadDataFromFile14()
        {
            var json = File.ReadAllText("ShopListBoxData14.txt");
            var data14 = JsonConvert.DeserializeObject<IEnumerable<ShopListDaily>>(json);
            return data14;
        }
        private IEnumerable<ShopListDaily> ReadDataFromFile15()
        {
            var json = File.ReadAllText("ShopListBoxData15.txt");
            var data15 = JsonConvert.DeserializeObject<IEnumerable<ShopListDaily>>(json);
            return data15;
        }
        private IEnumerable<ShopListDaily> ReadDataFromFile16()
        {
            var json = File.ReadAllText("ShopListBoxData16.txt");
            var data16 = JsonConvert.DeserializeObject<IEnumerable<ShopListDaily>>(json);
            return data16;
        }
        private IEnumerable<ShopListDaily> ReadDataFromFile17()
        {
            var json = File.ReadAllText("ShopListBoxData17.txt");
            var data17 = JsonConvert.DeserializeObject<IEnumerable<ShopListDaily>>(json);
            return data17;
        }
        private IEnumerable<ShopListDaily> ReadDataFromFile18()
        {
            var json = File.ReadAllText("ShopListBoxData18.txt");
            var data18 = JsonConvert.DeserializeObject<IEnumerable<ShopListDaily>>(json);
            return data18;
        }
        private IEnumerable<ShopListDaily> ReadDataFromFile19()
        {
            var json = File.ReadAllText("ShopListBoxData19.txt");
            var data19 = JsonConvert.DeserializeObject<IEnumerable<ShopListDaily>>(json);
            return data19;
        }
        private IEnumerable<ShopListDaily> ReadDataFromFile20()
        {
            var json = File.ReadAllText("ShopListBoxData20.txt");
            var data20 = JsonConvert.DeserializeObject<IEnumerable<ShopListDaily>>(json);
            return data20;
        }
        private IEnumerable<ShopListDaily> ReadDataFromFile21()
        {
            var json = File.ReadAllText("ShopListBoxData21.txt");
            var data21 = JsonConvert.DeserializeObject<IEnumerable<ShopListDaily>>(json);
            return data21;
        }
        private IEnumerable<ShopListDaily> ReadDataFromFile22()
        {
            var json = File.ReadAllText("ShopListBoxData22.txt");
            var data22 = JsonConvert.DeserializeObject<IEnumerable<ShopListDaily>>(json);
            return data22;
        }
        private IEnumerable<ShopListDaily> ReadDataFromFile23()
        {
            var json = File.ReadAllText("ShopListBoxData23.txt");
            var data23 = JsonConvert.DeserializeObject<IEnumerable<ShopListDaily>>(json);
            return data23;
        }
        private IEnumerable<ShopListDaily> ReadDataFromFile24()
        {
            var json = File.ReadAllText("ShopListBoxData24.txt");
            var data24 = JsonConvert.DeserializeObject<IEnumerable<ShopListDaily>>(json);
            return data24;
        }
        private IEnumerable<ShopListDaily> ReadDataFromFile25()
        {
            var json = File.ReadAllText("ShopListBoxData25.txt");
            var data25 = JsonConvert.DeserializeObject<IEnumerable<ShopListDaily>>(json);
            return data25;
        }
        private IEnumerable<ShopListDaily> ReadDataFromFile26()
        {
            var json = File.ReadAllText("ShopListBoxData26.txt");
            var data26 = JsonConvert.DeserializeObject<IEnumerable<ShopListDaily>>(json);
            return data26;
        }
        private IEnumerable<ShopListDaily> ReadDataFromFile27()
        {
            var json = File.ReadAllText("ShopListBoxData27.txt");
            var data27 = JsonConvert.DeserializeObject<IEnumerable<ShopListDaily>>(json);
            return data27;
        }
        private IEnumerable<ShopListDaily> ReadDataFromFile28()
        {
            var json = File.ReadAllText("ShopListBoxData28.txt");
            var data28 = JsonConvert.DeserializeObject<IEnumerable<ShopListDaily>>(json);
            return data28;
        }
        private IEnumerable<ShopListDaily> ReadDataFromFile29()
        {
            var json = File.ReadAllText("ShopListBoxData29.txt");
            var data29 = JsonConvert.DeserializeObject<IEnumerable<ShopListDaily>>(json);
            return data29;
        }
        private IEnumerable<ShopListDaily> ReadDataFromFile30()
        {
            var json = File.ReadAllText("ShopListBoxData30.txt");
            var data30 = JsonConvert.DeserializeObject<IEnumerable<ShopListDaily>>(json);
            return data30;
        }
        #endregion

        private void ShopListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
