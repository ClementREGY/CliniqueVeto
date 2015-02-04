namespace CliniqueVeto
{
    partial class FormVétérinaires
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVétérinaires));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBt_Ajouter = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBt_Suppr = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBt_Reinit = new System.Windows.Forms.ToolStripButton();
            this.LBox_Vetos = new System.Windows.Forms.ListBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBt_Ajouter,
            this.toolStripSeparator1,
            this.toolStripBt_Suppr,
            this.toolStripSeparator2,
            this.toolStripBt_Reinit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(242, 57);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBt_Ajouter
            // 
            this.toolStripBt_Ajouter.AutoSize = false;
            this.toolStripBt_Ajouter.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBt_Ajouter.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBt_Ajouter.Image")));
            this.toolStripBt_Ajouter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBt_Ajouter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBt_Ajouter.Name = "toolStripBt_Ajouter";
            this.toolStripBt_Ajouter.Size = new System.Drawing.Size(75, 54);
            this.toolStripBt_Ajouter.Text = "Ajouter";
            this.toolStripBt_Ajouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBt_Ajouter.Click += new System.EventHandler(this.toolStripBt_Ajouter_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 57);
            // 
            // toolStripBt_Suppr
            // 
            this.toolStripBt_Suppr.AutoSize = false;
            this.toolStripBt_Suppr.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBt_Suppr.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBt_Suppr.Image")));
            this.toolStripBt_Suppr.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBt_Suppr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBt_Suppr.Name = "toolStripBt_Suppr";
            this.toolStripBt_Suppr.Size = new System.Drawing.Size(75, 54);
            this.toolStripBt_Suppr.Text = "Supprimer";
            this.toolStripBt_Suppr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBt_Suppr.Click += new System.EventHandler(this.toolStripBt_Suppr_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 57);
            // 
            // toolStripBt_Reinit
            // 
            this.toolStripBt_Reinit.AutoSize = false;
            this.toolStripBt_Reinit.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBt_Reinit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBt_Reinit.Image")));
            this.toolStripBt_Reinit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBt_Reinit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBt_Reinit.Name = "toolStripBt_Reinit";
            this.toolStripBt_Reinit.Size = new System.Drawing.Size(75, 54);
            this.toolStripBt_Reinit.Text = "Réinitialiser";
            this.toolStripBt_Reinit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBt_Reinit.Click += new System.EventHandler(this.toolStripBt_Reinit_Click);
            // 
            // LBox_Vetos
            // 
            this.LBox_Vetos.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBox_Vetos.FormattingEnabled = true;
            this.LBox_Vetos.ItemHeight = 17;
            this.LBox_Vetos.Location = new System.Drawing.Point(12, 71);
            this.LBox_Vetos.Name = "LBox_Vetos";
            this.LBox_Vetos.Size = new System.Drawing.Size(218, 293);
            this.LBox_Vetos.TabIndex = 1;
            // 
            // FormVétérinaires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(242, 376);
            this.Controls.Add(this.LBox_Vetos);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormVétérinaires";
            this.Text = "Vétérinaires";
            this.Load += new System.EventHandler(this.FormVétérinaires_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBt_Ajouter;
        private System.Windows.Forms.ToolStripButton toolStripBt_Suppr;
        private System.Windows.Forms.ToolStripButton toolStripBt_Reinit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ListBox LBox_Vetos;
    }
}