using Demo.WPF_App.ViewModels;
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
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        private readonly RegisterVM registerVM;
        public RegisterWindow()
        {
            
            registerVM = new RegisterVM();
            DataContext = registerVM;
            InitializeComponent();
        }

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

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            var NewWindow = new MainWindow();
            NewWindow.Show();
            Window win = Window.GetWindow(this);
            if (win != null)
            {
                win.Close();
            }
        }
    }
}
