using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Lang
    {
        //==================
        //Account
        public static String ACCOUNT_NOT_EXIST = "Ce compte n'existe pas !";

        //==================
        //Agenda
        public static String AGENDA_ANIMAL_AND_VETO_REQUIRED = "Vous devez sélectionner un animal et un vétérinaire !";

        //==================
        //Animaux
        public static String ANIMAUX_CANT_DELETE_ANI_CUST_WITHOUT_GUID = "Impossible de supprimer tout les animaux d'un client sans Guid";
        public static String ANIMAUX_CANT_ARCHIVE_CONSULT_NOT_PAID = "Impossible d'archivé les animaux de {0}, certains on des consultations non payée";
        public static String ANIMAUX_CANT_DELETE_WITHOUT_GUID = "Impossible de supprimer un animal sans GUID";
        public static String ANIMAUX_HAVE_NOT_PAID_CONSULT = "L'animal {0} a une consultation non payée";
        public static String ANIMAUX_CREATE_SHOULD_HAVE_CLIENT = "Impossible de creer un animal sans client";
        public static String ANIMAUX_UPDATE_SHOULD_HAVE_CLIENT = "Impossible de mette à jour un animal sans client";
        public static String ANIMAUX_UPDATE_SHOULD_HAVE_CODE = "Impossible de mettre un animal sans code";
        public static String ANIMAUX_CANT_GET_BY_CLIENT_WITHOUT_GUID = "Impossible de récuperer les animaux d'un client sans GUID";

        //==================
        //Clients
        public static String CLIENTS_CANT_DELETE_WITHOUT_GUID = "Impossible de supprimer un client sans GUID";
        public static String CLIENTS_CANT_DELETE_HAVE_NOT_PAID_FACTURE = "Le client a {0} facture impayée ! Il ne peut pas être supprimé";

        //==================
        //Vétérinaires

        public static String VETERINAIRES_CANT_DELETE_WITHOUT_GUID = "Impossible de supprimer un vétérinaires sans Guid";

        //==================
        //LignesConsultations

        public static String LIGNESCONSULTATION_CANT_CREATE_WITHOUT_CONSULTATION = "Une ligne de consultation ne peut pas être enregistrer si elle n'est pas liée a une consultation";
        public static String LIGNESCONSULTATION_CANT_CREATE_WITHOUT_BAREM = "Une ligne de consultation ne peut pas être enregistrer si elle n'est pas liée a un barem";

        public static String LIGNESCONSULTATION_CANT_DELETE_PK = "Impossible de supprimer une ligne de consultation sans consultation et/ou numéros de ligne";
    }
}
