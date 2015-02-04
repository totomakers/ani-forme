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

        //=========================
        //FormLogin
        //=========================

        public static String FORM_LOGIN_TITLE = "Connection";
        public static String FORM_LOGIN_LIB_USERNAME = "Nom d'utilisateur";
        public static String FORM_LOGIN_LIB_PASSWORD = "Mot de passe";
        public static String FORM_LOGIN_BTN_LOGIN = "Valider";
        public static String FORM_LOGIN_LOGIN_FAIL_TITLE = "Erreur";
        public static String FORM_LOGIN_LOGIN_FAIL_TEXT = "La combinaison est invalide";

        //==========================
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

        //==========================
        //SubFormListPrice 
        //===========================
        public static String SUB_FORM_LIST_PRICE_TITLE = "Barème";
        public static String SUB_FORM_LIST_PRICE_LABEL_LIBELLE = "Libellé";
        public static String SUB_FORM_LIST_PRICE_LABEL_TARIF_FIXE = "Tarif";
        public static String SUB_FORM_LIST_PRICE_BTN_MODIFY = "Modifier";
    }
}

