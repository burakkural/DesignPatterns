using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Structural.Proxy
{
    public class ImageGeneratorProxy : IImageGenerator
    {
        private ImageGenerator _generator;
        private string _path;

        public ImageGeneratorProxy(string path)
        {
            _path = path;
        }

        public void ShowImage()
        {
            _generator ??= new ImageGenerator(_path);

            _generator.ShowImage();
        }
    }
}
