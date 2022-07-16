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

namespace WPFProject
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

        private void ButtonAddUser_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text) && !string.IsNullOrWhiteSpace(txtServices.Text) && !Services.Items.Contains(txtServices.Text) && !string.IsNullOrWhiteSpace(txtPhone.Text) && !Phone.Items.Contains(txtPhone.Text))
            {
                lstNames.Items.Add(txtName.Text);
                Phone.Items.Add(txtPhone.Text);
                Services.Items.Add(txtServices.Text);
                Date.Items.Add(txtDate.Text);
                txtName.Clear();
                txtPhone.Clear();
                txtServices.Clear();
                txtDate.Clear();
            }
        }

        private void ButtonRecords_Click(object sender, RoutedEventArgs e)
        {
            new Window1().Show();
        }
    }
}
