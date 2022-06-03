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
    public partial class FrmFaturaKalemleri : Form
    {
        public FrmFaturaKalemleri()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtFaturaId.Text);
            var degerler = (from u in db.TBLFATURADETAY
                            select new
                            {
                                u.FATURADETAYID,
                                u.URUN,
                                u.ADET,
                                u.FIYAT,
                                u.TUTAR,
                                u.FATURAID
                            }).Where(x => x.FATURAID == id);
            gridControl1.DataSource = degerler.ToList();

        }

        private void TxtSıraNo_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
