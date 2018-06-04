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
    /// Interaction logic for EventPlanner.xaml
    /// </summary>
    public partial class EventPlanner : Window
    {
        List<EventPlan> itemlist = new List<EventPlan>();
        public EventPlanner()
        {

            int dateall = 0;
            InitializeComponent();
            for (int i = 0; i < 31; i++)
            {
                dateall += 1;
                itemlist.Add(new EventPlan() { Date = dateall , Comment = "No comments here!", EventName = "No events today!", Place = "-"});
            }

            PlannerListBox.ItemsSource = itemlist;
        }
        public class EventPlan
        {
            public int Date { get; set; }
            public string EventName { get; set; }
            public double Time { get; set; }
            public string Place { get; set; }
            public string Comment { get; set; }
           
        }
    }
}