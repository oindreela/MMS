using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Item
    {
        long _id;
        string _name;
        string _itemCode;
        double _cost;

        public long Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string ItemCode { get { return _itemCode; } set { _itemCode = value; } }
        public double Cost { get { return _cost; } set { _cost = value; } }

        public Item() { }
        public Item(long id, string name, string itemCode, double cost)
        {
            _id = id;
            _name = name;
            _itemCode = itemCode;
            _cost = cost;
        }

        public static Item createItem(string itemDetail)
        {
            string[] input = itemDetail.Split(',');
            Item i = new Item(long.Parse(input[0]), input[1], input[2], double.Parse(input[3]));
            return i;
        }

        public static Item SearchItembyName(string itemName, List<Item>itemList)
        {
            foreach (Item i in itemList)
            {
                if (i.Name == itemName)
                    return i;
                else
                    return null;
            }
        }


    }
}
