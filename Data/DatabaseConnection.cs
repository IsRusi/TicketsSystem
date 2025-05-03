using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Data
{
    internal class DatabaseConnection
    {
        private string connectionString;
        private static NpgsqlConnection databaseConnection=new();
        public DatabaseConnection()
        {
        }
        public void CloseConnection() => databaseConnection.Close();
        public void OpenConnection() 
        {
            try
            {

                databaseConnection.ConnectionString = connectionString;
                databaseConnection.Open();
            }
            catch (Exception ex)
            {

            }
        }
        
    }
}
