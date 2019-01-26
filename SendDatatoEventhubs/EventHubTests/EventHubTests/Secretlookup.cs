using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EventHubTests
{
    class Secretlookup
    {
        public static string GetKey()
        {
            string key = null;
            string filePath = @"c:\temp\testeventhub.txt";
            if (File.Exists(filePath))
            {
                key = File.ReadAllText(filePath);
            }
            return key;
        }
    }
}
