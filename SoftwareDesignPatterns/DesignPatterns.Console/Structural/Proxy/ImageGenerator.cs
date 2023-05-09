using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Structural.Proxy
{
    public class ImageGenerator : IImageGenerator
    {
        private string _path;
        public ImageGenerator(string path)
        {
            _path = path;    
        }
        public void ShowImage()
        {
            System.Console.WriteLine("{0} Resim Gösteriliyor..", _path);
        }
    }
}
