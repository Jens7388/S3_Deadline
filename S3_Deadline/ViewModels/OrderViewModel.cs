using Entities;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DataAccess;
using System.Text;

namespace S3_Deadline.ViewModels
{
    public class OrderViewModel: ViewModelBase<Orders>
    {
        private Orders selectedOrder;

        public OrderViewModel()
        {
            Orders = new ObservableCollection<Orders>();
        }

        public ObservableCollection<Orders> Orders { get; set; }
        public Orders SelectedOrder
        {
            get => selectedOrder;
            set
            {
                selectedOrder = value;
                OnPropertyChanged(nameof(SelectedOrder));
            }
        }

        public override void LoadAll()
        {
            OrderRepository orderRepository = new OrderRepository();
            IEnumerable<Orders> orders = orderRepository.GetAll();
            Orders.ReplaceWith(orders);
        }
    }
}