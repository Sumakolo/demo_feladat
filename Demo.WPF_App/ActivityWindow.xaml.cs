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

namespace Demo.WPF_App
{
    /// <summary>
    /// Interaction logic for ActivityWindow.xaml
    /// </summary>
    public partial class ActivityWindow : Window
    {
        public ActivityWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clicking the Back button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            var NewWindow = new MainWindow();
            NewWindow.Show();
            Window win = Window.GetWindow(this);
            if (win != null)
            {
                win.Close();
            }
        }

        /// <summary>
        /// Clicking the Add Task button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            var NewWindow = new AddTaskWindow();
            NewWindow.Show();         
        }

        /// <summary>
        /// Clicking the Add Activity button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddActivity_Click(object sender, RoutedEventArgs e)
        {
            var NewWindow = new AddActivityWindow();
            NewWindow.Show();
        }
    }
}
