using DataAccess;

using S3_Deadline.ViewModels;

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

namespace S3_Deadline
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window
    {
        CustomerViewModel customerViewModel;
       // OrderRepository repo;

        public MainWindow()
        {
            InitializeComponent();
            customerViewModel = DataContext as CustomerViewModel;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            customerViewModel.Initialize();
        }
    }
}