using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_Project
{
    public class AtikKutusu : IAtikKutusu
    {
        private int _maxKapasite; //Maksimum kapasiteyi tutar.

        public int Kapasite { get; set; } //Boş olan kapasiteyi tutar.
        public int DoluHacim { get { return (_maxKapasite - Kapasite); } } //Dolu hacmi döndürür

        //Doluluk oranını döndürür.
        public int DolulukOrani { get { return (int)(((float)DoluHacim / _maxKapasite) * 100); } }

        public int BosaltmaPuani { get; } //Boşaltma puanını döndürür.

        //İlk atamaların yapıldığı kurucu method.
        public AtikKutusu(int maxKapasite, int bosaltmaPuani)
        {
            this._maxKapasite = maxKapasite;
            this.Kapasite = maxKapasite;
            this.BosaltmaPuani = bosaltmaPuani;
        }

        public bool Ekle(Atik atik) //Atik kutusuna atik ekler.
        {
            //Gelen atık hacmi kutunun kalan yerinden az ise atığı kutuya ekler.
            if (Kapasite >= atik.Hacim) 
            {
                Kapasite -= atik.Hacim;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Bosalt() //Atık kutusunu boşaltır.
        {
            if (DolulukOrani >= 75) //Doluluk oranı %75 veya üzeri ise kutuyu boşaltır.
            {
                Kapasite = _maxKapasite;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
