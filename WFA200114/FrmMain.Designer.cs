namespace WFA200114
{
    partial class FrmMain
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
            this.msFrmMain = new System.Windows.Forms.MenuStrip();
            this.iskolákToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diákokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SzerkesztesTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.KeresesTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.feladatokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eredményekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEredmenyek = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msFrmMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEredmenyek)).BeginInit();
            this.SuspendLayout();
            // 
            // msFrmMain
            // 
            this.msFrmMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msFrmMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iskolákToolStripMenuItem,
            this.diákokToolStripMenuItem,
            this.feladatokToolStripMenuItem,
            this.eredményekToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.msFrmMain.Location = new System.Drawing.Point(0, 0);
            this.msFrmMain.Name = "msFrmMain";
            this.msFrmMain.Size = new System.Drawing.Size(661, 92);
            this.msFrmMain.TabIndex = 0;
            this.msFrmMain.Text = "menuStrip1";
            // 
            // iskolákToolStripMenuItem
            // 
            this.iskolákToolStripMenuItem.Image = global::WFA200114.Properties.Resources.school;
            this.iskolákToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iskolákToolStripMenuItem.Name = "iskolákToolStripMenuItem";
            this.iskolákToolStripMenuItem.Size = new System.Drawing.Size(78, 88);
            this.iskolákToolStripMenuItem.Text = "Iskolák";
            this.iskolákToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // diákokToolStripMenuItem
            // 
            this.diákokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SzerkesztesTSMI,
            this.KeresesTSMI});
            this.diákokToolStripMenuItem.Image = global::WFA200114.Properties.Resources.student1;
            this.diákokToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.diákokToolStripMenuItem.Name = "diákokToolStripMenuItem";
            this.diákokToolStripMenuItem.Size = new System.Drawing.Size(78, 88);
            this.diákokToolStripMenuItem.Text = "Diákok";
            this.diákokToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SzerkesztesTSMI
            // 
            this.SzerkesztesTSMI.Name = "SzerkesztesTSMI";
            this.SzerkesztesTSMI.Size = new System.Drawing.Size(165, 26);
            this.SzerkesztesTSMI.Text = "szerkesztés";
            this.SzerkesztesTSMI.Click += new System.EventHandler(this.SzerkesztesTSMI_Click);
            // 
            // KeresesTSMI
            // 
            this.KeresesTSMI.Name = "KeresesTSMI";
            this.KeresesTSMI.Size = new System.Drawing.Size(165, 26);
            this.KeresesTSMI.Text = "keresés";
            this.KeresesTSMI.Click += new System.EventHandler(this.KeresesTSMI_Click);
            // 
            // feladatokToolStripMenuItem
            // 
            this.feladatokToolStripMenuItem.Image = global::WFA200114.Properties.Resources.task;
            this.feladatokToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.feladatokToolStripMenuItem.Name = "feladatokToolStripMenuItem";
            this.feladatokToolStripMenuItem.Size = new System.Drawing.Size(88, 88);
            this.feladatokToolStripMenuItem.Text = "Feladatok";
            this.feladatokToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // eredményekToolStripMenuItem
            // 
            this.eredményekToolStripMenuItem.Image = global::WFA200114.Properties.Resources.results;
            this.eredményekToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.eredményekToolStripMenuItem.Name = "eredményekToolStripMenuItem";
            this.eredményekToolStripMenuItem.Size = new System.Drawing.Size(111, 88);
            this.eredményekToolStripMenuItem.Text = "Eredmények";
            this.eredményekToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Image = global::WFA200114.Properties.Resources.exit;
            this.kilépésToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(78, 88);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "A 1014/15 évi pontverseny rangsora";
            // 
            // dgvEredmenyek
            // 
            this.dgvEredmenyek.AllowUserToAddRows = false;
            this.dgvEredmenyek.AllowUserToDeleteRows = false;
            this.dgvEredmenyek.AllowUserToResizeColumns = false;
            this.dgvEredmenyek.AllowUserToResizeRows = false;
            this.dgvEredmenyek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEredmenyek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEredmenyek.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvEredmenyek.Location = new System.Drawing.Point(15, 147);
            this.dgvEredmenyek.Name = "dgvEredmenyek";
            this.dgvEredmenyek.RowHeadersVisible = false;
            this.dgvEredmenyek.RowHeadersWidth = 51;
            this.dgvEredmenyek.RowTemplate.Height = 24;
            this.dgvEredmenyek.Size = new System.Drawing.Size(634, 291);
            this.dgvEredmenyek.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 1F;
            this.Column1.HeaderText = "Hely";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 3F;
            this.Column2.HeaderText = "Név";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 1F;
            this.Column3.HeaderText = "Pont";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 1F;
            this.Column4.HeaderText = "Évf.";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.FillWeight = 5F;
            this.Column5.HeaderText = "Iskola";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 450);
            this.Controls.Add(this.dgvEredmenyek);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msFrmMain);
            this.MainMenuStrip = this.msFrmMain;
            this.Name = "FrmMain";
            this.Text = "Matematika Pontveseny";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.msFrmMain.ResumeLayout(false);
            this.msFrmMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEredmenyek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msFrmMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEredmenyek;
        private System.Windows.Forms.ToolStripMenuItem iskolákToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diákokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feladatokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eredményekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ToolStripMenuItem SzerkesztesTSMI;
        private System.Windows.Forms.ToolStripMenuItem KeresesTSMI;
    }
}

