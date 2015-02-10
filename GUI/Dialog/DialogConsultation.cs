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
        private List<BO.LignesConsultations> lignesConsultation = new List<BO.LignesConsultations>();
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
                this.buttonDelete.Enabled = !readOnly;
                this.buttonSave.Enabled = !readOnly;
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
            if ( vetoLogged == null)
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

    
            consultation = BLL.ConsultationMgr.Get(agenda.DateRdv, agenda.Animal);

            if (consultation == null)
            {
                //Initialise une consultation vide
                consultation = new BO.Consultations
                {
                    Animal = agenda.Animal,
                    Etat = (short)BLL.ConsultationsEtat.EN_COURS_DE_SAISIE,
                    Commentaire = "",
                    Facture = null,
                    DateConsultation = agenda.DateRdv,
                    Veterinaire = vetoLogged,
                    Archive = 0
                };
            }
            else
            {
                if (consultation.Etat >= (short)BLL.ConsultationsEtat.SAISI_VETO_TERMINER_ET_FACTURE_POSSIBLE)
                    this.ReadOnly = true;

                lignesConsultation = BLL.LignesConsultationsMgr.GetAll(consultation.CodeConsultation); //Récupere tout les actes de la consultation
            }

            //Lie la liste au dataGridview
            this.dataGridViewActe.DataSource = lignesConsultation;
        }

        /// <summary>
        /// Refresh le total de la consultation
        /// </summary>
        private void RefreshTotal()
        { 
            double total = lignesConsultation.Sum(x => x.Prix);
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
                this.textBoxActeMin.Text = selectedBarems.TarifMaxi.ToString();

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
                this.textBoxActeMin.Text = "";

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
            //Sauvegarde la consultation en base si pas fais
            if (consultation.CodeConsultation == null)
                consultation = BLL.ConsultationMgr.Create(consultation);
            else //Sinon la met a jour
                BLL.ConsultationMgr.Update(consultation); //Changement du commentaire...
            
            //Sauve l'ensemble des actes
            for(Int32 i = 0; i < lignesConsultation.Count; i++)
            {
                BO.LignesConsultations ligne = lignesConsultation[i];

                //L'acte n'a pas été enregistré
                if(ligne.NumLigne == null)
                {
                     //Pas de consultation ou consultation différnete
                    if (ligne.Consultation == null || ligne.Consultation.CodeConsultation != consultation.CodeConsultation)
                        ligne.Consultation = consultation;

                    lignesConsultation[i] = BLL.LignesConsultationsMgr.Create(ligne);
                }
            }
        }

        
        private void buttonValidate_Click(object sender, EventArgs e)
        {
            //Valide la consultation (passage a l'etat 1 de la consultation)
            BLL.ConsultationMgr.Validate(consultation);

            //@TODO doit mettre le stock de vaccin a jour...

            this.ReadOnly = true;  //Rend la form non modifiable
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Supprime la consultation et tout les actes
            foreach (BO.LignesConsultations ligne in lignesConsultation)
            {
                //Supprime de la bdd, les autres sont des temporaires donc non sauvegardé
                if(ligne.NumLigne != null)
                    BLL.LignesConsultationsMgr.Delete(ligne);
            }

            //Supprime de la bdd
            if(consultation.CodeConsultation != null)
                BLL.ConsultationMgr.Delete(consultation);

            //@TODO message box
            this.Close();
        }

        private void buttonActeAdd_Click(object sender, EventArgs e)
        {
            if (selectedBarems == null)
                return; //@TODO message d'erreur, impossible d'ajouter un acte sans barem

            //Ajoute l'acte en cours au dataGridview
            BO.LignesConsultations ligne = new BO.LignesConsultations { Archive = 0, 
                                                                        Consultation = (consultation != null) ? consultation : null, 
                                                                        Prix = (float)this.numericUpDownActePrix.Value, 
                                                                        Barem = selectedBarems };
        }

        private void buttonActeDelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewActe.CurrentRow != null)
            {
                //Supprime l'acte selectionner
                BO.LignesConsultations ligne = (BO.LignesConsultations)this.dataGridViewActe.CurrentRow.DataBoundItem;

                //Supprime la ligne dela BDD
                if (ligne.NumLigne != default(Guid))
                    BLL.LignesConsultationsMgr.Delete(ligne);

                this.lignesConsultation.RemoveAt(this.dataGridViewActe.CurrentRow.Index);
            }
        }

        private void comboBoxActeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTarif();
        }

        private void comboBoxActeLibelle_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTarif();
        }

        private void dataGridViewActe_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            RefreshTotal();
        }

        private void dataGridViewActe_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            RefreshTotal();
        }

        private void textBoxComment_TextChanged(object sender, EventArgs e)
        {
            consultation.Commentaire = textBoxComment.Text;
        }
        #endregion
      
    }
}
