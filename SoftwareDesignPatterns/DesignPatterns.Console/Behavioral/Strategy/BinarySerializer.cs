using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Behavioral.Strategy
{
    public class BinarySerializer : ISerializable
    {
        public void Deserialize(string text)
        {
            System.Console.WriteLine("Binary Deserialize");
        }

        public void Serialize(string text)
        {
            System.Console.WriteLine("Binary Serialize");
        }
    }
}
