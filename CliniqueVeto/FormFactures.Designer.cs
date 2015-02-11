namespace CliniqueVeto
{
    partial class FormFactures
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
            this.DataGrid_Factures = new System.Windows.Forms.DataGridView();
            this.BTN_Créer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Factures)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_Factures
            // 
            this.DataGrid_Factures.AllowUserToResizeColumns = false;
            this.DataGrid_Factures.AllowUserToResizeRows = false;
            this.DataGrid_Factures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid_Factures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Factures.Location = new System.Drawing.Point(12, 12);
            this.DataGrid_Factures.MultiSelect = false;
            this.DataGrid_Factures.Name = "DataGrid_Factures";
            this.DataGrid_Factures.ReadOnly = true;
            this.DataGrid_Factures.RowHeadersVisible = false;
            this.DataGrid_Factures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_Factures.Size = new System.Drawing.Size(553, 149);
            this.DataGrid_Factures.TabIndex = 0;
            this.DataGrid_Factures.SelectionChanged += new System.EventHandler(this.DataGrid_Factures_SelectionChanged);
            // 
            // BTN_Créer
            // 
            this.BTN_Créer.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Créer.Location = new System.Drawing.Point(424, 168);
            this.BTN_Créer.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Créer.Name = "BTN_Créer";
            this.BTN_Créer.Size = new System.Drawing.Size(141, 25);
            this.BTN_Créer.TabIndex = 2;
            this.BTN_Créer.Text = "Créer la Facture";
            this.BTN_Créer.UseVisualStyleBackColor = false;
            this.BTN_Créer.Click += new System.EventHandler(this.BTN_Créer_Click);
            // 
            // FormFactures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(577, 203);
            this.Controls.Add(this.BTN_Créer);
            this.Controls.Add(this.DataGrid_Factures);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormFactures";
            this.Text = "Factures à Créer";
            this.Load += new System.EventHandler(this.FormFactures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Factures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid_Factures;
        private System.Windows.Forms.Button BTN_Créer;
    }
}