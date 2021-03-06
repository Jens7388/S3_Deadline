﻿using DataAccess;

using Entities;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace S3_Deadline.ViewModels
{
    public class CustomerViewModel: ViewModelBase<Customers>
    {
        private Customers selectedCustomer;
        private Orders selectedOrder;

        public CustomerViewModel()
        {
            Customers = new ObservableCollection<Customers>();
        }

        public ObservableCollection<Customers> Customers { get; set; }
        public Customers SelectedCustomer
        {
            get => selectedCustomer;
            set
            {
                selectedCustomer = value;
                OnPropertyChanged(nameof(SelectedCustomer));
            }
        }
        public Orders SelectedOrder
        {
            get
            {
                return selectedOrder;
            }

            set
            {
                selectedOrder = value;
                OnPropertyChanged(nameof(SelectedOrder));
            }
        }


        public override void LoadAll()
        {
            CustomerRepository customerRepository = new CustomerRepository();
            IEnumerable<Customers> customers = customerRepository.GetAll();
            Customers.ReplaceWith(customers);
        }
    }
}