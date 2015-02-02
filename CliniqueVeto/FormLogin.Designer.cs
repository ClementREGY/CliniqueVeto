namespace CliniqueVeto
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.TBox_User = new System.Windows.Forms.TextBox();
            this.TBox_Password = new System.Windows.Forms.TextBox();
            this.Label_User = new System.Windows.Forms.Label();
            this.Label_Password = new System.Windows.Forms.Label();
            this.BTN_Valider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBox_User
            // 
            this.TBox_User.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBox_User.Location = new System.Drawing.Point(122, 20);
            this.TBox_User.Name = "TBox_User";
            this.TBox_User.Size = new System.Drawing.Size(184, 26);
            this.TBox_User.TabIndex = 0;
            // 
            // TBox_Password
            // 
            this.TBox_Password.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBox_Password.Location = new System.Drawing.Point(122, 55);
            this.TBox_Password.Name = "TBox_Password";
            this.TBox_Password.Size = new System.Drawing.Size(184, 26);
            this.TBox_Password.TabIndex = 1;
            // 
            // Label_User
            // 
            this.Label_User.AutoSize = true;
            this.Label_User.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_User.Location = new System.Drawing.Point(28, 23);
            this.Label_User.Name = "Label_User";
            this.Label_User.Size = new System.Drawing.Size(88, 19);
            this.Label_User.TabIndex = 2;
            this.Label_User.Text = "Utilisateur :";
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Password.Location = new System.Drawing.Point(8, 58);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(108, 19);
            this.Label_Password.TabIndex = 3;
            this.Label_Password.Text = "Mot de Passe :";
            // 
            // BTN_Valider
            // 
            this.BTN_Valider.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Valider.Location = new System.Drawing.Point(181, 98);
            this.BTN_Valider.Name = "BTN_Valider";
            this.BTN_Valider.Size = new System.Drawing.Size(125, 30);
            this.BTN_Valider.TabIndex = 4;
            this.BTN_Valider.Text = "Se Connecter";
            this.BTN_Valider.UseVisualStyleBackColor = true;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 140);
            this.Controls.Add(this.BTN_Valider);
            this.Controls.Add(this.Label_Password);
            this.Controls.Add(this.Label_User);
            this.Controls.Add(this.TBox_Password);
            this.Controls.Add(this.TBox_User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBox_User;
        private System.Windows.Forms.TextBox TBox_Password;
        private System.Windows.Forms.Label Label_User;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.Button BTN_Valider;
    }
}

