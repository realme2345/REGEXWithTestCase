using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace REGEXWithTestCaseProblems
{/// <summary>
/// User Registretion
/// </summary>
    public class UserRegestrationProblem
    {
        public string Password;
        public static string Numeric= @"^(?=.*[0-9])[A-Za-z0-9]{8,}$";
        // this pattern used for validate the Password
        public UserRegestrationProblem(string password) // constructer
        {
            this.Password = password;
        }
        public string ValidatePassword() // this method used for the validating password with minimum eight characters
                                         // with atleast one numeric value
        {
            if (Regex.IsMatch(Password,Numeric))
            {
                return "Valid";
            }
            else
            {
                return "InValid";
            }
            //The End
        }
    }
}
