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
    public partial class FrmFaturaListesi : Form
    {
        public FrmFaturaListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        void istenilenKategoriGetir()
        {
            var degerler = from u in db.TBLFATURABILGI
                           select new
                           {
                               u.ID,
                               u.SERI,
                               u.SIRANO,
                               u.TARIH,
                               u.SAAT,
                               u.VERGIDAIRE,
                               CARI=u.TBLCARI.AD+" "+u.TBLCARI.SOYAD,
                               PERSONEL=u.TBLPERSONEL.AD+" "+u.TBLPERSONEL.SOYAD
                              
                               //CARI=u.TBLCARI.AD+" "+u.TBLCARI.SOYAD,
                             //  PERSONEL=u.TBLPERSONEL.AD+" "+u.TBLPERSONEL.SOYAD
                           };
            gridControl1.DataSource = degerler.ToList();

        }
        private void FrmFaturaListesi_Load(object sender, EventArgs e)
        {
            istenilenKategoriGetir();
            //LookUpEdit Düzenli Listeleme
            lookUpEditCari.Properties.DataSource = (from x in db.TBLCARI
                                                         select new
                                                         {
                                                             x.ID,
                                                             CARI=x.AD+" "+x.SOYAD
                                                         }).ToList(); 

            lookUpEditPersonel.Properties.DataSource = (from x in db.TBLPERSONEL
                                                        select new
                                                        {
                                                            x.ID,
                                                            PERSONEL = x.AD + " " + x.SOYAD
                                                        }).ToList();
            gridControl1.DataSource = db.TBLFATURABILGI.ToList();

            
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            istenilenKategoriGetir();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLFATURABILGI t = new TBLFATURABILGI();
            t.SERI = TxtSeri.Text;
            t.SIRANO = TxtSıraNo.Text;
            t.TARIH = Convert.ToDateTime(TxtTarih.Text);
            t.SAAT = TxtSaat.Text;
            t.VERGIDAIRE = TxtVergiDairesi.Text;
            t.CARI = int.Parse(lookUpEditCari.EditValue.ToString());
            t.PERSONEL = short.Parse(lookUpEditPersonel.EditValue.ToString());
            db.TBLFATURABILGI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Fatura Sisteme Kaydedildi.Kalem Girişi Yapabilirsiniz.");
            istenilenKategoriGetir();
        }

        
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaKalemCıktı fr = new FrmFaturaKalemCıktı();
            fr.id =int.Parse (gridView1.GetFocusedRowCellValue("ID").ToString());
           // fr.serino = short.Parse(gridView1.GetFocusedRowCellValue("SERI").ToString());
           
            fr.Show();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridControl1.Focused==true)
            {
                try
                {
                    TxtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                    TxtSeri.Text = gridView1.GetFocusedRowCellValue("SERI").ToString();
                    TxtSıraNo.Text = gridView1.GetFocusedRowCellValue("SIRANO").ToString();
                    TxtTarih.Text = gridView1.GetFocusedRowCellValue("TARIH").ToString();
                    TxtSaat.Text = gridView1.GetFocusedRowCellValue("SAAT").ToString();
                    TxtVergiDairesi.Text = gridView1.GetFocusedRowCellValue("VERGIDAIRE").ToString();
                    lookUpEditCari.Text = gridView1.GetFocusedRowCellValue("CARI").ToString();
                    lookUpEditPersonel.Text = gridView1.GetFocusedRowCellValue("PERSONEL").ToString();
                   


                }
                catch (Exception)
                {

                    MessageBox.Show("Hata");
                }
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtId.Text = "";
            TxtSeri.Text = "";
            TxtSıraNo.Text = "";
            TxtTarih.Text = "";
            TxtSaat.Text = "";
            TxtVergiDairesi.Text = "";
            lookUpEditCari.Text = "CARI";
            lookUpEditPersonel.Text = "PERSONEL";
        }

        private void TxtSıraNo_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
