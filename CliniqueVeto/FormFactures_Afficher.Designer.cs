namespace CliniqueVeto
{
    partial class FormFactures_Afficher
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
            this.richTBox_Facture = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTBox_Facture
            // 
            this.richTBox_Facture.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTBox_Facture.Location = new System.Drawing.Point(0, 0);
            this.richTBox_Facture.Name = "richTBox_Facture";
            this.richTBox_Facture.Size = new System.Drawing.Size(375, 461);
            this.richTBox_Facture.TabIndex = 0;
            this.richTBox_Facture.Text = "";
            // 
            // FormFactures_Afficher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(375, 461);
            this.Controls.Add(this.richTBox_Facture);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormFactures_Afficher";
            this.Text = "Facture";
            this.Load += new System.EventHandler(this.FormFactures_Afficher_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTBox_Facture;
    }
}