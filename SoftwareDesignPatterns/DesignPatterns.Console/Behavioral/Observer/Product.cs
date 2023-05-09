using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Behavioral.Observer
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }

        private double amount;

        public double Amount
        {
            get { return amount; }
            set {
                if (amount > value) Notify();
                amount = value; 
            }
        }


        List<Subscriber> Subscribers;

        public Product()
        {
            Subscribers = new List<Subscriber>();
        }

        public void AddSubscriber(Subscriber subscriber)
        {
            Subscribers.Add(subscriber);
        }

        public void RemoveSubscriber(Subscriber subscriber) {
            Subscribers.Remove(subscriber);
        }

        public void Notify()
        {
            foreach (Subscriber subscriber in Subscribers)
            {
                subscriber.Notify();
            }
        }
    }
}
