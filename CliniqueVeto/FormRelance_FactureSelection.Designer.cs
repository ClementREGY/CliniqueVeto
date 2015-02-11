namespace CliniqueVeto
{
    partial class FormRelance_FactureSelection
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
            this.BTN_GenererRelance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Relance)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_Relance
            // 
            this.DataGrid_Relance.AllowUserToResizeColumns = false;
            this.DataGrid_Relance.AllowUserToResizeRows = false;
            this.DataGrid_Relance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Relance.Location = new System.Drawing.Point(13, 13);
            this.DataGrid_Relance.Margin = new System.Windows.Forms.Padding(4);
            this.DataGrid_Relance.Name = "DataGrid_Relance";
            this.DataGrid_Relance.RowHeadersVisible = false;
            this.DataGrid_Relance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_Relance.Size = new System.Drawing.Size(498, 247);
            this.DataGrid_Relance.TabIndex = 0;
            // 
            // BTN_GenererRelance
            // 
            this.BTN_GenererRelance.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_GenererRelance.Location = new System.Drawing.Point(172, 268);
            this.BTN_GenererRelance.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_GenererRelance.Name = "BTN_GenererRelance";
            this.BTN_GenererRelance.Size = new System.Drawing.Size(155, 30);
            this.BTN_GenererRelance.TabIndex = 1;
            this.BTN_GenererRelance.Text = "Générer la Relance";
            this.BTN_GenererRelance.UseVisualStyleBackColor = false;
            this.BTN_GenererRelance.Click += new System.EventHandler(this.BTN_GenererRelance_Click);
            // 
            // FormRelance_FactureSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(524, 307);
            this.Controls.Add(this.BTN_GenererRelance);
            this.Controls.Add(this.DataGrid_Relance);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRelance_FactureSelection";
            this.Text = "Sélection de la relance";
            this.Load += new System.EventHandler(this.FormRelance_FactureSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Relance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid_Relance;
        private System.Windows.Forms.Button BTN_GenererRelance;
    }
}