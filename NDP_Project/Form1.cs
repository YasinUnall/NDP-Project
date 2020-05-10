using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDP_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] atikBilgi;
            Atik camSise = new Atik(600, Image.FromFile("CamSise.jpg"));
            Atik bardak = new Atik(250, Image.FromFile("Bardak.jpg"));
            Atik gazete = new Atik(250, Image.FromFile("Gazete.jpg"));
            Atik dergi = new Atik(600, Image.FromFile("Dergi.png"));
            Atik domates = new Atik(150, Image.FromFile("Domates.jpg"));
            Atik salatalik = new Atik(120, Image.FromFile("Salatalik.jpg"));
            Atik kolaKutusu = new Atik(350, Image.FromFile("KolaKutusu.jpg"));
            Atik salcaKutusu = new Atik(550, Image.FromFile("SalcaKutusu.jpg"));

            pictureBoxAtık.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBoxAtık.Image = camSise.Image;

            IAtik atik;
        }
    }
}
