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
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            gridControlKritikSeviye.DataSource = (from x in db.TBLURUN
                                                  select new
                                                  {
                                                      x.AD,
                                                      KATEGORI=x.TBLKATEGORI.AD,
                                                      x.STOK
                                                  }).Where(x => x.STOK < 30).ToList();
            gridControlFihrist.DataSource = (from y in db.TBLCARI
                                             select new
                                             {
                                                 y.AD,
                                                 y.SOYAD,
                                                 y.IL
                                             }).ToList();
            gridControlKategori.DataSource = db.urunkategori().ToList();

            DateTime bugun = DateTime.Today;
            var deger = (from x in db.TBLNOTLARIM.OrderBy(y => y.ID)
                         where (x.TARIH == bugun)
                         select new
                         {
                             
                             x.BASLIK,
                             x.ICERIK
                         });
            gridControlYapilacaklar.DataSource = deger.ToList();
        }
    }
}
