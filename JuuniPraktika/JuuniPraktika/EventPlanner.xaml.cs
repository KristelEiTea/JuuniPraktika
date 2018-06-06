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
        /// <summary>
        /// Sets the date as 0, then adds numbers in a cycle, adds original text in the columns.
        /// </summary>
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
        /// <summary>
        /// Sets the needed variables.
        /// </summary>
        public class EventPlan
        {
            public int Date { get; set; }
            public string EventName { get; set; }
            public string Time { get; set; }
            public string Place { get; set; }
            public string Comment { get; set; }
           
        }
        /// <summary>
        /// This void adds the name, time, place of the event from the text box, then refreshes the info.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAll_Click(object sender, RoutedEventArgs e)
        {
            //if((PlannerListBox.SelectedItem as EventPlan).EventName = 
            //{

            //}
            
            string EventName = (Eventbox.Text);
            string Time = (Timebox.Text);
            string Place = (Placebox.Text);
            (PlannerListBox.SelectedItem as EventPlan).EventName = EventName;
            (PlannerListBox.SelectedItem as EventPlan).Time = Time;
            (PlannerListBox.SelectedItem as EventPlan).Place = Place;

            //Errors(); - THEY DON'T WORK!!!!!!!!!!!
            PlannerListBox.Items.Refresh();
         
        }

        /// <summary>
        /// This void adds a comment from textbox and then refreshes the shown info.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddComment_Click(object sender, RoutedEventArgs e)
        {
            string Comment = (Commentbox.Text);
            (PlannerListBox.SelectedItem as EventPlan).Comment = Comment;
            PlannerListBox.Items.Refresh();
        }
        /// <summary>
        /// This clears the info from the column by overwriting it with the original text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ClearAll_Click(object sender, RoutedEventArgs e)
        {
            (PlannerListBox.SelectedItem as EventPlan).EventName = "No events today!";
            (PlannerListBox.SelectedItem as EventPlan).Time = " ";
            (PlannerListBox.SelectedItem as EventPlan).Place = "-";
            (PlannerListBox.SelectedItem as EventPlan).Comment = "No comments here!";
            PlannerListBox.Items.Refresh();

        }
        ///PS! THESE ERRORS UNDER HERE DON'T WORK! PLEASE CHANGE THEM OR DELETE THEM
        
        //public void Errors()
        //{
        //if (Eventbox.Text == "")
        //    {
        //        Console.WriteLine("Please fill in all the info!");
        //    }

        //if (Timebox.Text == "")
        //    { Console.WriteLine("Please fill in all the info!");
        //    }
        //if (Placebox.Text == "")
        //    {
        //        Console.WriteLine("Please fill in all the info!");
        //    }
        
        //}




    }
}