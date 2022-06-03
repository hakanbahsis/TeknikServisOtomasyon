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
    public partial class FrmCariListesi : Form
    {
        public FrmCariListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        int secilen;
        void secileniAktar()
        {
            try
            {
                TxtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString().ToUpper();
                TxtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString().ToUpper();
                TxtSoyad.Text = gridView1.GetFocusedRowCellValue("SOYAD").ToString().ToUpper();
                TxtTelefon.Text = gridView1.GetFocusedRowCellValue("TELEFON").ToString();
              lookUpEditIl.Text = gridView1.GetFocusedRowCellValue("IL").ToString();
               lookUpEditIlce.Text = gridView1.GetFocusedRowCellValue("ILCE").ToString();
                comboBoxEditBanka.Text = gridView1.GetFocusedRowCellValue("BANKA").ToString();
                TxtVergiDairesi.Text = gridView1.GetFocusedRowCellValue("VERGIDAIRESI").ToString().ToUpper();
                TxtVergiNo.Text = gridView1.GetFocusedRowCellValue("VERGINO").ToString();
                comboBoxEditStatu.Text = gridView1.GetFocusedRowCellValue("STATU").ToString().ToUpper();
                TxtAdres.Text = gridView1.GetFocusedRowCellValue("ADRES").ToString().ToUpper();
            }
            catch (Exception)
            {

                MessageBox.Show("Cari Bilgileri Eksik.");
            }
        }
        void istenilenKategoriGetir()
        {
            var degerler = from u in db.TBLCARI
                           select new
                           {
                               u.ID,
                              u.AD,
                               u.SOYAD,
                               u.TELEFON,
                               u.MAIL,
                               u.IL,
                               u.ILCE,
                               u.BANKA,
                               u.VERGIDAIRESI,
                               u.VERGINO,
                               u.STATU,
                               u.ADRES
                           };
            gridControl1.DataSource = degerler.ToList();

            lookUpEditIl.Properties.DataSource = (from x in db.TBLILLER
                                                         select new
                                                         {
                                                             x.id,
                                                             x.sehir
                                                         }).ToList(); ;

           
        }
        private void FrmCariListesi_Load(object sender, EventArgs e)
        {
            istenilenKategoriGetir();
            gridControl1.DataSource = db.TBLCARI.ToList();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            if (gridControl1.Focused==true)
            {
                    secileniAktar();
            }
            
            
           
            
        }

        private void lookUpEditIl_EditValueChanged(object sender, EventArgs e)
        {
            secilen = int.Parse(lookUpEditIl.EditValue.ToString());
            lookUpEditIlce.Properties.DataSource = (from x in db.TBLILCELER
                                                    select new
                                                    {
                                                        x.id,
                                                        x.ilce,
                                                        x.sehir
                                                    }).Where(z => z.sehir == secilen).ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtAd.Text!="" & TxtSoyad.Text!="")
            {
                TBLCARI t = new TBLCARI();
                t.AD = TxtAd.Text;
                t.SOYAD = TxtSoyad.Text;
                t.TELEFON = TxtTelefon.Text;
                t.IL = lookUpEditIl.Text;
                t.ILCE = lookUpEditIlce.Text;
                t.BANKA = comboBoxEditBanka.Text;
                t.VERGIDAIRESI = TxtVergiDairesi.Text;
                t.VERGINO = TxtVergiNo.Text;
                t.STATU = comboBoxEditStatu.Text;
                t.ADRES = TxtAdres.Text;
                db.TBLCARI.Add(t);
                db.SaveChanges();
                MessageBox.Show("Cari Sisteme Eklendi.");
                istenilenKategoriGetir();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş.");
            }
            
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            istenilenKategoriGetir();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtId.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            TxtTelefon.Text = "";
            lookUpEditIl.Text = "İl Seçiniz";
            lookUpEditIlce.Text = "İlçe Seçiniz";
            comboBoxEditBanka.Text = "Banka Seçiniz";
            TxtVergiDairesi.Text = "";
            TxtVergiNo.Text = "";
            comboBoxEditStatu.Text = "Statü";
            TxtAdres.Text = "";
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var deger = db.TBLCARI.Find(id);
            deger.AD = TxtAd.Text;
            deger.SOYAD = TxtSoyad.Text;
            deger.TELEFON = TxtTelefon.Text;
            deger.IL = lookUpEditIl.Text;
            deger.ILCE = lookUpEditIlce.Text;
            deger.BANKA = comboBoxEditBanka.EditValue.ToString();
            deger.VERGIDAIRESI = TxtVergiDairesi.Text;
            deger.VERGINO = TxtVergiNo.Text;
            deger.STATU = comboBoxEditStatu.Text.ToString();
            deger.ADRES = TxtAdres.Text;
            
          //  deger.ALISFIYAT = decimal.Parse(TxtAlisFiyat.Text);
           // deger.SATISFIYAT = decimal.Parse(TxtSatisFiyat.Text);
           // deger.ILCE = byte.Parse(lookUpEditIlce.EditValue.ToString());
            db.SaveChanges();
            istenilenKategoriGetir();
            MessageBox.Show("Ürün Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var deger = db.TBLCARI.Find(id);
            db.TBLCARI.Remove(deger);
            db.SaveChanges();
            istenilenKategoriGetir();
            MessageBox.Show("Ürün Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }
    }
}
