namespace CliniqueVeto
{
    partial class FormAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgenda));
            this.GBox_Vétérinaire = new System.Windows.Forms.GroupBox();
            this.DTPicker_Date = new System.Windows.Forms.DateTimePicker();
            this.Label_Date = new System.Windows.Forms.Label();
            this.CBox_Vétérinaires = new System.Windows.Forms.ComboBox();
            this.Label_Vétérinaire = new System.Windows.Forms.Label();
            this.DataGrid_Agenda = new System.Windows.Forms.DataGridView();
            this.Label_Dossier = new System.Windows.Forms.Label();
            this.BTN_Dossier = new System.Windows.Forms.Button();
            this.GBox_Vétérinaire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Agenda)).BeginInit();
            this.SuspendLayout();
            // 
            // GBox_Vétérinaire
            // 
            this.GBox_Vétérinaire.Controls.Add(this.DTPicker_Date);
            this.GBox_Vétérinaire.Controls.Add(this.Label_Date);
            this.GBox_Vétérinaire.Controls.Add(this.CBox_Vétérinaires);
            this.GBox_Vétérinaire.Controls.Add(this.Label_Vétérinaire);
            this.GBox_Vétérinaire.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBox_Vétérinaire.Location = new System.Drawing.Point(12, 12);
            this.GBox_Vétérinaire.Name = "GBox_Vétérinaire";
            this.GBox_Vétérinaire.Size = new System.Drawing.Size(585, 73);
            this.GBox_Vétérinaire.TabIndex = 2;
            this.GBox_Vétérinaire.TabStop = false;
            this.GBox_Vétérinaire.Text = "De";
            // 
            // DTPicker_Date
            // 
            this.DTPicker_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPicker_Date.Location = new System.Drawing.Point(428, 28);
            this.DTPicker_Date.Name = "DTPicker_Date";
            this.DTPicker_Date.Size = new System.Drawing.Size(135, 26);
            this.DTPicker_Date.TabIndex = 20;
            this.DTPicker_Date.ValueChanged += new System.EventHandler(this.DTPicker_Date_ValueChanged);
            // 
            // Label_Date
            // 
            this.Label_Date.AutoSize = true;
            this.Label_Date.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Date.Location = new System.Drawing.Point(381, 31);
            this.Label_Date.Name = "Label_Date";
            this.Label_Date.Size = new System.Drawing.Size(41, 19);
            this.Label_Date.TabIndex = 19;
            this.Label_Date.Text = "Date";
            // 
            // CBox_Vétérinaires
            // 
            this.CBox_Vétérinaires.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBox_Vétérinaires.FormattingEnabled = true;
            this.CBox_Vétérinaires.Location = new System.Drawing.Point(111, 28);
            this.CBox_Vétérinaires.Name = "CBox_Vétérinaires";
            this.CBox_Vétérinaires.Size = new System.Drawing.Size(190, 27);
            this.CBox_Vétérinaires.TabIndex = 18;
            this.CBox_Vétérinaires.SelectedIndexChanged += new System.EventHandler(this.CBox_Vétérinaires_SelectedIndexChanged);
            // 
            // Label_Vétérinaire
            // 
            this.Label_Vétérinaire.AutoSize = true;
            this.Label_Vétérinaire.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Vétérinaire.Location = new System.Drawing.Point(19, 31);
            this.Label_Vétérinaire.Name = "Label_Vétérinaire";
            this.Label_Vétérinaire.Size = new System.Drawing.Size(86, 19);
            this.Label_Vétérinaire.TabIndex = 17;
            this.Label_Vétérinaire.Text = "Vétérinaire";
            // 
            // DataGrid_Agenda
            // 
            this.DataGrid_Agenda.AllowUserToResizeRows = false;
            this.DataGrid_Agenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid_Agenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Agenda.Location = new System.Drawing.Point(12, 103);
            this.DataGrid_Agenda.MultiSelect = false;
            this.DataGrid_Agenda.Name = "DataGrid_Agenda";
            this.DataGrid_Agenda.RowHeadersVisible = false;
            this.DataGrid_Agenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_Agenda.Size = new System.Drawing.Size(585, 257);
            this.DataGrid_Agenda.TabIndex = 3;
            // 
            // Label_Dossier
            // 
            this.Label_Dossier.AutoSize = true;
            this.Label_Dossier.BackColor = System.Drawing.Color.Transparent;
            this.Label_Dossier.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Dossier.Location = new System.Drawing.Point(490, 419);
            this.Label_Dossier.Name = "Label_Dossier";
            this.Label_Dossier.Size = new System.Drawing.Size(107, 17);
            this.Label_Dossier.TabIndex = 10;
            this.Label_Dossier.Text = "Dossier Médical";
            // 
            // BTN_Dossier
            // 
            this.BTN_Dossier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Dossier.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Dossier.Image")));
            this.BTN_Dossier.Location = new System.Drawing.Point(516, 366);
            this.BTN_Dossier.Name = "BTN_Dossier";
            this.BTN_Dossier.Size = new System.Drawing.Size(50, 50);
            this.BTN_Dossier.TabIndex = 9;
            this.BTN_Dossier.UseVisualStyleBackColor = true;
            // 
            // FormAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(606, 442);
            this.Controls.Add(this.Label_Dossier);
            this.Controls.Add(this.BTN_Dossier);
            this.Controls.Add(this.DataGrid_Agenda);
            this.Controls.Add(this.GBox_Vétérinaire);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormAgenda";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.FormAgenda_Load);
            this.GBox_Vétérinaire.ResumeLayout(false);
            this.GBox_Vétérinaire.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Agenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBox_Vétérinaire;
        private System.Windows.Forms.DateTimePicker DTPicker_Date;
        private System.Windows.Forms.Label Label_Date;
        private System.Windows.Forms.ComboBox CBox_Vétérinaires;
        private System.Windows.Forms.Label Label_Vétérinaire;
        private System.Windows.Forms.DataGridView DataGrid_Agenda;
        private System.Windows.Forms.Label Label_Dossier;
        private System.Windows.Forms.Button BTN_Dossier;
    }
}