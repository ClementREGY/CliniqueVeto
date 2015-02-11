namespace CliniqueVeto
{
    partial class FormFactures_Règlement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFactures_Règlement));
            this.BTN_Visualiser = new System.Windows.Forms.Button();
            this.DataGrid_Factures = new System.Windows.Forms.DataGridView();
            this.BTN_Régler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Factures)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Visualiser
            // 
            this.BTN_Visualiser.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Visualiser.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Visualiser.Location = new System.Drawing.Point(11, 165);
            this.BTN_Visualiser.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_Visualiser.Name = "BTN_Visualiser";
            this.BTN_Visualiser.Size = new System.Drawing.Size(160, 25);
            this.BTN_Visualiser.TabIndex = 4;
            this.BTN_Visualiser.Text = "Visualiser la Facture";
            this.BTN_Visualiser.UseVisualStyleBackColor = false;
            this.BTN_Visualiser.Click += new System.EventHandler(this.BTN_Visualiser_Click);
            // 
            // DataGrid_Factures
            // 
            this.DataGrid_Factures.AllowUserToResizeColumns = false;
            this.DataGrid_Factures.AllowUserToResizeRows = false;
            this.DataGrid_Factures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid_Factures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Factures.Location = new System.Drawing.Point(11, 13);
            this.DataGrid_Factures.Margin = new System.Windows.Forms.Padding(4);
            this.DataGrid_Factures.MultiSelect = false;
            this.DataGrid_Factures.Name = "DataGrid_Factures";
            this.DataGrid_Factures.ReadOnly = true;
            this.DataGrid_Factures.RowHeadersVisible = false;
            this.DataGrid_Factures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_Factures.Size = new System.Drawing.Size(567, 142);
            this.DataGrid_Factures.TabIndex = 3;
            this.DataGrid_Factures.SelectionChanged += new System.EventHandler(this.DataGrid_Factures_SelectionChanged);
            // 
            // BTN_Régler
            // 
            this.BTN_Régler.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Régler.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Régler.ForeColor = System.Drawing.Color.Green;
            this.BTN_Régler.Location = new System.Drawing.Point(418, 165);
            this.BTN_Régler.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_Régler.Name = "BTN_Régler";
            this.BTN_Régler.Size = new System.Drawing.Size(160, 25);
            this.BTN_Régler.TabIndex = 5;
            this.BTN_Régler.Text = "Facture Réglée";
            this.BTN_Régler.UseVisualStyleBackColor = false;
            this.BTN_Régler.Click += new System.EventHandler(this.BTN_Régler_Click);
            // 
            // FormFactures_Règlement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(589, 200);
            this.Controls.Add(this.BTN_Régler);
            this.Controls.Add(this.BTN_Visualiser);
            this.Controls.Add(this.DataGrid_Factures);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormFactures_Règlement";
            this.Text = "Factures Impayées";
            this.Load += new System.EventHandler(this.FormFactures_Règlement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Factures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Visualiser;
        private System.Windows.Forms.DataGridView DataGrid_Factures;
        private System.Windows.Forms.Button BTN_Régler;

    }
}