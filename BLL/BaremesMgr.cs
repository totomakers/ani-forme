using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BLL
{
    public class BaremesMgr
    {
        /// <summary>
        /// Retourne l'ensemble des barèmes
        /// </summary>
        /// <returns></returns>
        public static List<BO.Baremes> GetAll(String Type)
        {
            List<BO.Baremes> list = DAL.Baremes.GetBaremes(Type);
            return list;
        }

        /// <summary>
        /// Retourne la liste des types d'actes
        /// </summary>
        /// <returns></returns>
        public static List<String> GetTypeActe()
        {
            return DAL.Baremes.GetTypeActe();
        }

        /// <summary>
        /// Création d'un barème
        /// </summary>
        /// <param name="code"></param>
        /// <param name="date"></param>
        /// <param name="newTarif"></param>
        public static void CreateBareme(BO.Baremes baremeParam, String newTarifFixe, String newTarifMini, String newTarifMaxi)
        {
            BO.Baremes bareme = DAL.Baremes.GetBareme(baremeParam.CodeGroupement, baremeParam.DateVigueur);
            if (DAL.Baremes.Archive(bareme, true))
            {
                bareme.DateVigueur = DateTime.Now.ToString("dd/MM/yy");
                bareme.TarifFixe = Decimal.Parse(newTarifFixe);
                bareme.TarifMaxi = Decimal.Parse(newTarifMaxi);
                bareme.TarifMini = Decimal.Parse(newTarifMini);
                if (!DAL.Baremes.CreateBareme(bareme))
                {
                    DAL.Baremes.Archive(bareme, false);
                }
            }
        }

        /// <summary>
        /// Importe le xml dans barème
        /// </summary>
        /// <param name="path"></param>
        public static void ImportXml(string path)
        {
            XDocument doc = XDocument.Load(path);
            List<XNode> nodes = (from n in doc.Descendants()
                                where n.Name == "Baremes"
                                select n).ToList<XNode>();
            DAL.Baremes.Flush();
            foreach (XElement node in nodes)
            {
                BO.Baremes bar = new BO.Baremes();
                foreach (XElement son in node.Nodes())
                {
                    bar.Attribute(son.Name.ToString(), son.Value);
                }
                DAL.Baremes.CreateBareme(bar);
            }
        }
    }
}
