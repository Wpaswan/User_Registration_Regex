using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationApp
{
    internal class Registration
    {
        public static string FirsName = "^[A-Z]{1}[a-zA-Z0-9]{2,29}$";
        public bool ValidateUserName(string uName)
        {
            return Regex.IsMatch(uName, FirsName);
        }
    }
}
