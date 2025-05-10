using Exam.DataAccess.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.DataAccess.Repositories
{
    public class PassangerRepository
    {
        private DatabaseConnection dataBaseConnection=new();

        public void AddPassanger(Passanger passanger)
        {
            dataBaseConnection.OpenConnection();
            using (var commands = new NpgsqlCommand())
            {
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
        }
    }
}
