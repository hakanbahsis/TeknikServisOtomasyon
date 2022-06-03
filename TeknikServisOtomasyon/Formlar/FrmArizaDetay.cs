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
    public partial class FrmArizaDetay : Form
    {
        public FrmArizaDetay()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DbTeknikServisEntities db = new DbTeknikServisEntities();
            TBLURUNTAKIP t = new TBLURUNTAKIP();
            t.ACIKLAMA = richTextBox1.Text;
            t.SERINO = TxtSeriNo.Text;
            t.TARIH = DateTime.Parse(TxtTarih.Text);
            t.URUNDURUMU = comboBoxEdit1.Text;
            db.TBLURUNTAKIP.Add(t);

            //2.güncelleme
            TBLURUNKABUL tb = new TBLURUNKABUL();
            int urunid = int.Parse(id.ToString());
            var deger = db.TBLURUNKABUL.Find(urunid);
            deger.URUNDURUMDETAY = comboBoxEdit1.Text;
            db.SaveChanges();
            MessageBox.Show("Ürün Arıza Detayı Güncellendi.");
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtTarih_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtTarih_Click(object sender, EventArgs e)
        {
            TxtSeriNo.Text = "";
        }

        private void TxtTarih_Click_1(object sender, EventArgs e)
        {
            TxtTarih.Text = DateTime.Now.ToShortDateString();
        }

        //Arıza listesinde Çift Tıkladığında Ürün Kaydına Seri No Yazdırma
        public string id,serino,durum,tarih;
        
        private void FrmArizaDetay_Load(object sender, EventArgs e)
        {
            TxtSeriNo.Text = serino;
            comboBoxEdit1.Text = durum;
            TxtTarih.Text = tarih;
        }
    }
}
