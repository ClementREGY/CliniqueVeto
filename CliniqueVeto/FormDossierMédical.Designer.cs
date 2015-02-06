namespace CliniqueVeto
{
    partial class FormDossierMédical
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
            this.richTBox_Dossier = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTBox_Dossier
            // 
            this.richTBox_Dossier.Location = new System.Drawing.Point(0, 0);
            this.richTBox_Dossier.Name = "richTBox_Dossier";
            this.richTBox_Dossier.Size = new System.Drawing.Size(579, 541);
            this.richTBox_Dossier.TabIndex = 0;
            this.richTBox_Dossier.Text = "";
            // 
            // FormDossierMédical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(579, 541);
            this.Controls.Add(this.richTBox_Dossier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormDossierMédical";
            this.Text = "Dossier Médical";
            this.Load += new System.EventHandler(this.FormDossierMédical_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTBox_Dossier;
    }
}