using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Behavioral.Iterator
{
    public class DateTimeAggregate : IAggregate
    {
        public DateTime startDate;
        public DateTime endDate;
        public IIterator CreateIterator()
        {
            return new DateTimeIterator(this);
        }
    }
}
