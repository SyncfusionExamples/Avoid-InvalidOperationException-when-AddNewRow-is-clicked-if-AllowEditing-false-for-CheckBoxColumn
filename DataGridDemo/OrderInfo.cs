using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DataGridDemo
{  
    public class OrderInfo : INotifyPropertyChanged
    {
        private int orderID;
        private string country;
        private string customerName;

        public int OrderID
        {
            get => orderID;
            set
            {
                if (orderID != value)
                {
                    orderID = value;
                    OnPropertyChanged("OrderID");
                }
            }
        }

        public bool Status
        {
            get => this.OrderID % 2 == 0;
        }

        public string CustomerName
        {
            get => customerName;
            set
            {
                if (customerName != value)
                {
                    customerName = value;
                    OnPropertyChanged("CustomerName");
                }
            }
        }

        public string Country
        {
            get => country;
            set
            {
                if (country != value)
                {
                    country = value;
                    OnPropertyChanged("Country");
                }
            }
        }

        public OrderInfo()
        {

        }

        public OrderInfo(int orderId, string customerName, string country)
        {
            this.OrderID = orderId;
            this.CustomerName = customerName;
            this.Country = country;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
