using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mock7Req4
{
    class Table:IComparer<Table>
    {
        long _id;
        string _number;
        string _capacity;

        public Table() { }
        public Table(long id, string number, string capacity)
        {
            _id = id;
            _number = number;
            _capacity = capacity;
        }

        public long Id { get => _id; set => _id = value; }
        public string Number { get => _number; set => _number = value; }
        public string Capacity { get => _capacity; set => _capacity = value; }

        public int Compare(Table x, Table y)
        {
            
        }
    }
}
