using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Behavioral.Template
{
    abstract class Alisveris
    {
        protected string UrunAdi;
        protected OdemeTipi odemeTipi;
        void Baslat()
        {
            System.Console.WriteLine("Alışveriş Başladı");
        }
        void Bitir()
        {
            System.Console.WriteLine($"Alışveriş {UrunAdi} ve {odemeTipi} yöntemiyle tamamlandı");
        }
        abstract public void Urun();
        abstract public void OdemeSekli();

        public void TemplateMethod()
        {
            Baslat();
            Urun();
            OdemeSekli();
            Bitir();
        }
    }
    enum OdemeTipi
    {
        Pesin,
        Taksit
    }
}
