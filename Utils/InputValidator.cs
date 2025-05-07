using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Utils
{
    public static class InputValidator
    {
        public static bool IsValidEmail(string email)
        {
            return !string.IsNullOrWhiteSpace(email)
                && email.Contains("@")
                && email.Contains(".");
        }

        public static bool IsValidPassword(string password)
        {
            return !string.IsNullOrWhiteSpace(password)
                && password.Length >= 6;
        }
    }

}
