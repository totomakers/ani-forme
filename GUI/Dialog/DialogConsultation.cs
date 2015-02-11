using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Dialog
{
    public partial class DialogConsultation : Form
    {
        private BO.Agenda agenda;
        private BO.Veterinaires vetoLogged;
        private BO.Consultations consultation;
        private BO.Baremes selectedBarems;
        private List<BO.Baremes> barems = new List<BO.Baremes>();
        private BindingList<BO.LignesConsultations> lignesConsultation = new BindingList<BO.LignesConsultations>();
        private bool readOnly;

        public DialogConsultation(BO.Agenda agenda)
        {
            InitializeComponent();
            this.agenda = agenda;
            I18N(); 
            InitializeConsultation();       
        }

        public bool ReadOnly
        {
            get { return readOnly;  }
            set
            {
                readOnly = value;
                this.textBoxAniTatoo.Enabled = !readOnly;
                this.comboBoxActeLibelle.Enabled = !readOnly;
                this.comboBoxActeType.Enabled = !readOnly;

                this.textBoxComment.ReadOnly = readOnly;
                this.buttonActeAdd.Enabled = !readOnly;
                this.buttonActeDelete.Enabled = !readOnly;
                this.buttonSave.Enabled = !readOnly;
                this.buttonValidate.Enabled = !readOnly;
            }
        }

        private void I18N()
        {
            this.Text = String.Format(Lang.DIALOG_CONSULTATION_TITLE, agenda.DateRdv.ToShortDateString(), agenda.Animal.NomAnimal);
            this.buttonActeAdd.Text = Lang.DIALOG_CONSULATION_ADD_ACTE;
            this.buttonActeDelete .Text = Lang.DIALOG_CONSULATION_DELETE_ACTE;
            this.buttonDelete.Text = Lang.DIALOG_CONSULATION_DELETE_CONSULTATION;
            this.buttonMedicalFolder.Text = Lang.DIALOG_CONSULATION_MEDICAL_FOLDER;
            this.buttonSave.Text = Lang.DIALOG_CONSULTATION_SAVE;
            this.buttonValidate.Text = Lang.DIALOG_CONSULATION_VALIDATE;

            this.labelActeDate.Text = Lang.DIALOG_CONSULTATION_ACTE_DATE;
            this.labelActeLibelle.Text = Lang.DIALOG_CONSULTATION_ACTE_LIBELLE;
            this.labelActePrix.Text = Lang.DIALOG_CONSULTATION_ACTE_PRIX;
            this.labelActeTotal.Text = Lang.DIALOG_CONSULTATION_ACTE_TOTAL;
            this.labelActeType.Text = Lang.DIALOG_CONSULTATION_ACTE_TYPE;
            this.labelActeVeto.Text = Lang.DIALOG_CONSULTATION_ACTE_VETO;

            this.labelActeMax.Text = Lang.DIALOG_CONSULTATION_ACTE_MAX;
            this.labelActeMin.Text = Lang.DIALOG_CONSULTATION_ACTE_MIN;

            this.labelAniCode.Text = Lang.DIALOG_CONSULTATION_ANI_CODE;
            this.labelAniColor.Text = Lang.DIALOG_CONSULTATION_ANI_COLOR;
            this.labelAniEspece.Text= Lang.DIALOG_CONSULTATION_ANI_ESPECE;
            this.labelAniName.Text = Lang.DIALOG_CONSULTATION_ANI_NAME;
            this.labelAniRace.Text = Lang.DIALOG_CONSULTATION_ANI_RACE;
            this.labelAniSexe.Text = Lang.DIALOG_CONSULTATION_ANI_SEXE;
            this.labelAniTatoo.Text = Lang.DIALOG_CONSULTATION_ANI_TATOO;

            this.labelComment.Text = Lang.DIALOG_CONSULTATION_COMMENT;

            this.groupBoxActe.Text = Lang.DIALOG_CONSULTATION_GROUPBOX_ACTES;
            this.groupBoxAnimal.Text = Lang.DIALOG_CONSULTATION_GROUPBOX_ANIMAL;
            this.groupBoxTarif.Text = Lang.DIALOG_CONSULATION_GROUPBOX_TARIF;
        }

        #region Methodes
        private void InitializeConsultation()
        {
            //Pas connecté
            if (BLL.AccountMgr.loggedAccount == null)
                this.Close();

            //Pas connecté en tant que vétérinaires, il est donc impossible de saisir la consultation
            vetoLogged = BLL.VeterinairesMgr.GetByAccount(BLL.AccountMgr.loggedAccount.Id);
            if (vetoLogged == null)
                this.Close();
                 
            //Chargement animal
            this.textBoxAniCode.Text = agenda.Animal.CodeAnimal.ToString();
            this.textBoxAniColor.Text = agenda.Animal.Couleur;
            this.textBoxAniEspec.Text = agenda.Animal.Espece;
            this.textBoxAniName.Text = agenda.Animal.NomAnimal;
            this.textBoxAniRace.Text = agenda.Animal.Race;
            this.textBoxAniSexe.Text = agenda.Animal.Sexe.ToString();
            this.textBoxAniTatoo.Text = agenda.Animal.Tatouage;

            //Chargement véto connecté
            this.textBoxActeVeto.Text = vetoLogged.NomVeto;

            try
            {
                consultation = BLL.ConsultationMgr.Get(agenda.DateRdv, agenda.Animal);
                this.buttonValidate.Enabled = true;

                if (consultation.Etat >= (short)BLL.ConsultationsEtat.SAISI_VETO_TERMINER_ET_FACTURE_POSSIBLE)
                    this.ReadOnly = true;

                lignesConsultation = new BindingList<BO.LignesConsultations>(BLL.LignesConsultationsMgr.GetAll((Guid)consultation.CodeConsultation)); //Récupere tout les actes de la consultation
            }
            catch (Exception ex) //la consultation n'existe pas
            {
                consultation = new BO.Consultations
                {
                    Animal = agenda.Animal,
                    Etat = (short)BLL.ConsultationsEtat.EN_COURS_DE_SAISIE,
                    Commentaire = "",
                    Facture = null,
                    DateConsultation = agenda.DateRdv,
                    Veterinaire = vetoLogged,
                    Archive = false
                };

                this.buttonValidate.Enabled = false;
            }

            this.textBoxComment.Text = consultation.Commentaire;
            this.dataGridViewActe.DataSource = lignesConsultation;
            this.comboBoxActeType.DataSource = BLL.BaremesMgr.GetTypeActe();
        }

        /// <summary>
        /// Refresh le total de la consultation
        /// </summary>
        private void RefreshTotal()
        { 
            Decimal total = lignesConsultation.Sum(x => x.Prix);
            this.textBoxActeTotal.Text = total.ToString();
        }

        /// <summary>
        /// Refresh le tarif
        /// </summary>
        private void RefreshTarif()
        {
            if (selectedBarems != null)
            {
                //Initialize min max
                this.textBoxActeMin.Text = selectedBarems.TarifMini.ToString();
                this.textBoxActeMax.Text = selectedBarems.TarifMaxi.ToString();

                //Reset du prix au min
                this.numericUpDownActePrix.Minimum = selectedBarems.TarifMini;
                this.numericUpDownActePrix.Maximum = selectedBarems.TarifMaxi;
                this.numericUpDownActePrix.Value = selectedBarems.TarifMini;

                this.numericUpDownActePrix.Enabled = true;
            }
            else
            {
                //Initialize min max
                this.textBoxActeMin.Text = "";
                this.textBoxActeMax.Text = "";

                //Reset du prix au min
                this.numericUpDownActePrix.Minimum = 0;
                this.numericUpDownActePrix.Maximum = 0;
                this.numericUpDownActePrix.Value = 0;

                this.numericUpDownActePrix.Enabled = false;
            }
        }
        #endregion

        #region Evenements
        private void buttonMedicalFolder_Click(object sender, EventArgs e)
        {
            SubFormDossierMedical dossierMedical = new SubFormDossierMedical(agenda.Animal);
            dossierMedical.ShowDialog();
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            consultation = BLL.ConsultationMgr.Save(consultation);

            if (consultation == null)
                return; 

            lignesConsultation =
                    new BindingList<BO.LignesConsultations>(BLL.LignesConsultationsMgr.CreateAll(lignesConsultation.ToList(), 
                                    (Guid)consultation.CodeConsultation));

            this.buttonValidate.Enabled = true;
            this.dataGridViewActe.Refresh();
        }

        
        private void buttonValidate_Click(object sender, EventArgs e)
        {
            BLL.ConsultationMgr.Validate(consultation);  //@TODO doit mettre le stock de vaccin a jour...
            
            this.ReadOnly = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Supprime les lignes de la consultation
            foreach (BO.LignesConsultations ligne in lignesConsultation)
            {
                if(ligne.NumLigne != null)
                    BLL.LignesConsultationsMgr.Delete(ligne);
            }

            //Supprime la consultation
            if(consultation.CodeConsultation != null)
                BLL.ConsultationMgr.Delete(consultation);


            MessageBox.Show("Consultation supprimé", 
                            "La consultation a été supprimé avec succés",
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);

            this.Close();
        }

        private void buttonActeAdd_Click(object sender, EventArgs e)
        {
            if (selectedBarems == null)
            {
                MessageBox.Show("Vous devez selectionner un barem pour continuer", 
                                Lang.FORM_DEFAULT_ERROR_TITLE, 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
                return;
            }

            //Ajoute l'acte en cours au dataGridview
            BO.LignesConsultations ligne = new BO.LignesConsultations { 
                                                                        Archive = false, 
                                                                        Consultation = (consultation != null) ? consultation : null, 
                                                                        Prix = this.numericUpDownActePrix.Value, 
                                                                        Barem = selectedBarems };

            lignesConsultation.Add(ligne);
            this.dataGridViewActe.DataSource = new List<BO.LignesConsultations>();
            this.dataGridViewActe.DataSource = lignesConsultation;
        }

        private void buttonActeDelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewActe.CurrentRow != null)
            {
                //Supprime l'acte selectionner
                BO.LignesConsultations ligne = (BO.LignesConsultations)this.dataGridViewActe.CurrentRow.DataBoundItem;

                this.lignesConsultation.RemoveAt(this.dataGridViewActe.CurrentRow.Index);

                //Supprime la ligne dela BDD
                if (ligne.NumLigne != null && ligne.Consultation != null)
                    BLL.LignesConsultationsMgr.Delete(ligne);
            }
        }

        private void comboBoxActeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            barems = BLL.BaremesMgr.GetAll(comboBoxActeType.Text);
            this.comboBoxActeLibelle.DataSource = barems;
            this.comboBoxActeLibelle.DisplayMember = "Libelle";
        }

        private void comboBoxActeLibelle_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedBarems = (BO.Baremes)this.comboBoxActeLibelle.SelectedItem;
            RefreshTarif();
        }

        private void textBoxComment_TextChanged(object sender, EventArgs e)
        {
            consultation.Commentaire = textBoxComment.Text;
        }

        private void dataGridViewActe_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            RefreshTotal();
        }

        private void dataGridViewActe_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            RefreshTotal();
        }
        #endregion



    }
}
