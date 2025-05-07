

namespace Exam.DataAccess.Models
{
    public class Passanger
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email{ get; set; }
        public string Phone{ get; set; }
        public string DocumentNumber{ get; set; }
        public string Gender{ get; set; }
        public DateTime BirthDate{ get; set; }
        public Passanger()
        {

        }
        public Passanger(int id, string lastName, string firstName, string surname, string email, string phone, string documentNumber, string gender, DateTime birthDate)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            Surname = surname;
            Email = email;
            Phone = phone;
            DocumentNumber = documentNumber;
            Gender = gender;
            BirthDate = birthDate;
        }
        public override string ToString()
        {
            return $"'{LastName}', '{FirstName}', '{Surname}', '{Email}', '{Phone}', '{DocumentNumber}', '{Gender}', '{BirthDate:yyyy-MM-dd}'";
        }

    }
}