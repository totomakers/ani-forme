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
        public static List<BO.Baremes> GetBaremes(String Type)
        {
            try
            {
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                List<BO.Baremes> results = null;
                if (String.IsNullOrEmpty(Type))
                {
                    String query = @"SELECT * FROM Baremes b 
                                LEFT JOIN Vaccins v ON b.CodeVaccin = v.CodeVaccin 
                                WHERE b.archive = 0 
                                ORDER BY b.CodeGroupement";
                    results = cnx.Query<BO.Baremes, BO.Vaccins, BO.Baremes>(query, (bareme, vaccin) => { bareme.Vaccin = vaccin; return bareme; }, splitOn: "CodeVaccin").ToList<BO.Baremes>();
                }
                else
                {
                    String query = @"SELECT * FROM Baremes b 
                                LEFT JOIN Vaccins v ON b.CodeVaccin = v.CodeVaccin 
                                WHERE b.archive = 0 
                                AND TypeActe LIKE ('%' + @type + '%')
                                ORDER BY b.CodeGroupement";
                    results = cnx.Query<BO.Baremes, BO.Vaccins, BO.Baremes>(query, (bareme, vaccin) => { bareme.Vaccin = vaccin; return bareme; }, new { type = Type }, splitOn: "CodeVaccin").ToList<BO.Baremes>();
                }
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

        public static List<String> GetTypeActe()
        {
            try
            {
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                String query = @"Select distinct TypeActe FROM Baremes";
                List<String> results = cnx.Query<String>(query).ToList<String>();
                SqlConnexion.CloseConnexion(cnx);
                return results;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static bool CreateBareme(BO.Baremes bareme)
        {
            //@TODO : Correction crash liée a la date... :D
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
                    nomvaccin = (bareme.Vaccin == null) ? "" : bareme.Vaccin.NomVaccin
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

        /// <summary>
        /// Archive ou desarchive un bareme
        /// </summary>
        /// <param name="bareme"></param>
        /// <param name="archiveParam"></param>
        /// <returns></returns>
        public static bool Archive(BO.Baremes bareme, bool archiveParam)
        {
            try
            {
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                var query = @"UPDATE Baremes SET Archive=@archive WHERE CodeGroupement = @code AND DateVigueur like('%' + @date + '%')";
                int rowNb = cnx.Execute(query, new { archive = (archiveParam) ? 1 : 0, code = bareme.CodeGroupement, date = bareme.DateVigueur });
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
