namespace WFA200114
{
    partial class FrmDiak
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
            this.msFrmDiak = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.nudEvf = new System.Windows.Forms.NumericUpDown();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.cbIsk = new System.Windows.Forms.ComboBox();
            this.KeresesTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.MentesTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.TorlesTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.UresUTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAzon = new System.Windows.Forms.TextBox();
            this.msFrmDiak.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEvf)).BeginInit();
            this.SuspendLayout();
            // 
            // msFrmDiak
            // 
            this.msFrmDiak.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.msFrmDiak.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msFrmDiak.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KeresesTSMI,
            this.MentesTSMI,
            this.TorlesTSMI,
            this.UresUTSMI});
            this.msFrmDiak.Location = new System.Drawing.Point(0, 229);
            this.msFrmDiak.Name = "msFrmDiak";
            this.msFrmDiak.Size = new System.Drawing.Size(406, 64);
            this.msFrmDiak.TabIndex = 0;
            this.msFrmDiak.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Azonosító:";
            // 
            // nudEvf
            // 
            this.nudEvf.Location = new System.Drawing.Point(149, 120);
            this.nudEvf.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.nudEvf.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudEvf.Name = "nudEvf";
            this.nudEvf.Size = new System.Drawing.Size(120, 22);
            this.nudEvf.TabIndex = 2;
            this.nudEvf.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(149, 70);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(224, 22);
            this.tbNev.TabIndex = 3;
            // 
            // cbIsk
            // 
            this.cbIsk.FormattingEnabled = true;
            this.cbIsk.Location = new System.Drawing.Point(149, 166);
            this.cbIsk.Name = "cbIsk";
            this.cbIsk.Size = new System.Drawing.Size(224, 24);
            this.cbIsk.TabIndex = 4;
            // 
            // KeresesTSMI
            // 
            this.KeresesTSMI.Image = global::WFA200114.Properties.Resources.keres;
            this.KeresesTSMI.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.KeresesTSMI.Name = "KeresesTSMI";
            this.KeresesTSMI.Size = new System.Drawing.Size(73, 60);
            this.KeresesTSMI.Text = "Keresés";
            this.KeresesTSMI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.KeresesTSMI.Click += new System.EventHandler(this.KeresesTSMI_Click);
            // 
            // MentesTSMI
            // 
            this.MentesTSMI.Image = global::WFA200114.Properties.Resources.save;
            this.MentesTSMI.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MentesTSMI.Name = "MentesTSMI";
            this.MentesTSMI.Size = new System.Drawing.Size(71, 60);
            this.MentesTSMI.Text = "Mentés";
            this.MentesTSMI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MentesTSMI.Click += new System.EventHandler(this.MentesTSMI_Click);
            // 
            // TorlesTSMI
            // 
            this.TorlesTSMI.Enabled = false;
            this.TorlesTSMI.Image = global::WFA200114.Properties.Resources.delete;
            this.TorlesTSMI.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TorlesTSMI.Name = "TorlesTSMI";
            this.TorlesTSMI.Size = new System.Drawing.Size(62, 60);
            this.TorlesTSMI.Text = "Törlés";
            this.TorlesTSMI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // UresUTSMI
            // 
            this.UresUTSMI.Image = global::WFA200114.Properties.Resources.ures_urlap;
            this.UresUTSMI.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UresUTSMI.Name = "UresUTSMI";
            this.UresUTSMI.Size = new System.Drawing.Size(90, 60);
            this.UresUTSMI.Text = "Üres űrlap";
            this.UresUTSMI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Évfolyam:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Iskola:";
            // 
            // tbAzon
            // 
            this.tbAzon.Enabled = false;
            this.tbAzon.Location = new System.Drawing.Point(149, 25);
            this.tbAzon.Name = "tbAzon";
            this.tbAzon.Size = new System.Drawing.Size(120, 22);
            this.tbAzon.TabIndex = 3;
            // 
            // FrmDiak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 293);
            this.Controls.Add(this.tbAzon);
            this.Controls.Add(this.cbIsk);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.nudEvf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msFrmDiak);
            this.MainMenuStrip = this.msFrmDiak;
            this.Name = "FrmDiak";
            this.Text = "FrmDiak";
            this.Load += new System.EventHandler(this.FrmDiak_Load);
            this.msFrmDiak.ResumeLayout(false);
            this.msFrmDiak.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEvf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msFrmDiak;
        private System.Windows.Forms.ToolStripMenuItem KeresesTSMI;
        private System.Windows.Forms.ToolStripMenuItem MentesTSMI;
        private System.Windows.Forms.ToolStripMenuItem TorlesTSMI;
        private System.Windows.Forms.ToolStripMenuItem UresUTSMI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudEvf;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.ComboBox cbIsk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAzon;
    }
}