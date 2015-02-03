namespace CliniqueVeto
{
    partial class FormBarèmes
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
            this.LBox_Barèmes = new System.Windows.Forms.ListBox();
            this.BTN_MiseAJour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBox_Barèmes
            // 
            this.LBox_Barèmes.FormattingEnabled = true;
            this.LBox_Barèmes.ItemHeight = 17;
            this.LBox_Barèmes.Location = new System.Drawing.Point(13, 13);
            this.LBox_Barèmes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LBox_Barèmes.Name = "LBox_Barèmes";
            this.LBox_Barèmes.Size = new System.Drawing.Size(513, 208);
            this.LBox_Barèmes.TabIndex = 0;
            // 
            // BTN_MiseAJour
            // 
            this.BTN_MiseAJour.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_MiseAJour.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_MiseAJour.Location = new System.Drawing.Point(412, 239);
            this.BTN_MiseAJour.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_MiseAJour.Name = "BTN_MiseAJour";
            this.BTN_MiseAJour.Size = new System.Drawing.Size(114, 27);
            this.BTN_MiseAJour.TabIndex = 2;
            this.BTN_MiseAJour.Text = "Mettre à Jour";
            this.BTN_MiseAJour.UseVisualStyleBackColor = false;
            // 
            // FormBarèmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(539, 279);
            this.Controls.Add(this.BTN_MiseAJour);
            this.Controls.Add(this.LBox_Barèmes);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormBarèmes";
            this.Text = "Barème de Tarification";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LBox_Barèmes;
        private System.Windows.Forms.Button BTN_MiseAJour;
    }
}