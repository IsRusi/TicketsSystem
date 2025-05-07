using Exam.DataAccess.Repositories;
using Exam.DataAccess.Utils;
using Exam.Utils;
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
        public string? GetUserRoleByEmail(string email)
        {
            var userWithRole = userRepository.GetUserRoleByEmail(email);
            return userWithRole?.RoleName;
        }
        public LoginResult Login(string email, string password)
        {

            var user = userRepository.GetUserByEmail(email);
            if (!InputValidator.IsValidEmail(email))
                return LoginResult.UserNotFound;
           
            if (user is null) return LoginResult.UserNotFound;
            if (user.IsLocked) return LoginResult.UserLocked;

            if (!HashPassword(user.PasswordHash, password) || !InputValidator.IsValidPassword(password))
            {
                user.FailedLoginAttempts++;
                if (user.FailedLoginAttempts >= 5)
                {
                    user.IsLocked = true;
                }
                userRepository.IncrementFailedAttempts(email);
                return LoginResult.WrongPassword;
            }

            userRepository.ResetFailedAttempts(email);
            return LoginResult.Success;
        }

        public bool HashPassword(string hash, string password) => CryptPassword.Sha256(password).Equals(hash);
    }
}
