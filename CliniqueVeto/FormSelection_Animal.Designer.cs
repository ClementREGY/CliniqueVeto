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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelection_Animal));
            this.CBox_Animal = new System.Windows.Forms.ComboBox();
            this.Label_Animal = new System.Windows.Forms.Label();
            this.CBox_Client = new System.Windows.Forms.ComboBox();
            this.Label_Client = new System.Windows.Forms.Label();
            this.BTN_Valider = new System.Windows.Forms.Button();
            this.TBox_Recherche = new System.Windows.Forms.TextBox();
            this.BTN_Rechercher = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.Line = new Microsoft.VisualBasic.PowerPacks.LineShape();
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
            this.BTN_Valider.Location = new System.Drawing.Point(15, 180);
            this.BTN_Valider.Name = "BTN_Valider";
            this.BTN_Valider.Size = new System.Drawing.Size(231, 26);
            this.BTN_Valider.TabIndex = 12;
            this.BTN_Valider.Text = "Valider";
            this.BTN_Valider.UseVisualStyleBackColor = false;
            this.BTN_Valider.Click += new System.EventHandler(this.BTN_Valider_Click);
            // 
            // TBox_Recherche
            // 
            this.TBox_Recherche.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBox_Recherche.ForeColor = System.Drawing.Color.Black;
            this.TBox_Recherche.Location = new System.Drawing.Point(15, 138);
            this.TBox_Recherche.Name = "TBox_Recherche";
            this.TBox_Recherche.Size = new System.Drawing.Size(199, 26);
            this.TBox_Recherche.TabIndex = 10;
            // 
            // BTN_Rechercher
            // 
            this.BTN_Rechercher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Rechercher.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Rechercher.Image")));
            this.BTN_Rechercher.Location = new System.Drawing.Point(220, 137);
            this.BTN_Rechercher.Name = "BTN_Rechercher";
            this.BTN_Rechercher.Size = new System.Drawing.Size(26, 26);
            this.BTN_Rechercher.TabIndex = 11;
            this.BTN_Rechercher.UseVisualStyleBackColor = true;
            this.BTN_Rechercher.Click += new System.EventHandler(this.BTN_Rechercher_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.Line});
            this.shapeContainer1.Size = new System.Drawing.Size(258, 219);
            this.shapeContainer1.TabIndex = 13;
            this.shapeContainer1.TabStop = false;
            // 
            // Line
            // 
            this.Line.BorderColor = System.Drawing.Color.SeaGreen;
            this.Line.Name = "Line";
            this.Line.X1 = 8;
            this.Line.X2 = 250;
            this.Line.Y1 = 121;
            this.Line.Y2 = 121;
            // 
            // FormSelection_Animal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(258, 219);
            this.Controls.Add(this.TBox_Recherche);
            this.Controls.Add(this.BTN_Rechercher);
            this.Controls.Add(this.BTN_Valider);
            this.Controls.Add(this.CBox_Animal);
            this.Controls.Add(this.Label_Animal);
            this.Controls.Add(this.CBox_Client);
            this.Controls.Add(this.Label_Client);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox TBox_Recherche;
        private System.Windows.Forms.Button BTN_Rechercher;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape Line;
    }
}