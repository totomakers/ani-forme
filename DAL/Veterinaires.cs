﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAL.Dapper;
using System.Data.SqlClient;

namespace DAL
{
    public class Veterinaires
    {
        /// <summary>
        /// Récupère tout les vétérinaires
        /// </summary>
        /// <returns></returns>
        public static List<BO.Veterinaires> GetAll()
        {
            try
            {
                var query = @"SELECT * FROM  Veterinaires v left join Account a on a.id = v.IdAccount Order By v.CodeVeto";
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                List<BO.Veterinaires> results = cnx.Query<BO.Veterinaires, BO.Account, BO.Veterinaires>(query, (veto, account) => { veto.Account = account; return veto; }).ToList<BO.Veterinaires>();
                SqlConnexion.CloseConnexion(cnx);

                return results;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Surcharge de la méthode getAll pour obtenir les archivés ou non
        /// </summary>
        /// <param name="archived"></param>
        /// <returns></returns>
        public static List<BO.Veterinaires> GetAll(bool archived)
        {
            try
            {
                var query = @"SELECT * FROM  Veterinaires v left join Account a on a.id = v.IdAccount Order By v.CodeVeto";
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                List<BO.Veterinaires> results = cnx.Query<BO.Veterinaires, BO.Account, BO.Veterinaires>(query, (veto, account) => { veto.Account = account; return veto; }).ToList<BO.Veterinaires>();
                SqlConnexion.CloseConnexion(cnx);

                return results;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}