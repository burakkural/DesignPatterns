using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Behavioral.Strategy
{
    public interface ISerializable
    {
        void Serialize(string text);
        void Deserialize(string text);
    }
}
