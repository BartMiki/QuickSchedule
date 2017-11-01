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

namespace QuickSchedule
{
    /// <summary>
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public Task Task { get; set; }

        public AddWindow()
        {
            InitializeComponent();
        }

        private void Apply_Click(object sender, RoutedEventArgs e)
        {
            string name = Name.Text;
            TimeSpan duration = TimeSpan.FromMinutes(Convert.ToDouble(Duration.Text));
            Task = new Task(name,DateTime.Now,duration,Priority.MEDIUM);
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Task = null;
            Close();
        }
    }
}
