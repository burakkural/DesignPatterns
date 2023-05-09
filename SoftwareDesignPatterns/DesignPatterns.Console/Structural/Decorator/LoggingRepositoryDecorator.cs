using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Structural.Decorator
{
    public class LoggingRepositoryDecorator<T> : DecoratorRepository<T> where T : class
    {
        private readonly IRepository<T> repository;

        public LoggingRepositoryDecorator(IRepository<T> repository) : base(repository)
        {
            this.repository = repository;
        }
        public override void Add(T model)
        {
            base.Add(model);
            System.Console.WriteLine($"LOG : {typeof(T).Name} eklenmiştir.");
        }
        public override void Delete(T model)
        {
            base.Delete(model);
            System.Console.WriteLine($"LOG : {typeof(T).Name} silinmiştir.");
        }
        public override void Update(T model)
        {
            base.Update(model);
            System.Console.WriteLine($"LOG : {typeof(T).Name} güncellenmiştir.");
        }
    }
}
