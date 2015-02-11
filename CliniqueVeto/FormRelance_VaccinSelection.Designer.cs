namespace CliniqueVeto
{
    partial class FormRelance_VaccinSelection
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
            this.BTN_Générer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Relance)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_Relance
            // 
            this.DataGrid_Relance.AllowUserToResizeColumns = false;
            this.DataGrid_Relance.AllowUserToResizeRows = false;
            this.DataGrid_Relance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGrid_Relance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Relance.Location = new System.Drawing.Point(16, 16);
            this.DataGrid_Relance.Margin = new System.Windows.Forms.Padding(4);
            this.DataGrid_Relance.Name = "DataGrid_Relance";
            this.DataGrid_Relance.RowHeadersVisible = false;
            this.DataGrid_Relance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_Relance.Size = new System.Drawing.Size(622, 153);
            this.DataGrid_Relance.TabIndex = 0;
            // 
            // BTN_Générer
            // 
            this.BTN_Générer.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Générer.Location = new System.Drawing.Point(255, 179);
            this.BTN_Générer.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Générer.Name = "BTN_Générer";
            this.BTN_Générer.Size = new System.Drawing.Size(141, 25);
            this.BTN_Générer.TabIndex = 1;
            this.BTN_Générer.Text = "Générer la Relance";
            this.BTN_Générer.UseVisualStyleBackColor = false;
            this.BTN_Générer.Click += new System.EventHandler(this.BTN_Générer_Click);
            // 
            // FormRelance_VaccinSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(651, 214);
            this.Controls.Add(this.BTN_Générer);
            this.Controls.Add(this.DataGrid_Relance);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRelance_VaccinSelection";
            this.Text = "Relance";
            this.Load += new System.EventHandler(this.FormRelance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Relance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid_Relance;
        private System.Windows.Forms.Button BTN_Générer;

    }
}