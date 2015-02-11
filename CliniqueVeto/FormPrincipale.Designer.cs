namespace CliniqueVeto
{
    partial class FormPrincipale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipale));
            this.menuGénéral = new System.Windows.Forms.MenuStrip();
            this.secrétariatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priseDeRendezVousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dossierClientAnimauxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miseÀJourDuStockDeVaccinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créationDeFacturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impressionDeFacturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relancesVaccinationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relancesFacturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vétérinaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dossiersMédicauxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramétrageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vétérinairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miseÀJourDuBarèmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barreAccès = new System.Windows.Forms.ToolStrip();
            this.toolStripBt_RDV = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBt_Client = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBt_Relance = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBt_Agenda = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBt_Dossier = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.réglementDuneFactureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGénéral.SuspendLayout();
            this.barreAccès.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuGénéral
            // 
            this.menuGénéral.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuGénéral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.secrétariatToolStripMenuItem,
            this.vétérinaireToolStripMenuItem,
            this.paramétrageToolStripMenuItem});
            this.menuGénéral.Location = new System.Drawing.Point(0, 0);
            this.menuGénéral.Name = "menuGénéral";
            this.menuGénéral.Size = new System.Drawing.Size(990, 27);
            this.menuGénéral.TabIndex = 1;
            this.menuGénéral.Text = "menuStrip1";
            // 
            // secrétariatToolStripMenuItem
            // 
            this.secrétariatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.priseDeRendezVousToolStripMenuItem,
            this.dossierClientAnimauxToolStripMenuItem,
            this.miseÀJourDuStockDeVaccinsToolStripMenuItem,
            this.facturationToolStripMenuItem,
            this.relancesToolStripMenuItem});
            this.secrétariatToolStripMenuItem.Name = "secrétariatToolStripMenuItem";
            this.secrétariatToolStripMenuItem.Size = new System.Drawing.Size(96, 23);
            this.secrétariatToolStripMenuItem.Text = "&Secrétariat";
            // 
            // priseDeRendezVousToolStripMenuItem
            // 
            this.priseDeRendezVousToolStripMenuItem.Name = "priseDeRendezVousToolStripMenuItem";
            this.priseDeRendezVousToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.priseDeRendezVousToolStripMenuItem.Size = new System.Drawing.Size(355, 24);
            this.priseDeRendezVousToolStripMenuItem.Text = "Prise de Rendez-Vous";
            this.priseDeRendezVousToolStripMenuItem.Click += new System.EventHandler(this.AfficherRDV);
            // 
            // dossierClientAnimauxToolStripMenuItem
            // 
            this.dossierClientAnimauxToolStripMenuItem.Name = "dossierClientAnimauxToolStripMenuItem";
            this.dossierClientAnimauxToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.dossierClientAnimauxToolStripMenuItem.Size = new System.Drawing.Size(355, 24);
            this.dossierClientAnimauxToolStripMenuItem.Text = "Dossiers Client / Animaux";
            this.dossierClientAnimauxToolStripMenuItem.Click += new System.EventHandler(this.AfficherClients);
            // 
            // miseÀJourDuStockDeVaccinsToolStripMenuItem
            // 
            this.miseÀJourDuStockDeVaccinsToolStripMenuItem.Name = "miseÀJourDuStockDeVaccinsToolStripMenuItem";
            this.miseÀJourDuStockDeVaccinsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.miseÀJourDuStockDeVaccinsToolStripMenuItem.Size = new System.Drawing.Size(355, 24);
            this.miseÀJourDuStockDeVaccinsToolStripMenuItem.Text = "Mise à Jour du Stock de Vaccins";
            this.miseÀJourDuStockDeVaccinsToolStripMenuItem.Click += new System.EventHandler(this.AfficherStocks);
            // 
            // facturationToolStripMenuItem
            // 
            this.facturationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créationDeFacturesToolStripMenuItem,
            this.impressionDeFacturesToolStripMenuItem,
            this.réglementDuneFactureToolStripMenuItem});
            this.facturationToolStripMenuItem.Name = "facturationToolStripMenuItem";
            this.facturationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.facturationToolStripMenuItem.Size = new System.Drawing.Size(355, 24);
            this.facturationToolStripMenuItem.Text = "Facturation";
            // 
            // créationDeFacturesToolStripMenuItem
            // 
            this.créationDeFacturesToolStripMenuItem.Name = "créationDeFacturesToolStripMenuItem";
            this.créationDeFacturesToolStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.créationDeFacturesToolStripMenuItem.Text = "Créer une Facture";
            this.créationDeFacturesToolStripMenuItem.Click += new System.EventHandler(this.AfficherCreationFacture);
            // 
            // impressionDeFacturesToolStripMenuItem
            // 
            this.impressionDeFacturesToolStripMenuItem.Name = "impressionDeFacturesToolStripMenuItem";
            this.impressionDeFacturesToolStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.impressionDeFacturesToolStripMenuItem.Text = "Imprimer une Facture";
            this.impressionDeFacturesToolStripMenuItem.Click += new System.EventHandler(this.AfficherImpressionFacture);
            // 
            // relancesToolStripMenuItem
            // 
            this.relancesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relancesVaccinationToolStripMenuItem,
            this.relancesFacturesToolStripMenuItem});
            this.relancesToolStripMenuItem.Name = "relancesToolStripMenuItem";
            this.relancesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.relancesToolStripMenuItem.Size = new System.Drawing.Size(355, 24);
            this.relancesToolStripMenuItem.Text = "Relances";
            // 
            // relancesVaccinationToolStripMenuItem
            // 
            this.relancesVaccinationToolStripMenuItem.Name = "relancesVaccinationToolStripMenuItem";
            this.relancesVaccinationToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.relancesVaccinationToolStripMenuItem.Text = "Vaccinations";
            this.relancesVaccinationToolStripMenuItem.Click += new System.EventHandler(this.AfficherRelanceVaccin);
            // 
            // relancesFacturesToolStripMenuItem
            // 
            this.relancesFacturesToolStripMenuItem.Name = "relancesFacturesToolStripMenuItem";
            this.relancesFacturesToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.relancesFacturesToolStripMenuItem.Text = "Factures";
            this.relancesFacturesToolStripMenuItem.Click += new System.EventHandler(this.AfficherRelanceFacture);
            // 
            // vétérinaireToolStripMenuItem
            // 
            this.vétérinaireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendaToolStripMenuItem,
            this.dossiersMédicauxToolStripMenuItem});
            this.vétérinaireToolStripMenuItem.Name = "vétérinaireToolStripMenuItem";
            this.vétérinaireToolStripMenuItem.Size = new System.Drawing.Size(98, 23);
            this.vétérinaireToolStripMenuItem.Text = "&Vétérinaire";
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(266, 24);
            this.agendaToolStripMenuItem.Text = "Agenda";
            this.agendaToolStripMenuItem.Click += new System.EventHandler(this.AfficherAgenda);
            // 
            // dossiersMédicauxToolStripMenuItem
            // 
            this.dossiersMédicauxToolStripMenuItem.Name = "dossiersMédicauxToolStripMenuItem";
            this.dossiersMédicauxToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.dossiersMédicauxToolStripMenuItem.Size = new System.Drawing.Size(266, 24);
            this.dossiersMédicauxToolStripMenuItem.Text = "Dossiers Médicaux";
            this.dossiersMédicauxToolStripMenuItem.Click += new System.EventHandler(this.AfficherDossier);
            // 
            // paramétrageToolStripMenuItem
            // 
            this.paramétrageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vétérinairesToolStripMenuItem,
            this.miseÀJourDuBarèmeToolStripMenuItem});
            this.paramétrageToolStripMenuItem.Name = "paramétrageToolStripMenuItem";
            this.paramétrageToolStripMenuItem.Size = new System.Drawing.Size(110, 23);
            this.paramétrageToolStripMenuItem.Text = "&Paramétrage";
            // 
            // vétérinairesToolStripMenuItem
            // 
            this.vétérinairesToolStripMenuItem.Name = "vétérinairesToolStripMenuItem";
            this.vétérinairesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.vétérinairesToolStripMenuItem.Size = new System.Drawing.Size(396, 24);
            this.vétérinairesToolStripMenuItem.Text = "Vétérinaires";
            this.vétérinairesToolStripMenuItem.Click += new System.EventHandler(this.AfficherVétérinaires);
            // 
            // miseÀJourDuBarèmeToolStripMenuItem
            // 
            this.miseÀJourDuBarèmeToolStripMenuItem.Name = "miseÀJourDuBarèmeToolStripMenuItem";
            this.miseÀJourDuBarèmeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.miseÀJourDuBarèmeToolStripMenuItem.Size = new System.Drawing.Size(396, 24);
            this.miseÀJourDuBarèmeToolStripMenuItem.Text = "Mise à Jour du Barème de Tarification";
            this.miseÀJourDuBarèmeToolStripMenuItem.Click += new System.EventHandler(this.AfficherBarèmes);
            // 
            // barreAccès
            // 
            this.barreAccès.Dock = System.Windows.Forms.DockStyle.Right;
            this.barreAccès.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.barreAccès.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBt_RDV,
            this.toolStripSeparator5,
            this.toolStripBt_Client,
            this.toolStripSeparator4,
            this.toolStripBt_Relance,
            this.toolStripSeparator2,
            this.toolStripBt_Agenda,
            this.toolStripSeparator3,
            this.toolStripBt_Dossier,
            this.toolStripSeparator1});
            this.barreAccès.Location = new System.Drawing.Point(889, 27);
            this.barreAccès.Name = "barreAccès";
            this.barreAccès.Padding = new System.Windows.Forms.Padding(0);
            this.barreAccès.Size = new System.Drawing.Size(101, 794);
            this.barreAccès.TabIndex = 2;
            this.barreAccès.Text = "toolStrip1";
            // 
            // toolStripBt_RDV
            // 
            this.toolStripBt_RDV.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBt_RDV.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBt_RDV.Image")));
            this.toolStripBt_RDV.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBt_RDV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBt_RDV.Name = "toolStripBt_RDV";
            this.toolStripBt_RDV.Size = new System.Drawing.Size(100, 69);
            this.toolStripBt_RDV.Text = "Rendez-Vous";
            this.toolStripBt_RDV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBt_RDV.Click += new System.EventHandler(this.AfficherRDV);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(100, 6);
            // 
            // toolStripBt_Client
            // 
            this.toolStripBt_Client.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBt_Client.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBt_Client.Image")));
            this.toolStripBt_Client.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBt_Client.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBt_Client.Name = "toolStripBt_Client";
            this.toolStripBt_Client.Size = new System.Drawing.Size(100, 69);
            this.toolStripBt_Client.Text = "Client Animal";
            this.toolStripBt_Client.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBt_Client.Click += new System.EventHandler(this.AfficherClients);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(100, 6);
            // 
            // toolStripBt_Relance
            // 
            this.toolStripBt_Relance.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBt_Relance.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBt_Relance.Image")));
            this.toolStripBt_Relance.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBt_Relance.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBt_Relance.Name = "toolStripBt_Relance";
            this.toolStripBt_Relance.Size = new System.Drawing.Size(100, 69);
            this.toolStripBt_Relance.Text = "Relance Vaccins";
            this.toolStripBt_Relance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBt_Relance.Click += new System.EventHandler(this.AfficherRelanceVaccin);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(100, 6);
            // 
            // toolStripBt_Agenda
            // 
            this.toolStripBt_Agenda.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBt_Agenda.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBt_Agenda.Image")));
            this.toolStripBt_Agenda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBt_Agenda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBt_Agenda.Name = "toolStripBt_Agenda";
            this.toolStripBt_Agenda.Size = new System.Drawing.Size(100, 69);
            this.toolStripBt_Agenda.Text = "Agenda";
            this.toolStripBt_Agenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBt_Agenda.Click += new System.EventHandler(this.AfficherAgenda);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(100, 6);
            // 
            // toolStripBt_Dossier
            // 
            this.toolStripBt_Dossier.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBt_Dossier.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBt_Dossier.Image")));
            this.toolStripBt_Dossier.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBt_Dossier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBt_Dossier.Name = "toolStripBt_Dossier";
            this.toolStripBt_Dossier.Size = new System.Drawing.Size(100, 69);
            this.toolStripBt_Dossier.Text = "Dossier Médical";
            this.toolStripBt_Dossier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBt_Dossier.Click += new System.EventHandler(this.AfficherDossier);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // réglementDuneFactureToolStripMenuItem
            // 
            this.réglementDuneFactureToolStripMenuItem.Name = "réglementDuneFactureToolStripMenuItem";
            this.réglementDuneFactureToolStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.réglementDuneFactureToolStripMenuItem.Text = "Réglement d\'une Facture";
            this.réglementDuneFactureToolStripMenuItem.Click += new System.EventHandler(this.AfficheRèglementFacture);
            // 
            // FormPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 821);
            this.Controls.Add(this.barreAccès);
            this.Controls.Add(this.menuGénéral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuGénéral;
            this.Name = "FormPrincipale";
            this.Text = "Clinique Vétérinaire";
            this.menuGénéral.ResumeLayout(false);
            this.menuGénéral.PerformLayout();
            this.barreAccès.ResumeLayout(false);
            this.barreAccès.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuGénéral;
        private System.Windows.Forms.ToolStripMenuItem secrétariatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priseDeRendezVousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dossierClientAnimauxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relancesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miseÀJourDuStockDeVaccinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vétérinaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dossiersMédicauxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paramétrageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vétérinairesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miseÀJourDuBarèmeToolStripMenuItem;
        private System.Windows.Forms.ToolStrip barreAccès;
        private System.Windows.Forms.ToolStripButton toolStripBt_RDV;
        private System.Windows.Forms.ToolStripButton toolStripBt_Client;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripBt_Relance;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripBt_Agenda;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripBt_Dossier;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem facturationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créationDeFacturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impressionDeFacturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relancesVaccinationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relancesFacturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réglementDuneFactureToolStripMenuItem;
    }
}