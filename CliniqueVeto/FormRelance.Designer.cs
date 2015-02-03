namespace CliniqueVeto
{
    partial class FormRelance
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
            this.LBox_Relances = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LBox_Relances
            // 
            this.LBox_Relances.FormattingEnabled = true;
            this.LBox_Relances.Location = new System.Drawing.Point(13, 13);
            this.LBox_Relances.Name = "LBox_Relances";
            this.LBox_Relances.Size = new System.Drawing.Size(485, 186);
            this.LBox_Relances.TabIndex = 0;
            // 
            // FormRelance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(510, 210);
            this.Controls.Add(this.LBox_Relances);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormRelance";
            this.Text = "Relance";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LBox_Relances;
    }
}