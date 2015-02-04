namespace CliniqueVeto
{
    partial class FormRDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRDV));
            this.GBox_Pour = new System.Windows.Forms.GroupBox();
            this.PBox_AddAnimal = new System.Windows.Forms.PictureBox();
            this.PBox_AddClient = new System.Windows.Forms.PictureBox();
            this.CBox_Animal = new System.Windows.Forms.ComboBox();
            this.Label_Animal = new System.Windows.Forms.Label();
            this.CBox_Client = new System.Windows.Forms.ComboBox();
            this.Label_Client = new System.Windows.Forms.Label();
            this.GBox_Par = new System.Windows.Forms.GroupBox();
            this.CBox_Vétérinaire = new System.Windows.Forms.ComboBox();
            this.Label_Vétérinaire = new System.Windows.Forms.Label();
            this.GBox_Quand = new System.Windows.Forms.GroupBox();
            this.Label_Urgence = new System.Windows.Forms.Label();
            this.BTN_Urgence = new System.Windows.Forms.Button();
            this.CBox_Minute = new System.Windows.Forms.ComboBox();
            this.Label_H = new System.Windows.Forms.Label();
            this.CBox_Heure = new System.Windows.Forms.ComboBox();
            this.Label_Heure = new System.Windows.Forms.Label();
            this.DTPicker_Date = new System.Windows.Forms.DateTimePicker();
            this.Label_Date = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.BTN_Valider = new System.Windows.Forms.Button();
            this.BTN_Supprimer = new System.Windows.Forms.Button();
            this.GBox_Pour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBox_AddAnimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBox_AddClient)).BeginInit();
            this.GBox_Par.SuspendLayout();
            this.GBox_Quand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GBox_Pour
            // 
            this.GBox_Pour.Controls.Add(this.PBox_AddAnimal);
            this.GBox_Pour.Controls.Add(this.PBox_AddClient);
            this.GBox_Pour.Controls.Add(this.CBox_Animal);
            this.GBox_Pour.Controls.Add(this.Label_Animal);
            this.GBox_Pour.Controls.Add(this.CBox_Client);
            this.GBox_Pour.Controls.Add(this.Label_Client);
            this.GBox_Pour.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBox_Pour.Location = new System.Drawing.Point(12, 12);
            this.GBox_Pour.Name = "GBox_Pour";
            this.GBox_Pour.Size = new System.Drawing.Size(240, 140);
            this.GBox_Pour.TabIndex = 0;
            this.GBox_Pour.TabStop = false;
            this.GBox_Pour.Text = "Pour";
            // 
            // PBox_AddAnimal
            // 
            this.PBox_AddAnimal.Image = ((System.Drawing.Image)(resources.GetObject("PBox_AddAnimal.Image")));
            this.PBox_AddAnimal.Location = new System.Drawing.Point(203, 101);
            this.PBox_AddAnimal.Name = "PBox_AddAnimal";
            this.PBox_AddAnimal.Size = new System.Drawing.Size(23, 23);
            this.PBox_AddAnimal.TabIndex = 6;
            this.PBox_AddAnimal.TabStop = false;
            // 
            // PBox_AddClient
            // 
            this.PBox_AddClient.Image = ((System.Drawing.Image)(resources.GetObject("PBox_AddClient.Image")));
            this.PBox_AddClient.Location = new System.Drawing.Point(203, 50);
            this.PBox_AddClient.Name = "PBox_AddClient";
            this.PBox_AddClient.Size = new System.Drawing.Size(23, 23);
            this.PBox_AddClient.TabIndex = 3;
            this.PBox_AddClient.TabStop = false;
            // 
            // CBox_Animal
            // 
            this.CBox_Animal.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBox_Animal.FormattingEnabled = true;
            this.CBox_Animal.Location = new System.Drawing.Point(15, 101);
            this.CBox_Animal.Name = "CBox_Animal";
            this.CBox_Animal.Size = new System.Drawing.Size(182, 23);
            this.CBox_Animal.TabIndex = 5;
            // 
            // Label_Animal
            // 
            this.Label_Animal.AutoSize = true;
            this.Label_Animal.Location = new System.Drawing.Point(12, 79);
            this.Label_Animal.Name = "Label_Animal";
            this.Label_Animal.Size = new System.Drawing.Size(52, 17);
            this.Label_Animal.TabIndex = 4;
            this.Label_Animal.Text = "Animal";
            // 
            // CBox_Client
            // 
            this.CBox_Client.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBox_Client.FormattingEnabled = true;
            this.CBox_Client.Location = new System.Drawing.Point(15, 50);
            this.CBox_Client.Name = "CBox_Client";
            this.CBox_Client.Size = new System.Drawing.Size(182, 23);
            this.CBox_Client.TabIndex = 3;
            this.CBox_Client.SelectedIndexChanged += new System.EventHandler(this.CBox_Client_SelectedIndexChanged);
            // 
            // Label_Client
            // 
            this.Label_Client.AutoSize = true;
            this.Label_Client.Location = new System.Drawing.Point(12, 28);
            this.Label_Client.Name = "Label_Client";
            this.Label_Client.Size = new System.Drawing.Size(44, 17);
            this.Label_Client.TabIndex = 2;
            this.Label_Client.Text = "Client";
            // 
            // GBox_Par
            // 
            this.GBox_Par.Controls.Add(this.CBox_Vétérinaire);
            this.GBox_Par.Controls.Add(this.Label_Vétérinaire);
            this.GBox_Par.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBox_Par.Location = new System.Drawing.Point(272, 12);
            this.GBox_Par.Name = "GBox_Par";
            this.GBox_Par.Size = new System.Drawing.Size(240, 140);
            this.GBox_Par.TabIndex = 1;
            this.GBox_Par.TabStop = false;
            this.GBox_Par.Text = "Par";
            // 
            // CBox_Vétérinaire
            // 
            this.CBox_Vétérinaire.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBox_Vétérinaire.FormattingEnabled = true;
            this.CBox_Vétérinaire.Location = new System.Drawing.Point(21, 72);
            this.CBox_Vétérinaire.Name = "CBox_Vétérinaire";
            this.CBox_Vétérinaire.Size = new System.Drawing.Size(200, 23);
            this.CBox_Vétérinaire.TabIndex = 1;
            // 
            // Label_Vétérinaire
            // 
            this.Label_Vétérinaire.AutoSize = true;
            this.Label_Vétérinaire.Location = new System.Drawing.Point(18, 50);
            this.Label_Vétérinaire.Name = "Label_Vétérinaire";
            this.Label_Vétérinaire.Size = new System.Drawing.Size(77, 17);
            this.Label_Vétérinaire.TabIndex = 0;
            this.Label_Vétérinaire.Text = "Vétérinaire";
            // 
            // GBox_Quand
            // 
            this.GBox_Quand.Controls.Add(this.Label_Urgence);
            this.GBox_Quand.Controls.Add(this.BTN_Urgence);
            this.GBox_Quand.Controls.Add(this.CBox_Minute);
            this.GBox_Quand.Controls.Add(this.Label_H);
            this.GBox_Quand.Controls.Add(this.CBox_Heure);
            this.GBox_Quand.Controls.Add(this.Label_Heure);
            this.GBox_Quand.Controls.Add(this.DTPicker_Date);
            this.GBox_Quand.Controls.Add(this.Label_Date);
            this.GBox_Quand.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBox_Quand.Location = new System.Drawing.Point(530, 12);
            this.GBox_Quand.Name = "GBox_Quand";
            this.GBox_Quand.Size = new System.Drawing.Size(240, 140);
            this.GBox_Quand.TabIndex = 2;
            this.GBox_Quand.TabStop = false;
            this.GBox_Quand.Text = "Quand";
            // 
            // Label_Urgence
            // 
            this.Label_Urgence.AutoSize = true;
            this.Label_Urgence.BackColor = System.Drawing.Color.Transparent;
            this.Label_Urgence.Location = new System.Drawing.Point(173, 119);
            this.Label_Urgence.Name = "Label_Urgence";
            this.Label_Urgence.Size = new System.Drawing.Size(60, 17);
            this.Label_Urgence.TabIndex = 7;
            this.Label_Urgence.Text = "Urgence";
            // 
            // BTN_Urgence
            // 
            this.BTN_Urgence.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Urgence.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Urgence.BackgroundImage")));
            this.BTN_Urgence.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Urgence.Location = new System.Drawing.Point(181, 79);
            this.BTN_Urgence.Name = "BTN_Urgence";
            this.BTN_Urgence.Size = new System.Drawing.Size(40, 40);
            this.BTN_Urgence.TabIndex = 6;
            this.BTN_Urgence.UseVisualStyleBackColor = false;
            // 
            // CBox_Minute
            // 
            this.CBox_Minute.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBox_Minute.FormattingEnabled = true;
            this.CBox_Minute.Items.AddRange(new object[] {
            "00",
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.CBox_Minute.Location = new System.Drawing.Point(83, 96);
            this.CBox_Minute.Name = "CBox_Minute";
            this.CBox_Minute.Size = new System.Drawing.Size(43, 23);
            this.CBox_Minute.TabIndex = 5;
            // 
            // Label_H
            // 
            this.Label_H.AutoSize = true;
            this.Label_H.Location = new System.Drawing.Point(65, 99);
            this.Label_H.Name = "Label_H";
            this.Label_H.Size = new System.Drawing.Size(18, 17);
            this.Label_H.TabIndex = 4;
            this.Label_H.Text = "H";
            // 
            // CBox_Heure
            // 
            this.CBox_Heure.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBox_Heure.FormattingEnabled = true;
            this.CBox_Heure.Items.AddRange(new object[] {
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.CBox_Heure.Location = new System.Drawing.Point(21, 96);
            this.CBox_Heure.Name = "CBox_Heure";
            this.CBox_Heure.Size = new System.Drawing.Size(43, 23);
            this.CBox_Heure.TabIndex = 4;
            // 
            // Label_Heure
            // 
            this.Label_Heure.AutoSize = true;
            this.Label_Heure.Location = new System.Drawing.Point(18, 75);
            this.Label_Heure.Name = "Label_Heure";
            this.Label_Heure.Size = new System.Drawing.Size(46, 17);
            this.Label_Heure.TabIndex = 3;
            this.Label_Heure.Text = "Heure";
            // 
            // DTPicker_Date
            // 
            this.DTPicker_Date.CalendarFont = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPicker_Date.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPicker_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPicker_Date.Location = new System.Drawing.Point(21, 50);
            this.DTPicker_Date.Name = "DTPicker_Date";
            this.DTPicker_Date.Size = new System.Drawing.Size(200, 23);
            this.DTPicker_Date.TabIndex = 2;
            // 
            // Label_Date
            // 
            this.Label_Date.AutoSize = true;
            this.Label_Date.Location = new System.Drawing.Point(18, 28);
            this.Label_Date.Name = "Label_Date";
            this.Label_Date.Size = new System.Drawing.Size(37, 17);
            this.Label_Date.TabIndex = 1;
            this.Label_Date.Text = "Date";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(758, 214);
            this.dataGridView1.TabIndex = 3;
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Annuler.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Annuler.Location = new System.Drawing.Point(670, 406);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(100, 30);
            this.BTN_Annuler.TabIndex = 4;
            this.BTN_Annuler.Text = "Annuler";
            this.BTN_Annuler.UseVisualStyleBackColor = false;
            // 
            // BTN_Valider
            // 
            this.BTN_Valider.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Valider.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Valider.Location = new System.Drawing.Point(555, 406);
            this.BTN_Valider.Name = "BTN_Valider";
            this.BTN_Valider.Size = new System.Drawing.Size(100, 30);
            this.BTN_Valider.TabIndex = 5;
            this.BTN_Valider.Text = "Valider";
            this.BTN_Valider.UseVisualStyleBackColor = false;
            // 
            // BTN_Supprimer
            // 
            this.BTN_Supprimer.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Supprimer.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Supprimer.Location = new System.Drawing.Point(440, 406);
            this.BTN_Supprimer.Name = "BTN_Supprimer";
            this.BTN_Supprimer.Size = new System.Drawing.Size(100, 30);
            this.BTN_Supprimer.TabIndex = 6;
            this.BTN_Supprimer.Text = "Supprimer";
            this.BTN_Supprimer.UseVisualStyleBackColor = false;
            // 
            // FormRDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(780, 451);
            this.Controls.Add(this.BTN_Supprimer);
            this.Controls.Add(this.BTN_Valider);
            this.Controls.Add(this.BTN_Annuler);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GBox_Quand);
            this.Controls.Add(this.GBox_Par);
            this.Controls.Add(this.GBox_Pour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormRDV";
            this.Text = "Prise de Rendez-Vous";
            this.Load += new System.EventHandler(this.FormRDV_Load);
            this.GBox_Pour.ResumeLayout(false);
            this.GBox_Pour.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBox_AddAnimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBox_AddClient)).EndInit();
            this.GBox_Par.ResumeLayout(false);
            this.GBox_Par.PerformLayout();
            this.GBox_Quand.ResumeLayout(false);
            this.GBox_Quand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBox_Pour;
        private System.Windows.Forms.GroupBox GBox_Par;
        private System.Windows.Forms.GroupBox GBox_Quand;
        private System.Windows.Forms.ComboBox CBox_Vétérinaire;
        private System.Windows.Forms.Label Label_Vétérinaire;
        private System.Windows.Forms.Label Label_Date;
        private System.Windows.Forms.PictureBox PBox_AddAnimal;
        private System.Windows.Forms.PictureBox PBox_AddClient;
        private System.Windows.Forms.ComboBox CBox_Animal;
        private System.Windows.Forms.Label Label_Animal;
        private System.Windows.Forms.ComboBox CBox_Client;
        private System.Windows.Forms.Label Label_Client;
        private System.Windows.Forms.Label Label_Urgence;
        private System.Windows.Forms.Button BTN_Urgence;
        private System.Windows.Forms.ComboBox CBox_Minute;
        private System.Windows.Forms.Label Label_H;
        private System.Windows.Forms.ComboBox CBox_Heure;
        private System.Windows.Forms.Label Label_Heure;
        private System.Windows.Forms.DateTimePicker DTPicker_Date;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTN_Annuler;
        private System.Windows.Forms.Button BTN_Valider;
        private System.Windows.Forms.Button BTN_Supprimer;
    }
}