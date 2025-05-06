using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Exam.DataAccess.Utils
{
    internal class EncryptPassword
    {
        public static string Sha256(string inputString)
        {
                SHA256 crypt = SHA256.Create();
                string hash = string.Empty;
                byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(inputString));
                foreach (byte theByte in crypto)
                {
                    hash += theByte.ToString("x2");
                }
                return hash;
            }

    }
}
