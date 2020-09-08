using DataAccess;

using Entities;

using S3_Deadline.ViewModels;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
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
        Customers selectedCustomer;

        public Login()
        {
            InitializeComponent();
            customerViewModel = DataContext as CustomerViewModel;
            customerViewModel.Initialize();
        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            selectedCustomer = customerViewModel.SelectedCustomer;
            string password = textBoxPassword.Text;
            foreach(Customers customer in customerViewModel.Customers)
            {
                if(customer.CustomerId == textBoxUserName.Text)
                {
                    selectedCustomer = customer;
                }
            }
            if(selectedCustomer == null)
            {
                MessageBox.Show("Forkert brugernavn! prøv igen");
            }
            else if(password.ToLower() != "password")
            {
                MessageBox.Show("Forkert adgangskode! Prøv igen");
            }
            else
            {
                Visibility = Visibility.Hidden;
                MainWindow mainWindow = new MainWindow();
                OrderRepository orderRepository = new OrderRepository();
                IEnumerable<Orders> orders = selectedCustomer.Orders
                    .OrderBy(o => o.RequiredDate)
                    .Where(o => o.ShippedDate == null);              
                /*IGNORER DETTE
                foreach(Orders order in orders)
                {
                    foreach(Orders order2 in selectedCustomer.Orders)
                    {
                        if(order.OrderId != order2.OrderId)
                        {
                            orders.Add(order);
                        };
                    }
                }*/
                mainWindow.orderListBox.ItemsSource = orders;
                mainWindow.Show();
            }
        }
    }
}