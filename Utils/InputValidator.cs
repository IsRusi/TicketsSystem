using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Exam.Utils
{
    public static class InputValidator
    {
        public static bool IsValidEmail(string email)=>!string.IsNullOrWhiteSpace(email) && Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        public static bool IsValidPassword(string password)=>!string.IsNullOrWhiteSpace(password) && password.Length >= 6;
        
    }

}
