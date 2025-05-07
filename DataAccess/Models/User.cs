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
        public int PassangerId{ get; set; }
        public string PasswordHash{ get; set; }
        public int FailedLoginAttempts { get; set; }
        public bool IsLocked { get; set; }
        public User() { }
        public User(int id,int passengerId, string passwordHash, int failedLoginAttempts,bool isLocked)
        {  Id = id; PassangerId = passengerId;PasswordHash = passwordHash;FailedLoginAttempts = failedLoginAttempts;IsLocked = isLocked; }
      

    }
}
