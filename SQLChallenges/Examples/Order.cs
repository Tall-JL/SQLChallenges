﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.Examples
{
    public class Order
    {
        public int OrderID { get; set; }

        //this is the foreign key
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        public short OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int StoreID { get; set; }
        public int StaffID { get; set; }

    }
}
