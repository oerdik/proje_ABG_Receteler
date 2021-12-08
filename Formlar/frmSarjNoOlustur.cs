using DevExpress.XtraEditors;
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
using wordeaktar = Microsoft.Office.Interop.Word;
using System.Reflection;
using System.IO;

namespace proje_ABG_Recete.Formlar
{
    public partial class frmSarjNoOlustur : Form
    {
        DbAgrobestGrupReceteEntities db = new DbAgrobestGrupReceteEntities();
        public frmSarjNoOlustur()
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

        private void frmSarjNoOlustur_Load(object sender, EventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            lstRecete.Items.Clear();
            lblUrunId.Text = gridView1.GetFocusedRowCellValue("UrunId").ToString();
            lblUrunAdi.Text = gridView1.GetFocusedRowCellValue("UrunAdi").ToString();
            lblRuhsatSahibi.Text = gridView1.GetFocusedRowCellValue("RuhsatSahibi").ToString();
            lblUrunBoyut.Text = gridView1.GetFocusedRowCellValue("UrunBoyutu").ToString();
            BilesenList b = new BilesenList();
            foreach (var item in db.BilesenList)
            {
                if (item.UrunId == Convert.ToInt16(lblUrunId.Text))
                {
                    lstRecete.Items.Add(item.BilesenAdi + "       " + item.BilesenOrani);
                    
                }
            }

        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSarjNoOlustur_Click(object sender, EventArgs e)
        {
            lstRecete.Items.Clear();
            DateTime date = new DateTime();
            date = dateEditUT.DateTime.AddYears(Convert.ToByte(cmbMiadi.Text));
            tblSarjNo tbl = new tblSarjNo();
            tbl.UrunId = Convert.ToInt16(lblUrunId.Text);
            tbl.SarjNo = txtSarjNo.Text;
            tbl.UrtTarihi = dateEditUT.DateTime;
            tbl.MiadiOmru = Convert.ToByte(cmbMiadi.Text);
            lblSKT.Text = Convert.ToString(date.ToShortDateString());
            db.tblSarjNo.Add(tbl);
            db.SaveChanges();
            XtraMessageBox.Show("Şarj NO Başarılı Bir Şekilde Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            int miktar = Convert.ToInt32(txtMiktar.Text);
            BilesenList b = new BilesenList();
            foreach (var item in db.BilesenList)
            {
                if (item.UrunId == Convert.ToInt16(lblUrunId.Text))
                {
                    lstRecete.Items.Add(item.BilesenAdi + "       " + item.BilesenOrani * miktar);
                    
                }
            }
        }

        private void tablePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDolumFormu_Click(object sender, EventArgs e)
        {
         

        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            string template = @Path.GetDirectoryName(Application.ExecutablePath).Trim() + "\\Template.docx";
            wordeaktar.Application wordapp = new wordeaktar.Application();
            wordapp.Visible = true;
            wordeaktar.Document worddoc = wordapp.Documents.OpenNoRepairDialog(template);
            worddoc.Activate();
            wordeaktar.Table table = worddoc.Tables[1];
            table.Cell(1, 2).Range.Text = lblUrunAdi.Text;
            table.Cell(2, 2).Range.Text = lblRuhsatSahibi.Text;
            table.Cell(3, 2).Range.Text = lblUrunBoyut.Text;
            wordeaktar.Table table2 = worddoc.Tables[2];
            table2.Cell(1, 2).Range.Text = txtSarjNo.Text;
            table2.Cell(2, 2).Range.Text = dateEditUT.Text;
            table2.Cell(3, 2).Range.Text = lblSKT.Text;
            table2.Cell(4, 2).Range.Text = txtMiktar.Text;
            table2.Cell(5, 2).Range.Text = txtHat.Text;
            wordeaktar.Table table3 = worddoc.Tables[3];

           
                for (int r = 0; r < 7; r++)
                {

                    table3.Cell(r,1).Range.Text =lstRecete.Items[r].ToString();
                }
           
                    
             
        }
    }
}
