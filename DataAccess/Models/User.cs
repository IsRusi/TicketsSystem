using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.DataAccess.Models
{
    public class User
    {
        public int Id { get; set; }
        public int PassengerId{ get; set; }
        public string PasswordHash{ get; set; }
        public User() { }
        public User(int id,int passengerId, string passwordHash)
        {  Id = id; PassengerId = passengerId;PasswordHash = passwordHash;}
        public override string ToString()=>$"{PassengerId}, '{PasswordHash}'";
    

    }
}
