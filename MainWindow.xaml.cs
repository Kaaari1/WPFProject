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
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text) && !string.IsNullOrWhiteSpace(txtEmail.Text) && !Email.Items.Contains(txtEmail.Text) && !string.IsNullOrWhiteSpace(txtPhone.Text) && !Phone.Items.Contains(txtPhone.Text))
            {
                lstNames.Items.Add(txtName.Text);
                Email.Items.Add(txtEmail.Text);
                Phone.Items.Add(txtPhone.Text);
                txtName.Clear();
                txtEmail.Clear();
                txtPhone.Clear();
            }
        }

        private void ButtonRecords_Click(object sender, RoutedEventArgs e)
        {
            MainWindow wnd = new MainWindow();
        }
    }
}
