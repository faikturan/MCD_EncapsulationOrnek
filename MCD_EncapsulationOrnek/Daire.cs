using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_EncapsulationOrnek
{
    class Daire
    {
        #region Ozellikler
        public double YariCap { get; set; }

        private double _cap = 0;

        public double Cap
        {
            get
            {
                if (YariCap >0d)
                {
                    _cap = YariCap * 2;
                }

                return _cap;
            }
        }

        public double PiSayisi { get; set; }

        #endregion

        #region Constructorlar Yani Yapıcı Metotlar
        public Daire()
        {
            PiSayisi = 3;
        }

        public Daire(double DisardanAlinanPiSayisi)
        {
            PiSayisi = DisardanAlinanPiSayisi;
        }
        #endregion

        #region Metotlar

        public void AlanHesapla()
        {//pi r kare

            double sonuc = PiSayisi * Math.Pow(YariCap, 2);
            Console.WriteLine("Alan=" +sonuc.ToString("0.00"));
        }

        public void CevreHesapla()
        {
            //2 pi r
            double sonuc = 2 * PiSayisi * YariCap;
            Console.WriteLine("Çevre= " +sonuc.ToString("0.00"));
        }


        #endregion

    }
}
