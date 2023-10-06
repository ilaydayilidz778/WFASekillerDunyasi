using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFASekillerDuyasi
{
   public class Elips: Sekiller
    {
        //public double R { get { return (Genislik + Yukseklik / 2); } }
        public double R => (Genislik + Yukseklik )/ 2d;
        public Elips(): base("Elips")
        {

        }
        //public override double Alan()
        //{
        //    return Math.PI * Genislik * Yukseklik / 4;
        //}
        //Yöntem2
        public override double Alan() => Math.PI *Genislik * Yukseklik / 4;
        //public override double Cevre()
        //{
        //    return Math.PI * R;
        //}
        public override double Cevre() => Math.PI * R;
        public override void Ciz(Graphics g)
        {
            Brush firca = new SolidBrush(Renk);
            g.FillEllipse(firca, X, Y, Genislik, Yukseklik);
        }
    }
}
