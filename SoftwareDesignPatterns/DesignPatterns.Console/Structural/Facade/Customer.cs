using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Structural.Facade
{
    public class Customer
    {
        public int CustomerNumber { get; set; }
        public string Fullname { get; set; }
        public string IDNo { get; set; }
        public decimal CashAmount { get; set; }
    }
}
