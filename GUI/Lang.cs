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

        public static String FORM_DEFAULT_ERROR_TITLE = "Erreur";

        public static String FORM_DEFAULT_FIRST = "<< Premier";
        public static String FORM_DEFAULT_LAST = "Dernier >>";
        public static String FORM_DEFAULT_PREV = "< Précédent";
        public static String FORM_DEFAULT_NEXT = "Suivant >";

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
        public static String SUBFORM_LIST_PRICE_LIB_TARIF_FIXE = "Tarif";
        public static String SUBFORM_LIST_PRICE_BTN_MODIFY = "Modifier";
        public static String SUBFORM_LIST_PRICE_BTN_IMPORT = "Import XML";

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
        public static String SUBFORM_FOLDERCUSTANI_DELETE_ANI = "Supprimer animal";
        public static String SUBFORM_FOLDERCUSTANI_TITLE_SUCCEFULL_ARCHIVE = "Client archivé";
        public static String SUBFORM_FOLDERCUSTANI_SUCCEFULL_ARCHIVE = "Le client {0} a été archivé !";
        public static String SUBFORM_FOLDERCUSTANI_SEARCH = "Flitrer";
    }
}

