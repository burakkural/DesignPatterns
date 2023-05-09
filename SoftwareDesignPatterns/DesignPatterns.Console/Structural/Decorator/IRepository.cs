using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Structural.Decorator
{
    public interface IRepository<T> where T : class
    {
        public void Add(T entity);
        public void Update(T entity);
        public void Delete(T entity);
        public void GetAll();
        public void Get(int id);
    }
}
