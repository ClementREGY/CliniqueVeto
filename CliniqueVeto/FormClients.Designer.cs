﻿namespace CliniqueVeto
{
    partial class FormClients
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClients));
            this.Panel_GestionClients = new System.Windows.Forms.Panel();
            this.navBar1 = new ControlsLibrary.NavBar();
            this.BTN_SupprimerClient = new System.Windows.Forms.Button();
            this.BTN_AjouterClient = new System.Windows.Forms.Button();
            this.TBox_Recherche = new System.Windows.Forms.TextBox();
            this.Label_Premier = new System.Windows.Forms.Label();
            this.Label_Précédent = new System.Windows.Forms.Label();
            this.Label_Suivant = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_AjouterClient = new System.Windows.Forms.Label();
            this.Label_SupprimerClient = new System.Windows.Forms.Label();
            this.BTN_Rechercher = new System.Windows.Forms.Button();
            this.Label_Rechercher = new System.Windows.Forms.Label();
            this.TBox_Code = new System.Windows.Forms.TextBox();
            this.TBox_Nom = new System.Windows.Forms.TextBox();
            this.TBox_Prénom = new System.Windows.Forms.TextBox();
            this.TBox_Adresse1 = new System.Windows.Forms.TextBox();
            this.TBox_Adresse2 = new System.Windows.Forms.TextBox();
            this.TBox_CodePostal = new System.Windows.Forms.TextBox();
            this.TBox_Ville = new System.Windows.Forms.TextBox();
            this.Label_Code = new System.Windows.Forms.Label();
            this.Label_Nom = new System.Windows.Forms.Label();
            this.Label_Prénom = new System.Windows.Forms.Label();
            this.Label_Adresse = new System.Windows.Forms.Label();
            this.Label_CodePostal = new System.Windows.Forms.Label();
            this.Label_Ville = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTN_EditerAnimal = new System.Windows.Forms.Button();
            this.BTN_AjouterAnimal = new System.Windows.Forms.Button();
            this.BTN_SupprimerAnimal = new System.Windows.Forms.Button();
            this.Label_SupprimerAnimal = new System.Windows.Forms.Label();
            this.Label_AjouterAnimal = new System.Windows.Forms.Label();
            this.Label_EditerAnimal = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Panel_GestionClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_GestionClients
            // 
            this.Panel_GestionClients.BackColor = System.Drawing.SystemColors.Control;
            this.Panel_GestionClients.Controls.Add(this.Label_Rechercher);
            this.Panel_GestionClients.Controls.Add(this.Label_SupprimerClient);
            this.Panel_GestionClients.Controls.Add(this.Label_AjouterClient);
            this.Panel_GestionClients.Controls.Add(this.label1);
            this.Panel_GestionClients.Controls.Add(this.Label_Suivant);
            this.Panel_GestionClients.Controls.Add(this.Label_Précédent);
            this.Panel_GestionClients.Controls.Add(this.Label_Premier);
            this.Panel_GestionClients.Controls.Add(this.TBox_Recherche);
            this.Panel_GestionClients.Controls.Add(this.BTN_Rechercher);
            this.Panel_GestionClients.Controls.Add(this.BTN_AjouterClient);
            this.Panel_GestionClients.Controls.Add(this.BTN_SupprimerClient);
            this.Panel_GestionClients.Controls.Add(this.navBar1);
            this.Panel_GestionClients.Location = new System.Drawing.Point(0, 0);
            this.Panel_GestionClients.Name = "Panel_GestionClients";
            this.Panel_GestionClients.Size = new System.Drawing.Size(673, 83);
            this.Panel_GestionClients.TabIndex = 0;
            // 
            // navBar1
            // 
            this.navBar1.ApresEnable = true;
            this.navBar1.AvantEnable = true;
            this.navBar1.ButtonBorder = 1;
            this.navBar1.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.navBar1.ImageDernier = ((System.Drawing.Image)(resources.GetObject("navBar1.ImageDernier")));
            this.navBar1.ImagePrecedent = ((System.Drawing.Image)(resources.GetObject("navBar1.ImagePrecedent")));
            this.navBar1.ImagePremier = ((System.Drawing.Image)(resources.GetObject("navBar1.ImagePremier")));
            this.navBar1.ImageSuivant = ((System.Drawing.Image)(resources.GetObject("navBar1.ImageSuivant")));
            this.navBar1.Location = new System.Drawing.Point(3, 3);
            this.navBar1.Name = "navBar1";
            this.navBar1.Size = new System.Drawing.Size(255, 59);
            this.navBar1.TabIndex = 0;
            this.navBar1.TextDernier = "";
            this.navBar1.TextPrecedent = "";
            this.navBar1.TextPremier = "";
            this.navBar1.TextSuivant = "";
            // 
            // BTN_SupprimerClient
            // 
            this.BTN_SupprimerClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_SupprimerClient.Image = ((System.Drawing.Image)(resources.GetObject("BTN_SupprimerClient.Image")));
            this.BTN_SupprimerClient.Location = new System.Drawing.Point(386, 6);
            this.BTN_SupprimerClient.Name = "BTN_SupprimerClient";
            this.BTN_SupprimerClient.Size = new System.Drawing.Size(60, 53);
            this.BTN_SupprimerClient.TabIndex = 2;
            this.BTN_SupprimerClient.UseVisualStyleBackColor = true;
            // 
            // BTN_AjouterClient
            // 
            this.BTN_AjouterClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_AjouterClient.Image = ((System.Drawing.Image)(resources.GetObject("BTN_AjouterClient.Image")));
            this.BTN_AjouterClient.Location = new System.Drawing.Point(307, 6);
            this.BTN_AjouterClient.Name = "BTN_AjouterClient";
            this.BTN_AjouterClient.Size = new System.Drawing.Size(60, 53);
            this.BTN_AjouterClient.TabIndex = 3;
            this.BTN_AjouterClient.UseVisualStyleBackColor = true;
            // 
            // TBox_Recherche
            // 
            this.TBox_Recherche.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBox_Recherche.Location = new System.Drawing.Point(498, 28);
            this.TBox_Recherche.Name = "TBox_Recherche";
            this.TBox_Recherche.Size = new System.Drawing.Size(131, 26);
            this.TBox_Recherche.TabIndex = 4;
            // 
            // Label_Premier
            // 
            this.Label_Premier.AutoSize = true;
            this.Label_Premier.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Premier.Location = new System.Drawing.Point(10, 62);
            this.Label_Premier.Name = "Label_Premier";
            this.Label_Premier.Size = new System.Drawing.Size(51, 15);
            this.Label_Premier.TabIndex = 5;
            this.Label_Premier.Text = "Premier";
            // 
            // Label_Précédent
            // 
            this.Label_Précédent.AutoSize = true;
            this.Label_Précédent.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Précédent.Location = new System.Drawing.Point(68, 62);
            this.Label_Précédent.Name = "Label_Précédent";
            this.Label_Précédent.Size = new System.Drawing.Size(61, 15);
            this.Label_Précédent.TabIndex = 6;
            this.Label_Précédent.Text = "Précédent";
            // 
            // Label_Suivant
            // 
            this.Label_Suivant.AutoSize = true;
            this.Label_Suivant.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Suivant.Location = new System.Drawing.Point(137, 62);
            this.Label_Suivant.Name = "Label_Suivant";
            this.Label_Suivant.Size = new System.Drawing.Size(48, 15);
            this.Label_Suivant.TabIndex = 7;
            this.Label_Suivant.Text = "Suivant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dernier";
            // 
            // Label_AjouterClient
            // 
            this.Label_AjouterClient.AutoSize = true;
            this.Label_AjouterClient.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_AjouterClient.Location = new System.Drawing.Point(315, 62);
            this.Label_AjouterClient.Name = "Label_AjouterClient";
            this.Label_AjouterClient.Size = new System.Drawing.Size(47, 15);
            this.Label_AjouterClient.TabIndex = 7;
            this.Label_AjouterClient.Text = "Ajouter";
            // 
            // Label_SupprimerClient
            // 
            this.Label_SupprimerClient.AutoSize = true;
            this.Label_SupprimerClient.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_SupprimerClient.Location = new System.Drawing.Point(384, 62);
            this.Label_SupprimerClient.Name = "Label_SupprimerClient";
            this.Label_SupprimerClient.Size = new System.Drawing.Size(65, 15);
            this.Label_SupprimerClient.TabIndex = 7;
            this.Label_SupprimerClient.Text = "Supprimer";
            // 
            // BTN_Rechercher
            // 
            this.BTN_Rechercher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Rechercher.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Rechercher.Image")));
            this.BTN_Rechercher.Location = new System.Drawing.Point(639, 28);
            this.BTN_Rechercher.Name = "BTN_Rechercher";
            this.BTN_Rechercher.Size = new System.Drawing.Size(26, 26);
            this.BTN_Rechercher.TabIndex = 3;
            this.BTN_Rechercher.UseVisualStyleBackColor = true;
            // 
            // Label_Rechercher
            // 
            this.Label_Rechercher.AutoSize = true;
            this.Label_Rechercher.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Rechercher.Location = new System.Drawing.Point(550, 62);
            this.Label_Rechercher.Name = "Label_Rechercher";
            this.Label_Rechercher.Size = new System.Drawing.Size(69, 15);
            this.Label_Rechercher.TabIndex = 8;
            this.Label_Rechercher.Text = "Rechercher";
            // 
            // TBox_Code
            // 
            this.TBox_Code.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBox_Code.Location = new System.Drawing.Point(108, 107);
            this.TBox_Code.Name = "TBox_Code";
            this.TBox_Code.Size = new System.Drawing.Size(150, 26);
            this.TBox_Code.TabIndex = 1;
            // 
            // TBox_Nom
            // 
            this.TBox_Nom.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBox_Nom.Location = new System.Drawing.Point(108, 148);
            this.TBox_Nom.Name = "TBox_Nom";
            this.TBox_Nom.Size = new System.Drawing.Size(150, 26);
            this.TBox_Nom.TabIndex = 2;
            // 
            // TBox_Prénom
            // 
            this.TBox_Prénom.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBox_Prénom.Location = new System.Drawing.Point(108, 189);
            this.TBox_Prénom.Name = "TBox_Prénom";
            this.TBox_Prénom.Size = new System.Drawing.Size(150, 26);
            this.TBox_Prénom.TabIndex = 3;
            // 
            // TBox_Adresse1
            // 
            this.TBox_Adresse1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBox_Adresse1.Location = new System.Drawing.Point(108, 231);
            this.TBox_Adresse1.Name = "TBox_Adresse1";
            this.TBox_Adresse1.Size = new System.Drawing.Size(150, 26);
            this.TBox_Adresse1.TabIndex = 4;
            // 
            // TBox_Adresse2
            // 
            this.TBox_Adresse2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBox_Adresse2.Location = new System.Drawing.Point(108, 272);
            this.TBox_Adresse2.Name = "TBox_Adresse2";
            this.TBox_Adresse2.Size = new System.Drawing.Size(150, 26);
            this.TBox_Adresse2.TabIndex = 5;
            // 
            // TBox_CodePostal
            // 
            this.TBox_CodePostal.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBox_CodePostal.Location = new System.Drawing.Point(108, 313);
            this.TBox_CodePostal.Name = "TBox_CodePostal";
            this.TBox_CodePostal.Size = new System.Drawing.Size(150, 26);
            this.TBox_CodePostal.TabIndex = 6;
            // 
            // TBox_Ville
            // 
            this.TBox_Ville.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBox_Ville.Location = new System.Drawing.Point(108, 354);
            this.TBox_Ville.Name = "TBox_Ville";
            this.TBox_Ville.Size = new System.Drawing.Size(150, 26);
            this.TBox_Ville.TabIndex = 7;
            // 
            // Label_Code
            // 
            this.Label_Code.AutoSize = true;
            this.Label_Code.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Code.Location = new System.Drawing.Point(12, 110);
            this.Label_Code.Name = "Label_Code";
            this.Label_Code.Size = new System.Drawing.Size(44, 19);
            this.Label_Code.TabIndex = 8;
            this.Label_Code.Text = "Code";
            // 
            // Label_Nom
            // 
            this.Label_Nom.AutoSize = true;
            this.Label_Nom.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Nom.Location = new System.Drawing.Point(12, 151);
            this.Label_Nom.Name = "Label_Nom";
            this.Label_Nom.Size = new System.Drawing.Size(42, 19);
            this.Label_Nom.TabIndex = 9;
            this.Label_Nom.Text = "Nom";
            // 
            // Label_Prénom
            // 
            this.Label_Prénom.AutoSize = true;
            this.Label_Prénom.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Prénom.Location = new System.Drawing.Point(9, 192);
            this.Label_Prénom.Name = "Label_Prénom";
            this.Label_Prénom.Size = new System.Drawing.Size(64, 19);
            this.Label_Prénom.TabIndex = 10;
            this.Label_Prénom.Text = "Prénom";
            // 
            // Label_Adresse
            // 
            this.Label_Adresse.AutoSize = true;
            this.Label_Adresse.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Adresse.Location = new System.Drawing.Point(9, 234);
            this.Label_Adresse.Name = "Label_Adresse";
            this.Label_Adresse.Size = new System.Drawing.Size(65, 19);
            this.Label_Adresse.TabIndex = 11;
            this.Label_Adresse.Text = "Adresse";
            // 
            // Label_CodePostal
            // 
            this.Label_CodePostal.AutoSize = true;
            this.Label_CodePostal.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CodePostal.Location = new System.Drawing.Point(9, 316);
            this.Label_CodePostal.Name = "Label_CodePostal";
            this.Label_CodePostal.Size = new System.Drawing.Size(90, 19);
            this.Label_CodePostal.TabIndex = 12;
            this.Label_CodePostal.Text = "Code Postal";
            // 
            // Label_Ville
            // 
            this.Label_Ville.AutoSize = true;
            this.Label_Ville.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Ville.Location = new System.Drawing.Point(12, 357);
            this.Label_Ville.Name = "Label_Ville";
            this.Label_Ville.Size = new System.Drawing.Size(39, 19);
            this.Label_Ville.TabIndex = 13;
            this.Label_Ville.Text = "Ville";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(307, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(354, 160);
            this.dataGridView1.TabIndex = 14;
            // 
            // BTN_EditerAnimal
            // 
            this.BTN_EditerAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_EditerAnimal.Image = ((System.Drawing.Image)(resources.GetObject("BTN_EditerAnimal.Image")));
            this.BTN_EditerAnimal.Location = new System.Drawing.Point(601, 273);
            this.BTN_EditerAnimal.Name = "BTN_EditerAnimal";
            this.BTN_EditerAnimal.Size = new System.Drawing.Size(60, 53);
            this.BTN_EditerAnimal.TabIndex = 15;
            this.BTN_EditerAnimal.UseVisualStyleBackColor = true;
            // 
            // BTN_AjouterAnimal
            // 
            this.BTN_AjouterAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_AjouterAnimal.Image = ((System.Drawing.Image)(resources.GetObject("BTN_AjouterAnimal.Image")));
            this.BTN_AjouterAnimal.Location = new System.Drawing.Point(469, 272);
            this.BTN_AjouterAnimal.Name = "BTN_AjouterAnimal";
            this.BTN_AjouterAnimal.Size = new System.Drawing.Size(60, 53);
            this.BTN_AjouterAnimal.TabIndex = 17;
            this.BTN_AjouterAnimal.UseVisualStyleBackColor = true;
            // 
            // BTN_SupprimerAnimal
            // 
            this.BTN_SupprimerAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_SupprimerAnimal.Image = ((System.Drawing.Image)(resources.GetObject("BTN_SupprimerAnimal.Image")));
            this.BTN_SupprimerAnimal.Location = new System.Drawing.Point(535, 273);
            this.BTN_SupprimerAnimal.Name = "BTN_SupprimerAnimal";
            this.BTN_SupprimerAnimal.Size = new System.Drawing.Size(60, 53);
            this.BTN_SupprimerAnimal.TabIndex = 18;
            this.BTN_SupprimerAnimal.UseVisualStyleBackColor = true;
            // 
            // Label_SupprimerAnimal
            // 
            this.Label_SupprimerAnimal.AutoSize = true;
            this.Label_SupprimerAnimal.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_SupprimerAnimal.Location = new System.Drawing.Point(533, 329);
            this.Label_SupprimerAnimal.Name = "Label_SupprimerAnimal";
            this.Label_SupprimerAnimal.Size = new System.Drawing.Size(65, 15);
            this.Label_SupprimerAnimal.TabIndex = 19;
            this.Label_SupprimerAnimal.Text = "Supprimer";
            // 
            // Label_AjouterAnimal
            // 
            this.Label_AjouterAnimal.AutoSize = true;
            this.Label_AjouterAnimal.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_AjouterAnimal.Location = new System.Drawing.Point(476, 329);
            this.Label_AjouterAnimal.Name = "Label_AjouterAnimal";
            this.Label_AjouterAnimal.Size = new System.Drawing.Size(47, 15);
            this.Label_AjouterAnimal.TabIndex = 20;
            this.Label_AjouterAnimal.Text = "Ajouter";
            // 
            // Label_EditerAnimal
            // 
            this.Label_EditerAnimal.AutoSize = true;
            this.Label_EditerAnimal.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_EditerAnimal.Location = new System.Drawing.Point(612, 329);
            this.Label_EditerAnimal.Name = "Label_EditerAnimal";
            this.Label_EditerAnimal.Size = new System.Drawing.Size(40, 15);
            this.Label_EditerAnimal.TabIndex = 21;
            this.Label_EditerAnimal.Text = "Éditer";
            // 
            // FormClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(673, 403);
            this.Controls.Add(this.Label_EditerAnimal);
            this.Controls.Add(this.Label_SupprimerAnimal);
            this.Controls.Add(this.Label_AjouterAnimal);
            this.Controls.Add(this.BTN_SupprimerAnimal);
            this.Controls.Add(this.BTN_AjouterAnimal);
            this.Controls.Add(this.BTN_EditerAnimal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Label_Ville);
            this.Controls.Add(this.Label_CodePostal);
            this.Controls.Add(this.Label_Adresse);
            this.Controls.Add(this.Label_Prénom);
            this.Controls.Add(this.Label_Nom);
            this.Controls.Add(this.Label_Code);
            this.Controls.Add(this.TBox_Ville);
            this.Controls.Add(this.TBox_CodePostal);
            this.Controls.Add(this.TBox_Adresse2);
            this.Controls.Add(this.TBox_Adresse1);
            this.Controls.Add(this.TBox_Prénom);
            this.Controls.Add(this.TBox_Nom);
            this.Controls.Add(this.TBox_Code);
            this.Controls.Add(this.Panel_GestionClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormClients";
            this.Text = "Clients";
            this.Panel_GestionClients.ResumeLayout(false);
            this.Panel_GestionClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_GestionClients;
        private System.Windows.Forms.Label Label_Rechercher;
        private System.Windows.Forms.Label Label_SupprimerClient;
        private System.Windows.Forms.Label Label_AjouterClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_Suivant;
        private System.Windows.Forms.Label Label_Précédent;
        private System.Windows.Forms.Label Label_Premier;
        private System.Windows.Forms.TextBox TBox_Recherche;
        private System.Windows.Forms.Button BTN_Rechercher;
        private System.Windows.Forms.Button BTN_AjouterClient;
        private System.Windows.Forms.Button BTN_SupprimerClient;
        private ControlsLibrary.NavBar navBar1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox TBox_Code;
        private System.Windows.Forms.TextBox TBox_Nom;
        private System.Windows.Forms.TextBox TBox_Prénom;
        private System.Windows.Forms.TextBox TBox_Adresse1;
        private System.Windows.Forms.TextBox TBox_Adresse2;
        private System.Windows.Forms.TextBox TBox_CodePostal;
        private System.Windows.Forms.TextBox TBox_Ville;
        private System.Windows.Forms.Label Label_Code;
        private System.Windows.Forms.Label Label_Nom;
        private System.Windows.Forms.Label Label_Prénom;
        private System.Windows.Forms.Label Label_Adresse;
        private System.Windows.Forms.Label Label_CodePostal;
        private System.Windows.Forms.Label Label_Ville;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTN_EditerAnimal;
        private System.Windows.Forms.Button BTN_AjouterAnimal;
        private System.Windows.Forms.Button BTN_SupprimerAnimal;
        private System.Windows.Forms.Label Label_SupprimerAnimal;
        private System.Windows.Forms.Label Label_AjouterAnimal;
        private System.Windows.Forms.Label Label_EditerAnimal;
    }
}