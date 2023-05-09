using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Structural.Adapter
{
    public class Client
    {
        private readonly IResponse response;

        public Client(IResponse response)
        {
            this.response = response;
        }

        public void Response()
        {
            response.ResponseJson();
        }
    }
}
