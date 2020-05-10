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

        private String[] _atikIsimleri;

        private IAtik _camSise;
        private IAtik _bardak;
        private IAtik _gazete;
        private IAtik _dergi;
        private IAtik _domates;
        private IAtik _salatalik;
        private IAtik _kolaKutusu;
        private IAtik _salcaKutusu;
        private IAtik[] _atiklar;

        private IAtikKutusu _organikAtikKutusu;
        private IAtikKutusu _kagitKutusu;
        private IAtikKutusu _camKutusu;
        private IAtikKutusu _metalKutusu;

        private IAtik _anlikGelenAtik;
        private int _guncelAtikSayi;

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxAtık.SizeMode = PictureBoxSizeMode.StretchImage;

            organikAtikListBox.Enabled = false;
            kagitListBox.Enabled = false;
            camListBox.Enabled = false;
            metalListBox.Enabled = false;

            organikAtikEkleBtn.Enabled = false;
            kagitEkleBtn.Enabled = false;
            camEkleBtn.Enabled = false;
            metalEkleBtn.Enabled = false;

            organikAtikBosaltBtn.Enabled = false;
            kagitBosaltBtn.Enabled = false;
            camBosaltBtn.Enabled = false;
            metalBosaltBtn.Enabled = false;

            sureLabel.Text = "60";
            puanLabel.Text = "0";
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            string[] tempAtikIsim = { "Cam Şişe", "Bardak", "Gazete", "Dergi", "Domates", "Salatalık", "Kola Kutusu", "Salça Kutusu" };
            _atikIsimleri = tempAtikIsim;
            tempAtikIsim = null;

            _camSise = new Atik(600, Image.FromFile("CamSise.jpg"));
            _bardak = new Atik(250, Image.FromFile("Bardak.jpg"));
            _gazete = new Atik(250, Image.FromFile("Gazete.jpg"));
            _dergi = new Atik(200, Image.FromFile("Dergi.png"));
            _domates = new Atik(150, Image.FromFile("Domates.jpg"));
            _salatalik = new Atik(120, Image.FromFile("Salatalik.jpg"));
            _kolaKutusu = new Atik(350, Image.FromFile("KolaKutusu.jpg"));
            _salcaKutusu = new Atik(550, Image.FromFile("SalcaKutusu.jpg"));

            IAtik[] atiklar = { _camSise, _bardak, _gazete, _dergi, _domates, _salatalik, _kolaKutusu, _salcaKutusu };
            this._atiklar = atiklar;


            _organikAtikKutusu = new AtikKutusu(700, 0);
            _kagitKutusu = new AtikKutusu(1200, 1000);
            _camKutusu = new AtikKutusu(2200, 600);
            _metalKutusu = new AtikKutusu(2300, 800);

            organikAtikListBox.Enabled = true;
            kagitListBox.Enabled = true;
            camListBox.Enabled = true;
            metalListBox.Enabled = true;

            organikAtikEkleBtn.Enabled = true;
            kagitEkleBtn.Enabled = true;
            camEkleBtn.Enabled = true;
            metalEkleBtn.Enabled = true;

            organikAtikBosaltBtn.Enabled = true;
            kagitBosaltBtn.Enabled = true;
            camBosaltBtn.Enabled = true;
            metalBosaltBtn.Enabled = true;

            organikAtikListBox.Items.Clear();
            kagitListBox.Items.Clear();
            camListBox.Items.Clear();
            metalListBox.Items.Clear();

            prgsBarOrganikAtik.Value = 0;
            prgsBarKagit.Value = 0;
            prgsBarCam.Value = 0;
            prgsBarMetal.Value = 0;

            sureLabel.Text = "60";
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
            _guncelAtikSayi = rand.Next(0, _atikIsimleri.Length);

            _anlikGelenAtik = _atiklar[_guncelAtikSayi];
            pictureBoxAtık.Image = _anlikGelenAtik.Image;
        }

        private void SureBitis()
        {
            sureLabel.BackColor = Color.AliceBlue;
            sureLabel.ForeColor = Color.DodgerBlue;

            puanLabel.BackColor = Color.AliceBlue;
            puanLabel.ForeColor = Color.DodgerBlue;

            yeniOyunBtn.ForeColor = Color.White;

            organikAtikListBox.Enabled = false;
            kagitListBox.Enabled = false;
            camListBox.Enabled = false;
            metalListBox.Enabled = false;

            organikAtikEkleBtn.Enabled = false;
            kagitEkleBtn.Enabled = false;
            camEkleBtn.Enabled = false;
            metalEkleBtn.Enabled = false;

            organikAtikBosaltBtn.Enabled = false;
            kagitBosaltBtn.Enabled = false;
            camBosaltBtn.Enabled = false;
            metalBosaltBtn.Enabled = false;

            string[] tempAtikIsim = null;

            _camSise = null;
            _bardak = null;
            _gazete = null;
            _dergi = null;
            _domates = null;
            _salatalik = null;
            _kolaKutusu = null;
            _salcaKutusu = null;

            this._atiklar = null;


            _organikAtikKutusu = null;
            _kagitKutusu = null;
            _camKutusu = null;
            _metalKutusu = null;
        }

        private void OrganikAtikEkleBtn_Click(object sender, EventArgs e)
        {
            if (_organikAtikKutusu.Ekle((Atik)_anlikGelenAtik) && (_atikIsimleri[_guncelAtikSayi] == "Domates" || _atikIsimleri[_guncelAtikSayi] == "Salatalık"))
            {
                organikAtikListBox.Items.Add(_atikIsimleri[_guncelAtikSayi] + "(" + _anlikGelenAtik.Hacim + ")");
                prgsBarOrganikAtik.Value = _organikAtikKutusu.DolulukOrani;

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
            if (_organikAtikKutusu.Bosalt())
            {
                puanLabel.Text = (Convert.ToInt32(puanLabel.Text) + _organikAtikKutusu.BosaltmaPuani).ToString();
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
            if (_kagitKutusu.Ekle((Atik)_anlikGelenAtik) && (_atikIsimleri[_guncelAtikSayi] == "Gazete" || _atikIsimleri[_guncelAtikSayi] == "Dergi"))
            {
                kagitListBox.Items.Add(_atikIsimleri[_guncelAtikSayi] + "(" + _anlikGelenAtik.Hacim + ")");
                prgsBarKagit.Value = _kagitKutusu.DolulukOrani;

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
            if (_kagitKutusu.Bosalt())
            {
                puanLabel.Text = (Convert.ToInt32(puanLabel.Text) + _kagitKutusu.BosaltmaPuani).ToString();
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
            if (_camKutusu.Ekle((Atik)_anlikGelenAtik) && (_atikIsimleri[_guncelAtikSayi] == "Cam Şişe" || _atikIsimleri[_guncelAtikSayi] == "Bardak"))
            {
                camListBox.Items.Add(_atikIsimleri[_guncelAtikSayi] + "(" + _anlikGelenAtik.Hacim + ")");
                prgsBarCam.Value = _camKutusu.DolulukOrani;

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
            if (_camKutusu.Bosalt())
            {
                puanLabel.Text = (Convert.ToInt32(puanLabel.Text) + _camKutusu.BosaltmaPuani).ToString();
                sureLabel.Text = (Convert.ToInt32(sureLabel.Text) + 3).ToString();

                camListBox.Items.Clear();
                prgsBarCam.Value = 0;
            }
            else
            {
                return;
            }
        }

        private void MetalEkleBtn_Click(object sender, EventArgs e)
        {
            if (_metalKutusu.Ekle((Atik)_anlikGelenAtik) && (_atikIsimleri[_guncelAtikSayi] == "Kola Kutusu" || _atikIsimleri[_guncelAtikSayi] == "Salça Kutusu"))
            {
                metalListBox.Items.Add(_atikIsimleri[_guncelAtikSayi] + "(" + _anlikGelenAtik.Hacim + ")");
                prgsBarMetal.Value = _metalKutusu.DolulukOrani;

                puanLabel.Text = (Convert.ToInt32(puanLabel.Text) + _anlikGelenAtik.Hacim).ToString();

                AtikOlustur();
            }
            else
            {
                return;
            }
        }

        private void MetalBosaltBtn_Click(object sender, EventArgs e)
        {
            if (_metalKutusu.Bosalt())
            {
                puanLabel.Text = (Convert.ToInt32(puanLabel.Text) + _metalKutusu.BosaltmaPuani).ToString();
                sureLabel.Text = (Convert.ToInt32(sureLabel.Text) + 3).ToString();

                metalListBox.Items.Clear();
                prgsBarMetal.Value = 0;
            }
            else
            {
                return;
            }
        }
    }
}
