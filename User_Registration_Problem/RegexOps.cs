using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_Registration_Problem
{
    public class RegexOps
    {
        public static string RegexRule = "^[A-Z][A-Za-z]{3}";

        public bool ValidateUserName(string username)
        {
            {
                return Regex.IsMatch(username, RegexRule);

            }
        }
    }
}
