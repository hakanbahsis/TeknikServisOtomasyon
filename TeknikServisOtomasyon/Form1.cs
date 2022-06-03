using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Formlar.FrmUrunListesi frUrunListesi;
        private void BtnUrunListesiFormu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frUrunListesi == null || frUrunListesi.IsDisposed)
            {
                frUrunListesi = new Formlar.FrmUrunListesi();
                frUrunListesi.MdiParent = this;
                frUrunListesi.Show();
            }

        }

        private void BtnYeniUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniUrun fr = new Formlar.FrmYeniUrun();
            //  fr.MdiParent = this;
            fr.Show();
        }
        Formlar.FrmKategori frKategori;
        private void BtnKategoriListe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frKategori == null || frKategori.IsDisposed)
            {
                frKategori = new Formlar.FrmKategori();
                frKategori.MdiParent = this;
                frKategori.Show();
            }

        }
        Formlar.FrmYeniKategori frYeniKategori;
        private void BtnYeniKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frYeniKategori == null || frYeniKategori.IsDisposed)
            {
                frYeniKategori = new Formlar.FrmYeniKategori();

                frYeniKategori.Show();
            }

        }

        private void BtnIstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmIstatistik fr = new Formlar.FrmIstatistik();

            fr.Show();
        }
        Formlar.FrmMarkalar frMarkalar;
        private void BtnMarkaİst_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frMarkalar == null || frMarkalar.IsDisposed)
            {
                frMarkalar = new Formlar.FrmMarkalar();
                frMarkalar.MdiParent = this;
                frMarkalar.Show();
            }



        }
        Formlar.FrmCariListesi frCariListesi;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frCariListesi==null ||frCariListesi.IsDisposed)
            {
                frCariListesi = new Formlar.FrmCariListesi();
                frCariListesi.MdiParent = this;
                frCariListesi.Show();
            }
            
        }
        Formlar.FrmCariİller frCariIller;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frCariIller==null || frCariIller.IsDisposed)
            {
                    frCariIller = new Formlar.FrmCariİller();
                    frCariIller.MdiParent = this;
                    frCariIller.Show();
            }
            
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmCariEkle fr = new Formlar.FrmCariEkle();

            fr.Show();
        }
        Formlar.FrmPersonel frPersonel;
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frPersonel==null||frPersonel.IsDisposed)
            {
                frPersonel = new Formlar.FrmPersonel();
                frPersonel.MdiParent = this;
                frPersonel.Show();
            }
            
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        Formlar.FrmDepartman frDepartman;
        private void BtnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frDepartman==null||frDepartman.IsDisposed)
            {
            frDepartman = new Formlar.FrmDepartman();
            frDepartman.MdiParent = this;
            frDepartman.Show();
            }
            
        }

        private void BtnYeniDepartman_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniDepartman fr = new Formlar.FrmYeniDepartman();

            fr.Show();
        }

        private void barButtonItem4_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }
        Formlar.FrmKurlar frKurlar;
        private void BtnKurlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frKurlar==null||frKurlar.IsDisposed)
            {
            frKurlar = new Formlar.FrmKurlar();
            frKurlar.MdiParent = this;
            frKurlar.Show();
            }
            
        }

        private void BtnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void BtnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }
        Formlar.FrmNotlarım frNotlar;
        private void BtnNotListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frNotlar==null||frNotlar.IsDisposed)
            {
                frNotlar = new Formlar.FrmNotlarım();
                frNotlar.MdiParent = this;
                frNotlar.Show();
            }
            
        }
            Formlar.FrmArizaListesi frArizaListesi ;
        private void BtnArizaliUrunListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frArizaListesi==null||frArizaListesi.IsDisposed)
            {
                frArizaListesi = new Formlar.FrmArizaListesi();
                     frArizaListesi.MdiParent = this;
                     frArizaListesi.Show();
            }
            
        }

        private void BtnUrunSatis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmUrunSatis fr = new Formlar.FrmUrunSatis();
            fr.Show();
        }
        Formlar.FrmSatislar frSatislar;
        private void BtnSatisListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frSatislar==null || frSatislar.IsDisposed)
            {
                frSatislar = new Formlar.FrmSatislar();
                frSatislar.MdiParent = this;
                frSatislar.Show();
            }
            
        }

        private void BtnYeniArizaliUrunKaydi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmArizaliUrunKaydi fr = new Formlar.FrmArizaliUrunKaydi();
            fr.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmArizaDetay fr = new Formlar.FrmArizaDetay();
            fr.Show();
        }
        Formlar.FrmArizaliUrunDetaylari frArizaliUrunDetaylari;
        private void BtnArizalıUrunDetayları_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frArizaliUrunDetaylari == null || frArizaliUrunDetaylari.IsDisposed)
            {
                frArizaliUrunDetaylari = new Formlar.FrmArizaliUrunDetaylari();
                frArizaliUrunDetaylari.MdiParent = this;
                frArizaliUrunDetaylari.Show();
            }
        }

        private void BtnQrCode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmQrKod fr = new Formlar.FrmQrKod();
            fr.Show();
        }
        Formlar.FrmFaturaListesi frFaturaListesi;
        private void BtnFaturaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frFaturaListesi==null||frFaturaListesi.IsDisposed)
            {
                frFaturaListesi = new Formlar.FrmFaturaListesi();
                frFaturaListesi.MdiParent = this;
                frFaturaListesi.Show();
            }
            

        }
        Formlar.FrmFaturaKalemGirisi frFaturaKalemGirisi;
        private void BtnFaturaKalemGirisi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frFaturaKalemGirisi==null||frFaturaKalemGirisi.IsDisposed)
            {
                frFaturaKalemGirisi = new Formlar.FrmFaturaKalemGirisi();
                frFaturaKalemGirisi.MdiParent = this;
                frFaturaKalemGirisi.Show();
            }
            
        }
        Formlar.FrmFaturaKalemleri frFaturaKalemleri;
        private void BtnFaturaKalemleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frFaturaKalemleri==null||frFaturaKalemleri.IsDisposed)
            {
                frFaturaKalemleri = new Formlar.FrmFaturaKalemleri();
                frFaturaKalemleri.MdiParent = this;
                frFaturaKalemleri.Show();
            }
            

        }

        private void BtnRaporlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmRapor fr = new Formlar.FrmRapor();
            // fr.MdiParent = this;
            fr.Show();

        }
        Formlar.FrmAnaSayfa frAnasayfa;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (frAnasayfa == null || frAnasayfa.IsDisposed)
            {
                frAnasayfa = new Formlar.FrmAnaSayfa();
                frAnasayfa.MdiParent = this;
                frAnasayfa.Show();
            }
           
            
            

        }

        private void BtnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (frAnasayfa == null || frAnasayfa.IsDisposed)
            {
                frAnasayfa = new Formlar.FrmAnaSayfa();
                frAnasayfa.MdiParent = this;
                frAnasayfa.Show();
            }
        }
        Formlar.FrmRehber frRehber;
        private void BtnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frRehber == null || frRehber.IsDisposed)
            {
                frRehber = new Formlar.FrmRehber();
                frRehber.MdiParent = this;
                frRehber.Show();
            }
        }
        

        private void labelControlTarih_Click(object sender, EventArgs e)
        {

        }
    }
}

