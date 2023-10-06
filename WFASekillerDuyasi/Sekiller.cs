using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFASekillerDuyasi
{
    public abstract class Sekiller //abstract sınıflardan ınstance alınamaz.
    {
        public Sekiller(string ad)
        {
            Ad = ad;
        }
        public string Ad { get; set; } /*= "Şekil";*/
        public int Genislik { get; set; }
        public int Yukseklik { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Color Renk { get; set; } = Color.Black;
        public abstract double Alan();// miras alan sınıflar abstract metodları IMPLEMENT ETMEK(İÇİNİ DOLDURMAK)ZORUNDADIR!!!

        public abstract double Cevre();
        public abstract void Ciz(Graphics g);

        public override String ToString()
        {
            return $"{Ad} ({X},{Y}) {Genislik}X{Yukseklik} A:{Alan():0.00} Ç:{Cevre():0.00}";
        }
    }
}
