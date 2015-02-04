namespace CliniqueVeto
{
    partial class FormReinit_Vétérinaire
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
            this.Label_Password2 = new System.Windows.Forms.Label();
            this.TBox_Password2 = new System.Windows.Forms.TextBox();
            this.Label_Password = new System.Windows.Forms.Label();
            this.TBox_Password = new System.Windows.Forms.TextBox();
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.BTN_Valider = new System.Windows.Forms.Button();
            this.errorSaisie = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorSaisie)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Password2
            // 
            this.Label_Password2.AutoSize = true;
            this.Label_Password2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Password2.Location = new System.Drawing.Point(15, 56);
            this.Label_Password2.Name = "Label_Password2";
            this.Label_Password2.Size = new System.Drawing.Size(192, 18);
            this.Label_Password2.TabIndex = 15;
            this.Label_Password2.Text = "Retaper le Mot de Passe";
            // 
            // TBox_Password2
            // 
            this.TBox_Password2.Location = new System.Drawing.Point(218, 55);
            this.TBox_Password2.Name = "TBox_Password2";
            this.TBox_Password2.Size = new System.Drawing.Size(148, 23);
            this.TBox_Password2.TabIndex = 11;
            this.TBox_Password2.UseSystemPasswordChar = true;
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Password.Location = new System.Drawing.Point(39, 22);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(168, 18);
            this.Label_Password.TabIndex = 14;
            this.Label_Password.Text = "Nouveau Mot de Passe";
            // 
            // TBox_Password
            // 
            this.TBox_Password.Location = new System.Drawing.Point(218, 21);
            this.TBox_Password.Name = "TBox_Password";
            this.TBox_Password.Size = new System.Drawing.Size(148, 23);
            this.TBox_Password.TabIndex = 10;
            this.TBox_Password.UseSystemPasswordChar = true;
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Annuler.Location = new System.Drawing.Point(18, 125);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(353, 23);
            this.BTN_Annuler.TabIndex = 17;
            this.BTN_Annuler.Text = "Annuler";
            this.BTN_Annuler.UseVisualStyleBackColor = false;
            // 
            // BTN_Valider
            // 
            this.BTN_Valider.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Valider.Location = new System.Drawing.Point(18, 96);
            this.BTN_Valider.Name = "BTN_Valider";
            this.BTN_Valider.Size = new System.Drawing.Size(353, 23);
            this.BTN_Valider.TabIndex = 16;
            this.BTN_Valider.Text = "Valider";
            this.BTN_Valider.UseVisualStyleBackColor = false;
            this.BTN_Valider.Click += new System.EventHandler(this.BTN_Valider_Click);
            // 
            // errorSaisie
            // 
            this.errorSaisie.ContainerControl = this;
            // 
            // FormReinit_Vétérinaire
            // 
            this.AcceptButton = this.BTN_Valider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.CancelButton = this.BTN_Annuler;
            this.ClientSize = new System.Drawing.Size(383, 156);
            this.Controls.Add(this.BTN_Annuler);
            this.Controls.Add(this.BTN_Valider);
            this.Controls.Add(this.Label_Password2);
            this.Controls.Add(this.TBox_Password2);
            this.Controls.Add(this.Label_Password);
            this.Controls.Add(this.TBox_Password);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormReinit_Vétérinaire";
            this.Text = "Réinitialiser le Mot de Passe";
            ((System.ComponentModel.ISupportInitialize)(this.errorSaisie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Password2;
        private System.Windows.Forms.TextBox TBox_Password2;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.TextBox TBox_Password;
        private System.Windows.Forms.Button BTN_Annuler;
        public System.Windows.Forms.Button BTN_Valider;
        private System.Windows.Forms.ErrorProvider errorSaisie;
    }
}