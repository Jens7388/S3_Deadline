using Entities;

using S3_Deadline.ViewModels;

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace S3_Deadline
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login: Window
    {
        CustomerViewModel customerViewModel;

        public Login()
        {
            InitializeComponent();
            customerViewModel = DataContext as CustomerViewModel;
        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            foreach(Customers customer in customerViewModel.Customers)
            {
                if(customer.CustomerId == textBoxUserName.Text)
                {

                }
            }
        }
    }
}