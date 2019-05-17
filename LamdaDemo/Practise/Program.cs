using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Order> orderList = new List<Order>();
            orderList.Add(new Order{ Oid=1, Itemname="P1", OrderDate=DateTime.Parse("11 - 04 - 2019"), Qty=20 });
            orderList.Add(new Order { Oid = 2, Itemname = "P2", OrderDate = DateTime.Parse("12 - 04 - 2019"), Qty = 10 });
            orderList.Add(new Order { Oid = 3, Itemname = "P3", OrderDate = DateTime.Parse("11 - 04 - 2019"), Qty = 25 });
            orderList.Add(new Order { Oid = 4, Itemname = "P4", OrderDate = DateTime.Parse("09 - 04 - 2019"), Qty = 26 });
            var SortedList = from o in orderList
                             orderby o.OrderDate descending, o.Qty descending
                             select o;

            var itemMaxHeight = orderList.Max(y => y.Qty);
            var itemsMax = orderList.Find(x => x.Qty == itemMaxHeight);
            Console.WriteLine(itemsMax.Itemname);

            var datewise = from o in orderList
                           group o by o.OrderDate into g
                           select new { g.Key, sumQty = g.Sum<Order>(x => x.Qty) };
            foreach(var obj in datewise)
            {
                Console.WriteLine(obj.Key + "\t" +obj .sumQty);
            }

            var  productwise = from o in orderList
                              group o by o.Itemname into g
                              select new { g.Key, sumQty = g.Sum<Order>(x => x.Qty) };
            foreach (var x in productwise)
            {
                Console.WriteLine(x.Key + "\t" + x.sumQty);
            }

            
        }
    }
    class A: Array
    {

    }
}
