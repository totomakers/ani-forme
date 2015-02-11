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
                String query;
                List<BO.Agenda> results;
                if (veto == null)
                {
                    query = @"SELECT * FROM Agendas ag
                            LEFT JOIN Veterinaires v ON ag.CodeVeto = v.CodeVeto
                            LEFT JOIN Animaux an ON ag.CodeAnimal = an.CodeAnimal
                            ORDER BY ag.DateRdv";
                    results = cnx.Query<BO.Agenda, BO.Veterinaires, BO.Animaux, BO.Agenda>(query,
                                               (agenda, veterinaire, animal) => { agenda.Animal = animal; agenda.Veterinaires = veterinaire; return agenda; },
                                               splitOn: "CodeVeto,CodeAnimal")
                                               .ToList<BO.Agenda>();
                }
                else
                {
                    query = @"SELECT * FROM Agendas ag
                            LEFT JOIN Veterinaires v ON ag.CodeVeto = v.CodeVeto
                            LEFT JOIN Animaux an ON ag.CodeAnimal = an.CodeAnimal
                            WHERE  ag.CodeVeto = @codeVeto
                            ORDER BY ag.DateRdv";
                    results = cnx.Query<BO.Agenda, BO.Veterinaires, BO.Animaux, BO.Agenda>(query,
                                              (agenda, veterinaire, animal) => { agenda.Animal = animal; agenda.Veterinaires = veterinaire; return agenda; },
                                              new { codeVeto = veto.CodeVeto },
                                              splitOn: "CodeVeto,CodeAnimal")
                                              .ToList<BO.Agenda>();
                }

                SqlConnexion.CloseConnexion(cnx);
                return results;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        
        public static List<BO.Agenda> GetAll(BO.Veterinaires veto, DateTime date)
        {
            try
            {
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                String query;
                List<BO.Agenda> results;
                date = new DateTime(date.Year, date.Month, date.Day);
                if (veto == null)
                {
                    query = @"SELECT * FROM Agendas ag
                            LEFT JOIN Veterinaires v ON ag.CodeVeto = v.CodeVeto
                            LEFT JOIN Animaux an ON ag.CodeAnimal = an.CodeAnimal
                            LEFT JOIN Clients c ON an.CodeClient = c.CodeClient
                            WHERE DateRdv BETWEEN cast(@dateRdv as SmallDateTime) AND cast(@dateRdv as SmallDateTime)+1
                            ORDER BY ag.DateRdv";
                    results = cnx.Query<BO.Agenda, BO.Veterinaires, BO.Animaux, BO.Clients, BO.Agenda>(query,
                                               (agenda, veterinaire, animal, client) => { animal.Client = client; agenda.Animal = animal; agenda.Veterinaires = veterinaire; return agenda; },
                                               new { dateRdv = date },
                                               splitOn: "CodeVeto,CodeAnimal,CodeClient")
                                               .ToList<BO.Agenda>();
                }
                else
                {
                    query = @"SELECT * FROM Agendas ag
                            LEFT JOIN Veterinaires v ON ag.CodeVeto = v.CodeVeto
                            LEFT JOIN Animaux an ON ag.CodeAnimal = an.CodeAnimal
                            LEFT JOIN Clients c ON an.CodeClient = c.CodeClient
                            WHERE  ag.CodeVeto = @codeVeto
                            AND DateRdv BETWEEN cast(@dateRdv as SmallDateTime) AND cast(@dateRdv as SmallDateTime)+1
                            ORDER BY ag.DateRdv";
                    results = cnx.Query<BO.Agenda, BO.Veterinaires, BO.Animaux, BO.Clients, BO.Agenda>(query,
                                              (agenda, veterinaire, animal, client) => { animal.Client = client;  agenda.Animal = animal; agenda.Veterinaires = veterinaire; return agenda; },
                                              new { codeVeto = veto.CodeVeto, dateRdv = date },
                                              splitOn: "CodeVeto,CodeAnimal,CodeClient")
                                              .ToList<BO.Agenda>();
                }

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
	                                            codeveto = agenda.Veterinaires.CodeVeto,
	                                            daterdv = agenda.DateRdv,
                                                urgence = (agenda.Urgence) ? 1 : 0
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
