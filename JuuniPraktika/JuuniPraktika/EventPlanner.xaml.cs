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
            public string Time { get; set; }
            public string Place { get; set; }
            public string Comment { get; set; }
           
        }

        private void AddAll_Click(object sender, RoutedEventArgs e)
        {
            
            string EventName = (Eventbox.Text);
            string Time = (Timebox.Text);
            string Place = (Placebox.Text);
            string Comment = (Commentbox.Text);
            (PlannerListBox.SelectedItem as EventPlan).EventName = EventName;
            (PlannerListBox.SelectedItem as EventPlan).Time = Time;
            (PlannerListBox.SelectedItem as EventPlan).Place = Place;

            Errors();
            PlannerListBox.Items.Refresh();
            
           
        }

        private void AddComment_Click(object sender, RoutedEventArgs e)
        {
            string Comment = (Commentbox.Text);
            (PlannerListBox.SelectedItem as EventPlan).Comment = Comment;
            PlannerListBox.Items.Refresh();
        }

        private void ClearAll_Click(object sender, RoutedEventArgs e)
        {
            (PlannerListBox.SelectedItem as EventPlan).EventName = "No events today!";
            (PlannerListBox.SelectedItem as EventPlan).Time = " ";
            (PlannerListBox.SelectedItem as EventPlan).Place = "-";
            (PlannerListBox.SelectedItem as EventPlan).Comment = "No comments here!";
            PlannerListBox.Items.Refresh();

        }
        public void Errors()
        {
        if (Eventbox.Text == "")
            {
                Console.WriteLine("Please fill in all the info!");
            }

        if (Timebox.Text == "")
            { Console.WriteLine("Please fill in all the info!");
            }
        if (Placebox.Text == "")
            {
                Console.WriteLine("Please fill in all the info!");
            }
        
        }


        //private void Eventbox_GotFocus(object sender, TextChangedEventArgs e)
    //    {
    //        if (Eventbox.Text == Eventbox.Text)
    //            Eventbox.Text = "";

    //    }
    //private void Eventbox_LostFocus(object sender, TextChangedEventArgs e)
    //{

    //}


}
}