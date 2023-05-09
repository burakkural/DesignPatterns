using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Behavioral.Strategy
{
    public class Serializer
    {
        private readonly ISerializable serializer;

        public Serializer(ISerializable serializer)
        {
            this.serializer = serializer;
        }

        public void Serialize(string text)
        {
            serializer.Serialize(text);
        }

        public void Deserialize(string text)
        {
            serializer.Deserialize(text);
        }
    }
}
