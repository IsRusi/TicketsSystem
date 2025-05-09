using Exam.DataAccess.Models;
using Exam.DataAccess.Repositories;
using Exam.DataAccess.Utils;
using Exam.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
      
        public RegistrationResult Registration(RegistrationData data)
        {
            var hashedPassword = CryptPassword.Sha256(data.Password);
            var passanger = new Passanger
            {
                FirstName = data.FirstName,
                LastName = data.LastName,
                Surname = data.Surname,
                Email = data.Email,
                Phone = data.Phone,
                Gender = data.Gender,
                DocumentNumber = data.DocumentNumber,
                BirthDate = data.BirthDate
            };

            var user = new User
            {
                PasswordHash = hashedPassword,
                FailedLoginAttempts = 0,
                IsLocked = false
            };
            if (user is null || passanger is null || data is null)
                return RegistrationResult.InvalidData;

            if (!InputValidator.IsValidEmail(data.Email))
                return RegistrationResult.InvalidEmail;

            if (userRepository.ExistsByEmail(passanger.Email))
                return RegistrationResult.UserAlreadyExists;

          
            userRepository.AddPassanger(passanger);
            user.PassangerId = passanger.Id;
            userRepository.AddUser(user);
            userRepository.AddRoleToUser(user.Id,2);
            return RegistrationResult.Success;
        }
        public RecoverResult RecoverPassword(string email,string password)
        {
            if (!InputValidator.IsValidEmail(email))
                return RecoverResult.InvalidEmail;

            if (!InputValidator.IsValidPassword(password))
                return RecoverResult.InvalidPassword;

            var user = userRepository.GetUserByEmail(email);
            if (user is null)
                return RecoverResult.InvalidUser;
            var passwordHash = CryptPassword.Sha256(password);
            bool isChanged = userRepository.ChangePasswordByEmail(email, passwordHash);
            return isChanged ? RecoverResult.Success : RecoverResult.ChangeFailed;

        }
        public LoginResult Login(string email, string password)
        {

            var user = userRepository.GetUserByEmail(email);
            if (!InputValidator.IsValidEmail(email))
                return LoginResult.UserNotFound;
           
            if (user is null) return LoginResult.UserNotFound;
            if (user.IsLocked) return LoginResult.UserLocked;

            if (!CryptPassword.HashPassword(user.PasswordHash, password) || !InputValidator.IsValidPassword(password))
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

       
    }
}
