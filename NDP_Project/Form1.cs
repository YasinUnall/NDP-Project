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

        //Program süresince farklı method ve event methodlarından erişilebilirlik için
        //aşağıda içi boş private fieldlar tanımlanmıştır. İlk nesne oluşumları
        //programın içinde yeni oyuna başlanırken yapılmaktadır.
        
        //Bu fieldlarda atik nesneleri tutulur.
        private IAtik _camSise;
        private IAtik _bardak; 
        private IAtik _gazete; 
        private IAtik _dergi; 
        private IAtik _domates;
        private IAtik _salatalik;
        private IAtik _kolaKutusu;
        private IAtik _salcaKutusu;
        private IAtik[] _atiklar;

        //Bu fieldlarda atık kutusu nesneleri tutulur.
        private IAtikKutusu _organikAtikKutusu;
        private IAtikKutusu _kagitKutusu;
        private IAtikKutusu _camKutusu;
        private IAtikKutusu _metalKutusu;

        private IAtik _anlikGelenAtik; //Son gelen atik bilgilerini tutan property
        private int _guncelAtikSayi; //Son gelen atığın ilişkilendirildiği numarayı tutar.

        private void Form1_Load(object sender, EventArgs e)
        {
            //Resmin düzgün görülmesi için mod ve arkaplan rengi ayarlaması yapılır.
            pictureBoxAtık.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAtık.BackColor = Color.LightGray;

            //List boxlar deaktif edilir.
            organikAtikListBox.Enabled = false;
            kagitListBox.Enabled = false;
            camListBox.Enabled = false;
            metalListBox.Enabled = false;

            //Ekle butonları deaktif edilir.
            organikAtikEkleBtn.Enabled = false;
            kagitEkleBtn.Enabled = false;
            camEkleBtn.Enabled = false;
            metalEkleBtn.Enabled = false;

            //Boşalt butonları deaktif edilir.
            organikAtikBosaltBtn.Enabled = false;
            kagitBosaltBtn.Enabled = false;
            camBosaltBtn.Enabled = false;
            metalBosaltBtn.Enabled = false;

            //Süre ve puan tutan labellara başlangıç değerleri atanır.
            sureLabel.Text = "60";
            puanLabel.Text = "0";
        }

        //Oyun başlangıcında gerekli olan nesneleri oluşturur, renkleri ayarlar ve diğer düzenlemeleri yapar. 
        private void NewGame_Click(object sender, EventArgs e)
        {
            //isimlerin list boxlara yazılabilmesi için isimleri tutar.
            string[] tempAtikIsim = { "Cam Şişe", "Bardak", "Gazete", "Dergi", "Domates", "Salatalık", "Kola Kutusu", "Salça Kutusu" };
            _atikIsimleri = tempAtikIsim;
            tempAtikIsim = null;

            //Atik nesneleri için tanımlanmış private fieldlar içinde atik nesneleri oluşturulur.
            _camSise = new Atik(600, Image.FromFile("CamSise.jpg"));
            _bardak = new Atik(250, Image.FromFile("Bardak.jpg"));
            _gazete = new Atik(250, Image.FromFile("Gazete.jpg"));
            _dergi = new Atik(200, Image.FromFile("Dergi.png"));
            _domates = new Atik(150, Image.FromFile("Domates.jpg"));
            _salatalik = new Atik(120, Image.FromFile("Salatalik.jpg"));
            _kolaKutusu = new Atik(350, Image.FromFile("KolaKutusu.jpg"));
            _salcaKutusu = new Atik(550, Image.FromFile("SalcaKutusu.jpg"));

            //Atik nesnelerini random bir tane seçilebilmesi için diziye aktarılır.
            IAtik[] atiklar = { _camSise, _bardak, _gazete, _dergi, _domates, _salatalik, _kolaKutusu, _salcaKutusu };
            this._atiklar = atiklar;

            //Atik kutusu nesneleri için tanımlanmış private fieldlar içinde atik kutusu nesneleri oluşturulur.
            _organikAtikKutusu = new AtikKutusu(700, 0);
            _kagitKutusu = new AtikKutusu(1200, 1000);
            _camKutusu = new AtikKutusu(2200, 600);
            _metalKutusu = new AtikKutusu(2300, 800);

            //List boxlar aktif edilir.
            organikAtikListBox.Enabled = true;
            kagitListBox.Enabled = true;
            camListBox.Enabled = true;
            metalListBox.Enabled = true;

            //Ekle butonları aktif edilir.
            organikAtikEkleBtn.Enabled = true;
            kagitEkleBtn.Enabled = true;
            camEkleBtn.Enabled = true;
            metalEkleBtn.Enabled = true;

            //Boşalt butonları aktif edilir.
            organikAtikBosaltBtn.Enabled = true;
            kagitBosaltBtn.Enabled = true;
            camBosaltBtn.Enabled = true;
            metalBosaltBtn.Enabled = true;

            //List boxlar temizlenir.
            organikAtikListBox.Items.Clear();
            kagitListBox.Items.Clear();
            camListBox.Items.Clear();
            metalListBox.Items.Clear();

            //Progress barlar temizlenir.
            prgsBarOrganikAtik.Value = 0;
            prgsBarKagit.Value = 0;
            prgsBarCam.Value = 0;
            prgsBarMetal.Value = 0;

            //Süre ve puan tutan labellara başlangıç değerleri atanır.
            sureLabel.Text = "60";
            puanLabel.Text = "0";

            //Süre ve puan tutan labelların ve yeni oyun butonunun renk paletleri oyun durumuna geçirilir.
            sureLabel.BackColor = Color.DodgerBlue;
            sureLabel.ForeColor = Color.AliceBlue;

            puanLabel.BackColor = Color.DodgerBlue;
            puanLabel.ForeColor = Color.AliceBlue;

            yeniOyunBtn.ForeColor = Color.Black;

            //Timerın aktifleşme saniyesi ayarlanır ve ardından timer başlatılır.
            oyunTimer.Interval = 1000;
            oyunTimer.Enabled = true;

            //Yeni oyunun ilk atığı oluşur.
            AtikOlustur();
        }

        //Süre tutmak ve oyunun bittiğini anlamak için yazılmış timer tick event.
        private void OyunTimer_Tick(object sender, EventArgs e)
        {
            if (Convert.ToInt32(sureLabel.Text) > 0) //Süre 0 değilse saniyeyi bir düşürür.
            {
                sureLabel.Text = (Convert.ToInt32(sureLabel.Text) - 1).ToString();
            }
            else //Süre bittiyse SureBitis methodunu çağırarak gerekli ayarlamaları yaptırır.
            {
                SureBitis();
            }
        }

        //Oyundan çıkılır(Form uygulaması kapanır).
        private void CikisBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Rastgele bir atik oluşturulur.
        private void AtikOlustur()
        {
            //Rastgele bir sayı oluşturulur ve _guncelAtikSayi içine aktarılır.
            Random rand = new Random();
            _guncelAtikSayi = rand.Next(0, _atikIsimleri.Length);

            //Bir atık seçilir.
            _anlikGelenAtik = _atiklar[_guncelAtikSayi];

            //Atığın resmi ilgili yere koyulur.
            pictureBoxAtık.Image = _anlikGelenAtik.Image;
        }

        //Süre bittiğinde yapılacak işlemleri yapar.
        private void SureBitis()
        {
            //Süre durdurulur ve renk paletleri düzenlenir.
            oyunTimer.Enabled = false;

            sureLabel.BackColor = Color.AliceBlue;
            sureLabel.ForeColor = Color.DodgerBlue;

            puanLabel.BackColor = Color.AliceBlue;
            puanLabel.ForeColor = Color.DodgerBlue;

            yeniOyunBtn.ForeColor = Color.White;

            //List boxlar deaktif edilir.
            organikAtikListBox.Enabled = false;
            kagitListBox.Enabled = false;
            camListBox.Enabled = false;
            metalListBox.Enabled = false;

            //Ekle butonları deaktif edilir.
            organikAtikEkleBtn.Enabled = false;
            kagitEkleBtn.Enabled = false;
            camEkleBtn.Enabled = false;
            metalEkleBtn.Enabled = false;

            //Boşalt butonları deaktif edilir.
            organikAtikBosaltBtn.Enabled = false;
            kagitBosaltBtn.Enabled = false;
            camBosaltBtn.Enabled = false;
            metalBosaltBtn.Enabled = false;

            //İsimler temizlenir.
            string[] tempAtikIsim = null;

            //Nesneler temizlenir.
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

        //Organik atıkların eklenmesini kontrol eden buton eventi.
        private void OrganikAtikEkleBtn_Click(object sender, EventArgs e)
        {
            //Organik atık kutusunun gelen atiğin hacmi kadar yeri var mı ve gelen atık organik atık mı kontrolü yapılır.
            if (_organikAtikKutusu.Ekle((Atik)_anlikGelenAtik) && (_atikIsimleri[_guncelAtikSayi] == "Domates" || _atikIsimleri[_guncelAtikSayi] == "Salatalık"))
            {
                //List boxa gelen atığın ismi ve hacmi eklenir. Progress bar kutunun dolan hacmi %'sinde doldurulur.
                organikAtikListBox.Items.Add(_atikIsimleri[_guncelAtikSayi] + "(" + _anlikGelenAtik.Hacim + ")");
                prgsBarOrganikAtik.Value = _organikAtikKutusu.DolulukOrani;

                //Eklenen atığın hacmi kadar puan kazanılır.
                puanLabel.Text = (Convert.ToInt32(puanLabel.Text) + _anlikGelenAtik.Hacim).ToString();

                AtikOlustur(); //Yeni rastgele bir atık oluşturulur.
            }
            else
            {
                return;
            }
        }

        //Organik atıkların boşaltılmasını kontrol eden buton eventi
        private void OrganikAtikBosaltBtn_Click(object sender, EventArgs e)
        {
            //Organik atık kutusunun Bosalt methodu çağrılarak kutunun boşaltıma uygun olup olmadığı kontrol edilir.
            if (_organikAtikKutusu.Bosalt())
            {
                //Kutunun boşaltma puanı kadar puan kazanılır. Süreye 3 saniye eklenir.
                puanLabel.Text = (Convert.ToInt32(puanLabel.Text) + _organikAtikKutusu.BosaltmaPuani).ToString();
                sureLabel.Text = (Convert.ToInt32(sureLabel.Text) + 3).ToString();
                
                //List box temizlenir ve progress bar resetlenir.
                organikAtikListBox.Items.Clear();
                prgsBarOrganikAtik.Value = 0;
            }
            else
            {
                return;
            }
        }

        //Kağıt atık eklenmesini kontrol eden buton eventi.
        private void KagitEkleBtn_Click(object sender, EventArgs e)
        {
            //Kağıt atık kutusunun gelen atiğin hacmi kadar yeri var mı ve gelen atık kağıt atık mı kontrolü yapılır.
            if (_kagitKutusu.Ekle((Atik)_anlikGelenAtik) && (_atikIsimleri[_guncelAtikSayi] == "Gazete" || _atikIsimleri[_guncelAtikSayi] == "Dergi"))
            {
                //List boxa gelen atığın ismi ve hacmi eklenir. Progress bar kutunun dolan hacmi %'sinde doldurulur.
                kagitListBox.Items.Add(_atikIsimleri[_guncelAtikSayi] + "(" + _anlikGelenAtik.Hacim + ")");
                prgsBarKagit.Value = _kagitKutusu.DolulukOrani;

                //Eklenen atığın hacmi kadar puan kazanılır.
                puanLabel.Text = (Convert.ToInt32(puanLabel.Text) + _anlikGelenAtik.Hacim).ToString();

                AtikOlustur(); //Yeni rastgele bir atık oluşturulur.
            }
            else
            {
                return;
            }
        }

        //Kağıt atık boşaltılmasını kontrol eden buton eventi
        private void KagitBosaltBtn_Click(object sender, EventArgs e)
        {
            //Kağıt kutusunun Bosalt methodu çağrılarak kutunun boşaltıma uygun olup olmadığı kontrol edilir.
            if (_kagitKutusu.Bosalt())
            {
                //Kutunun boşaltma puanı kadar puan kazanılır. Süreye 3 saniye eklenir.
                puanLabel.Text = (Convert.ToInt32(puanLabel.Text) + _kagitKutusu.BosaltmaPuani).ToString();
                sureLabel.Text = (Convert.ToInt32(sureLabel.Text) + 3).ToString();

                //List box temizlenir ve progress bar resetlenir.
                kagitListBox.Items.Clear();
                prgsBarKagit.Value = 0;
            }
            else
            {
                return;
            }
        }

        //Cam atık eklenmesini kontrol eden buton eventi.
        private void CamEkleBtn_Click(object sender, EventArgs e)
        {
            //Cam atık kutusunun gelen atiğin hacmi kadar yeri var mı ve gelen atık cam atık mı kontrolü yapılır.
            if (_camKutusu.Ekle((Atik)_anlikGelenAtik) && (_atikIsimleri[_guncelAtikSayi] == "Cam Şişe" || _atikIsimleri[_guncelAtikSayi] == "Bardak"))
            {
                //List boxa gelen atığın ismi ve hacmi eklenir. Progress bar kutunun dolan hacmi %'sinde doldurulur.
                camListBox.Items.Add(_atikIsimleri[_guncelAtikSayi] + "(" + _anlikGelenAtik.Hacim + ")");
                prgsBarCam.Value = _camKutusu.DolulukOrani;

                //Eklenen atığın hacmi kadar puan kazanılır.
                puanLabel.Text = (Convert.ToInt32(puanLabel.Text) + _anlikGelenAtik.Hacim).ToString();

                AtikOlustur(); //Yeni rastgele bir atık oluşturulur.
            }
            else
            {
                return;
            }
        }

        //Cam atık boşaltılmasını kontrol eden buton eventi
        private void CamBosaltBtn_Click(object sender, EventArgs e)
        {
            //Cam kutusunun Bosalt methodu çağrılarak kutunun boşaltıma uygun olup olmadığı kontrol edilir.
            if (_camKutusu.Bosalt())
            {
                //Kutunun boşaltma puanı kadar puan kazanılır. Süreye 3 saniye eklenir.
                puanLabel.Text = (Convert.ToInt32(puanLabel.Text) + _camKutusu.BosaltmaPuani).ToString();
                sureLabel.Text = (Convert.ToInt32(sureLabel.Text) + 3).ToString();

                //List box temizlenir ve progress bar resetlenir.
                camListBox.Items.Clear();
                prgsBarCam.Value = 0;
            }
            else
            {
                return;
            }
        }

        //Metal atık eklenmesini kontrol eden buton eventi.
        private void MetalEkleBtn_Click(object sender, EventArgs e)
        {
            //Metal atık kutusunun gelen atiğin hacmi kadar yeri var mı ve gelen atık metal atık mı kontrolü yapılır.
            if (_metalKutusu.Ekle((Atik)_anlikGelenAtik) && (_atikIsimleri[_guncelAtikSayi] == "Kola Kutusu" || _atikIsimleri[_guncelAtikSayi] == "Salça Kutusu"))
            {
                //List boxa gelen atığın ismi ve hacmi eklenir. Progress bar kutunun dolan hacmi %'sinde doldurulur.
                metalListBox.Items.Add(_atikIsimleri[_guncelAtikSayi] + "(" + _anlikGelenAtik.Hacim + ")");
                prgsBarMetal.Value = _metalKutusu.DolulukOrani;

                //Eklenen atığın hacmi kadar puan kazanılır.
                puanLabel.Text = (Convert.ToInt32(puanLabel.Text) + _anlikGelenAtik.Hacim).ToString();

                AtikOlustur(); //Yeni rastgele bir atık oluşturulur.
            }
            else
            {
                return;
            }
        }

        //Metal atık boşaltılmasını kontrol eden buton eventi
        private void MetalBosaltBtn_Click(object sender, EventArgs e)
        {
            //Metal kutusunun Bosalt methodu çağrılarak kutunun boşaltıma uygun olup olmadığı kontrol edilir.
            if (_metalKutusu.Bosalt())
            {
                //Kutunun boşaltma puanı kadar puan kazanılır. Süreye 3 saniye eklenir.
                puanLabel.Text = (Convert.ToInt32(puanLabel.Text) + _metalKutusu.BosaltmaPuani).ToString();
                sureLabel.Text = (Convert.ToInt32(sureLabel.Text) + 3).ToString();

                //List box temizlenir ve progress bar resetlenir.
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
