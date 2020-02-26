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

namespace WPFBasic
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

        private void applyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"This description is {description.Text}");
        }

        private void resetButtom_Click(object sender, RoutedEventArgs e)
        {
            this.car.IsChecked = this.bike.IsChecked = this.bus.IsChecked = this.motor.IsChecked = this.well.IsChecked = this.cycle.IsChecked = false;
        }

        private void Checked(object sender, RoutedEventArgs e)
        {
            this.mass.Text += $"{(string) ((CheckBox)sender).Content}, ";
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.NoteText == null)
            {
                return;
            }
              
            var combo = (ComboBox)sender;
            var value = (ComboBoxItem)combo.SelectedValue;
            this.NoteText.Text = (string) value.Content;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.ComboBox_SelectionChanged(this.ComboBox, null);
        }
    }
}
