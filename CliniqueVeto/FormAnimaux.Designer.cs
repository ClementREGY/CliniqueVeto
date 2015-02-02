namespace CliniqueVeto
{
    partial class FormAnimaux
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
            this.Panel_GestionAnimaux = new System.Windows.Forms.Panel();
            this.BTN_Dossier = new System.Windows.Forms.Button();
            this.Panel_GestionAnimaux.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_GestionAnimaux
            // 
            this.Panel_GestionAnimaux.BackColor = System.Drawing.SystemColors.Control;
            this.Panel_GestionAnimaux.Controls.Add(this.BTN_Dossier);
            this.Panel_GestionAnimaux.Location = new System.Drawing.Point(0, 0);
            this.Panel_GestionAnimaux.Name = "Panel_GestionAnimaux";
            this.Panel_GestionAnimaux.Size = new System.Drawing.Size(472, 83);
            this.Panel_GestionAnimaux.TabIndex = 0;
            // 
            // BTN_Dossier
            // 
            this.BTN_Dossier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Dossier.Location = new System.Drawing.Point(12, 12);
            this.BTN_Dossier.Name = "BTN_Dossier";
            this.BTN_Dossier.Size = new System.Drawing.Size(50, 50);
            this.BTN_Dossier.TabIndex = 0;
            this.BTN_Dossier.UseVisualStyleBackColor = true;
            // 
            // FormAnimaux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(472, 362);
            this.Controls.Add(this.Panel_GestionAnimaux);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormAnimaux";
            this.Text = "Animaux";
            this.Panel_GestionAnimaux.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_GestionAnimaux;
        private System.Windows.Forms.Button BTN_Dossier;

    }
}