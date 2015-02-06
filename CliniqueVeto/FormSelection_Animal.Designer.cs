namespace CliniqueVeto
{
    partial class FormSelection_Animal
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
            this.CBox_Animal = new System.Windows.Forms.ComboBox();
            this.Label_Animal = new System.Windows.Forms.Label();
            this.CBox_Client = new System.Windows.Forms.ComboBox();
            this.Label_Client = new System.Windows.Forms.Label();
            this.BTN_Valider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CBox_Animal
            // 
            this.CBox_Animal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBox_Animal.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBox_Animal.FormattingEnabled = true;
            this.CBox_Animal.Location = new System.Drawing.Point(15, 82);
            this.CBox_Animal.Name = "CBox_Animal";
            this.CBox_Animal.Size = new System.Drawing.Size(231, 23);
            this.CBox_Animal.TabIndex = 9;
            // 
            // Label_Animal
            // 
            this.Label_Animal.AutoSize = true;
            this.Label_Animal.Location = new System.Drawing.Point(12, 60);
            this.Label_Animal.Name = "Label_Animal";
            this.Label_Animal.Size = new System.Drawing.Size(52, 17);
            this.Label_Animal.TabIndex = 8;
            this.Label_Animal.Text = "Animal";
            // 
            // CBox_Client
            // 
            this.CBox_Client.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBox_Client.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBox_Client.FormattingEnabled = true;
            this.CBox_Client.Location = new System.Drawing.Point(15, 31);
            this.CBox_Client.Name = "CBox_Client";
            this.CBox_Client.Size = new System.Drawing.Size(231, 23);
            this.CBox_Client.TabIndex = 7;
            this.CBox_Client.SelectedIndexChanged += new System.EventHandler(this.CBox_Client_SelectedIndexChanged);
            // 
            // Label_Client
            // 
            this.Label_Client.AutoSize = true;
            this.Label_Client.Location = new System.Drawing.Point(12, 9);
            this.Label_Client.Name = "Label_Client";
            this.Label_Client.Size = new System.Drawing.Size(44, 17);
            this.Label_Client.TabIndex = 6;
            this.Label_Client.Text = "Client";
            // 
            // BTN_Valider
            // 
            this.BTN_Valider.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Valider.Location = new System.Drawing.Point(15, 124);
            this.BTN_Valider.Name = "BTN_Valider";
            this.BTN_Valider.Size = new System.Drawing.Size(231, 26);
            this.BTN_Valider.TabIndex = 10;
            this.BTN_Valider.Text = "Valider";
            this.BTN_Valider.UseVisualStyleBackColor = false;
            this.BTN_Valider.Click += new System.EventHandler(this.BTN_Valider_Click);
            // 
            // FormSelection_Animal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(258, 162);
            this.Controls.Add(this.BTN_Valider);
            this.Controls.Add(this.CBox_Animal);
            this.Controls.Add(this.Label_Animal);
            this.Controls.Add(this.CBox_Client);
            this.Controls.Add(this.Label_Client);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormSelection_Animal";
            this.Text = "Clients / Animaux";
            this.Load += new System.EventHandler(this.FormSelection_Animal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBox_Animal;
        private System.Windows.Forms.Label Label_Animal;
        private System.Windows.Forms.ComboBox CBox_Client;
        private System.Windows.Forms.Label Label_Client;
        private System.Windows.Forms.Button BTN_Valider;
    }
}