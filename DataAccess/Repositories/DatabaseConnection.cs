using Microsoft.Extensions.Configuration;
using Npgsql;
using Exam.DataAccess.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.DataAccess.Repositories
{
    internal class DatabaseConnection
    {
        private const string path= "O:\\programming\\Exam Project\\C#\\Exam\\keys\\";
        private string connectionString;
        private NpgsqlConnection databaseConnection=new();
        public DatabaseConnection()
        {
            connectionString = JsonsReader.ReadJsonFile(path);
            databaseConnection.ConnectionString = connectionString;
        }
        public void CloseConnection() => databaseConnection.Close();
        public void OpenConnection() 
        {
            try
            {
                connectionString=JsonsReader.ReadJsonFile(path);
                databaseConnection.ConnectionString = connectionString;
                databaseConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ошибка подключения : "+ex.Message);
            }
        }
        public NpgsqlConnection GetConnection() => databaseConnection;
    
    }
}
