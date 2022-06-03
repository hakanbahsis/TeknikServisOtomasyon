using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisOtomasyon.Formlar
{
    public partial class FrmFaturaKalemGirisi : Form
    {
        public FrmFaturaKalemGirisi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        void istenilenKategoriGetir()
        {
            var degerler = from u in db.TBLFATURADETAY
                           select new
                           {
                               u.FATURADETAYID,
                               u.URUN,
                               u.ADET,
                               u.FIYAT,
                               u.TUTAR,
                               u.FATURAID
                           
                           };
            gridControl1.DataSource = degerler.ToList();

        }
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLFATURADETAY T = new TBLFATURADETAY();
            T.URUN = TxtUrun.Text;
            T.ADET = short.Parse(TxtAdet.Text);
            T.FIYAT = decimal.Parse(TxtFiyat.Text);
            T.TUTAR = decimal.Parse(TxtTutar.Text);
            T.FATURAID = int.Parse(TxtFaturaId.Text);
            db.TBLFATURADETAY.Add(T);
            db.SaveChanges();
            MessageBox.Show("Faturaya Kalem Girişi Yapıldı.");


        }

        private void FrmFaturaKalemGirisi_Load(object sender, EventArgs e)
        {
            istenilenKategoriGetir();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            istenilenKategoriGetir();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridControl1.Focused==true)
            {
                try
                {
                    TxtDetayId.Text = gridView1.GetFocusedRowCellValue("FATURADETAYID").ToString();
                    TxtUrun.Text = gridView1.GetFocusedRowCellValue("URUN").ToString();
                    TxtAdet.Text = gridView1.GetFocusedRowCellValue("ADET").ToString();
                    TxtFiyat.Text = gridView1.GetFocusedRowCellValue("FIYAT").ToString();
                    TxtTutar.Text = gridView1.GetFocusedRowCellValue("TUTAR").ToString();
                    TxtFaturaId.Text = gridView1.GetFocusedRowCellValue("FATURAID").ToString();
                }
                catch (Exception)
                {

                    MessageBox.Show("Hata");
                }
            }
            
            
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtDetayId.Text = "";
            TxtUrun.Text = "";
            TxtAdet.Text = "";
            TxtFiyat.Text = "";
            TxtTutar.Text = "";
            TxtFaturaId.Text = "";
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtDetayId.Text);
            var deger = db.TBLFATURADETAY.Find(id);
            db.TBLFATURADETAY.Remove(deger);
            db.SaveChanges();
            istenilenKategoriGetir();
            MessageBox.Show("Departman Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtDetayId.Text);
            var deger = db.TBLFATURADETAY.Find(id);
            deger.URUN = TxtUrun.Text;
            deger.ADET = short.Parse(TxtAdet.Text);
            deger.FIYAT = decimal.Parse(TxtFiyat.Text);
            deger.TUTAR = decimal.Parse(TxtTutar.Text);
            deger.FATURAID = int.Parse(TxtFaturaId.Text);
            db.SaveChanges();
            MessageBox.Show("Departman Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
