using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.DataAccess.Utils
{
    public class JsonsReader
    {
        public static string ReadJsonFile(string path)
        {
            var config = new ConfigurationBuilder()
       .SetBasePath(path)
       .AddJsonFile("appconfig.json")
       .Build();
            return config.GetConnectionString("DefaultConnection");
        }
    }
}
