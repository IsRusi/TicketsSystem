using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.DataAccess.Utils;
using Exam.DataAccess.Repositories;
using Npgsql;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Exam.DataAccess.Models;
using System.CodeDom;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace Exam.DataAccess.Repositories
{

    public class UserRepository
    {
        private DatabaseConnection dataBaseConnection = new();
        private NpgsqlCommand commands = new();
        public UserRepository()
        {
        }
        public User? GetUserByEmail(string email)
        {
            dataBaseConnection.OpenConnection();
            commands.Connection = dataBaseConnection.GetConnection();
            commands.CommandText = "select users.user_id,users.passenger_id,users.password_hash from users inner join passenger on passenger.passenger_id=users.passenger_id where passenger.email = @email";
            commands.Parameters.Clear();
            commands.Parameters.AddWithValue("@email", email);
            User? user = null;
            using (var reader = commands.ExecuteReader())
            {
                while (reader.Read())
                {
                    user = new User
                    {
                        Id = Convert.ToInt32(reader["user_id"]),
                        PassengerId = Convert.ToInt32(reader["passenger_id"]),
                        PasswordHash = reader["password_hash"].ToString()
                    };
                }
            }
            MessageBox.Show($"{user is null}");
            dataBaseConnection.CloseConnection();
        return user;
        }
        public void AddPassanger(Passenger passenger)
        {
            dataBaseConnection.OpenConnection();
            commands.Connection = dataBaseConnection.GetConnection();
            commands.CommandText = @"insert into passenger(first_name,second_name,middle_name,email,phone,document_number,gender,birth_date) values(@passenger)";
            commands.Parameters.Clear();
            commands.Parameters.AddWithValue("@passenger", passenger.ToString());
            dataBaseConnection.CloseConnection();
        }
        public void AddUser(User user)
        {
            dataBaseConnection.OpenConnection();
            commands.Connection = dataBaseConnection.GetConnection();
            commands.CommandText = @"insert into passenger(first_name,second_name,middle_name,email,phone,document_number,gender,birth_date) values(@passenger)";
            commands.Parameters.Clear();
            commands.Parameters.AddWithValue("@passenger", user.ToString());
            dataBaseConnection.CloseConnection();
        }
    }
}