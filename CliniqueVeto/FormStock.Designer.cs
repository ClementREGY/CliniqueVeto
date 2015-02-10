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
            this.components = new System.ComponentModel.Container();
            this.BTN_MiseAJour = new System.Windows.Forms.Button();
            this.Label_Fournisseur = new System.Windows.Forms.Label();
            this.CBox_Fournisseurs = new System.Windows.Forms.ComboBox();
            this.Label_Nombre = new System.Windows.Forms.Label();
            this.TBox_Nombre = new System.Windows.Forms.TextBox();
            this.DataGrid_Vaccins = new System.Windows.Forms.DataGridView();
            this.errorSaisie = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Vaccins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSaisie)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_MiseAJour
            // 
            this.BTN_MiseAJour.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_MiseAJour.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_MiseAJour.Location = new System.Drawing.Point(427, 183);
            this.BTN_MiseAJour.Margin = new System.Windows.Forms.Padding(4);
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
            this.CBox_Fournisseurs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBox_Fournisseurs.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBox_Fournisseurs.FormattingEnabled = true;
            this.CBox_Fournisseurs.Location = new System.Drawing.Point(96, 186);
            this.CBox_Fournisseurs.Margin = new System.Windows.Forms.Padding(4);
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
            // DataGrid_Vaccins
            // 
            this.DataGrid_Vaccins.AllowUserToResizeColumns = false;
            this.DataGrid_Vaccins.AllowUserToResizeRows = false;
            this.DataGrid_Vaccins.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid_Vaccins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Vaccins.Location = new System.Drawing.Point(12, 12);
            this.DataGrid_Vaccins.MultiSelect = false;
            this.DataGrid_Vaccins.Name = "DataGrid_Vaccins";
            this.DataGrid_Vaccins.ReadOnly = true;
            this.DataGrid_Vaccins.RowHeadersVisible = false;
            this.DataGrid_Vaccins.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_Vaccins.Size = new System.Drawing.Size(528, 164);
            this.DataGrid_Vaccins.TabIndex = 6;
            this.DataGrid_Vaccins.SelectionChanged += new System.EventHandler(this.DataGrid_Vaccins_SelectionChanged);
            // 
            // errorSaisie
            // 
            this.errorSaisie.ContainerControl = this;
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(554, 222);
            this.Controls.Add(this.DataGrid_Vaccins);
            this.Controls.Add(this.TBox_Nombre);
            this.Controls.Add(this.Label_Nombre);
            this.Controls.Add(this.CBox_Fournisseurs);
            this.Controls.Add(this.Label_Fournisseur);
            this.Controls.Add(this.BTN_MiseAJour);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormStock";
            this.Text = "Stock des Vaccins";
            this.Load += new System.EventHandler(this.FormStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Vaccins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSaisie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_MiseAJour;
        private System.Windows.Forms.Label Label_Fournisseur;
        private System.Windows.Forms.ComboBox CBox_Fournisseurs;
        private System.Windows.Forms.Label Label_Nombre;
        private System.Windows.Forms.TextBox TBox_Nombre;
        private System.Windows.Forms.DataGridView DataGrid_Vaccins;
        private System.Windows.Forms.ErrorProvider errorSaisie;
    }
}