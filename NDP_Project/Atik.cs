using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_Project
{
    public class Atik : IAtik
    {
        public int Hacim { get; } //Atık hacmini tutar.
        public System.Drawing.Image Image { get; } //Atık resmini tutar.

        //İlk atamaların yapıldığı kurucu method.
        public Atik(int hacim, System.Drawing.Image image)
        {
            this.Hacim = hacim;
            this.Image = image;
        }
    }
}
