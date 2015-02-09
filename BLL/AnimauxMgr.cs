using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    /// <summary>
    /// Tout les sexes possible pour un animal
    /// </summary>
    public class AnimauxSexe
    {
        public static Char MALE = 'M';
        public static Char FEMELLE = 'F';
    }

    /// <summary>
    /// Tout les critères de recherche possible
    /// </summary>
    public enum AnimauxRechercheCritere
    {
        NOM_CLIENT,
        NOM,
        TATOO
    }

    public class AnimauxMgr
    {
        /// <summary>
        /// Retourne tout les animaux
        /// </summary>
        /// <returns></returns>
        public static List<BO.Animaux> GetAll()
        {
            return DAL.Animaux.GetAll();
        }

        /// <summary>
        /// Retourne l'ensemble des sexe possible
        /// </summary>
        /// <returns></returns>
        public static List<Char> getSexe()
        {
            List<Char> sexeList = new List<char>();
            sexeList.Add(AnimauxSexe.MALE);
            sexeList.Add(AnimauxSexe.FEMELLE);

            return sexeList;
        }

        /// <summary>
        /// Retourne tout les animaux, archivé ou non
        /// </summary>
        /// <param name="archived"></param>
        /// <returns></returns>
        public static List<BO.Animaux> GetAll(bool archived)
        {
            return DAL.Animaux.GetAll(archived);
        }

        /// <summary>
        /// Retourne tout les animaux par clients
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public static List<BO.Animaux> GetAllByClient(BO.Clients client)
        {
            if (client.CodeClient == default(Guid))
                throw new Exception(Lang.ANIMAUX_CANT_GET_BY_CLIENT_WITHOUT_GUID);

            return DAL.Animaux.GetAllByClient(client);
        }

        /// <summary>
        /// Retourne tout les animaux par client, archivé ou non
        /// </summary>
        /// <param name="client"></param>
        /// <param name="archived"></param>
        /// <returns></returns>
        public static List<BO.Animaux> GetAllByClient(BO.Clients client, bool archived)
        {
            if (client.CodeClient == default(Guid))
                throw new Exception(Lang.ANIMAUX_CANT_GET_BY_CLIENT_WITHOUT_GUID);

            return DAL.Animaux.GetAllByClient(client, archived);
        }

        /// <summary>
        /// Archive tout les animaux du clients passé en params
        /// </summary>
        /// <param name="client"></param>
        public static void DeleteAllByClient(BO.Clients client)
        {
            if (client.CodeClient == default(Guid))
                throw new Exception(Lang.ANIMAUX_CANT_DELETE_ANI_CUST_WITHOUT_GUID);

            List<BO.Animaux> animaux = DAL.Animaux.GetAllByClient(client);
            foreach (BO.Animaux animal in animaux)
            {
                if (DAL.Consultations.GetNonPayed(animal) > 0)
                    throw new Exception(String.Format(Lang.ANIMAUX_CANT_ARCHIVE_CONSULT_NOT_PAID, client.getFullName()));
            }
            DAL.Animaux.ArchiveAllByClient(client);
        }

        /// <summary>
        /// Retourne tout les animaux archivé ou non avec un like sur la colonne du critere
        /// </summary>
        /// <param name="critere"></param>
        /// <param name="value"></param>
        /// <param name="archived"></param>
        public static List<BO.Animaux> GetAllByColumnLikeValue(AnimauxRechercheCritere critere, String value, bool archived)
        {
            switch (critere)
            {
                case AnimauxRechercheCritere.NOM:
                    return DAL.Animaux.GetAllByNomAnimalArchive(value, archived);

                case AnimauxRechercheCritere.NOM_CLIENT:
                    return DAL.Animaux.GetAllByNomClientArchive(value, archived);

                case AnimauxRechercheCritere.TATOO:
                    return DAL.Animaux.GetAllByTatooArchive(value, archived);

                default:
                    throw new Exception("W00T ?");
            }
        }

        /// <summary>
        /// Archive l'animal passé en params
        /// </summary>
        /// <param name="animal"></param>
        public static void Delete(BO.Animaux animal)
        {
            if (animal.CodeAnimal == default(Guid))
                throw new Exception(Lang.ANIMAUX_CANT_DELETE_WITHOUT_GUID);

            if (DAL.Consultations.GetNonPayed(animal) > 0) 
                throw new Exception(String.Format(Lang.ANIMAUX_CANT_ARCHIVE_CONSULT_NOT_PAID, animal.NomAnimal));
            

            DAL.Animaux.Archive(animal);
        }

        /// <summary>
        /// Permet de creer l'animal passer en param
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        public static BO.Animaux Create(BO.Animaux animal)
        {
            //Ne peut pas être creer si aucun client
            if (animal.Client == null)
                throw new Exception(Lang.ANIMAUX_CREATE_SHOULD_HAVE_CLIENT);

            return DAL.Animaux.Create(animal);
        }

        /// <summary>
        /// Mise a jour de l'animal selectionné
        /// </summary>
        /// <param name="animal"></param>
        public static bool Update(BO.Animaux animal)
        {
            if(animal.Client == null)
                throw new Exception(Lang.ANIMAUX_UPDATE_SHOULD_HAVE_CLIENT);

            if (animal.CodeAnimal == default(Guid))
                throw new Exception(Lang.ANIMAUX_UPDATE_SHOULD_HAVE_CODE);
            
            return DAL.Animaux.Update(animal);
        }
    }
}
