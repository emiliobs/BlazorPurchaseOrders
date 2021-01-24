using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPurchaseOrders.Data
{
    public class SqlConnectionConfiguration
    {
        public string Value { get; set; }

        public SqlConnectionConfiguration(string value) => Value = value;
       
    }
}
