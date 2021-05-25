using GalaSoft.MvvmLight.Messaging;
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
using Demo.Logic;
using Demo.Repository;

namespace Demo.WPF_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EmployeeRepository employeeRepository;
        EmployeeLogic logic;

        public MainWindow()
        {
            InitializeComponent();
            employeeRepository = new EmployeeRepository();
            logic = new EmployeeLogic(employeeRepository);
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            var NewWindow = new ActivityWindow();
            NewWindow.Show();
            Window win = Window.GetWindow(this);
            if (win != null)
            {
                win.Close();
            }
        }

        private void CreateUser_Click(object sender, RoutedEventArgs e)
        {
            var NewWindow = new RegisterWindow();
            NewWindow.Show();
            Window win = Window.GetWindow(this);
            if (win != null)
            {
                win.Close();
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Window win = Window.GetWindow(this);
            if (win != null)
            {
                win.Close();
            }
        }
    }
}
