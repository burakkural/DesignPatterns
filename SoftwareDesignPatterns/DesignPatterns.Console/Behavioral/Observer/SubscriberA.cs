using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Behavioral.Observer
{
    public class SubscriberA : Subscriber
    {
        public override void Notify()
        {
            System.Console.WriteLine($"Hey {nameof(SubscriberA)}! Takip ettiğiniz ürünün fiyatı düştü!");
        }
    }

    public class SubscriberB : Subscriber
    {
        public override void Notify()
        {
            System.Console.WriteLine($"Hey {nameof(SubscriberB)}! Takip ettiğiniz ürünün fiyatı düştü!");
        }
    }
}
