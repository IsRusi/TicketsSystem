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
            commands.CommandText = "select users.user_id,users.passanger_id,users.password_hash,users.failed_attempts,users.is_locked  from users inner join passanger on passanger.passanger_id=users.passanger_id where passanger.email = @email";
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
                        PassangerId = Convert.ToInt32(reader["passanger_id"]),
                        PasswordHash = reader["password_hash"].ToString(),
                        FailedLoginAttempts = Convert.ToInt32(reader["failed_attempts"]),
                        IsLocked= Convert.ToBoolean(reader["is_locked"])
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
            commands.CommandText = "SELECT COUNT(*) FROM passanger WHERE email = @email";
            commands.Parameters.Clear();
            commands.Parameters.AddWithValue("@email", email);

            bool exists = false;
            try
            {
                var result = commands.ExecuteScalar();
                exists = Convert.ToInt64(result) > 0;
            }
            finally
            {
                dataBaseConnection.CloseConnection();
            }

            return exists;
        }

        public bool IsAccountLocked(string email)
        {
            dataBaseConnection.OpenConnection();
            commands.Connection = dataBaseConnection.GetConnection();

            commands.CommandText = @"
        SELECT is_locked FROM users u
        JOIN passanger p ON p.passanger_id = u.passanger_id
        WHERE p.email = @Email";
            commands.Parameters.Clear();
            commands.Parameters.AddWithValue("@Email", email);

            bool isLocked = false;
            using (var reader = commands.ExecuteReader())
            {
                if (reader.Read())
                {
                    isLocked = Convert.ToBoolean(reader["is_locked"]);
                }
            }

            dataBaseConnection.CloseConnection();
            return isLocked;
        }
        public void IncrementFailedAttempts(string email)
        {
            dataBaseConnection.OpenConnection();
            commands.Connection = dataBaseConnection.GetConnection();
            commands.CommandText = @"
        UPDATE users
        SET failed_attempts = failed_attempts + 1,
            is_locked = CASE WHEN failed_attempts >= 5 THEN TRUE ELSE is_locked END
        FROM passanger
        WHERE passanger.passanger_id = users.passanger_id AND passanger.email = @Email";
            commands.Parameters.Clear();
            commands.Parameters.AddWithValue("@Email", email);
            commands.ExecuteNonQuery();
            dataBaseConnection.CloseConnection();
        }
        public void ResetFailedAttempts(string email)
        {
            dataBaseConnection.OpenConnection();
            commands.Connection = dataBaseConnection.GetConnection();
            commands.CommandText = @"
        UPDATE users
        SET failed_attempts = 0, is_locked = FALSE
        FROM passanger
        WHERE passanger.passanger_id = users.passanger_id AND passanger.email = @Email";
            commands.Parameters.Clear();
            commands.Parameters.AddWithValue("@Email", email);
            commands.ExecuteNonQuery();
            dataBaseConnection.CloseConnection();
        }

        public void AddRoleToUser(int userId,int roleId)
        {
            dataBaseConnection.OpenConnection();
            commands.Connection = dataBaseConnection.GetConnection();
            commands.CommandText = @"insert into usersrole(user_id,role_id) values(@userId,@roleId)";
            commands.Parameters.Clear();
            commands.Parameters.AddWithValue("@userId",userId);
            commands.Parameters.AddWithValue("@roleId",roleId);
            dataBaseConnection.CloseConnection();
        }
        public void AddPassanger(Passanger passanger)
        {
            dataBaseConnection.OpenConnection();
            commands.Connection = dataBaseConnection.GetConnection();
            commands.CommandText = @"
             INSERT INTO passanger (first_name, second_name,surname, email, phone, document_number, gender, birth_date) 
            VALUES (@first_name, @second_name,@middle_name, @email, @phone, @document_number, @gender, @birth_date) 
            RETURNING passanger_id;";

            commands.Parameters.Clear();


            commands.Parameters.AddWithValue("@first_name", passanger.FirstName);
            commands.Parameters.AddWithValue("@second_name", passanger.LastName);
            commands.Parameters.AddWithValue("@middle_name", passanger.Surname);
            commands.Parameters.AddWithValue("@email", passanger.Email);
            commands.Parameters.AddWithValue("@phone", passanger.Phone);
            commands.Parameters.AddWithValue("@document_number", passanger.DocumentNumber);
            commands.Parameters.AddWithValue("@gender", passanger.Gender);
            commands.Parameters.AddWithValue("@birth_date", passanger.BirthDate);

            var result = commands.ExecuteScalar();
            int passangerId = (int)result;
            passanger.Id = passangerId;


            dataBaseConnection.CloseConnection();
        }
        public void AddUser(User user)
        {
            dataBaseConnection.OpenConnection();
            commands.Connection = dataBaseConnection.GetConnection();
            commands.CommandText = @"
        INSERT INTO users (passanger_id, password_hash, failed_attempts, is_locked) 
        VALUES (@passanger_id, @password_hash, @failed_attempts, @is_locked);";

            commands.Parameters.Clear();

            commands.Parameters.AddWithValue("@passanger_id", user.PassangerId);
            commands.Parameters.AddWithValue("@password_hash", user.PasswordHash);
            commands.Parameters.AddWithValue("@failed_attempts", user.FailedLoginAttempts);
            commands.Parameters.AddWithValue("@is_locked", user.IsLocked);
            commands.ExecuteNonQuery();
            dataBaseConnection.CloseConnection();
        }
    }
}