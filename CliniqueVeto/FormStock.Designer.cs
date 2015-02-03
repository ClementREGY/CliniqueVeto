namespace CliniqueVeto
{
    partial class FormStock
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
            this.LBox_Vaccins = new System.Windows.Forms.ListBox();
            this.BTN_MiseAJour = new System.Windows.Forms.Button();
            this.Label_Fournisseur = new System.Windows.Forms.Label();
            this.CBox_Fournisseurs = new System.Windows.Forms.ComboBox();
            this.Label_Nombre = new System.Windows.Forms.Label();
            this.TBox_Nombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LBox_Vaccins
            // 
            this.LBox_Vaccins.FormattingEnabled = true;
            this.LBox_Vaccins.ItemHeight = 17;
            this.LBox_Vaccins.Location = new System.Drawing.Point(16, 16);
            this.LBox_Vaccins.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LBox_Vaccins.Name = "LBox_Vaccins";
            this.LBox_Vaccins.Size = new System.Drawing.Size(525, 157);
            this.LBox_Vaccins.TabIndex = 0;
            // 
            // BTN_MiseAJour
            // 
            this.BTN_MiseAJour.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_MiseAJour.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_MiseAJour.Location = new System.Drawing.Point(427, 183);
            this.BTN_MiseAJour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_MiseAJour.Name = "BTN_MiseAJour";
            this.BTN_MiseAJour.Size = new System.Drawing.Size(114, 27);
            this.BTN_MiseAJour.TabIndex = 1;
            this.BTN_MiseAJour.Text = "Mettre à Jour";
            this.BTN_MiseAJour.UseVisualStyleBackColor = false;
            this.BTN_MiseAJour.Click += new System.EventHandler(this.BTN_MiseAJour_Click);
            // 
            // Label_Fournisseur
            // 
            this.Label_Fournisseur.AutoSize = true;
            this.Label_Fournisseur.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Fournisseur.Location = new System.Drawing.Point(13, 188);
            this.Label_Fournisseur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Fournisseur.Name = "Label_Fournisseur";
            this.Label_Fournisseur.Size = new System.Drawing.Size(82, 17);
            this.Label_Fournisseur.TabIndex = 2;
            this.Label_Fournisseur.Text = "Fournisseur";
            this.Label_Fournisseur.Visible = false;
            // 
            // CBox_Fournisseurs
            // 
            this.CBox_Fournisseurs.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBox_Fournisseurs.FormattingEnabled = true;
            this.CBox_Fournisseurs.Location = new System.Drawing.Point(96, 186);
            this.CBox_Fournisseurs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBox_Fournisseurs.Name = "CBox_Fournisseurs";
            this.CBox_Fournisseurs.Size = new System.Drawing.Size(118, 23);
            this.CBox_Fournisseurs.TabIndex = 3;
            this.CBox_Fournisseurs.Visible = false;
            // 
            // Label_Nombre
            // 
            this.Label_Nombre.AutoSize = true;
            this.Label_Nombre.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Nombre.Location = new System.Drawing.Point(225, 188);
            this.Label_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Nombre.Name = "Label_Nombre";
            this.Label_Nombre.Size = new System.Drawing.Size(119, 17);
            this.Label_Nombre.TabIndex = 4;
            this.Label_Nombre.Text = "Nombre à Ajouter";
            this.Label_Nombre.Visible = false;
            // 
            // TBox_Nombre
            // 
            this.TBox_Nombre.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBox_Nombre.Location = new System.Drawing.Point(346, 186);
            this.TBox_Nombre.Name = "TBox_Nombre";
            this.TBox_Nombre.Size = new System.Drawing.Size(58, 23);
            this.TBox_Nombre.TabIndex = 5;
            this.TBox_Nombre.Visible = false;
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(554, 222);
            this.Controls.Add(this.TBox_Nombre);
            this.Controls.Add(this.Label_Nombre);
            this.Controls.Add(this.CBox_Fournisseurs);
            this.Controls.Add(this.Label_Fournisseur);
            this.Controls.Add(this.BTN_MiseAJour);
            this.Controls.Add(this.LBox_Vaccins);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormStock";
            this.Text = "Stock des Vaccins";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LBox_Vaccins;
        private System.Windows.Forms.Button BTN_MiseAJour;
        private System.Windows.Forms.Label Label_Fournisseur;
        private System.Windows.Forms.ComboBox CBox_Fournisseurs;
        private System.Windows.Forms.Label Label_Nombre;
        private System.Windows.Forms.TextBox TBox_Nombre;
    }
}