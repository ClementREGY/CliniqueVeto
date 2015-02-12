using BO;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CliniqueVeto
{
    public partial class FormClients : Form
    {
        #region Attributs et Propriétés

        private String _modeAnimal;
        private int _courant = -1;
        private Client _clientCourant;

        public String ModeAnimal 
        { 
            get { return _modeAnimal; } 
            set { _modeAnimal = value; } 
        }

        private int IndiceCourant
        {
            get { return _courant; }
            set
            {
                _courant = value;
                _clientCourant = MgtClient.GetClients().ElementAt(_courant);
                NavBarre.ApresEnable = (_courant != MgtClient.GetClients().Count - 1);
                NavBarre.AvantEnable = (_courant != 0);
                AfficherClientCourant();
            }
        }

        public Animal AnimalCourant
        {
            get
            {
                return (Animal)DataGrid_Animaux.CurrentRow.DataBoundItem;
            }
        }

        public Client ClientCourant
        {
            get { return _clientCourant; }
            set { _clientCourant = value; }
        }

        #endregion

        public FormClients()
        {
            InitializeComponent();
        }

        private void FormClients_Load(object sender, EventArgs e)
        {
            TBox_Code.Enabled = false;
            NavBarre.AvantEnable = false;
            DataGrid_Animaux.DefaultCellStyle.Font = new Font("Cambria", 12);
            DataGrid_Animaux.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 12);
        }
        
        #region Navigation et Affichage

        /// <summary>
        /// Affichage à l'aide des données du Client courant
        /// </summary>
        private void AfficherClientCourant()
        {
            TBox_Nom.Text = ClientCourant.nomClient;
            TBox_Prénom.Text = ClientCourant.prenomClient;
            TBox_Code.Text = ClientCourant.codeClient.ToString();
            TBox_Code.Enabled = false;
            TBox_Adresse1.Text = ClientCourant.adresse;
            TBox_Adresse2.Text = ClientCourant.adresse2;
            TBox_CodePostal.Text = ClientCourant.cp;
            TBox_Ville.Text = ClientCourant.ville;

            // Remplissage du numéro de téléphone
            if (!String.IsNullOrEmpty(ClientCourant.numTel))
            {
                String[] NumTel = ClientCourant.numTel.Split('.');
                TBox_Num1.Text = NumTel[0];
                TBox_Num2.Text = NumTel[1];
                TBox_Num3.Text = NumTel[2];
                TBox_Num4.Text = NumTel[3];
                TBox_Num5.Text = NumTel[4];
            }
            else
            {
                TBox_Num1.Clear();
                TBox_Num2.Clear();
                TBox_Num3.Clear();
                TBox_Num4.Clear();
                TBox_Num5.Clear();
            }

            TBox_Email.Text = ClientCourant.email;
            TBox_Assurance.Text = ClientCourant.assurance;
            DataGrid_Animaux.DataSource = MgtAnimal.GetAnimalsByClient(ClientCourant.codeClient);
        }

        /// <summary>
        /// Évenement de navigation de la NavBarre
        /// </summary>
        private void NavBarre_Navigation(object sender, ControlsLibrary.NavBarEventArgs e)
        {
            switch (e.NavAction)
            {
                case ControlsLibrary.NavBar.NavActionEnum.suivant:
                    IndiceCourant += 1;
                    break;
                case ControlsLibrary.NavBar.NavActionEnum.precedent:
                    IndiceCourant -= 1;
                    break;
                case ControlsLibrary.NavBar.NavActionEnum.premier:
                    IndiceCourant = 0;
                    break;
                case ControlsLibrary.NavBar.NavActionEnum.dernier:
                    IndiceCourant = MgtClient.GetClients().Count - 1;
                    break;
            }
        }

        #endregion

        #region Gestion des Boutons

        /// <summary>
        /// Initialise les Champs pour ajouter un nouveau client
        /// </summary>
        private void BTN_AjouterClient_Click(object sender, EventArgs e)
        {
            Panel_GestionClients.Enabled = false;
            DataGrid_Animaux.DataSource = null;
            BTN_AjouterAnimal.Enabled = false;
            BTN_EditerAnimal.Enabled = false;
            BTN_SupprimerAnimal.Enabled = false;
            TBox_Nom.Clear();
            TBox_Prénom.Clear();
            TBox_Code.Clear();
            TBox_Adresse1.Clear();
            TBox_Adresse2.Clear();
            TBox_CodePostal.Clear();
            TBox_Ville.Clear();
            TBox_Num1.Clear();
            TBox_Num2.Clear();
            TBox_Num3.Clear();
            TBox_Num4.Clear();
            TBox_Num5.Clear();
            TBox_Email.Clear();
            TBox_Assurance.Clear();
            TBox_Nom.Focus();
            BTN_Valider.Visible = true;
            BTN_Annuler.Visible = true;
        }

        /// <summary>
        /// Tentative d'archivage du Client courant
        /// </summary>
        private void BTN_SupprimerClient_Click(object sender, EventArgs e)
        {
            // Vérifie si le client a des factures impayées
            if (!MgtClient.GetFacturesImpayees(ClientCourant.codeClient))
            {
                // Si non, on tente d'archiver le Client ainsi que ses animaux
                try
                {
                    MgtClient.DeleteClient(ClientCourant);
                    MgtAnimal.DeleteAnimalByClient(ClientCourant);
                    Reset();
                    if (IndiceCourant == -1)
                    {
                        IndiceCourant = 0;
                    }
                    else if (IndiceCourant >= MgtClient.GetClients().Count)
                    {
                        IndiceCourant = MgtClient.GetClients().Count - 1;
                    }
                    else
                    {
                        IndiceCourant = IndiceCourant;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Erreur lors de la suppression du Client...");
                }
            }
            else
            {
                MessageBox.Show("Suppression impossible : Le Client a des factures impayées !");
            }
        }

        /// <summary>
        /// Recherche dans la liste des Clients de la première occurence correspondante à la recherche saisie
        /// </summary>
        private void BTN_Rechercher_Click(object sender, EventArgs e)
        {
            bool isTrouve = false;
            foreach (Client unClient in MgtClient.GetClients())
            {
                if ((unClient.nomClient.ToLower().Contains(TBox_Recherche.Text.Trim().ToLower()) || unClient.prenomClient.ToLower().Contains(TBox_Recherche.Text.Trim().ToLower())) && isTrouve == false)
                {
                    isTrouve = true;
                    _clientCourant = unClient;
                    AfficherClientCourant();
                }
            }
            if (!isTrouve)
                MessageBox.Show("Aucun Client ne corespond à vos critères de recherche !");
        }

        /// <summary>
        /// Vérifie que tous les champs ont été remplis, si oui, ajout du Client dans la Base de Données
        /// </summary>
        private void BTN_Valider_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TBox_Nom.Text.Trim()))
            {
                errorSaisie.SetError(TBox_Nom, "Veuillez saisir un Nom.");
            }
            else
            {
                if (String.IsNullOrEmpty(TBox_Prénom.Text.Trim()))
                {
                    errorSaisie.SetError(TBox_Prénom, "Veuillez saisir un Prénom.");
                }
                else
                {
                    if (String.IsNullOrEmpty(TBox_Adresse1.Text.Trim()))
                    {
                        errorSaisie.SetError(TBox_Adresse1, "Veuillez saisir une Adresse.");
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(TBox_CodePostal.Text.Trim()))
                        {
                            errorSaisie.SetError(TBox_CodePostal, "Veuillez saisir un Code Postal.");
                        }
                        else
                        {
                            if (String.IsNullOrEmpty(TBox_Ville.Text.Trim()))
                            {
                                errorSaisie.SetError(TBox_Ville, "Veuillez saisir une Ville.");
                            }
                            else
                            {
                                try
                                {
                                    String numTel = "";
                                    if (!String.IsNullOrEmpty(TBox_Adresse1.Text.Trim()))
                                    {
                                        numTel = TBox_Num1.Text + "." + TBox_Num2.Text + "." + TBox_Num3.Text + "." + TBox_Num4.Text + "." + TBox_Num5.Text;
                                    }
                                    Client newClient = new Client(new Guid(), TBox_Nom.Text.ToUpper(), TBox_Prénom.Text, TBox_Adresse1.Text, TBox_CodePostal.Text, TBox_Ville.Text, numTel, TBox_Assurance.Text.ToUpper(), TBox_Email.Text, "", false, TBox_Adresse2.Text);
                                    Guid codeClient = MgtClient.CreateClient(newClient);
                                    Reset();
                                    ClientCourant = MgtClient.GetClient(codeClient);
                                    AfficherClientCourant();
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Erreur lors de la création du Client...");
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Annulation et réinitialisation
        /// </summary>
        private void BTN_Annuler_Click(object sender, EventArgs e)
        {
            Reset();
        }

        /// <summary>
        /// Ouverture du Formulaire de gestion d'un animal en passant les données actuelles (Client, Mode Ajout...)
        /// </summary>
        private void BTN_AjouterAnimal_Click(object sender, EventArgs e)
        {
            _modeAnimal = "Ajout";
            FormAnimaux frm = new FormAnimaux(this);
            frm.ShowDialog();
            DataGrid_Animaux.DataSource = MgtAnimal.GetAnimalsByClient(ClientCourant.codeClient);
        }

        /// <summary>
        /// Ouverture du Formulaire de gestion d'un animal en passant les données actuelles 
        /// (Client, Animal, Mode Modification...)
        /// </summary>
        private void BTN_EditerAnimal_Click(object sender, EventArgs e)
        {
            _modeAnimal = "Modification";
            FormAnimaux frm = new FormAnimaux(this);
            frm.ShowDialog();
            DataGrid_Animaux.DataSource = MgtAnimal.GetAnimalsByClient(ClientCourant.codeClient);
        }

        /// <summary>
        /// Réinitialisation des Champs de saisie
        /// </summary>
        private void Reset()
        {
            Panel_GestionClients.Enabled = true;
            BTN_AjouterAnimal.Enabled = true;
            BTN_EditerAnimal.Enabled = true;
            BTN_SupprimerAnimal.Enabled = true;
            TBox_Nom.Clear();
            TBox_Prénom.Clear();
            TBox_Code.Clear();
            TBox_Adresse1.Clear();
            TBox_Adresse2.Clear();
            TBox_CodePostal.Clear();
            TBox_Ville.Clear();
            TBox_Num1.Clear();
            TBox_Num2.Clear();
            TBox_Num3.Clear();
            TBox_Num4.Clear();
            TBox_Num5.Clear();
            TBox_Email.Clear();
            TBox_Assurance.Clear();
            BTN_Valider.Visible = false;
            BTN_Annuler.Visible = false;
        }

        /// <summary>
        /// Tentative de suppression de l'animal sélectionné dans la DataGridView
        /// </summary>
        private void BTN_SupprimerAnimal_Click(object sender, EventArgs e)
        {
            try
            {
                MgtAnimal.DeleteAnimal(AnimalCourant.codeAnimal);
                DataGrid_Animaux.DataSource = MgtAnimal.GetAnimalsByClient(ClientCourant.codeClient);
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de la Suppression de l'Animal...");
            }
        }

        #endregion

        #region TextBox Numéro de Téléphone

        /// <summary>
        /// Gestion de la TextBox du 1er et 2ème numéro du Téléphone
        /// </summary>
        private void TBox_Num1_TextChanged(object sender, EventArgs e)
        {
            if (TBox_Num1.Text.Length == 2)
            {
                TBox_Num2.Focus();
            }
        }

        /// <summary>
        /// Gestion de la TextBox du 3ème et 4ème numéro du Téléphone
        /// </summary>
        private void TBox_Num2_TextChanged(object sender, EventArgs e)
        {
            if (TBox_Num2.Text.Length == 2)
            {
                TBox_Num3.Focus();
            }
        }

        /// <summary>
        /// Gestion de la TextBox du 5ème et 6ème numéro du Téléphone
        /// </summary>
        private void TBox_Num3_TextChanged(object sender, EventArgs e)
        {
            if (TBox_Num3.Text.Length == 2)
            {
                TBox_Num4.Focus();
            }
        }

        /// <summary>
        /// Gestion de la TextBox du 7ème et 8ème numéro du Téléphone
        /// </summary>
        private void TBox_Num4_TextChanged(object sender, EventArgs e)
        {
            if (TBox_Num4.Text.Length == 2)
            {
                TBox_Num5.Focus();
            }
        }

        /// <summary>
        /// Gestion de la TextBox du 9ème et 10ème numéro du Téléphone
        /// </summary>
        private void TBox_Num5_TextChanged(object sender, EventArgs e)
        {
            if (TBox_Num5.Text.Length == 2)
            {
                TBox_Email.Focus();
            }
        }

        #endregion
    }
}
