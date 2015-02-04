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
        public static List<BO.Baremes> GetAll()
        {
            List<BO.Baremes> list = DAL.Baremes.GetBaremes();
            return list;
        }

        /// <summary>
        /// Création d'un barème
        /// </summary>
        /// <param name="code"></param>
        /// <param name="date"></param>
        /// <param name="newTarif"></param>
        public static void CreateBareme(String code, String date, String newTarif)
        {
            BO.Baremes bareme = DAL.Baremes.GetBareme(code, date);
            if (DAL.Baremes.ArchiveBareme(bareme))
            {
                bareme.DateVigueur = DateTime.Now.ToString("dd/MM/yy");
                bareme.TarifFixe = Decimal.Parse(newTarif);
                if (!DAL.Baremes.CreateBareme(bareme))
                {
                    DAL.Baremes.DesarchiveBareme(bareme);
                }
            }
        }

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
