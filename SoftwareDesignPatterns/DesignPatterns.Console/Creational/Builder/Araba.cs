using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Creational.Builder
{
     class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public double KM { get; set; }
        public bool OtomatikVitesMi { get; set; }
        public string VitesStr { get => OtomatikVitesMi ? "Maunel" : "Otomatik" ;} 
        public override string ToString()
        {
            return $"{Marka} marka araba {Model} modelinde {KM} kilometrede {VitesStr} vites olarak üretilmiştir.";
        }
    }
}
