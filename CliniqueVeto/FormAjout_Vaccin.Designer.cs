namespace CliniqueVeto
{
    partial class FormAjout_Vaccin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjout_Vaccin));
            this.Label_Période = new System.Windows.Forms.Label();
            this.Label_Nom = new System.Windows.Forms.Label();
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.BTN_Valider = new System.Windows.Forms.Button();
            this.TBox_Nom = new System.Windows.Forms.TextBox();
            this.Label_Quantité = new System.Windows.Forms.Label();
            this.TBox_TarifFixe = new System.Windows.Forms.TextBox();
            this.Label_Fixe = new System.Windows.Forms.Label();
            this.TBox_TarifMaxi = new System.Windows.Forms.TextBox();
            this.Label_Maxi = new System.Windows.Forms.Label();
            this.TBox_TarifMini = new System.Windows.Forms.TextBox();
            this.Label_Mini = new System.Windows.Forms.Label();
            this.Label_Tarif = new System.Windows.Forms.Label();
            this.CBox_TypeTarif = new System.Windows.Forms.ComboBox();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.errorSaisie = new System.Windows.Forms.ErrorProvider(this.components);
            this.DUP_Période = new System.Windows.Forms.NumericUpDown();
            this.DUP_Quantité = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.errorSaisie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DUP_Période)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DUP_Quantité)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Période
            // 
            this.Label_Période.AutoSize = true;
            this.Label_Période.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Période.Location = new System.Drawing.Point(16, 54);
            this.Label_Période.Name = "Label_Période";
            this.Label_Période.Size = new System.Drawing.Size(128, 18);
            this.Label_Période.TabIndex = 23;
            this.Label_Période.Text = "Validité (mois)";
            // 
            // Label_Nom
            // 
            this.Label_Nom.AutoSize = true;
            this.Label_Nom.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Nom.Location = new System.Drawing.Point(32, 25);
            this.Label_Nom.Name = "Label_Nom";
            this.Label_Nom.Size = new System.Drawing.Size(112, 18);
            this.Label_Nom.TabIndex = 21;
            this.Label_Nom.Text = "Nom du Vaccin";
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Annuler.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Annuler.Location = new System.Drawing.Point(20, 258);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(309, 25);
            this.BTN_Annuler.TabIndex = 9;
            this.BTN_Annuler.Text = "Annuler";
            this.BTN_Annuler.UseVisualStyleBackColor = false;
            // 
            // BTN_Valider
            // 
            this.BTN_Valider.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Valider.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Valider.Location = new System.Drawing.Point(19, 227);
            this.BTN_Valider.Name = "BTN_Valider";
            this.BTN_Valider.Size = new System.Drawing.Size(309, 25);
            this.BTN_Valider.TabIndex = 8;
            this.BTN_Valider.Text = "Valider";
            this.BTN_Valider.UseVisualStyleBackColor = false;
            this.BTN_Valider.Click += new System.EventHandler(this.BTN_Valider_Click);
            // 
            // TBox_Nom
            // 
            this.TBox_Nom.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBox_Nom.Location = new System.Drawing.Point(150, 22);
            this.TBox_Nom.Name = "TBox_Nom";
            this.TBox_Nom.Size = new System.Drawing.Size(178, 25);
            this.TBox_Nom.TabIndex = 1;
            // 
            // Label_Quantité
            // 
            this.Label_Quantité.AutoSize = true;
            this.Label_Quantité.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Quantité.Location = new System.Drawing.Point(72, 84);
            this.Label_Quantité.Name = "Label_Quantité";
            this.Label_Quantité.Size = new System.Drawing.Size(72, 18);
            this.Label_Quantité.TabIndex = 24;
            this.Label_Quantité.Text = "Quantité";
            // 
            // TBox_TarifFixe
            // 
            this.TBox_TarifFixe.Enabled = false;
            this.TBox_TarifFixe.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBox_TarifFixe.Location = new System.Drawing.Point(251, 143);
            this.TBox_TarifFixe.Name = "TBox_TarifFixe";
            this.TBox_TarifFixe.Size = new System.Drawing.Size(78, 25);
            this.TBox_TarifFixe.TabIndex = 5;
            this.TBox_TarifFixe.Visible = false;
            this.TBox_TarifFixe.Enter += new System.EventHandler(this.TBox_TarifFixe_Enter);
            // 
            // Label_Fixe
            // 
            this.Label_Fixe.AutoSize = true;
            this.Label_Fixe.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Fixe.Location = new System.Drawing.Point(205, 146);
            this.Label_Fixe.Name = "Label_Fixe";
            this.Label_Fixe.Size = new System.Drawing.Size(40, 18);
            this.Label_Fixe.TabIndex = 34;
            this.Label_Fixe.Text = "Fixe";
            this.Label_Fixe.Visible = false;
            // 
            // TBox_TarifMaxi
            // 
            this.TBox_TarifMaxi.Enabled = false;
            this.TBox_TarifMaxi.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBox_TarifMaxi.Location = new System.Drawing.Point(251, 177);
            this.TBox_TarifMaxi.Name = "TBox_TarifMaxi";
            this.TBox_TarifMaxi.Size = new System.Drawing.Size(78, 25);
            this.TBox_TarifMaxi.TabIndex = 7;
            this.TBox_TarifMaxi.Visible = false;
            this.TBox_TarifMaxi.Enter += new System.EventHandler(this.TBox_TarifMaxi_Enter);
            // 
            // Label_Maxi
            // 
            this.Label_Maxi.AutoSize = true;
            this.Label_Maxi.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Maxi.Location = new System.Drawing.Point(205, 180);
            this.Label_Maxi.Name = "Label_Maxi";
            this.Label_Maxi.Size = new System.Drawing.Size(40, 18);
            this.Label_Maxi.TabIndex = 33;
            this.Label_Maxi.Text = "Maxi";
            this.Label_Maxi.Visible = false;
            // 
            // TBox_TarifMini
            // 
            this.TBox_TarifMini.Enabled = false;
            this.TBox_TarifMini.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBox_TarifMini.Location = new System.Drawing.Point(58, 177);
            this.TBox_TarifMini.Name = "TBox_TarifMini";
            this.TBox_TarifMini.Size = new System.Drawing.Size(78, 25);
            this.TBox_TarifMini.TabIndex = 6;
            this.TBox_TarifMini.Visible = false;
            this.TBox_TarifMini.Enter += new System.EventHandler(this.TBox_TarifMini_Enter);
            // 
            // Label_Mini
            // 
            this.Label_Mini.AutoSize = true;
            this.Label_Mini.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Mini.Location = new System.Drawing.Point(12, 180);
            this.Label_Mini.Name = "Label_Mini";
            this.Label_Mini.Size = new System.Drawing.Size(40, 18);
            this.Label_Mini.TabIndex = 32;
            this.Label_Mini.Text = "Mini";
            this.Label_Mini.Visible = false;
            // 
            // Label_Tarif
            // 
            this.Label_Tarif.AutoSize = true;
            this.Label_Tarif.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Tarif.Location = new System.Drawing.Point(4, 145);
            this.Label_Tarif.Name = "Label_Tarif";
            this.Label_Tarif.Size = new System.Drawing.Size(48, 18);
            this.Label_Tarif.TabIndex = 31;
            this.Label_Tarif.Text = "Tarif";
            // 
            // CBox_TypeTarif
            // 
            this.CBox_TypeTarif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBox_TypeTarif.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBox_TypeTarif.FormattingEnabled = true;
            this.CBox_TypeTarif.Items.AddRange(new object[] {
            "Tarif Fixe",
            "Tarif Variable"});
            this.CBox_TypeTarif.Location = new System.Drawing.Point(58, 142);
            this.CBox_TypeTarif.Name = "CBox_TypeTarif";
            this.CBox_TypeTarif.Size = new System.Drawing.Size(125, 26);
            this.CBox_TypeTarif.TabIndex = 4;
            this.CBox_TypeTarif.SelectedIndexChanged += new System.EventHandler(this.CBox_TypeTarif_SelectedIndexChanged);
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 5;
            this.lineShape1.X2 = 335;
            this.lineShape1.Y1 = 125;
            this.lineShape1.Y2 = 125;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(341, 296);
            this.shapeContainer1.TabIndex = 35;
            this.shapeContainer1.TabStop = false;
            // 
            // errorSaisie
            // 
            this.errorSaisie.ContainerControl = this;
            // 
            // DUP_Période
            // 
            this.DUP_Période.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DUP_Période.Increment = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.DUP_Période.Location = new System.Drawing.Point(150, 52);
            this.DUP_Période.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.DUP_Période.Name = "DUP_Période";
            this.DUP_Période.Size = new System.Drawing.Size(178, 25);
            this.DUP_Période.TabIndex = 2;
            this.DUP_Période.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // DUP_Quantité
            // 
            this.DUP_Quantité.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DUP_Quantité.Location = new System.Drawing.Point(150, 82);
            this.DUP_Quantité.Name = "DUP_Quantité";
            this.DUP_Quantité.Size = new System.Drawing.Size(178, 25);
            this.DUP_Quantité.TabIndex = 3;
            // 
            // FormAjout_Vaccin
            // 
            this.AcceptButton = this.BTN_Valider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.CancelButton = this.BTN_Annuler;
            this.ClientSize = new System.Drawing.Size(341, 296);
            this.Controls.Add(this.DUP_Quantité);
            this.Controls.Add(this.DUP_Période);
            this.Controls.Add(this.TBox_TarifFixe);
            this.Controls.Add(this.Label_Fixe);
            this.Controls.Add(this.TBox_TarifMaxi);
            this.Controls.Add(this.Label_Maxi);
            this.Controls.Add(this.TBox_TarifMini);
            this.Controls.Add(this.Label_Mini);
            this.Controls.Add(this.Label_Tarif);
            this.Controls.Add(this.CBox_TypeTarif);
            this.Controls.Add(this.Label_Quantité);
            this.Controls.Add(this.Label_Période);
            this.Controls.Add(this.Label_Nom);
            this.Controls.Add(this.BTN_Annuler);
            this.Controls.Add(this.BTN_Valider);
            this.Controls.Add(this.TBox_Nom);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAjout_Vaccin";
            this.Text = "Ajouter un Nouveau Vaccin";
            this.Load += new System.EventHandler(this.FormAjout_Vaccin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorSaisie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DUP_Période)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DUP_Quantité)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Période;
        private System.Windows.Forms.Label Label_Nom;
        private System.Windows.Forms.Button BTN_Annuler;
        public System.Windows.Forms.Button BTN_Valider;
        private System.Windows.Forms.TextBox TBox_Nom;
        private System.Windows.Forms.Label Label_Quantité;
        private System.Windows.Forms.TextBox TBox_TarifFixe;
        private System.Windows.Forms.Label Label_Fixe;
        private System.Windows.Forms.TextBox TBox_TarifMaxi;
        private System.Windows.Forms.Label Label_Maxi;
        private System.Windows.Forms.TextBox TBox_TarifMini;
        private System.Windows.Forms.Label Label_Mini;
        private System.Windows.Forms.Label Label_Tarif;
        private System.Windows.Forms.ComboBox CBox_TypeTarif;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.ErrorProvider errorSaisie;
        private System.Windows.Forms.NumericUpDown DUP_Quantité;
        private System.Windows.Forms.NumericUpDown DUP_Période;
    }
}