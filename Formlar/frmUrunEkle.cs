using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using proje_ABG_Recete.Entity;

namespace proje_ABG_Recete.Formlar
{
    public partial class frmUrunEkle : Form
    {
        DbAgrobestGrupReceteEntities db = new DbAgrobestGrupReceteEntities();
        public frmUrunEkle()
        {
            InitializeComponent();
           
            var degerler = (from x in db.UrunList
                            select new
                            {
                                x.UrunId,
                                x.UrunAdi,
                                x.RuhsatSahibi,
                                x.UrunBoyutu
                            }).ToList();
            gridControl1.DataSource = degerler;
        }

     

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

    

        private void btnUrunEkle_Click_1(object sender, EventArgs e)
        {
            UrunList u = new UrunList();
            u.UrunAdi = txtUrunAdi.Text;
            u.RuhsatSahibi = cmbRuhsatSahibi.Text;
            u.UrunBoyutu = cmbUrunBoyutu.Text;
            db.UrunList.Add(u);
            db.SaveChanges();
            XtraMessageBox.Show("Ürün Başarılı Bir Şekilde Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

        }

        private void btnBilesenEkle_Click(object sender, EventArgs e)
        {
            short urunId;
            urunId = Convert.ToInt16(txtUrunID.Text);
            decimal bilesenOran = Convert.ToDecimal(txtBilesenOrani.Text);
            BilesenList b = new BilesenList();
            b.UrunId =urunId;
            b.BilesenAdi = txtBilesenAdi.Text;
            b.BilesenOrani = bilesenOran;
            db.BilesenList.Add(b);
            db.SaveChanges();
            XtraMessageBox.Show("Bileşen Başarılı Bir Şekilde Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
