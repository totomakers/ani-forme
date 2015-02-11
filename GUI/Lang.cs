using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class Lang
    {
        //=========================
        //Form
        //=========================

        public static String FORM_DEFAULT_TITLE = "Ani'Forme";

        public static String FORM_DEFAULT_ADD = "Ajouter";
        public static String FORM_DEFAULT_DELETE = "Supprimer";
        public static String FORM_DEFAULT_RESET = "Réinitialiser";
        public static String FORM_DEFAULT_VALIDATE = "Valider";
        public static String FORM_DEFAULT_CONFIRM = "Confirmer";
        public static String FORM_DEFAULT_CANCEL = "Annuler";

        public static String FORM_DEFAULT_ERROR_TITLE = "Erreur";

        public static String FORM_DEFAULT_FIRST = "<< Premier";
        public static String FORM_DEFAULT_LAST = "Dernier >>";
        public static String FORM_DEFAULT_PREV = "< Précédent";
        public static String FORM_DEFAULT_NEXT = "Suivant >";

        public static String FORM_DEFAULT_CREATE_UPDATE_TITLE = "Mise à jour/Création";


        //=========================
        //FormLogin
        //=========================

        public static String FORM_LOGIN_TITLE = "Connection";
        public static String FORM_LOGIN_LIB_USERNAME = "Nom d'utilisateur";
        public static String FORM_LOGIN_LIB_PASSWORD = "Mot de passe";
        public static String FORM_LOGIN_LOGIN_FAIL_TEXT = "La combinaison est invalide";

        //===========================
        //FormMain 
        //===========================

        public static String FORM_MAIN_TITLE = "Clinique vétérinaire";

        //SECRETARIAT
        public static String FORM_MAIN_TOOLSTRIP_SECRETARIAT = "Secrétariat";
        public static String FORM_MAIN_MENUITEM_TAKE_APPOINTEMENT = "Prendre rendez-vous";
        public static String FORM_MAIN_MENUITEM_FOLDER_CUSTOMER_ANIMAL = "Dossier client/animaux";
        public static String FORM_MAIN_MENUITEM_REMINDERS = "Relances";
        public static String FORM_MAIN_MENUITEM_UPDATE_STOCK_VACCIN = "Mise à jour du stock de vaccin";
    
        //VETERINARY
        public static String FORM_MAIN_TOOLSTRIP_VETERINARY = "Vétérinaire";
        public static String FORM_MAIN_MENUITEM_AGENDA = "Agenda";
        public static String FORM_MAIN_MENUITEM_MEDICAL_FOLDER = "Dossier médical";

        //PARAMS
        public static String FORM_MAIN_TOOLSTRIP_PARAMS = "Paramètres";
        public static String FORM_MAIN_MENUITEM_VETERINARY = "Vétérinaires";
        public static String FORM_MAIN_MENUITEM_UPDATECOST = "Mise à jour barème de tarification";      
   
        //===========================
        //SubFormVeterinary 
        //===========================

        public static String SUBFORM_VETERINARY_TITLE = "Vétérinaire";
        public static String SUBFORM_VETERINARY_TITLE_SUCCEFULL_ARCHIVE = "Compte archivé";
        public static String SUBFORM_VETERINARY_SUCCEFULL_ARCHIVE = "Le compte de {0} a été archivé !";

        //DialogAddVeterinary
        public static String DIALOG_VETERINARY_ADD_TITLE = "Ajout d'un vétérinaire";
        public static String DIALOG_VETERINARY_ADD_LIB_NAME = "Nom";
        public static String DIALOG_VETERINARY_ADD_LIB_USERNAME = "Nom d'utilisateur";
        public static String DIALOG_VETERINARY_ADD_LIB_PASSWORD = "Mot de passe";
       
        //DialogResetVeterinary
        public static String DIALOG_VETERINARY_RESET_TITLE = "Réinitialiser mot de passe";
        public static String DIALOG_VETERINARY_RESET_PASSWORD = "Nouveau mot de passe";
        public static String DIALOG_VETERINARY_RESET_CONFIRM_PASSWORD = "Confirmation du mdp";

        //===========================
        //SubFormListPrice 
        //===========================
        public static String SUBFORM_LIST_PRICE_TITLE = "Barème";
        public static String SUBFORM_LIST_PRICE_LIB_LIBELLE = "Libellé";
        public static String SUBFORM_LIST_PRICE_LIB_TARIF_FIXE = "Tarif fixe";
        public static String SUBFORM_LIST_PRICE_LIB_TARIF_MINI = "Tarif mini";
        public static String SUBFORM_LIST_PRICE_LIB_TARIF_MAXI = "Tarif maxi";
        public static String SUBFORM_LIST_PRICE_BTN_MODIFY = "Modifier";
        public static String SUBFORM_LIST_PRICE_BTN_IMPORT = "Import XML";
        public static String SUBFORM_LIST_PRICE_LABEL_FILTRE = "Type Acte";
        public static String SUBFORM_LIST_PRICE_EMPTY_FILTRE = "";

        //============================
        //SubFormFolderCustomerAnimal
        //============================
        public static String SUBFORM_FOLDERCUSTANI_TITLE = "Clients";
        public static String SUBFORM_FOLDERCUSTANI_LIB_CODE = "Code";
        public static String SUBFORM_FOLDERCUSTANI_LIB_FIRSTNAME = "Nom";
        public static String SUBFORM_FOLDERCUSTANI_LIB_LASTNAME = "Prénom";
        public static String SUBFORM_FOLDERCUSTANI_LIB_ADRESSE = "Addresse";
        public static String SUBFORM_FOLDERCUSTANI_LIB_POSTALCODE = "Code Postal";
        public static String SUBFORM_FOLDERCUSTANI_LIB_CITY = "Ville";

        public static String SUBFORM_FOLDERCUSTANI_ADD_CUST = "Ajouter un client";
        public static String SUBFORM_FOLDERCUSTANI_DEL_CUST = "Supprimer le client";
        public static String SUBFORM_FOLDERCUSTANI_ADD_ANI = "Ajouter animal";
        public static String SUBFORM_FOLDERCUSTANI_EDIT_ANI = "Editer animal";
        public static String SUBFORM_FOLDERCUSTANI_DELETE_ANI = "Supprimer animal";
        public static String SUBFORM_FOLDERCUSTANI_TITLE_SUCCEFULL_ARCHIVE = "Client archivé";
        public static String SUBFORM_FOLDERCUSTANI_SUCCEFULL_ARCHIVE = "Le client {0} a été archivé !";
        public static String SUBFORM_FOLDERCUSTANI_SEARCH = "Flitrer";


        //============================
        //SubFormPrendreRdv
        //============================
        public static String SUBFORM_PRENDRERDV_TITLE = "Prise de rendez-vous";
        public static String SUBFORM_PRENDRERDV_GB_CLIENT = "Client";
        public static String SUBFORM_PRENDRERDV_GB_VETO = "Vétérinaires";
        public static String SUBFORM_PRENDRERDV_GB_DATE = "Date";
        public static String SUBFORM_PRENDRERDV_BTN_SUBMIT = "Valider";
        public static String SUBFORM_PRENDRERDV_BTN_DELETE = "Supprimer";
        public static String SUBFORM_PRENDRERDV_BTN_CANCEL = "Annuler";
        public static String SUBFORM_PRENDRERDV_ERROR_NOCLIENT = "Pas de client séléctionné";
        

        //============================
        //DialogAnimal
        //============================
        public static String DIALOG_ANIMAL_TITLE = "Animaux";
        public static String DIALOG_ANIMAL_TITLE_ADD_CLIENT = "Ajout pour le client {0}";
        public static String DIALOG_ANIMAL_TITLE_EDIT_ANIMAL = "Edition de {0}";
        public static String DIALOG_ANIMAL_TITLE_CREATE = "Ajout d'un nouvel animal";

        public static String DIALOG_ANIMAL_MEDICAL_FOLDER = "Dossier médical";
        public static String DIALOG_ANIMAL_LIB_CUSTOMER = "Client";
        public static String DIALOG_ANIMAL_LIB_CODE = "Code";
        public static String DIALOG_ANIMAL_LIB_NAME = "Nom";
        public static String DIALOG_ANIMAL_LIB_COLOR = "Couleur";
        public static String DIALOG_ANIMAL_LIB_ESPECE = "Espece";
        public static String DIALOG_ANIMAL_LIB_RACE = "Race";
        public static String DIALOG_ANIMAL_LIB_TATOO = "Tatouage";

        public static String DIALOG_ANIMAL_CREATE_UPDATE_SUCCEFULL = "L'animal {0} à été mise a jour/crée avec succès";

        public static String DIALOG_ANIMAL_CLIENT_ERROR = "Impossible de trouver le client.";

        //============================
        //SubFormAgenda
        //============================
        public static String SUBFORM_AGENDA_TITLE = "Agenda";
        public static String SUBFORM_AGENDA_LABEL_DATE = "Le ";
        public static String SUBFORM_AGENDA_LABEL_VETO = "Vétérinaire :";
        public static String SUBFORM_AGENDA_BTN_DOSSIER = "Dossier Médical";
        public static String SUBFORM_AGENDA_GB_VETO = "De :";

        //Dialog Consultation
        public static String DIALOG_CONSULTATION_TITLE = "Consultation du {0} pour {1}";
        public static String DIALOG_CONSULATION_ADD_ACTE = "Ajouter acte";
        public static String DIALOG_CONSULATION_DELETE_ACTE = "Supprimer acte";
        public static String DIALOG_CONSULATION_DELETE_CONSULTATION = "Supprimer la consultation";
        public static String DIALOG_CONSULATION_MEDICAL_FOLDER = "Dossier médical";
        public static String DIALOG_CONSULTATION_SAVE = "Sauvegarder la consultation";
        public static String DIALOG_CONSULATION_VALIDATE = "Valider la consultation";

        public static String DIALOG_CONSULTATION_ACTE_DATE = "Date";
        public static String DIALOG_CONSULTATION_ACTE_LIBELLE = "Libelle";
        public static String DIALOG_CONSULTATION_ACTE_PRIX = "Prix";
        public static String DIALOG_CONSULTATION_ACTE_TOTAL = "Prix total";
        public static String DIALOG_CONSULTATION_ACTE_TYPE = "Type";
        public static String DIALOG_CONSULTATION_ACTE_VETO = "Vétérinaire";

        public static String DIALOG_CONSULTATION_ACTE_MAX = "Max";
        public static String DIALOG_CONSULTATION_ACTE_MIN = "Min";

        public static String DIALOG_CONSULTATION_ANI_CODE = "Code";
        public static String DIALOG_CONSULTATION_ANI_COLOR = "Couleur";
        public static String DIALOG_CONSULTATION_ANI_ESPECE = "Espéce";
        public static String DIALOG_CONSULTATION_ANI_NAME = "Nom";
        public static String DIALOG_CONSULTATION_ANI_RACE = "Race";
        public static String DIALOG_CONSULTATION_ANI_SEXE = "Sexe";
        public static String DIALOG_CONSULTATION_ANI_TATOO = "Tatouage";

        public static String DIALOG_CONSULTATION_COMMENT = "Commentaire";

        public static String DIALOG_CONSULTATION_GROUPBOX_ACTES = "Actes";
        public static String DIALOG_CONSULTATION_GROUPBOX_ANIMAL = "Animal";
        public static String DIALOG_CONSULATION_GROUPBOX_TARIF = "Tarif";

        //============================
        //SubFormMajVaccin
        //============================
        public static String SUBFORM_MAJVACCIN_TITLE = "Mise à jour des vaccins";
        public static String SUBFORM_MAJVACCIN_LABEL_NOM = "Nom : ";
        public static String SUBFORM_MAJVACCIN_LABEL_QTE = "Quantité : ";
        public static String SUBFORM_MAJVACCIN_LABEL_FOURNISSEUR = "Fournisseur : ";
        public static String SUBFORM_MAJVACCIN_BUTTON_MODIFY = "Modifier";

        //===========================
        //SubFormDossierMedical
        //===========================

        public static String SUBFORM_DOSSIER_MEDICAL_TITLE = "Dossier médical de {0}";
        public static String SUBFORM_DOSSIER_MEDICAL_TITLE_2 = "Dossie médical";

        //===========================
        //SubFormRelance
        //===========================

        public static string SUBFORM_RELANCE_TITLE = "Relances";
        public static String SUBFORM_RELANCE_RELANCE = "{0} client(s) relancé(s)";
        public static String SUBFORM_RELANCE_NORELANCE = "Pas de client relancé";
        public static String SUBFORM_RELANCE_RELANCE_ONE = "Client {0} relancé pour son animal {1}";
        public static String SUBFORM_RELANCE_NORELANCE_ONE = "Impossible de relancer {0}";
        public static String SUBFORM_RELANCE_BUTTON_RELANCE_ALL = "Relancer tous";
        public static String SUBFORM_RELANCE_BUTTON_RELANCE_ONE = "Relancer la ligne selectionnée";
        public static String SUBFORM_RELANCE_ERROR_DATA_LOAD = "Impossible de charger la liste : {0}";
        public static String SUBFORM_RELANCE_NOLINESELECTED = "Pas de ligne sélectionnée";
        

    }
}

