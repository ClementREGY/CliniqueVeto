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
            this.Label_Annuler = new System.Windows.Forms.Label();
            this.Label_Valider = new System.Windows.Forms.Label();
            this.Label_Dossier = new System.Windows.Forms.Label();
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.BTN_Valider = new System.Windows.Forms.Button();
            this.BTN_Dossier = new System.Windows.Forms.Button();
            this.GBox_Client = new System.Windows.Forms.GroupBox();
            this.TBox_Client = new System.Windows.Forms.TextBox();
            this.Label_Tatouage = new System.Windows.Forms.Label();
            this.Label_Couleur = new System.Windows.Forms.Label();
            this.Label_Nom = new System.Windows.Forms.Label();
            this.Label_Code = new System.Windows.Forms.Label();
            this.TBox_Tatouage = new System.Windows.Forms.TextBox();
            this.TBox_Couleur = new System.Windows.Forms.TextBox();
            this.TBox_Nom = new System.Windows.Forms.TextBox();
            this.TBox_Code = new System.Windows.Forms.TextBox();
            this.Label_Espèce = new System.Windows.Forms.Label();
            this.CBox_Espèce = new System.Windows.Forms.ComboBox();
            this.CBox_Race = new System.Windows.Forms.ComboBox();
            this.Label_Race = new System.Windows.Forms.Label();
            this.CBox_Genre = new System.Windows.Forms.ComboBox();
            this.Panel_GestionAnimaux.SuspendLayout();
            this.GBox_Client.SuspendLayout();
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
            this.Panel_GestionAnimaux.Size = new System.Drawing.Size(404, 83);
            this.Panel_GestionAnimaux.TabIndex = 0;
            // 
            // Label_Annuler
            // 
            this.Label_Annuler.AutoSize = true;
            this.Label_Annuler.BackColor = System.Drawing.Color.Transparent;
            this.Label_Annuler.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Annuler.Location = new System.Drawing.Point(332, 63);
            this.Label_Annuler.Name = "Label_Annuler";
            this.Label_Annuler.Size = new System.Drawing.Size(51, 15);
            this.Label_Annuler.TabIndex = 10;
            this.Label_Annuler.Text = "Annuler";
            // 
            // Label_Valider
            // 
            this.Label_Valider.AutoSize = true;
            this.Label_Valider.BackColor = System.Drawing.Color.Transparent;
            this.Label_Valider.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Valider.Location = new System.Drawing.Point(262, 63);
            this.Label_Valider.Name = "Label_Valider";
            this.Label_Valider.Size = new System.Drawing.Size(46, 15);
            this.Label_Valider.TabIndex = 9;
            this.Label_Valider.Text = "Valider";
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
            // BTN_Annuler
            // 
            this.BTN_Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Annuler.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Annuler.Image")));
            this.BTN_Annuler.Location = new System.Drawing.Point(333, 10);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(50, 50);
            this.BTN_Annuler.TabIndex = 2;
            this.BTN_Annuler.UseVisualStyleBackColor = true;
            // 
            // BTN_Valider
            // 
            this.BTN_Valider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Valider.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Valider.Image")));
            this.BTN_Valider.Location = new System.Drawing.Point(260, 10);
            this.BTN_Valider.Name = "BTN_Valider";
            this.BTN_Valider.Size = new System.Drawing.Size(50, 50);
            this.BTN_Valider.TabIndex = 1;
            this.BTN_Valider.UseVisualStyleBackColor = true;
            // 
            // BTN_Dossier
            // 
            this.BTN_Dossier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Dossier.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Dossier.Image")));
            this.BTN_Dossier.Location = new System.Drawing.Point(38, 10);
            this.BTN_Dossier.Name = "BTN_Dossier";
            this.BTN_Dossier.Size = new System.Drawing.Size(50, 50);
            this.BTN_Dossier.TabIndex = 0;
            this.BTN_Dossier.UseVisualStyleBackColor = true;
            // 
            // GBox_Client
            // 
            this.GBox_Client.Controls.Add(this.TBox_Client);
            this.GBox_Client.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBox_Client.Location = new System.Drawing.Point(12, 89);
            this.GBox_Client.Name = "GBox_Client";
            this.GBox_Client.Size = new System.Drawing.Size(381, 55);
            this.GBox_Client.TabIndex = 1;
            this.GBox_Client.TabStop = false;
            this.GBox_Client.Text = "Client";
            // 
            // TBox_Client
            // 
            this.TBox_Client.Enabled = false;
            this.TBox_Client.Location = new System.Drawing.Point(26, 21);
            this.TBox_Client.Name = "TBox_Client";
            this.TBox_Client.Size = new System.Drawing.Size(332, 25);
            this.TBox_Client.TabIndex = 0;
            // 
            // Label_Tatouage
            // 
            this.Label_Tatouage.AutoSize = true;
            this.Label_Tatouage.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Tatouage.Location = new System.Drawing.Point(23, 327);
            this.Label_Tatouage.Name = "Label_Tatouage";
            this.Label_Tatouage.Size = new System.Drawing.Size(72, 19);
            this.Label_Tatouage.TabIndex = 19;
            this.Label_Tatouage.Text = "Tatouage";
            // 
            // Label_Couleur
            // 
            this.Label_Couleur.AutoSize = true;
            this.Label_Couleur.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Couleur.Location = new System.Drawing.Point(23, 244);
            this.Label_Couleur.Name = "Label_Couleur";
            this.Label_Couleur.Size = new System.Drawing.Size(64, 19);
            this.Label_Couleur.TabIndex = 18;
            this.Label_Couleur.Text = "Couleur";
            // 
            // Label_Nom
            // 
            this.Label_Nom.AutoSize = true;
            this.Label_Nom.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Nom.Location = new System.Drawing.Point(23, 203);
            this.Label_Nom.Name = "Label_Nom";
            this.Label_Nom.Size = new System.Drawing.Size(42, 19);
            this.Label_Nom.TabIndex = 17;
            this.Label_Nom.Text = "Nom";
            // 
            // Label_Code
            // 
            this.Label_Code.AutoSize = true;
            this.Label_Code.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Code.Location = new System.Drawing.Point(23, 162);
            this.Label_Code.Name = "Label_Code";
            this.Label_Code.Size = new System.Drawing.Size(44, 19);
            this.Label_Code.TabIndex = 16;
            this.Label_Code.Text = "Code";
            // 
            // TBox_Tatouage
            // 
            this.TBox_Tatouage.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBox_Tatouage.Location = new System.Drawing.Point(97, 324);
            this.TBox_Tatouage.Name = "TBox_Tatouage";
            this.TBox_Tatouage.Size = new System.Drawing.Size(150, 26);
            this.TBox_Tatouage.TabIndex = 15;
            // 
            // TBox_Couleur
            // 
            this.TBox_Couleur.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBox_Couleur.Location = new System.Drawing.Point(97, 241);
            this.TBox_Couleur.Name = "TBox_Couleur";
            this.TBox_Couleur.Size = new System.Drawing.Size(150, 26);
            this.TBox_Couleur.TabIndex = 14;
            // 
            // TBox_Nom
            // 
            this.TBox_Nom.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBox_Nom.Location = new System.Drawing.Point(97, 200);
            this.TBox_Nom.Name = "TBox_Nom";
            this.TBox_Nom.Size = new System.Drawing.Size(150, 26);
            this.TBox_Nom.TabIndex = 13;
            // 
            // TBox_Code
            // 
            this.TBox_Code.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBox_Code.Location = new System.Drawing.Point(97, 159);
            this.TBox_Code.Name = "TBox_Code";
            this.TBox_Code.Size = new System.Drawing.Size(150, 26);
            this.TBox_Code.TabIndex = 12;
            // 
            // Label_Espèce
            // 
            this.Label_Espèce.AutoSize = true;
            this.Label_Espèce.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Espèce.Location = new System.Drawing.Point(23, 284);
            this.Label_Espèce.Name = "Label_Espèce";
            this.Label_Espèce.Size = new System.Drawing.Size(57, 19);
            this.Label_Espèce.TabIndex = 20;
            this.Label_Espèce.Text = "Espèce";
            // 
            // CBox_Espèce
            // 
            this.CBox_Espèce.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBox_Espèce.FormattingEnabled = true;
            this.CBox_Espèce.Location = new System.Drawing.Point(97, 281);
            this.CBox_Espèce.Name = "CBox_Espèce";
            this.CBox_Espèce.Size = new System.Drawing.Size(88, 27);
            this.CBox_Espèce.TabIndex = 21;
            // 
            // CBox_Race
            // 
            this.CBox_Race.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBox_Race.FormattingEnabled = true;
            this.CBox_Race.Location = new System.Drawing.Point(287, 281);
            this.CBox_Race.Name = "CBox_Race";
            this.CBox_Race.Size = new System.Drawing.Size(96, 27);
            this.CBox_Race.TabIndex = 23;
            // 
            // Label_Race
            // 
            this.Label_Race.AutoSize = true;
            this.Label_Race.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Race.Location = new System.Drawing.Point(223, 284);
            this.Label_Race.Name = "Label_Race";
            this.Label_Race.Size = new System.Drawing.Size(42, 19);
            this.Label_Race.TabIndex = 22;
            this.Label_Race.Text = "Race";
            // 
            // CBox_Genre
            // 
            this.CBox_Genre.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBox_Genre.FormattingEnabled = true;
            this.CBox_Genre.Items.AddRange(new object[] {
            "Femelle",
            "Mâle"});
            this.CBox_Genre.Location = new System.Drawing.Point(287, 200);
            this.CBox_Genre.Name = "CBox_Genre";
            this.CBox_Genre.Size = new System.Drawing.Size(96, 27);
            this.CBox_Genre.TabIndex = 24;
            this.CBox_Genre.SelectedIndexChanged += new System.EventHandler(this.CBox_Genre_SelectedIndexChanged);
            // 
            // FormAnimaux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(404, 364);
            this.Controls.Add(this.CBox_Genre);
            this.Controls.Add(this.CBox_Race);
            this.Controls.Add(this.Label_Race);
            this.Controls.Add(this.CBox_Espèce);
            this.Controls.Add(this.Label_Espèce);
            this.Controls.Add(this.Label_Tatouage);
            this.Controls.Add(this.Label_Couleur);
            this.Controls.Add(this.Label_Nom);
            this.Controls.Add(this.Label_Code);
            this.Controls.Add(this.TBox_Tatouage);
            this.Controls.Add(this.TBox_Couleur);
            this.Controls.Add(this.TBox_Nom);
            this.Controls.Add(this.TBox_Code);
            this.Controls.Add(this.GBox_Client);
            this.Controls.Add(this.Panel_GestionAnimaux);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormAnimaux";
            this.Text = "Animaux";
            this.Load += new System.EventHandler(this.FormAnimaux_Load);
            this.Panel_GestionAnimaux.ResumeLayout(false);
            this.Panel_GestionAnimaux.PerformLayout();
            this.GBox_Client.ResumeLayout(false);
            this.GBox_Client.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_GestionAnimaux;
        private System.Windows.Forms.Button BTN_Dossier;
        private System.Windows.Forms.Button BTN_Annuler;
        private System.Windows.Forms.Button BTN_Valider;
        private System.Windows.Forms.Label Label_Annuler;
        private System.Windows.Forms.Label Label_Valider;
        private System.Windows.Forms.Label Label_Dossier;
        private System.Windows.Forms.GroupBox GBox_Client;
        private System.Windows.Forms.TextBox TBox_Client;
        private System.Windows.Forms.Label Label_Tatouage;
        private System.Windows.Forms.Label Label_Couleur;
        private System.Windows.Forms.Label Label_Nom;
        private System.Windows.Forms.Label Label_Code;
        private System.Windows.Forms.TextBox TBox_Tatouage;
        private System.Windows.Forms.TextBox TBox_Couleur;
        private System.Windows.Forms.TextBox TBox_Nom;
        private System.Windows.Forms.TextBox TBox_Code;
        private System.Windows.Forms.Label Label_Espèce;
        private System.Windows.Forms.ComboBox CBox_Espèce;
        private System.Windows.Forms.ComboBox CBox_Race;
        private System.Windows.Forms.Label Label_Race;
        private System.Windows.Forms.ComboBox CBox_Genre;

    }
}