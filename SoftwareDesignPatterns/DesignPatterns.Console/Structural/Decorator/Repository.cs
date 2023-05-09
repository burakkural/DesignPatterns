using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Structural.Decorator
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public void Add(T entity)
        {
            System.Console.WriteLine("Model eklendi");
        }

        public void Delete(T entity)
        {
            System.Console.WriteLine("Model silindi");
        }

        public void Get(int id)
        {
            System.Console.WriteLine("Model bazlı veri çekildi");
        }

        public void GetAll()
        {
            System.Console.WriteLine("Tüm veriler çekildi");
        }

        public void Update(T entity)
        {
            System.Console.WriteLine("Model güncellendi");
        }
    }
}
