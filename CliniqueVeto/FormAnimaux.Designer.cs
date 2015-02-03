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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnimaux));
            this.Panel_GestionAnimaux = new System.Windows.Forms.Panel();
            this.BTN_Dossier = new System.Windows.Forms.Button();
            this.BTN_Valider = new System.Windows.Forms.Button();
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.Label_Dossier = new System.Windows.Forms.Label();
            this.Label_Valider = new System.Windows.Forms.Label();
            this.Label_Annuler = new System.Windows.Forms.Label();
            this.Panel_GestionAnimaux.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_GestionAnimaux
            // 
            this.Panel_GestionAnimaux.BackColor = System.Drawing.SystemColors.Control;
            this.Panel_GestionAnimaux.Controls.Add(this.Label_Annuler);
            this.Panel_GestionAnimaux.Controls.Add(this.Label_Valider);
            this.Panel_GestionAnimaux.Controls.Add(this.Label_Dossier);
            this.Panel_GestionAnimaux.Controls.Add(this.BTN_Annuler);
            this.Panel_GestionAnimaux.Controls.Add(this.BTN_Valider);
            this.Panel_GestionAnimaux.Controls.Add(this.BTN_Dossier);
            this.Panel_GestionAnimaux.Location = new System.Drawing.Point(0, 0);
            this.Panel_GestionAnimaux.Name = "Panel_GestionAnimaux";
            this.Panel_GestionAnimaux.Size = new System.Drawing.Size(472, 83);
            this.Panel_GestionAnimaux.TabIndex = 0;
            // 
            // BTN_Dossier
            // 
            this.BTN_Dossier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Dossier.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Dossier.Image")));
            this.BTN_Dossier.Location = new System.Drawing.Point(38, 12);
            this.BTN_Dossier.Name = "BTN_Dossier";
            this.BTN_Dossier.Size = new System.Drawing.Size(50, 50);
            this.BTN_Dossier.TabIndex = 0;
            this.BTN_Dossier.UseVisualStyleBackColor = true;
            // 
            // BTN_Valider
            // 
            this.BTN_Valider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Valider.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Valider.Image")));
            this.BTN_Valider.Location = new System.Drawing.Point(320, 12);
            this.BTN_Valider.Name = "BTN_Valider";
            this.BTN_Valider.Size = new System.Drawing.Size(50, 50);
            this.BTN_Valider.TabIndex = 1;
            this.BTN_Valider.UseVisualStyleBackColor = true;
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Annuler.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Annuler.Image")));
            this.BTN_Annuler.Location = new System.Drawing.Point(393, 12);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(50, 50);
            this.BTN_Annuler.TabIndex = 2;
            this.BTN_Annuler.UseVisualStyleBackColor = true;
            // 
            // Label_Dossier
            // 
            this.Label_Dossier.AutoSize = true;
            this.Label_Dossier.BackColor = System.Drawing.Color.Transparent;
            this.Label_Dossier.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Dossier.Location = new System.Drawing.Point(14, 63);
            this.Label_Dossier.Name = "Label_Dossier";
            this.Label_Dossier.Size = new System.Drawing.Size(97, 15);
            this.Label_Dossier.TabIndex = 8;
            this.Label_Dossier.Text = "Dossier Médical";
            // 
            // Label_Valider
            // 
            this.Label_Valider.AutoSize = true;
            this.Label_Valider.BackColor = System.Drawing.Color.Transparent;
            this.Label_Valider.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Valider.Location = new System.Drawing.Point(322, 63);
            this.Label_Valider.Name = "Label_Valider";
            this.Label_Valider.Size = new System.Drawing.Size(46, 15);
            this.Label_Valider.TabIndex = 9;
            this.Label_Valider.Text = "Valider";
            // 
            // Label_Annuler
            // 
            this.Label_Annuler.AutoSize = true;
            this.Label_Annuler.BackColor = System.Drawing.Color.Transparent;
            this.Label_Annuler.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Annuler.Location = new System.Drawing.Point(392, 63);
            this.Label_Annuler.Name = "Label_Annuler";
            this.Label_Annuler.Size = new System.Drawing.Size(51, 15);
            this.Label_Annuler.TabIndex = 10;
            this.Label_Annuler.Text = "Annuler";
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
            this.Panel_GestionAnimaux.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_GestionAnimaux;
        private System.Windows.Forms.Button BTN_Dossier;
        private System.Windows.Forms.Button BTN_Annuler;
        private System.Windows.Forms.Button BTN_Valider;
        private System.Windows.Forms.Label Label_Annuler;
        private System.Windows.Forms.Label Label_Valider;
        private System.Windows.Forms.Label Label_Dossier;

    }
}