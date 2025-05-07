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
            commands.CommandText = "select users.user_id,users.passanger_id,users.password_hash from users inner join passanger on passanger.passanger_id=users.passanger_id where passanger.email = @email";
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
                        PassengerId = Convert.ToInt32(reader["passanger_id"]),
                        PasswordHash = reader["password_hash"].ToString()
                    };
                }
            }
            dataBaseConnection.CloseConnection();
        return user;
        }
        public UsersRole? GetUserRoleByEmail(string email)
        {
            dataBaseConnection.OpenConnection();
            commands.Connection = dataBaseConnection.GetConnection();
            commands.CommandText = @"SELECT u.user_id, r.role_name
FROM users u
JOIN usersrole ur ON u.user_id = ur.user_id
JOIN role r ON ur.role_id = r.role_id
JOIN passanger p ON p.passanger_id = u.passanger_id
WHERE p.email = @Email
";
            commands.Parameters.Clear();
            commands.Parameters.AddWithValue("@Email", email);
            UsersRole? user = null;
            using (var reader = commands.ExecuteReader())
            {
                if (reader.Read())
                {
                    user = new UsersRole
                    {
                        Id = Convert.ToInt32(reader["user_id"]),
                        RoleName = reader["role_name"].ToString()
                    };
                }
            }

            dataBaseConnection.CloseConnection();
            return user;
        }
        public bool ExistsByEmail(string email)
        {
            dataBaseConnection.OpenConnection();
            commands.Connection = dataBaseConnection.GetConnection();
            string query = "SELECT COUNT(*) FROM users WHERE email = @email"; 
            commands.Parameters.AddWithValue("@email", email);
            return (long)commands.ExecuteScalar() > 0;
        }
        public void AddPassanger(Passanger passanger)
        {
            dataBaseConnection.OpenConnection();
            commands.Connection = dataBaseConnection.GetConnection();
            commands.CommandText = @"insert into passanger(first_name,second_name,middle_name,email,phone,document_number,gender,birth_date) values(@passanger)";
            commands.Parameters.Clear();
            commands.Parameters.AddWithValue("@passanger", passanger.ToString());
            dataBaseConnection.CloseConnection();
        }
        public void AddUser(User user)
        {
            dataBaseConnection.OpenConnection();
            commands.Connection = dataBaseConnection.GetConnection();
            commands.CommandText = @"insert into users(passenger_id,password_hash) values(@user)";
            commands.Parameters.Clear();
            commands.Parameters.AddWithValue("@user", user.ToString());
            dataBaseConnection.CloseConnection();
        }
    }
}