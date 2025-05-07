using Exam.DataAccess.Repositories;
using Exam.DataAccess.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Logic
{
    public class UserLogic
    {
        private UserRepository userRepository = new();

        public void Login(string email, string password)
        {
            if(EncryptPassword.Sha256(password)== userRepository.GetPasswordByEmail(email))
            {
            MessageBox.Show("вы успешно зашли в систему");
            }
        }
    }
}
