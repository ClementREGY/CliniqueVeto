namespace CliniqueVeto
{
    partial class FormRelance
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
            this.DataGrid_Relance = new System.Windows.Forms.DataGridView();
            this.BTN_Generer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Relance)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_Relance
            // 
            this.DataGrid_Relance.AllowUserToResizeColumns = false;
            this.DataGrid_Relance.AllowUserToResizeRows = false;
            this.DataGrid_Relance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid_Relance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Relance.Location = new System.Drawing.Point(12, 12);
            this.DataGrid_Relance.MultiSelect = false;
            this.DataGrid_Relance.Name = "DataGrid_Relance";
            this.DataGrid_Relance.ReadOnly = true;
            this.DataGrid_Relance.RowHeadersVisible = false;
            this.DataGrid_Relance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_Relance.Size = new System.Drawing.Size(593, 179);
            this.DataGrid_Relance.TabIndex = 0;
            // 
            // BTN_Generer
            // 
            this.BTN_Generer.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Generer.Location = new System.Drawing.Point(239, 197);
            this.BTN_Generer.Name = "BTN_Generer";
            this.BTN_Generer.Size = new System.Drawing.Size(136, 23);
            this.BTN_Generer.TabIndex = 1;
            this.BTN_Generer.Text = "Générer la relance";
            this.BTN_Generer.UseVisualStyleBackColor = false;
            this.BTN_Generer.Click += new System.EventHandler(this.BTN_Envoie_Click);
            // 
            // FormRelance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(617, 233);
            this.Controls.Add(this.BTN_Generer);
            this.Controls.Add(this.DataGrid_Relance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormRelance";
            this.Text = "Relance";
            this.Load += new System.EventHandler(this.FormRelance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Relance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid_Relance;
        private System.Windows.Forms.Button BTN_Generer;

    }
}