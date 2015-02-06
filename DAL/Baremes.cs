using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Dapper;
using System.Data;

namespace DAL
{
    public class Baremes
    {
        public static List<BO.Baremes> GetBaremes()
        {
            try
            {
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                String query = @"SELECT * FROM Baremes b LEFT JOIN Vaccins v ON b.CodeVaccin = v.CodeVaccin WHERE b.archive = 0 ORDER BY b.CodeGroupement";
                List<BO.Baremes> results = cnx.Query<BO.Baremes, BO.Vaccins, BO.Baremes>(query, (bareme, vaccin) => { bareme.Vaccin = vaccin; return bareme; }, splitOn:"CodeVaccin").ToList<BO.Baremes>();
                SqlConnexion.CloseConnexion(cnx);
                return results;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static BO.Baremes GetBareme(string codeParam, string dateParam)
        {
            try
            {
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                String query = String.Format(@"SELECT * FROM Baremes b LEFT JOIN Vaccins v ON b.CodeVaccin = v.CodeVaccin WHERE b.CodeGroupement = {0} AND b.DateVigueur LIKE ('%{1}%')", codeParam, dateParam);
                List<BO.Baremes> results = cnx.Query<BO.Baremes, BO.Vaccins, BO.Baremes>(query, (bareme, vaccin) => { bareme.Vaccin = vaccin; return bareme; }, splitOn: "CodeVaccin").ToList<BO.Baremes>();
                SqlConnexion.CloseConnexion(cnx);
                return results.First();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static bool CreateBareme(BO.Baremes bareme)
        {
            try
            {
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                int output = cnx.Execute("ajout_bareme", new
                {
                    codegroupement = bareme.CodeGroupement,
                    datevigueur = bareme.DateVigueur,
                    typeacte = bareme.TypeActe,
                    libelle = bareme.Libelle,
                    tfixe = bareme.TarifFixe,
                    tmini = bareme.TarifMini,
                    tmaxi = bareme.TarifMaxi,
                    nomvaccin = bareme.Vaccin.NomVaccin
                },
                                        commandType: CommandType.StoredProcedure);
                SqlConnexion.CloseConnexion(cnx);
                return (output > 0);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //@TODO : Faire une seule fonction avec @archived en params
        public static bool ArchiveBareme(BO.Baremes bareme)
        {
            try
            {
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                var query = @"UPDATE Baremes SET Archive=1 WHERE CodeGroupement = @code AND DateVigueur like('%' + @date + '%')";
                int rowNb = cnx.Execute(query, new { code = bareme.CodeGroupement, date = bareme.DateVigueur });
                SqlConnexion.CloseConnexion(cnx);
                return (rowNb > 0);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static bool DesarchiveBareme(BO.Baremes bareme)
        {
            try
            {
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                var query = @"UPDATE Baremes SET Archive=0 WHERE CodeGroupement = @code AND DateVigueure like('%' + @date + '%')";
                int rowNb = cnx.Execute(query, new { code = bareme.CodeGroupement, date = bareme.DateVigueur });
                SqlConnexion.CloseConnexion(cnx);
                return (rowNb > 0);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static bool Flush()
        {
            try
            {
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                var query = @"DELETE FROM Baremes";
                int rowNb = cnx.Execute(query);
                SqlConnexion.CloseConnexion(cnx);
                return (rowNb > 0);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
