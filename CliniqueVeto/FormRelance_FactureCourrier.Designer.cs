﻿namespace CliniqueVeto
{
    partial class FormRelance_FactureCourrier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelance_FactureCourrier));
            this.richTBox_Courrier = new System.Windows.Forms.RichTextBox();
            this.BTN_EnvoiRelance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTBox_Courrier
            // 
            this.richTBox_Courrier.Location = new System.Drawing.Point(0, 0);
            this.richTBox_Courrier.Name = "richTBox_Courrier";
            this.richTBox_Courrier.Size = new System.Drawing.Size(625, 359);
            this.richTBox_Courrier.TabIndex = 0;
            this.richTBox_Courrier.Text = "";
            // 
            // BTN_EnvoiRelance
            // 
            this.BTN_EnvoiRelance.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_EnvoiRelance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EnvoiRelance.Location = new System.Drawing.Point(236, 367);
            this.BTN_EnvoiRelance.Name = "BTN_EnvoiRelance";
            this.BTN_EnvoiRelance.Size = new System.Drawing.Size(156, 30);
            this.BTN_EnvoiRelance.TabIndex = 1;
            this.BTN_EnvoiRelance.Text = "Envoyer la Relance";
            this.BTN_EnvoiRelance.UseVisualStyleBackColor = false;
            this.BTN_EnvoiRelance.Click += new System.EventHandler(this.BTN_EnvoiRelance_Click);
            // 
            // FormRelance_FactureCourrier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(625, 409);
            this.Controls.Add(this.BTN_EnvoiRelance);
            this.Controls.Add(this.richTBox_Courrier);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRelance_FactureCourrier";
            this.Text = "Courrier de Relance";
            this.Load += new System.EventHandler(this.FormRelance_FactureCourrier_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTBox_Courrier;
        private System.Windows.Forms.Button BTN_EnvoiRelance;
    }
}