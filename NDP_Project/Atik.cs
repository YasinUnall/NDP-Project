using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_Project
{
    public class Atik : IAtik
    {
        public int Hacim { get; }
        public System.Drawing.Image Image { get; }

        public Atik(int hacim, System.Drawing.Image image)
        {
            this.Hacim = hacim;
            this.Image = image;
        }
    }
}
