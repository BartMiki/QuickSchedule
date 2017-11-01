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

namespace QuickSchedule
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Scheduler scheduler;
        private AddWindow addw;

        public MainWindow()
        {
            InitializeComponent();
            scheduler = new Scheduler();
            scheduleList.ItemsSource = scheduler.TasksToList((Task t1, Task t2) => t1.Name.CompareTo(t2.Name));
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            addw = new AddWindow();
            addw.ShowDialog();
            Task t = addw.Task;
            if (t != null)
            {
                scheduler.AddTask(t);
            }
            addw = null;
            scheduleList.ItemsSource = scheduler.TasksToList((Task t1, Task t2) => t1.Name.CompareTo(t2.Name));
        }

        private void SortByName_Click(object sender, RoutedEventArgs e)
        {
            scheduleList.ItemsSource = scheduler.TasksToList((Task t1, Task t2) => t1.Name.CompareTo(t2.Name));
        }

        private void SortByDuration_Click(object sender, RoutedEventArgs e)
        {
            scheduleList.ItemsSource = scheduler.TasksToList((Task t1, Task t2) => t1.Duration.CompareTo(t2.Duration));
        }

        private void SortByPriority_Click(object sender, RoutedEventArgs e)
        {
            scheduleList.ItemsSource = scheduler.TasksToList((Task t1, Task t2) => t1.Priority.CompareTo(t2.Priority));
        }
    }
}
