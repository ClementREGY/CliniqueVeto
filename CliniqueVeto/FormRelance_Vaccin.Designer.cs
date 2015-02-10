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
            this.BTN_EnvoieRelance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTBox_Courrier
            // 
            this.richTBox_Courrier.Location = new System.Drawing.Point(-1, 0);
            this.richTBox_Courrier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTBox_Courrier.Name = "richTBox_Courrier";
            this.richTBox_Courrier.Size = new System.Drawing.Size(609, 519);
            this.richTBox_Courrier.TabIndex = 1;
            this.richTBox_Courrier.Text = "";
            // 
            // BTN_EnvoieRelance
            // 
            this.BTN_EnvoieRelance.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_EnvoieRelance.Location = new System.Drawing.Point(225, 527);
            this.BTN_EnvoieRelance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_EnvoieRelance.Name = "BTN_EnvoieRelance";
            this.BTN_EnvoieRelance.Size = new System.Drawing.Size(156, 30);
            this.BTN_EnvoieRelance.TabIndex = 2;
            this.BTN_EnvoieRelance.Text = "Envoyer la relance";
            this.BTN_EnvoieRelance.UseVisualStyleBackColor = false;
            this.BTN_EnvoieRelance.Click += new System.EventHandler(this.BTN_EnvoieRelance_Click);
            // 
            // FormRelance_Vaccin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(608, 570);
            this.Controls.Add(this.BTN_EnvoieRelance);
            this.Controls.Add(this.richTBox_Courrier);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormRelance_Vaccin";
            this.Text = "Courrier de Relance";
            this.Load += new System.EventHandler(this.FormRelance_Vaccin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTBox_Courrier;
        private System.Windows.Forms.Button BTN_EnvoieRelance;
    }
}