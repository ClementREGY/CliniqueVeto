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
            this.DataGrid_Relance.Location = new System.Drawing.Point(16, 16);
            this.DataGrid_Relance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGrid_Relance.MultiSelect = false;
            this.DataGrid_Relance.Name = "DataGrid_Relance";
            this.DataGrid_Relance.ReadOnly = true;
            this.DataGrid_Relance.RowHeadersVisible = false;
            this.DataGrid_Relance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_Relance.Size = new System.Drawing.Size(553, 153);
            this.DataGrid_Relance.TabIndex = 0;
            // 
            // BTN_Generer
            // 
            this.BTN_Generer.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Generer.Location = new System.Drawing.Point(221, 177);
            this.BTN_Generer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_Generer.Name = "BTN_Generer";
            this.BTN_Generer.Size = new System.Drawing.Size(141, 30);
            this.BTN_Generer.TabIndex = 1;
            this.BTN_Generer.Text = "Générer la relance";
            this.BTN_Generer.UseVisualStyleBackColor = false;
            this.BTN_Generer.Click += new System.EventHandler(this.BTN_Envoie_Click);
            // 
            // FormRelance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(582, 214);
            this.Controls.Add(this.BTN_Generer);
            this.Controls.Add(this.DataGrid_Relance);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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