using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAL;

namespace BLL
{
    public class VeterinairesMgr
    {
        /// <summary>
        /// Retourne l'ensemble des vétérinaires
        /// </summary>
        /// <returns></returns>
        public static List<BO.Veterinaires> GetAll()
        {
            return DAL.Veterinaires.GetAll();
        }

        /// <summary>
        /// Retourne l'ensemble des vétérinaires archivé/non archivé
        /// </summary>
        /// <param name="archived"></param>
        /// <returns></returns>
        public static List<BO.Veterinaires> GetAll(bool archived)
        {
            return DAL.Veterinaires.GetAll(false);
        }

        public static BO.Veterinaires GetByAccount(int idParam)
        {
            return DAL.Veterinaires.GetByAccount(idParam);
        }

        /// <summary>
        /// Archive le vétérinaire passé en param
        /// </summary>
        /// <param name="veto"></param>
        /// <returns></returns>
        public static bool Delete(BO.Veterinaires veto)
        {
            if (veto.CodeVeto == default(Guid))
                throw new Exception(Lang.VETERINAIRES_CANT_DELETE_WITHOUT_GUID);

            return DAL.Veterinaires.Archive(veto, true);
        }

        /// <summary>
        /// Creer le vétérinaire
        /// et le retourne avec son id
        /// </summary>
        /// <param name="veterinaires"></param>
        public static BO.Veterinaires Create(BO.Veterinaires veterinaires)
        {
            return DAL.Veterinaires.Create(veterinaires);
        }
    }
}
