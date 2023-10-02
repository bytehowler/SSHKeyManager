using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SSHKeyManager
{
    internal class AlgorithmChecker
    {
        public static String getComment(String fileContent) 
        {
            Regex rx = new Regex(@"^(?:ssh-\w+\s+)(?:\S+\s+)([^\n]+)$");
            Match match = rx.Match(fileContent);

            return match.Groups[1].Value;
        }

    }
}
