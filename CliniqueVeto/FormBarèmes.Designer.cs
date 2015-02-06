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
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.DataGrid_Barèmes = new System.Windows.Forms.DataGridView();
            this.CBox_TypeTarif = new System.Windows.Forms.ComboBox();
            this.Tbox_Libelle = new System.Windows.Forms.TextBox();
            this.TBox_Type = new System.Windows.Forms.TextBox();
            this.Label_Acte = new System.Windows.Forms.Label();
            this.Label_Tarif = new System.Windows.Forms.Label();
            this.TBox_TarifMini = new System.Windows.Forms.TextBox();
            this.Label_Mini = new System.Windows.Forms.Label();
            this.TBox_TarifMaxi = new System.Windows.Forms.TextBox();
            this.Label_Maxi = new System.Windows.Forms.Label();
            this.TBox_TarifFixe = new System.Windows.Forms.TextBox();
            this.Label_Fixe = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.BTN_MiseAJour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Barèmes)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Annuler.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Annuler.Location = new System.Drawing.Point(345, 309);
            this.BTN_Annuler.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(114, 25);
            this.BTN_Annuler.TabIndex = 8;
            this.BTN_Annuler.Text = "Annuler";
            this.BTN_Annuler.UseVisualStyleBackColor = false;
            this.BTN_Annuler.Visible = false;
            this.BTN_Annuler.Click += new System.EventHandler(this.BTN_Annuler_Click);
            // 
            // DataGrid_Barèmes
            // 
            this.DataGrid_Barèmes.AllowUserToResizeColumns = false;
            this.DataGrid_Barèmes.AllowUserToResizeRows = false;
            this.DataGrid_Barèmes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid_Barèmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Barèmes.Location = new System.Drawing.Point(15, 12);
            this.DataGrid_Barèmes.Name = "DataGrid_Barèmes";
            this.DataGrid_Barèmes.ReadOnly = true;
            this.DataGrid_Barèmes.RowHeadersVisible = false;
            this.DataGrid_Barèmes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_Barèmes.Size = new System.Drawing.Size(445, 204);
            this.DataGrid_Barèmes.TabIndex = 1;
            // 
            // CBox_TypeTarif
            // 
            this.CBox_TypeTarif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBox_TypeTarif.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBox_TypeTarif.FormattingEnabled = true;
            this.CBox_TypeTarif.Items.AddRange(new object[] {
            "Tarif Fixe",
            "Tarif Variable"});
            this.CBox_TypeTarif.Location = new System.Drawing.Point(54, 279);
            this.CBox_TypeTarif.Name = "CBox_TypeTarif";
            this.CBox_TypeTarif.Size = new System.Drawing.Size(121, 23);
            this.CBox_TypeTarif.TabIndex = 4;
            this.CBox_TypeTarif.Visible = false;
            // 
            // Tbox_Libelle
            // 
            this.Tbox_Libelle.Enabled = false;
            this.Tbox_Libelle.Location = new System.Drawing.Point(138, 231);
            this.Tbox_Libelle.Name = "Tbox_Libelle";
            this.Tbox_Libelle.Size = new System.Drawing.Size(322, 25);
            this.Tbox_Libelle.TabIndex = 3;
            this.Tbox_Libelle.Visible = false;
            // 
            // TBox_Type
            // 
            this.TBox_Type.Enabled = false;
            this.TBox_Type.Location = new System.Drawing.Point(54, 231);
            this.TBox_Type.Name = "TBox_Type";
            this.TBox_Type.Size = new System.Drawing.Size(78, 25);
            this.TBox_Type.TabIndex = 2;
            this.TBox_Type.Visible = false;
            // 
            // Label_Acte
            // 
            this.Label_Acte.AutoSize = true;
            this.Label_Acte.Location = new System.Drawing.Point(12, 234);
            this.Label_Acte.Name = "Label_Acte";
            this.Label_Acte.Size = new System.Drawing.Size(36, 17);
            this.Label_Acte.TabIndex = 6;
            this.Label_Acte.Text = "Acte";
            this.Label_Acte.Visible = false;
            // 
            // Label_Tarif
            // 
            this.Label_Tarif.AutoSize = true;
            this.Label_Tarif.Location = new System.Drawing.Point(12, 280);
            this.Label_Tarif.Name = "Label_Tarif";
            this.Label_Tarif.Size = new System.Drawing.Size(38, 17);
            this.Label_Tarif.TabIndex = 8;
            this.Label_Tarif.Text = "Tarif";
            this.Label_Tarif.Visible = false;
            // 
            // TBox_TarifMini
            // 
            this.TBox_TarifMini.Enabled = false;
            this.TBox_TarifMini.Location = new System.Drawing.Point(54, 310);
            this.TBox_TarifMini.Name = "TBox_TarifMini";
            this.TBox_TarifMini.Size = new System.Drawing.Size(78, 25);
            this.TBox_TarifMini.TabIndex = 6;
            this.TBox_TarifMini.Visible = false;
            // 
            // Label_Mini
            // 
            this.Label_Mini.AutoSize = true;
            this.Label_Mini.Location = new System.Drawing.Point(12, 313);
            this.Label_Mini.Name = "Label_Mini";
            this.Label_Mini.Size = new System.Drawing.Size(43, 17);
            this.Label_Mini.TabIndex = 9;
            this.Label_Mini.Text = "Mini :";
            this.Label_Mini.Visible = false;
            // 
            // TBox_TarifMaxi
            // 
            this.TBox_TarifMaxi.Enabled = false;
            this.TBox_TarifMaxi.Location = new System.Drawing.Point(239, 310);
            this.TBox_TarifMaxi.Name = "TBox_TarifMaxi";
            this.TBox_TarifMaxi.Size = new System.Drawing.Size(78, 25);
            this.TBox_TarifMaxi.TabIndex = 7;
            this.TBox_TarifMaxi.Visible = false;
            // 
            // Label_Maxi
            // 
            this.Label_Maxi.AutoSize = true;
            this.Label_Maxi.Location = new System.Drawing.Point(188, 313);
            this.Label_Maxi.Name = "Label_Maxi";
            this.Label_Maxi.Size = new System.Drawing.Size(45, 17);
            this.Label_Maxi.TabIndex = 11;
            this.Label_Maxi.Text = "Maxi :";
            this.Label_Maxi.Visible = false;
            // 
            // TBox_TarifFixe
            // 
            this.TBox_TarifFixe.Enabled = false;
            this.TBox_TarifFixe.Location = new System.Drawing.Point(239, 277);
            this.TBox_TarifFixe.Name = "TBox_TarifFixe";
            this.TBox_TarifFixe.Size = new System.Drawing.Size(78, 25);
            this.TBox_TarifFixe.TabIndex = 5;
            this.TBox_TarifFixe.Visible = false;
            // 
            // Label_Fixe
            // 
            this.Label_Fixe.AutoSize = true;
            this.Label_Fixe.Location = new System.Drawing.Point(192, 280);
            this.Label_Fixe.Name = "Label_Fixe";
            this.Label_Fixe.Size = new System.Drawing.Size(41, 17);
            this.Label_Fixe.TabIndex = 13;
            this.Label_Fixe.Text = "Fixe :";
            this.Label_Fixe.Visible = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(472, 348);
            this.shapeContainer1.TabIndex = 14;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 10;
            this.lineShape1.X2 = 463;
            this.lineShape1.Y1 = 267;
            this.lineShape1.Y2 = 267;
            // 
            // BTN_MiseAJour
            // 
            this.BTN_MiseAJour.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_MiseAJour.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_MiseAJour.Location = new System.Drawing.Point(345, 276);
            this.BTN_MiseAJour.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_MiseAJour.Name = "BTN_MiseAJour";
            this.BTN_MiseAJour.Size = new System.Drawing.Size(114, 25);
            this.BTN_MiseAJour.TabIndex = 15;
            this.BTN_MiseAJour.Text = "Mettre à Jour";
            this.BTN_MiseAJour.UseVisualStyleBackColor = false;
            this.BTN_MiseAJour.Click += new System.EventHandler(this.BTN_MiseAJour_Click);
            // 
            // FormBarèmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(472, 348);
            this.Controls.Add(this.BTN_MiseAJour);
            this.Controls.Add(this.TBox_TarifFixe);
            this.Controls.Add(this.Label_Fixe);
            this.Controls.Add(this.TBox_TarifMaxi);
            this.Controls.Add(this.Label_Maxi);
            this.Controls.Add(this.TBox_TarifMini);
            this.Controls.Add(this.Label_Mini);
            this.Controls.Add(this.Label_Tarif);
            this.Controls.Add(this.TBox_Type);
            this.Controls.Add(this.Label_Acte);
            this.Controls.Add(this.Tbox_Libelle);
            this.Controls.Add(this.CBox_TypeTarif);
            this.Controls.Add(this.DataGrid_Barèmes);
            this.Controls.Add(this.BTN_Annuler);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormBarèmes";
            this.Text = "Barème de Tarification";
            this.Load += new System.EventHandler(this.FormBarèmes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Barèmes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Annuler;
        private System.Windows.Forms.DataGridView DataGrid_Barèmes;
        private System.Windows.Forms.ComboBox CBox_TypeTarif;
        private System.Windows.Forms.TextBox Tbox_Libelle;
        private System.Windows.Forms.TextBox TBox_Type;
        private System.Windows.Forms.Label Label_Acte;
        private System.Windows.Forms.Label Label_Tarif;
        private System.Windows.Forms.TextBox TBox_TarifMini;
        private System.Windows.Forms.Label Label_Mini;
        private System.Windows.Forms.TextBox TBox_TarifMaxi;
        private System.Windows.Forms.Label Label_Maxi;
        private System.Windows.Forms.TextBox TBox_TarifFixe;
        private System.Windows.Forms.Label Label_Fixe;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button BTN_MiseAJour;
    }
}