using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ListPriceMgr
    {
        public static List<BO.Baremes> GetBaremes()
        {
            List<BO.Baremes> list = DAL.Baremes.GetBaremes();
            return list;
        }

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
    }
}
