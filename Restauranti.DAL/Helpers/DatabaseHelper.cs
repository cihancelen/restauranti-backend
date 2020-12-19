using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Restauranti.DAL.Helpers
{
    public class DatabaseHelper
    {
        private static string ConnectionString = "Server=localhost,1433; Database=Restauranti; User Id=SA; Password=!restauranti2020";

        public static IDbConnection Connection => new SqlConnection(ConnectionString);
    }
}
