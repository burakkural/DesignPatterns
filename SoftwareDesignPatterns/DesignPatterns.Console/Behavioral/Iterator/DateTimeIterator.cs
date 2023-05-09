using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Behavioral.Iterator
{
    public class DateTimeIterator : IIterator
    {
        DateTimeAggregate aggregate;
        DateTime currentDate;
        DateTime weekendDate;

        public DateTimeIterator(DateTimeAggregate aggregate)
        {
            this.aggregate = aggregate;
            currentDate = aggregate.startDate;
        }

        public DateTime CurrentDate()
        {
            return currentDate;
        }

        public bool Hasdate()
        {
            if (currentDate.DayOfWeek == DayOfWeek.Saturday || currentDate.DayOfWeek == DayOfWeek.Sunday)
            {
                int dayCount = currentDate.DayOfWeek == DayOfWeek.Saturday ? 1 : 6;
                currentDate = currentDate.AddDays(dayCount);
            }
            else
            {
                int dayCount = (int)currentDate.DayOfWeek;
                currentDate = currentDate.AddDays(6 - dayCount);
                /*6'dan ilgili günün haftalık sayısını çıkarırsak eğer 
                 Cumartesi gününe kalan günü hesaplamış oluruz.
                 Haliyle bu hesabı ilgili tarihe eklersek eğer
                 o haftanın hafta sonuna ulaşmış oluruz.*/
            }
            return currentDate < aggregate.endDate;
        }
    }
}
