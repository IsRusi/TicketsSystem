

namespace Exam.DataAccess.Models
{
    public class Passenger
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
    }
}