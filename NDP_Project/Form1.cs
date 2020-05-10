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

        private String[] atikIsimleri;

        private IAtik camSise;
        private IAtik bardak;
        private IAtik gazete;
        private IAtik dergi;
        private IAtik domates;
        private IAtik salatalik;
        private IAtik kolaKutusu;
        private IAtik salcaKutusu;
        private IAtik[] atiklar;

        IAtikKutusu organikAtikKutusu;
        IAtikKutusu kagitKutusu;
        IAtikKutusu camKutusu;
        IAtikKutusu metalKutusu;
        IAtikKutusu[] atikKutulari;

        private IAtik _anlikGelenAtik;
        private int _guncelAtikSayi;

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxAtık.SizeMode = PictureBoxSizeMode.StretchImage;

            sureLabel.Text = "60";
            puanLabel.Text = "0";
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            string[] tempAtikIsim = { "Cam Şişe", "Bardak", "Gazete", "Dergi", "Domates", "Salatalık", "Kola Kutusu", "Salça Kutusu" };
            atikIsimleri = tempAtikIsim;
            tempAtikIsim = null;

            camSise = new Atik(600, Image.FromFile("CamSise.jpg"));
            bardak = new Atik(250, Image.FromFile("Bardak.jpg"));
            gazete = new Atik(250, Image.FromFile("Gazete.jpg"));
            dergi = new Atik(600, Image.FromFile("Dergi.png"));
            domates = new Atik(150, Image.FromFile("Domates.jpg"));
            salatalik = new Atik(120, Image.FromFile("Salatalik.jpg"));
            kolaKutusu = new Atik(350, Image.FromFile("KolaKutusu.jpg"));
            salcaKutusu = new Atik(550, Image.FromFile("SalcaKutusu.jpg"));

            IAtik[] atiklar = { camSise, bardak, gazete, dergi, domates, salatalik, kolaKutusu, salcaKutusu };
            this.atiklar = atiklar;


            organikAtikKutusu = new AtikKutusu(700, 0);
            kagitKutusu = new AtikKutusu(1200, 1000);
            camKutusu = new AtikKutusu(2200, 600);
            metalKutusu = new AtikKutusu(2300, 800);

            //IAtikKutusu[] atikKutulari = { organikAtikKutusu, kagitKutusu, camKutusu, metalKutusu };
            //this.atikKutulari = atikKutulari;

            organikAtikListBox.Enabled = true;
            kagitListBox.Enabled = true;
            camListBox.Enabled = true;
            metalListBox.Enabled = true;

            organikAtikListBox.Items.Clear();
            kagitListBox.Items.Clear();
            camListBox.Items.Clear();
            metalListBox.Items.Clear();

            prgsBarOrganikAtik.Value = 0;
            prgsBarKagit.Value = 0;
            prgsBarCam.Value = 0;
            prgsBarMetal.Value = 0;

            sureLabel.Text = "5";
            puanLabel.Text = "0";

            sureLabel.BackColor = Color.DodgerBlue;
            sureLabel.ForeColor = Color.AliceBlue;

            puanLabel.BackColor = Color.DodgerBlue;
            puanLabel.ForeColor = Color.AliceBlue;

            yeniOyunBtn.ForeColor = Color.Black;

            oyunTimer.Interval = 1000;
            oyunTimer.Enabled = true;

            AtikOlustur();
        }

        private void OyunTimer_Tick(object sender, EventArgs e)
        {
            if (Convert.ToInt32(sureLabel.Text) > 0)
            {
                sureLabel.Text = (Convert.ToInt32(sureLabel.Text) - 1).ToString();
            }
            else
            {
                SureBitis();
                oyunTimer.Enabled = false;
            }
        }

        private void CikisBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AtikOlustur()
        {
            Random rand = new Random();
            _guncelAtikSayi = rand.Next(0, atikIsimleri.Length);

            _anlikGelenAtik = atiklar[_guncelAtikSayi];
            pictureBoxAtık.Image = _anlikGelenAtik.Image;
        }

        private void SureBitis()
        {
            sureLabel.BackColor = Color.AliceBlue;
            sureLabel.ForeColor = Color.DodgerBlue;

            puanLabel.BackColor = Color.AliceBlue;
            puanLabel.ForeColor = Color.DodgerBlue;

            sureLabel.Text = "60";
            yeniOyunBtn.ForeColor = Color.White;

            organikAtikListBox.Enabled = false;
            kagitListBox.Enabled = false;
            camListBox.Enabled = false;
            metalListBox.Enabled = false;

        }

        private void OrganikAtikEkleBtn_Click(object sender, EventArgs e)
        {
            if (organikAtikKutusu.Ekle((Atik)_anlikGelenAtik) && (atikIsimleri[_guncelAtikSayi] == "Domates" || atikIsimleri[_guncelAtikSayi] == "Salatalık"))
            {
                organikAtikListBox.Items.Add(atikIsimleri[_guncelAtikSayi] + "(" + _anlikGelenAtik.Hacim + ")");
                prgsBarOrganikAtik.Value = organikAtikKutusu.DolulukOrani;

                puanLabel.Text = (Convert.ToInt32(puanLabel.Text) + _anlikGelenAtik.Hacim).ToString();

                AtikOlustur();
            }
            else
            {
                return;
            }
        }

        private void OrganikAtikBosaltBtn_Click(object sender, EventArgs e)
        {
            if (organikAtikKutusu.Bosalt())
            {
                puanLabel.Text = (Convert.ToInt32(puanLabel.Text) + organikAtikKutusu.BosaltmaPuani).ToString();
                sureLabel.Text = (Convert.ToInt32(sureLabel.Text) + 3).ToString();
                
                organikAtikListBox.Items.Clear();
                prgsBarOrganikAtik.Value = 0;
            }
            else
            {
                return;
            }
        }

        private void KagitEkleBtn_Click(object sender, EventArgs e)
        {
            if (kagitKutusu.Ekle((Atik)_anlikGelenAtik) && (atikIsimleri[_guncelAtikSayi] == "Gazete" || atikIsimleri[_guncelAtikSayi] == "Dergi"))
            {
                kagitListBox.Items.Add(atikIsimleri[_guncelAtikSayi] + "(" + _anlikGelenAtik.Hacim + ")");
                prgsBarKagit.Value = kagitKutusu.DolulukOrani;

                puanLabel.Text = (Convert.ToInt32(puanLabel.Text) + _anlikGelenAtik.Hacim).ToString();

                AtikOlustur();
            }
            else
            {
                return;
            }
        }

        private void KagitBosaltBtn_Click(object sender, EventArgs e)
        {
            if (kagitKutusu.Bosalt())
            {
                puanLabel.Text = (Convert.ToInt32(puanLabel.Text) + kagitKutusu.BosaltmaPuani).ToString();
                sureLabel.Text = (Convert.ToInt32(sureLabel.Text) + 3).ToString();

                kagitListBox.Items.Clear();
                prgsBarKagit.Value = 0;
            }
            else
            {
                return;
            }
        }

        private void CamEkleBtn_Click(object sender, EventArgs e)
        {
            if (camKutusu.Ekle((Atik)_anlikGelenAtik) && (atikIsimleri[_guncelAtikSayi] == "Cam Şişe" || atikIsimleri[_guncelAtikSayi] == "Bardak"))
            {
                camListBox.Items.Add(atikIsimleri[_guncelAtikSayi] + "(" + _anlikGelenAtik.Hacim + ")");
                prgsBarCam.Value = camKutusu.DolulukOrani;

                puanLabel.Text = (Convert.ToInt32(puanLabel.Text) + _anlikGelenAtik.Hacim).ToString();

                AtikOlustur();
            }
            else
            {
                return;
            }
        }

        private void CamBosaltBtn_Click(object sender, EventArgs e)
        {
            if (camKutusu.Bosalt())
            {
                puanLabel.Text = (Convert.ToInt32(puanLabel.Text) + camKutusu.BosaltmaPuani).ToString();
                sureLabel.Text = (Convert.ToInt32(sureLabel.Text) + 3).ToString();

                camListBox.Items.Clear();
                prgsBarCam.Value = 0;
            }
            else
            {
                return;
            }
        }
    }
}
