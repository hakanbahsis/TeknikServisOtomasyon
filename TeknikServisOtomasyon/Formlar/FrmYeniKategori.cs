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
    public partial class FrmYeniKategori : Form
    {
        public FrmYeniKategori()
        {
            InitializeComponent();
        }

        private void textEdit7_EditValueChanged(object sender, EventArgs e)
        {

        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtKategoriAd.Text!="" && TxtKategoriAd.Text.Length<=30)
            {
                TBLKATEGORI t = new TBLKATEGORI();
                t.AD = TxtKategoriAd.Text;
                db.TBLKATEGORI.Add(t);
                db.SaveChanges();
                MessageBox.Show("Kategori Başarıyla Kaydedildi.");
            }
            else
            {
                MessageBox.Show("Lütfen Karakter Sayısını 0-30 Aralığında Giriniz.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        private void FrmYeniKategori_Load(object sender, EventArgs e)
        {

        }

        private void pictureEdit2_Properties_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtKategoriAd_Click(object sender, EventArgs e)
        {
            TxtKategoriAd.Text = "";
        }
    }
}
