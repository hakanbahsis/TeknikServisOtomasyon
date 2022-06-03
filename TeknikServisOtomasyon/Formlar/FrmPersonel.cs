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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        void istenilenKategoriGetir()
        {
            var degerler = from u in db.TBLPERSONEL
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.SOYAD,
                               
                               u.MAIL,
                               u.TELEFON,
                               DEPARTMAN = u.TBLDEPARTMAN.AD
                              
                           };
            gridControl1.DataSource = degerler.ToList();

        }
        private void labelControl15_Click(object sender, EventArgs e)
        {

        }

        private void labelControl14_Click(object sender, EventArgs e)
        {

        }

        private void labelControl13_Click(object sender, EventArgs e)
        {

        }

        private void labelControl8_Click(object sender, EventArgs e)
        {

        }

        private void labelControl12_Click(object sender, EventArgs e)
        {

        }

        private void labelControl9_Click(object sender, EventArgs e)
        {

        }

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            istenilenKategoriGetir();
            
            //LookUpEdit Düzenli Listeleme
            lookUpEditDepartman.Properties.DataSource = (from x in db.TBLDEPARTMAN
                                                         select new
                                                         {
                                                             x.ID,
                                                             x.AD
                                                         }).ToList(); ;
            string ad1, soyad1, dep1, mail1;
            string ad2, soyad2, dep2, mail2;
            //Birinci Personel Fotoğrafı
            ad1 = db.TBLPERSONEL.First(x => x.ID == 1).AD;
            soyad1 = db.TBLPERSONEL.First(x =>x.ID== 1).SOYAD;
            labelControl12.Text = ad1 + " " + soyad1;
            dep1 = db.TBLPERSONEL.First(x => x.ID == 1).TBLDEPARTMAN.AD;
            mail1 = db.TBLPERSONEL.First(x => x.ID == 1).MAIL;
            labelControl13.Text = dep1;
            labelControl15.Text = mail1;
            //İkinci Personel Fotoğrafı
            ad2 = db.TBLPERSONEL.First(x => x.ID == 2).AD;
            soyad2 = db.TBLPERSONEL.First(x => x.ID == 2).SOYAD;
            labelControl18.Text = ad2 + " " + soyad2;
            dep2 = db.TBLPERSONEL.First(x => x.ID == 2).TBLDEPARTMAN.AD;
            mail2 = db.TBLPERSONEL.First(x => x.ID == 2).MAIL;
            labelControl16.Text = dep2;
            labelControl10.Text = mail2;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                TBLPERSONEL t = new TBLPERSONEL();
                t.AD = TxtAd.Text;
                t.SOYAD = TxtSoyad.Text;
                t.DEPARTMAN = byte.Parse(lookUpEditDepartman.EditValue.ToString());
                t.MAIL = TxtMail.Text;
                t.TELEFON = TxtTelefon.Text;
                db.TBLPERSONEL.Add(t);
                db.SaveChanges();
                MessageBox.Show("Personel Sisteme Kaydedildi.");

            }
            catch (Exception)
            {

                MessageBox.Show("Personel Bilgileri Eksik.");
            }
            istenilenKategoriGetir();


        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            istenilenKategoriGetir();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var deger = db.TBLPERSONEL.Find(id);
            db.TBLPERSONEL.Remove(deger);
            db.SaveChanges();
            istenilenKategoriGetir();
            MessageBox.Show("Departman Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TxtId.Text);
                var deger = db.TBLPERSONEL.Find(id);
                deger.AD = TxtAd.Text;
                deger.SOYAD = TxtSoyad.Text;
                deger.DEPARTMAN= byte.Parse(lookUpEditDepartman.EditValue.ToString());
                deger.MAIL = TxtMail.Text;
                deger.TELEFON = TxtTelefon.Text;
                db.SaveChanges();
                MessageBox.Show("Departman Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception)
            {

                MessageBox.Show("Eksik bilgi.");
            }
            istenilenKategoriGetir();
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridControl1.Focused==true)
            {
                try
            {
                    TxtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                    TxtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
                    TxtSoyad.Text = gridView1.GetFocusedRowCellValue("SOYAD").ToString();
                    lookUpEditDepartman.Text = gridView1.GetFocusedRowCellValue("DEPARTMAN").ToString();
                    
                    TxtMail.Text = gridView1.GetFocusedRowCellValue("MAIL").ToString();
                    TxtTelefon.Text = gridView1.GetFocusedRowCellValue("TELEFON").ToString();

            }
            catch (Exception)
            {

                    MessageBox.Show("Hata");
            }
            }
            
            

        }
    }
}
