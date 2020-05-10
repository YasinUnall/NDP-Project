using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_Project
{
    public class AtikKutusu : IAtikKutusu
    {
        private int _maxKapasite;

        public int Kapasite { get; set; }
        public int DoluHacim { get { return (_maxKapasite - Kapasite); } }
        public int DolulukOrani { get { return ((DoluHacim / _maxKapasite) * 100); } }

        public int BosaltmaPuani { get; }

        public AtikKutusu(int maxKapasite, int bosaltmaPuani)
        {
            this._maxKapasite = maxKapasite;
            this.Kapasite = maxKapasite;
            this.BosaltmaPuani = bosaltmaPuani;
        }

        public bool Ekle(Atik atik)
        {
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
        public bool Bosalt()
        {
            if ((Kapasite / _maxKapasite) * 100 >= 75)
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
