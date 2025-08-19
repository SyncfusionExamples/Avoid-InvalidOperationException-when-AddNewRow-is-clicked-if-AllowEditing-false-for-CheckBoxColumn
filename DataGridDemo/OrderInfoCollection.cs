using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridDemo
{
    public class OrderInfoCollection
    {
        private ObservableCollection<OrderInfo> _orders;

        public ObservableCollection<OrderInfo> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        public OrderInfoCollection()
        {
            _orders = new ObservableCollection<OrderInfo>();
            this.GenerateOrders();
        }

        private void GenerateOrders()
        {
            _orders.Add(new OrderInfo(1001, "Maria Anders", "Germany"));
            _orders.Add(new OrderInfo(1002, "Ana Trujilo", "Mexico"));
            _orders.Add(new OrderInfo(1003, "Antonio Moreno", "Mexico"));
            _orders.Add(new OrderInfo(1004, "Thomas Hardy", "UK"));
            _orders.Add(new OrderInfo(1005, "Christina Berglund", "Sweden"));
            _orders.Add(new OrderInfo(1006, "Hanna Moos", "Germany"));
            _orders.Add(new OrderInfo(1007, "Frederique Citeaux", "France"));
            _orders.Add(new OrderInfo(1008, "Martin Sommer", "Spain"));
            _orders.Add(new OrderInfo(1009, "Laurence Lebihan", "France"));
            _orders.Add(new OrderInfo(1010, "Elizabeth Lincoln", "Canada"));
        }
    }
}
