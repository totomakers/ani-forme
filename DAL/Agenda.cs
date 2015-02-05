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
    public class Agenda
    {
        public static List<BO.Agenda> GetAll(BO.Veterinaires veto = null)
        {
            try
            {
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                String query = @"SELECT * FROM Agendas ag
                                 LEFT JOIN Veterinaires v ON ag.CodeVeto = v.CodeVeto
                                 LEFT JOIN Animaux an ON ag.CodeAnimal = an.CodeAnimal
                                 ORDER BY ag.DateRdv";

                List<BO.Agenda> results = cnx.Query<BO.Agenda, BO.Veterinaires, BO.Animaux, BO.Agenda>(query,
                                           (agenda, veterinaire, animal) => { agenda.Animal = animal; agenda.Veterinaires = veterinaire; return agenda; },
                                           splitOn: "CodeVeto,CodeAnimal")
                                           .ToList<BO.Agenda>();

                SqlConnexion.CloseConnexion(cnx);
                return results;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static bool Verif(BO.Agenda agenda)
        {
            try 
	        {	        
		        SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                String query = @"SELECT count(*) FROM Agendas WHERE DateRdv=@date AND CodeVeto=@code";
                int results1 = cnx.Query<int>(query, new { date = agenda.DateRdv, code = agenda.Veterinaires.CodeVeto }).ToList<int>()[0];
                query = @"SELECT count(*) FROM Agendas WHERE DateRdv=@date AND CodeAnimal=@code";
                int results2 = cnx.Query<int>(query, new { date = agenda.DateRdv, code = agenda.Animal.CodeAnimal }).ToList<int>()[0];
            
                SqlConnexion.CloseConnexion(cnx);

                if (results1 > 0 || results2 > 0)
                    return false;
                else
                    return true;
	        }
	        catch (Exception e)
	        {
		
		        throw e;
	        }
        }

        public static bool Create(BO.Agenda agenda)
        {
            try
            {
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                int output = cnx.Execute(   "ajout_agenda", 
                                            new { 
                                                nomclient = DAL.Clients.Get(agenda.Animal.Client.CodeClient).NomClient,
	                                            prenomclient = DAL.Clients.Get(agenda.Animal.Client.CodeClient).PrenomClient,
	                                            nomanimal = agenda.Animal.NomAnimal,
	                                            nomveto = agenda.Veterinaires.NomVeto,
	                                            daterdv = agenda.DateRdv
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

        public static bool Delete(BO.Agenda agenda)
        {
            try
            {
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                var query = @"DELETE FROM Agendas WHERE CodeVeto = @codeVeto AND DateRdv = @date AND CodeAnimal = @codeAnimal";
                int rowNb = cnx.Execute(query, new { codeVeto = agenda.Veterinaires.CodeVeto, codeAnimal = agenda.Animal.CodeAnimal, date = agenda.DateRdv });
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
