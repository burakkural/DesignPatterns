using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Structural.Decorator
{
    public class DecoratorRepository<T> : IRepository<T> where T : class
    {
        private readonly IRepository<T> repository;

        public DecoratorRepository(IRepository<T> repository)
        {
            this.repository = repository;
        }
         public virtual void Add(T entity)
        {
            repository.Add(entity);
        }

        public virtual void Delete(T entity)
        {
           repository.Delete(entity);
        }

        public virtual void Get(int id)
        {
            repository.Get(id);
        }

        public virtual void GetAll()
        {
            repository.GetAll();
        }

        public virtual void Update(T entity)
        {
           repository.Update(entity);
        }
    }
}
