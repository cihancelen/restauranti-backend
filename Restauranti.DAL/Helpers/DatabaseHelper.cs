﻿using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Restauranti.DataAccess.Helpers
{
    public class DatabaseHelper
    {
        private static string ConnectionString = "Server=localhost,1433; Database=Restauranti; User Id=SA; Password=fx234hwe";

        public static IDbConnection Connection => new SqlConnection(ConnectionString);
    }
}