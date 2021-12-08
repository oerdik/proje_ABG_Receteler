namespace proje_ABG_Recete.Formlar
{
    partial class frmSarjNoOlustur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSarjNoOlustur));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblUrunAdi = new DevExpress.XtraEditors.LabelControl();
            this.lblUrunId = new DevExpress.XtraEditors.LabelControl();
            this.lblUrunKoduu = new DevExpress.XtraEditors.LabelControl();
            this.lblRuhsatSahibi = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblUrunBoyut = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtHat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtMiktar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.btnYazdir = new DevExpress.XtraEditors.SimpleButton();
            this.btnSarjNoOlustur = new DevExpress.XtraEditors.SimpleButton();
            this.cmbMiadi = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblSKT = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.dateEditUT = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSarjNo = new DevExpress.XtraEditors.TextEdit();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.lstRecete = new System.Windows.Forms.ListBox();
            this.lstBilesen = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMiadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditUT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditUT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSarjNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstBilesen)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(588, 821);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(141, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(181, 25);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "ŞARJ NO OLUŞTUR";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(14, 130);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 19);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Ürün Adı:";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAdi.Appearance.Options.UseFont = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(141, 130);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(0, 19);
            this.lblUrunAdi.TabIndex = 3;
            // 
            // lblUrunId
            // 
            this.lblUrunId.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunId.Appearance.Options.UseFont = true;
            this.lblUrunId.Location = new System.Drawing.Point(143, 100);
            this.lblUrunId.Name = "lblUrunId";
            this.lblUrunId.Size = new System.Drawing.Size(0, 19);
            this.lblUrunId.TabIndex = 7;
            // 
            // lblUrunKoduu
            // 
            this.lblUrunKoduu.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunKoduu.Appearance.Options.UseFont = true;
            this.lblUrunKoduu.Location = new System.Drawing.Point(14, 100);
            this.lblUrunKoduu.Name = "lblUrunKoduu";
            this.lblUrunKoduu.Size = new System.Drawing.Size(61, 19);
            this.lblUrunKoduu.TabIndex = 6;
            this.lblUrunKoduu.Text = "Ürün Id:";
            // 
            // lblRuhsatSahibi
            // 
            this.lblRuhsatSahibi.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRuhsatSahibi.Appearance.Options.UseFont = true;
            this.lblRuhsatSahibi.Location = new System.Drawing.Point(141, 188);
            this.lblRuhsatSahibi.Name = "lblRuhsatSahibi";
            this.lblRuhsatSahibi.Size = new System.Drawing.Size(0, 19);
            this.lblRuhsatSahibi.TabIndex = 9;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(14, 188);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(102, 19);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Ruhsat Sahibi:";
            // 
            // lblUrunBoyut
            // 
            this.lblUrunBoyut.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunBoyut.Appearance.Options.UseFont = true;
            this.lblUrunBoyut.Location = new System.Drawing.Point(141, 159);
            this.lblUrunBoyut.Name = "lblUrunBoyut";
            this.lblUrunBoyut.Size = new System.Drawing.Size(0, 19);
            this.lblUrunBoyut.TabIndex = 11;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(14, 159);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(95, 19);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Ürün Boyutu:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.txtHat);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtMiktar);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.btnYazdir);
            this.groupControl1.Controls.Add(this.btnSarjNoOlustur);
            this.groupControl1.Controls.Add(this.cmbMiadi);
            this.groupControl1.Controls.Add(this.lblSKT);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.dateEditUT);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtSarjNo);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.lblUrunBoyut);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.lblUrunAdi);
            this.groupControl1.Controls.Add(this.lblRuhsatSahibi);
            this.groupControl1.Controls.Add(this.lblUrunKoduu);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.lblUrunId);
            this.groupControl1.Location = new System.Drawing.Point(623, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(495, 607);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "Şarj No Oluştur";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(14, 392);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(86, 19);
            this.labelControl9.TabIndex = 23;
            this.labelControl9.Text = "Üretim Hattı";
            // 
            // txtHat
            // 
            this.txtHat.Location = new System.Drawing.Point(143, 394);
            this.txtHat.Name = "txtHat";
            this.txtHat.Size = new System.Drawing.Size(122, 20);
            this.txtHat.TabIndex = 22;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(14, 347);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(100, 19);
            this.labelControl8.TabIndex = 21;
            this.labelControl8.Text = "Üretim Miktarı";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(143, 349);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(122, 20);
            this.txtMiktar.TabIndex = 20;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(273, 270);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(98, 19);
            this.labelControl12.TabIndex = 19;
            this.labelControl12.Text = "Son K. Tarihi:";
            // 
            // btnYazdir
            // 
            this.btnYazdir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnYazdir.ImageOptions.SvgImage")));
            this.btnYazdir.Location = new System.Drawing.Point(141, 503);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(149, 63);
            this.btnYazdir.TabIndex = 14;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // btnSarjNoOlustur
            // 
            this.btnSarjNoOlustur.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSarjNoOlustur.ImageOptions.SvgImage")));
            this.btnSarjNoOlustur.Location = new System.Drawing.Point(141, 441);
            this.btnSarjNoOlustur.Name = "btnSarjNoOlustur";
            this.btnSarjNoOlustur.Size = new System.Drawing.Size(124, 45);
            this.btnSarjNoOlustur.TabIndex = 18;
            this.btnSarjNoOlustur.Text = "Şarj No Oluştur";
            this.btnSarjNoOlustur.Click += new System.EventHandler(this.btnSarjNoOlustur_Click);
            // 
            // cmbMiadi
            // 
            this.cmbMiadi.Location = new System.Drawing.Point(141, 309);
            this.cmbMiadi.Name = "cmbMiadi";
            this.cmbMiadi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMiadi.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbMiadi.Size = new System.Drawing.Size(124, 20);
            this.cmbMiadi.TabIndex = 17;
            // 
            // lblSKT
            // 
            this.lblSKT.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSKT.Appearance.Options.UseFont = true;
            this.lblSKT.Location = new System.Drawing.Point(377, 273);
            this.lblSKT.Name = "lblSKT";
            this.lblSKT.Size = new System.Drawing.Size(23, 16);
            this.lblSKT.TabIndex = 0;
            this.lblSKT.Text = "SKT";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(14, 307);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(91, 19);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "Miadi Süresi:";
            // 
            // dateEditUT
            // 
            this.dateEditUT.EditValue = null;
            this.dateEditUT.Location = new System.Drawing.Point(143, 267);
            this.dateEditUT.Name = "dateEditUT";
            this.dateEditUT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditUT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditUT.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.ClassicNew;
            this.dateEditUT.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateEditUT.Size = new System.Drawing.Size(122, 20);
            this.dateEditUT.TabIndex = 15;
            this.dateEditUT.EditValueChanged += new System.EventHandler(this.dateEdit1_EditValueChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(14, 265);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(100, 19);
            this.labelControl6.TabIndex = 14;
            this.labelControl6.Text = "Üretim Tarihi:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(14, 224);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 19);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Şarj NO:";
            // 
            // txtSarjNo
            // 
            this.txtSarjNo.Location = new System.Drawing.Point(141, 223);
            this.txtSarjNo.Name = "txtSarjNo";
            this.txtSarjNo.Size = new System.Drawing.Size(124, 20);
            this.txtSarjNo.TabIndex = 12;
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.lstRecete);
            this.groupControl4.Controls.Add(this.lstBilesen);
            this.groupControl4.Location = new System.Drawing.Point(1168, 12);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(397, 243);
            this.groupControl4.TabIndex = 16;
            this.groupControl4.Text = "groupControl4";
            this.groupControl4.Visible = false;
            // 
            // lstRecete
            // 
            this.lstRecete.FormattingEnabled = true;
            this.lstRecete.Location = new System.Drawing.Point(46, 150);
            this.lstRecete.Name = "lstRecete";
            this.lstRecete.Size = new System.Drawing.Size(294, 82);
            this.lstRecete.TabIndex = 1;
            // 
            // lstBilesen
            // 
            this.lstBilesen.Location = new System.Drawing.Point(46, 26);
            this.lstBilesen.Name = "lstBilesen";
            this.lstBilesen.Size = new System.Drawing.Size(294, 107);
            this.lstBilesen.TabIndex = 0;
            // 
            // frmSarjNoOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1642, 861);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmSarjNoOlustur";
            this.Text = "frmSarjNoOlustur";
            this.Load += new System.EventHandler(this.frmSarjNoOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMiadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditUT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditUT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSarjNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstBilesen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblUrunAdi;
        private DevExpress.XtraEditors.LabelControl lblUrunId;
        private DevExpress.XtraEditors.LabelControl lblUrunKoduu;
        private DevExpress.XtraEditors.LabelControl lblRuhsatSahibi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lblUrunBoyut;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.DateEdit dateEditUT;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtSarjNo;
        private DevExpress.XtraEditors.SimpleButton btnSarjNoOlustur;
        private DevExpress.XtraEditors.ComboBoxEdit cmbMiadi;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private DevExpress.XtraEditors.SimpleButton btnYazdir;
        private DevExpress.XtraEditors.LabelControl lblSKT;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.ListBoxControl lstBilesen;
        private System.Windows.Forms.ListBox lstRecete;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtMiktar;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtHat;
    }
}