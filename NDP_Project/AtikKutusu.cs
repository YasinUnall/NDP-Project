﻿using System;
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
        public int DoluHacim { get { return (_maxKapasite - Kapasite); } }
        public int DolulukOrani { get { return (int)(((float)DoluHacim / _maxKapasite) * 100); } }

        public int BosaltmaPuani { get; }

        public AtikKutusu(int maxKapasite, int bosaltmaPuani)
        {
            this._maxKapasite = maxKapasite;
            this.Kapasite = maxKapasite;
            this.BosaltmaPuani = bosaltmaPuani;
        }

        public bool Ekle(Atik atik) //Atik kutusuna atik ekler.
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
            if (DolulukOrani >= 75)
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
