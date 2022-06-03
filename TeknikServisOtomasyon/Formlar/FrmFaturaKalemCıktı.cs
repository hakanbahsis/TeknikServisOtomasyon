using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TeknikServisOtomasyon.Formlar
{
    public partial class FrmFaturaKalemCıktı : Form
    {
        public FrmFaturaKalemCıktı()
        {
            InitializeComponent();
        }

        public int id,serino;
        private string dosyayolum;
        private string pdfyeniyol;

        private void FrmFaturaKalemCıktı_Load(object sender, EventArgs e)
        {
            //labelControl1.Text = id.ToString();
            DbTeknikServisEntities db = new DbTeknikServisEntities();
            gridControl1.DataSource = (from x in db.TBLFATURADETAY.Where(x => x.FATURAID == id)
                                       select new {
                                           x.URUN,
                                           x.ADET,
                                           x.FIYAT,
                                           x.TUTAR
                                       }).ToList();
            gridControl2.DataSource = (from x in db.TBLFATURABILGI.Where(x => x.ID == id)
                                       select new
                                       {
                                           x.ID,
                                           x.SERI,
                                           x.SIRANO,
                                           x.TARIH,
                                           x.SAAT,
                                           x.VERGIDAIRE,
                                           CARI = x.TBLCARI.AD + " " + x.TBLCARI.SOYAD,
                                           PERSONEL = x.TBLPERSONEL.AD + " " + x.TBLPERSONEL.SOYAD,
                                            //Fatura toplamını yazdırma
                                           FATURATUTARI = (from y in db.TBLFATURADETAY.Where(y=>y.FATURAID==id)
                                                           select  y.TUTAR).Sum().ToString()
                                       }
                                       ).ToList();
           



            string seri, sirano;
            seri = db.TBLFATURABILGI.First(x => x.ID == id).SERI;
            sirano = db.TBLFATURABILGI.First(x => x.ID == id).SIRANO;
            labelControlFatura.Text = seri + "" + sirano + " Numaralı Fatura";

        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            OpenFileDialog filer = new OpenFileDialog();
            filer.Filter = "PDF Files|*.pdf";
            filer.Title = "PDF Dosyası Seçiniz..";
            filer.ShowDialog();
            dosyayolum = filer.FileName;
            pdfyeniyol = Application.StartupPath + "\\pdf\\" + Guid.NewGuid().ToString() + ".pdf";
            File.Create(pdfyeniyol);
            //string dosyaYolu = "Dosya1.pdf";
            // gridControl2.ExportToPdf(dosyaYolu);
        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            string dosyaYolu = "Dosya1.xls";
            gridControl2.ExportToXls(dosyaYolu);
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
