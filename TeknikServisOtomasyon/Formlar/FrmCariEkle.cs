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
    public partial class FrmCariEkle : Form
    {
        public FrmCariEkle()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        int secilen;
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                TBLCARI t = new TBLCARI();
                 t.AD = TxtAd.Text;
                 t.SOYAD = TxtSoyad.Text;
                 t.IL = lookUpEditIl.Text;
                 t.ILCE = lookUpEditIlce.Text;
                t.BANKA = comboBoxEdit1.Text;
                 db.TBLCARI.Add(t);
                 db.SaveChanges();
                    MessageBox.Show("Yeni Cari Sisteme Başarıyla Kaydedildi.", "Bilgi",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("Bilgiler Eksik.");
            }
           

        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureEdit14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCariEkle_Load(object sender, EventArgs e)
        {
            lookUpEditIl.Properties.DataSource = (from x in db.TBLILLER
                                                  select new
                                                  {
                                                      x.id,
                                                      x.sehir
                                                  }).ToList(); ;
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

        private void TxtAd_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtAd_Click(object sender, EventArgs e)
        {
            TxtAd.Text = "";
            TxtAd.Focus();
        }

        private void TxtSoyad_Click(object sender, EventArgs e)
        {
            TxtSoyad.Text = "";
            TxtSoyad.Focus();
        }

        private void TxtTelefon_Click(object sender, EventArgs e)
        {
            TxtTelefon.Text = "";
            TxtTelefon.Focus();
        }

        private void TxtMail_Click(object sender, EventArgs e)
        {
            TxtMail.Text = "";
            TxtMail.Focus();

        }

        private void TxtBanka_Click(object sender, EventArgs e)
        {

        }

        private void TxtVergiDairesi_Click(object sender, EventArgs e)
        {
            TxtVergiDairesi.Text = "";
            TxtVergiDairesi.Focus();
        }

        private void TxtVergiNumarası_Click(object sender, EventArgs e)
        {
            TxtVergiNumarası.Text = "";
            TxtVergiNumarası.Focus();
       
        }

        private void TxtStatu_Click(object sender, EventArgs e)
        {

        }

        private void TxtAdres_Click(object sender, EventArgs e)
        {
            TxtAdres.Text = "";
            TxtAdres.Focus();
        }

        private void TxtAciklama_Click(object sender, EventArgs e)
        {
            TxtAciklama.Text = "";
            TxtAciklama.Focus();
        }
    }
}
