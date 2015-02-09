namespace CliniqueVeto
{
    partial class FormRelance_Vaccin
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
            this.richTBox_Courrier = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTBox_Courrier
            // 
            this.richTBox_Courrier.Location = new System.Drawing.Point(-1, 0);
            this.richTBox_Courrier.Name = "richTBox_Courrier";
            this.richTBox_Courrier.Size = new System.Drawing.Size(582, 480);
            this.richTBox_Courrier.TabIndex = 1;
            this.richTBox_Courrier.Text = "";
            // 
            // FormRelance_Vaccin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(581, 480);
            this.Controls.Add(this.richTBox_Courrier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormRelance_Vaccin";
            this.Text = "Courrier de Relance";
            this.Load += new System.EventHandler(this.FormRelance_Vaccin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTBox_Courrier;
    }
}