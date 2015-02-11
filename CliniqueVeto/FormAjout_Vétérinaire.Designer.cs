namespace CliniqueVeto
{
    partial class FormAjout_Vétérinaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjout_Vétérinaire));
            this.TBox_Nom = new System.Windows.Forms.TextBox();
            this.TBox_Prénom = new System.Windows.Forms.TextBox();
            this.TBox_Password = new System.Windows.Forms.TextBox();
            this.BTN_Valider = new System.Windows.Forms.Button();
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.Label_Nom = new System.Windows.Forms.Label();
            this.Label_Prénom = new System.Windows.Forms.Label();
            this.Label_Password = new System.Windows.Forms.Label();
            this.Label_Password2 = new System.Windows.Forms.Label();
            this.TBox_Password2 = new System.Windows.Forms.TextBox();
            this.errorSaisie = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorSaisie)).BeginInit();
            this.SuspendLayout();
            // 
            // TBox_Nom
            // 
            this.TBox_Nom.Location = new System.Drawing.Point(81, 25);
            this.TBox_Nom.Name = "TBox_Nom";
            this.TBox_Nom.Size = new System.Drawing.Size(232, 23);
            this.TBox_Nom.TabIndex = 0;
            // 
            // TBox_Prénom
            // 
            this.TBox_Prénom.Location = new System.Drawing.Point(81, 54);
            this.TBox_Prénom.Name = "TBox_Prénom";
            this.TBox_Prénom.Size = new System.Drawing.Size(232, 23);
            this.TBox_Prénom.TabIndex = 1;
            // 
            // TBox_Password
            // 
            this.TBox_Password.Location = new System.Drawing.Point(187, 97);
            this.TBox_Password.Name = "TBox_Password";
            this.TBox_Password.Size = new System.Drawing.Size(126, 23);
            this.TBox_Password.TabIndex = 2;
            this.TBox_Password.UseSystemPasswordChar = true;
            // 
            // BTN_Valider
            // 
            this.BTN_Valider.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Valider.Location = new System.Drawing.Point(12, 169);
            this.BTN_Valider.Name = "BTN_Valider";
            this.BTN_Valider.Size = new System.Drawing.Size(309, 23);
            this.BTN_Valider.TabIndex = 4;
            this.BTN_Valider.Text = "Valider";
            this.BTN_Valider.UseVisualStyleBackColor = false;
            this.BTN_Valider.Click += new System.EventHandler(this.BTN_Valider_Click);
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Annuler.Location = new System.Drawing.Point(12, 198);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(309, 23);
            this.BTN_Annuler.TabIndex = 5;
            this.BTN_Annuler.Text = "Annuler";
            this.BTN_Annuler.UseVisualStyleBackColor = false;
            // 
            // Label_Nom
            // 
            this.Label_Nom.AutoSize = true;
            this.Label_Nom.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Nom.Location = new System.Drawing.Point(13, 26);
            this.Label_Nom.Name = "Label_Nom";
            this.Label_Nom.Size = new System.Drawing.Size(32, 18);
            this.Label_Nom.TabIndex = 5;
            this.Label_Nom.Text = "Nom";
            // 
            // Label_Prénom
            // 
            this.Label_Prénom.AutoSize = true;
            this.Label_Prénom.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Prénom.Location = new System.Drawing.Point(13, 55);
            this.Label_Prénom.Name = "Label_Prénom";
            this.Label_Prénom.Size = new System.Drawing.Size(56, 18);
            this.Label_Prénom.TabIndex = 6;
            this.Label_Prénom.Text = "Prénom";
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Password.Location = new System.Drawing.Point(77, 98);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(104, 18);
            this.Label_Password.TabIndex = 7;
            this.Label_Password.Text = "Mot de Passe";
            // 
            // Label_Password2
            // 
            this.Label_Password2.AutoSize = true;
            this.Label_Password2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Password2.Location = new System.Drawing.Point(13, 127);
            this.Label_Password2.Name = "Label_Password2";
            this.Label_Password2.Size = new System.Drawing.Size(168, 18);
            this.Label_Password2.TabIndex = 9;
            this.Label_Password2.Text = "Retaper Mot de Passe";
            // 
            // TBox_Password2
            // 
            this.TBox_Password2.Location = new System.Drawing.Point(187, 126);
            this.TBox_Password2.Name = "TBox_Password2";
            this.TBox_Password2.Size = new System.Drawing.Size(126, 23);
            this.TBox_Password2.TabIndex = 3;
            this.TBox_Password2.UseSystemPasswordChar = true;
            // 
            // errorSaisie
            // 
            this.errorSaisie.ContainerControl = this;
            // 
            // FormAjout_Vétérinaire
            // 
            this.AcceptButton = this.BTN_Valider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.CancelButton = this.BTN_Annuler;
            this.ClientSize = new System.Drawing.Size(333, 232);
            this.Controls.Add(this.Label_Password2);
            this.Controls.Add(this.TBox_Password2);
            this.Controls.Add(this.Label_Password);
            this.Controls.Add(this.Label_Prénom);
            this.Controls.Add(this.Label_Nom);
            this.Controls.Add(this.BTN_Annuler);
            this.Controls.Add(this.BTN_Valider);
            this.Controls.Add(this.TBox_Password);
            this.Controls.Add(this.TBox_Prénom);
            this.Controls.Add(this.TBox_Nom);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAjout_Vétérinaire";
            this.Text = "Ajouter un Vétérinaire";
            ((System.ComponentModel.ISupportInitialize)(this.errorSaisie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBox_Nom;
        private System.Windows.Forms.TextBox TBox_Prénom;
        private System.Windows.Forms.TextBox TBox_Password;
        private System.Windows.Forms.Button BTN_Annuler;
        private System.Windows.Forms.Label Label_Nom;
        private System.Windows.Forms.Label Label_Prénom;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.Label Label_Password2;
        private System.Windows.Forms.ErrorProvider errorSaisie;
        public System.Windows.Forms.Button BTN_Valider;
        private System.Windows.Forms.TextBox TBox_Password2;
    }
}