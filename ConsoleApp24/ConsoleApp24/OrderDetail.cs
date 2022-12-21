using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    
        public class OrderDetail
        {
            public Int32 DetailID { get; set; }
            public String ProductName { get; set; }
            public Int32 Qty { get; set; }
            public Decimal Price { get; set; }
            public Decimal? Amount { get; set; }
            public Int32 OrderID { get; set; }
        }
    
}
