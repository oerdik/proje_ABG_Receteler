using proje_ABG_Recete.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_ABG_Recete.Formlar
{
    public partial class FrmUrunReceteList : Form
    {
        DbAgrobestGrupReceteEntities db = new DbAgrobestGrupReceteEntities();
        public FrmUrunReceteList()
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


        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            lblUrunId.Text = gridView1.GetFocusedRowCellValue("UrunId").ToString();
            lblUrunAdi.Text = gridView1.GetFocusedRowCellValue("UrunAdi").ToString();
            lblRuhsat.Text = gridView1.GetFocusedRowCellValue("RuhsatSahibi").ToString();
            double toplam = 0;
            BilesenList b = new BilesenList();
            foreach (var item in db.BilesenList)
            {
                if (item.UrunId==Convert.ToInt16(lblUrunId.Text))
                {
                    lstRecete.Items.Add( item.BilesenAdi + "       " + item.BilesenOrani);
                    toplam = toplam + Convert.ToDouble(item.BilesenOrani);
                }
            }
            lblGenelToplam.Text = Convert.ToString(toplam);
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double toplam = 0;
            lstRecete.Items.Clear();
            int miktar = Convert.ToInt32(txtMiktar.Text);
            BilesenList b = new BilesenList();
            foreach (var item in db.BilesenList)
            {
                if (item.UrunId == Convert.ToInt16(lblUrunId.Text))
                {
                    lstRecete.Items.Add(item.BilesenAdi + "       " + item.BilesenOrani*miktar);
                    toplam = toplam + Convert.ToDouble(item.BilesenOrani);
                }
            }
            lblGenelToplam.Text = Convert.ToString(toplam*miktar);
        }
    }
}
