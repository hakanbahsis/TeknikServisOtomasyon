namespace TeknikServisOtomasyon.Formlar
{
    partial class FrmAnaSayfa
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
            this.gridControlKritikSeviye = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControlKritikSeviye = new DevExpress.XtraEditors.GroupControl();
            this.groupControlKategori = new DevExpress.XtraEditors.GroupControl();
            this.gridControlKategori = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControlYapilacaklar = new DevExpress.XtraEditors.GroupControl();
            this.gridControlYapilacaklar = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControlFihrist = new DevExpress.XtraEditors.GroupControl();
            this.gridControlFihrist = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKritikSeviye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlKritikSeviye)).BeginInit();
            this.groupControlKritikSeviye.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlKategori)).BeginInit();
            this.groupControlKategori.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKategori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlYapilacaklar)).BeginInit();
            this.groupControlYapilacaklar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlYapilacaklar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlFihrist)).BeginInit();
            this.groupControlFihrist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFihrist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlKritikSeviye
            // 
            this.gridControlKritikSeviye.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlKritikSeviye.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlKritikSeviye.Location = new System.Drawing.Point(2, 25);
            this.gridControlKritikSeviye.MainView = this.gridView1;
            this.gridControlKritikSeviye.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlKritikSeviye.Name = "gridControlKritikSeviye";
            this.gridControlKritikSeviye.Size = new System.Drawing.Size(896, 281);
            this.gridControlKritikSeviye.TabIndex = 12;
            this.gridControlKritikSeviye.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseBorderColor = true;
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridView1.GridControl = this.gridControlKritikSeviye;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Save;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupControlKritikSeviye
            // 
            this.groupControlKritikSeviye.Controls.Add(this.gridControlKritikSeviye);
            this.groupControlKritikSeviye.Location = new System.Drawing.Point(8, 7);
            this.groupControlKritikSeviye.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControlKritikSeviye.Name = "groupControlKritikSeviye";
            this.groupControlKritikSeviye.Size = new System.Drawing.Size(900, 308);
            this.groupControlKritikSeviye.TabIndex = 13;
            this.groupControlKritikSeviye.Text = "Kritik Seviye";
            // 
            // groupControlKategori
            // 
            this.groupControlKategori.Controls.Add(this.gridControlKategori);
            this.groupControlKategori.Location = new System.Drawing.Point(11, 318);
            this.groupControlKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControlKategori.Name = "groupControlKategori";
            this.groupControlKategori.Size = new System.Drawing.Size(900, 357);
            this.groupControlKategori.TabIndex = 14;
            this.groupControlKategori.Text = "Katefori-Ürün";
            // 
            // gridControlKategori
            // 
            this.gridControlKategori.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlKategori.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlKategori.Location = new System.Drawing.Point(2, 25);
            this.gridControlKategori.MainView = this.gridView2;
            this.gridControlKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlKategori.Name = "gridControlKategori";
            this.gridControlKategori.Size = new System.Drawing.Size(896, 330);
            this.gridControlKategori.TabIndex = 12;
            this.gridControlKategori.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView2.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView2.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.Appearance.Row.Options.UseBorderColor = true;
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridView2.GridControl = this.gridControlKategori;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Save;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // groupControlYapilacaklar
            // 
            this.groupControlYapilacaklar.Controls.Add(this.gridControlYapilacaklar);
            this.groupControlYapilacaklar.Location = new System.Drawing.Point(925, 318);
            this.groupControlYapilacaklar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControlYapilacaklar.Name = "groupControlYapilacaklar";
            this.groupControlYapilacaklar.Size = new System.Drawing.Size(900, 357);
            this.groupControlYapilacaklar.TabIndex = 16;
            this.groupControlYapilacaklar.Text = "Bugün Yapılacaklar";
            // 
            // gridControlYapilacaklar
            // 
            this.gridControlYapilacaklar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlYapilacaklar.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlYapilacaklar.Location = new System.Drawing.Point(2, 25);
            this.gridControlYapilacaklar.MainView = this.gridView3;
            this.gridControlYapilacaklar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlYapilacaklar.Name = "gridControlYapilacaklar";
            this.gridControlYapilacaklar.Size = new System.Drawing.Size(896, 330);
            this.gridControlYapilacaklar.TabIndex = 12;
            this.gridControlYapilacaklar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView3.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView3.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gridView3.Appearance.Row.Options.UseBackColor = true;
            this.gridView3.Appearance.Row.Options.UseBorderColor = true;
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridView3.GridControl = this.gridControlYapilacaklar;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Save;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // groupControlFihrist
            // 
            this.groupControlFihrist.Controls.Add(this.gridControlFihrist);
            this.groupControlFihrist.Location = new System.Drawing.Point(923, 5);
            this.groupControlFihrist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControlFihrist.Name = "groupControlFihrist";
            this.groupControlFihrist.Size = new System.Drawing.Size(900, 308);
            this.groupControlFihrist.TabIndex = 15;
            this.groupControlFihrist.Text = "Fihrist";
            // 
            // gridControlFihrist
            // 
            this.gridControlFihrist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlFihrist.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlFihrist.Location = new System.Drawing.Point(2, 25);
            this.gridControlFihrist.MainView = this.gridView4;
            this.gridControlFihrist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlFihrist.Name = "gridControlFihrist";
            this.gridControlFihrist.Size = new System.Drawing.Size(896, 281);
            this.gridControlFihrist.TabIndex = 12;
            this.gridControlFihrist.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView4.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView4.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gridView4.Appearance.Row.Options.UseBackColor = true;
            this.gridView4.Appearance.Row.Options.UseBorderColor = true;
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridView4.GridControl = this.gridControlFihrist;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Save;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1827, 741);
            this.Controls.Add(this.groupControlYapilacaklar);
            this.Controls.Add(this.groupControlFihrist);
            this.Controls.Add(this.groupControlKategori);
            this.Controls.Add(this.groupControlKritikSeviye);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmAnaSayfa";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.FrmAnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKritikSeviye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlKritikSeviye)).EndInit();
            this.groupControlKritikSeviye.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlKategori)).EndInit();
            this.groupControlKategori.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKategori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlYapilacaklar)).EndInit();
            this.groupControlYapilacaklar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlYapilacaklar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlFihrist)).EndInit();
            this.groupControlFihrist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFihrist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlKritikSeviye;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControlKritikSeviye;
        private DevExpress.XtraEditors.GroupControl groupControlKategori;
        private DevExpress.XtraGrid.GridControl gridControlKategori;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GroupControl groupControlYapilacaklar;
        private DevExpress.XtraGrid.GridControl gridControlYapilacaklar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.GroupControl groupControlFihrist;
        private DevExpress.XtraGrid.GridControl gridControlFihrist;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
    }
}