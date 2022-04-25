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

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Exit_Click(object sender, RoutedEventArgs e) 
        { 
        Close();
        }
        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Отрубянко Никита, Милев Сергей");
        }
        private void StatusBarItem_Checked(object sender, RoutedEventArgs e)
        {
            statusBar.Visibility = Visibility.Visible;
        }
        private void StatusBarItem_Unchecked(object sender, RoutedEventArgs e)
        {
            statusBar.Visibility = Visibility.Hidden;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataTextBlock.Text += DateTime.Now;
        }
        private void StackPanelButton_Click(object sender, RoutedEventArgs e)
        {
            StackPanelLabel.Visibility = Visibility.Hidden;
            StackPanelLabel2.Visibility = Visibility.Hidden;
            StackPanelLabel3.Visibility = Visibility.Hidden;
        }
    }
}
