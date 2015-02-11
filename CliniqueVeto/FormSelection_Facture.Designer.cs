namespace CliniqueVeto
{
    partial class FormSelection_Facture
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
            this.BTN_Imprimer = new System.Windows.Forms.Button();
            this.BTN_Visualiser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Factures)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_Factures
            // 
            this.DataGrid_Factures.AllowUserToResizeColumns = false;
            this.DataGrid_Factures.AllowUserToResizeRows = false;
            this.DataGrid_Factures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid_Factures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Factures.Location = new System.Drawing.Point(16, 16);
            this.DataGrid_Factures.Margin = new System.Windows.Forms.Padding(4);
            this.DataGrid_Factures.MultiSelect = false;
            this.DataGrid_Factures.Name = "DataGrid_Factures";
            this.DataGrid_Factures.ReadOnly = true;
            this.DataGrid_Factures.RowHeadersVisible = false;
            this.DataGrid_Factures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_Factures.Size = new System.Drawing.Size(567, 142);
            this.DataGrid_Factures.TabIndex = 0;
            this.DataGrid_Factures.SelectionChanged += new System.EventHandler(this.DataGrid_Factures_SelectionChanged);
            // 
            // BTN_Imprimer
            // 
            this.BTN_Imprimer.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Imprimer.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Imprimer.Location = new System.Drawing.Point(423, 168);
            this.BTN_Imprimer.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_Imprimer.Name = "BTN_Imprimer";
            this.BTN_Imprimer.Size = new System.Drawing.Size(160, 25);
            this.BTN_Imprimer.TabIndex = 2;
            this.BTN_Imprimer.Text = "Imprimer la Facture";
            this.BTN_Imprimer.UseVisualStyleBackColor = false;
            this.BTN_Imprimer.Click += new System.EventHandler(this.BTN_Imprimer_Click);
            // 
            // BTN_Visualiser
            // 
            this.BTN_Visualiser.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Visualiser.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Visualiser.Location = new System.Drawing.Point(16, 168);
            this.BTN_Visualiser.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_Visualiser.Name = "BTN_Visualiser";
            this.BTN_Visualiser.Size = new System.Drawing.Size(160, 25);
            this.BTN_Visualiser.TabIndex = 1;
            this.BTN_Visualiser.Text = "Visualiser la Facture";
            this.BTN_Visualiser.UseVisualStyleBackColor = false;
            this.BTN_Visualiser.Click += new System.EventHandler(this.BTN_Visualiser_Click);
            // 
            // FormSelection_Facture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(596, 204);
            this.Controls.Add(this.BTN_Visualiser);
            this.Controls.Add(this.BTN_Imprimer);
            this.Controls.Add(this.DataGrid_Factures);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSelection_Facture";
            this.Text = "Factures à Imprimer";
            this.Load += new System.EventHandler(this.FormSelection_Facture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Factures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid_Factures;
        private System.Windows.Forms.Button BTN_Imprimer;
        private System.Windows.Forms.Button BTN_Visualiser;
    }
}