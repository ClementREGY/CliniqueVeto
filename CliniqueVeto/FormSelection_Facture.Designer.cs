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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTN_Créer = new System.Windows.Forms.Button();
            this.BTN_Visualiser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 16);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(523, 142);
            this.dataGridView1.TabIndex = 0;
            // 
            // BTN_Créer
            // 
            this.BTN_Créer.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Créer.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Créer.Location = new System.Drawing.Point(392, 167);
            this.BTN_Créer.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BTN_Créer.Name = "BTN_Créer";
            this.BTN_Créer.Size = new System.Drawing.Size(147, 30);
            this.BTN_Créer.TabIndex = 3;
            this.BTN_Créer.Text = "Créer la Facture";
            this.BTN_Créer.UseVisualStyleBackColor = false;
            // 
            // BTN_Visualiser
            // 
            this.BTN_Visualiser.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Visualiser.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Visualiser.Location = new System.Drawing.Point(16, 167);
            this.BTN_Visualiser.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BTN_Visualiser.Name = "BTN_Visualiser";
            this.BTN_Visualiser.Size = new System.Drawing.Size(159, 30);
            this.BTN_Visualiser.TabIndex = 4;
            this.BTN_Visualiser.Text = "Visualiser la Facture";
            this.BTN_Visualiser.UseVisualStyleBackColor = false;
            // 
            // FormSelection_Facture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(552, 207);
            this.Controls.Add(this.BTN_Visualiser);
            this.Controls.Add(this.BTN_Créer);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormSelection_Facture";
            this.Text = "Factures à Imprimer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTN_Créer;
        private System.Windows.Forms.Button BTN_Visualiser;
    }
}