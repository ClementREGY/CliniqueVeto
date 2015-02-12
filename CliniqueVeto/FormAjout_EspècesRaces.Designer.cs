namespace CliniqueVeto
{
    partial class FormAjout_EspècesRaces
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjout_EspècesRaces));
            this.Label_Race = new System.Windows.Forms.Label();
            this.Label_Espèce = new System.Windows.Forms.Label();
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.BTN_Valider = new System.Windows.Forms.Button();
            this.TBox_Race = new System.Windows.Forms.TextBox();
            this.TBox_Espèce = new System.Windows.Forms.TextBox();
            this.errorSaisie = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorSaisie)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Race
            // 
            this.Label_Race.AutoSize = true;
            this.Label_Race.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Race.Location = new System.Drawing.Point(15, 46);
            this.Label_Race.Name = "Label_Race";
            this.Label_Race.Size = new System.Drawing.Size(40, 18);
            this.Label_Race.TabIndex = 17;
            this.Label_Race.Text = "Race";
            // 
            // Label_Espèce
            // 
            this.Label_Espèce.AutoSize = true;
            this.Label_Espèce.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Espèce.Location = new System.Drawing.Point(15, 17);
            this.Label_Espèce.Name = "Label_Espèce";
            this.Label_Espèce.Size = new System.Drawing.Size(56, 18);
            this.Label_Espèce.TabIndex = 15;
            this.Label_Espèce.Text = "Espèce";
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Annuler.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Annuler.Location = new System.Drawing.Point(16, 120);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(309, 25);
            this.BTN_Annuler.TabIndex = 16;
            this.BTN_Annuler.Text = "Annuler";
            this.BTN_Annuler.UseVisualStyleBackColor = false;
            // 
            // BTN_Valider
            // 
            this.BTN_Valider.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Valider.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Valider.Location = new System.Drawing.Point(16, 89);
            this.BTN_Valider.Name = "BTN_Valider";
            this.BTN_Valider.Size = new System.Drawing.Size(309, 25);
            this.BTN_Valider.TabIndex = 14;
            this.BTN_Valider.Text = "Valider";
            this.BTN_Valider.UseVisualStyleBackColor = false;
            this.BTN_Valider.Click += new System.EventHandler(this.BTN_Valider_Click);
            // 
            // TBox_Race
            // 
            this.TBox_Race.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBox_Race.Location = new System.Drawing.Point(83, 43);
            this.TBox_Race.Name = "TBox_Race";
            this.TBox_Race.Size = new System.Drawing.Size(240, 25);
            this.TBox_Race.TabIndex = 11;
            // 
            // TBox_Espèce
            // 
            this.TBox_Espèce.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBox_Espèce.Location = new System.Drawing.Point(83, 14);
            this.TBox_Espèce.Name = "TBox_Espèce";
            this.TBox_Espèce.Size = new System.Drawing.Size(240, 25);
            this.TBox_Espèce.TabIndex = 10;
            // 
            // errorSaisie
            // 
            this.errorSaisie.ContainerControl = this;
            // 
            // FormAjout_EspècesRaces
            // 
            this.AcceptButton = this.BTN_Valider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.CancelButton = this.BTN_Annuler;
            this.ClientSize = new System.Drawing.Size(337, 157);
            this.Controls.Add(this.Label_Race);
            this.Controls.Add(this.Label_Espèce);
            this.Controls.Add(this.BTN_Annuler);
            this.Controls.Add(this.BTN_Valider);
            this.Controls.Add(this.TBox_Race);
            this.Controls.Add(this.TBox_Espèce);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAjout_EspècesRaces";
            this.Text = "Ajout d\'une Espèce";
            this.Load += new System.EventHandler(this.FormAjout_EspècesRaces_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorSaisie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Race;
        private System.Windows.Forms.Label Label_Espèce;
        private System.Windows.Forms.Button BTN_Annuler;
        public System.Windows.Forms.Button BTN_Valider;
        private System.Windows.Forms.TextBox TBox_Race;
        private System.Windows.Forms.TextBox TBox_Espèce;
        private System.Windows.Forms.ErrorProvider errorSaisie;
    }
}