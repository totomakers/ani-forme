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

        public DialogConsultation(BO.Agenda agenda)
        {
            InitializeComponent();
            this.agenda = agenda;
            I18N();
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

        #region Evenements
        private void buttonMedicalFolder_Click(object sender, EventArgs e)
        {
            SubFormDossierMedical dossierMedical = new SubFormDossierMedical(agenda.Animal);
            dossierMedical.ShowDialog();
        }
        #endregion
    }
}
