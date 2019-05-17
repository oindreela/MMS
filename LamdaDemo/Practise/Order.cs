using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class Order
    {
        int _oid;
        string _itemname;
        DateTime _orderDate;
        int _qty;

        public int Oid { get => _oid; set => _oid = value; }
        public string Itemname { get => _itemname; set => _itemname = value; }
        public DateTime OrderDate { get => _orderDate; set => _orderDate = value; }
        public int Qty { get => _qty; set => _qty = value; }

        //public Order(int orderid, string itemname,DateTime orderdate,int quantity)
        //{
        //    orderid = Oid;
        //    itemname = Itemname;
        //    orderdate = OrderDate;
        //    quantity = Qty;
        //}
    }
}
