﻿//using Dapper;
//using Microsoft.Data.SqlClient;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Threading.Tasks;

//namespace MonthlyBillsWebAPI.Data
//{
//    public class DataAccess
//    {
//        public class Instance<T>
//        {
//            private string connectionString;
//            public Instance()
//            {
//                connectionString = Startup.ConnectionString;
//            }

//            public IEnumerable<T> Execute(string proc, DynamicParameters parameters = null)
//            {
//                using (var conn = new SqlConnection(connectionString))
//                {
//                    try
//                    {
//                        var results = conn.Query<T>(proc, parameters, commandType: CommandType.StoredProcedure);
//                        return results;
//                    }

//                    catch (Exception e)
//                    {
//                        //Logging.Log("error executing query:" + e.Message);
//                        return null;
//                    }
//                }
//            }
//        }

//    }
//}
