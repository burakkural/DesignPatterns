using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Structural.Adapter
{
    public class ThirdApiAdapter : IResponse
    {
        private  ThirdApiResponse response;

        public ThirdApiAdapter(ThirdApiResponse response)
        {
            this.response = response;
        }
        public void ResponseJson()
        {
            //Converting XML to JSON
            response.ResponseXML();
        }
    }
}
