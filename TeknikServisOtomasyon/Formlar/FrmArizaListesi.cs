using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisOtomasyon.Formlar
{
    public partial class FrmArizaListesi : Form
    {
        public FrmArizaListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmArizaListesi_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.TBLURUNKABUL
                           select new
                           {
                               x.ISLEMID,
                              
                               CARİ =( x.TBLCARI.AD+" "+ x.TBLCARI.SOYAD).ToUpper(),
                               PERSONEL = x.TBLPERSONEL.AD+" "+x.TBLPERSONEL.SOYAD,     
                               x.GELISTARIHI,
                               x.CIKISTARIHI,
                               x.URUNSERINO,
                               x.URUNDURUMDETAY
                           };
            gridControl1.DataSource = degerler.ToList();
            labelControl3.Text = db.TBLURUNKABUL.Count(x=>x.URUNDURUM==true).ToString();
            labelControl5.Text = db.TBLURUNKABUL.Count(x=>x.URUNDURUM==false).ToString();
            labelControl11.Text = db.TBLURUN.Count().ToString();
            labelControl7.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "Parça Bekliyor").ToString();
            labelControl13.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "Mesaj Bekliyor").ToString();
            labelControl1.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "İptal Bekliyor").ToString();

            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-GQ2CP62\SQLEXPRESS;
                    Initial Catalog=DbTeknikServis;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT URUNDURUMDETAY,COUNT(*) FROM TBLURUNKABUL GROUP BY URUNDURUMDETAY", baglanti);

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Markalar"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            baglanti.Close();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {   // Arıza Listesinde Çift Tıkladığında Ürün KAydı Güncelleme Açılacak.
            FrmArizaDetay fr = new FrmArizaDetay();
            fr.id = gridView1.GetFocusedRowCellValue("ISLEMID").ToString();
            fr.serino = gridView1.GetFocusedRowCellValue("URUNSERINO").ToString();
            fr.durum = gridView1.GetFocusedRowCellValue("URUNDURUMDETAY").ToString();
            fr.tarih = gridView1.GetFocusedRowCellValue("GELISTARIHI").ToString();
            fr.Show();
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
