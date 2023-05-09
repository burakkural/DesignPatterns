using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Behavioral.Iterator
{
    public interface IIterator
    {
        bool Hasdate();

        DateTime CurrentDate();
    }
}
