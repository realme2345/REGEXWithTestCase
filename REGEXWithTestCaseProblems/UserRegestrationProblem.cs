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
        public string Mobile;
        public static string MobileNum = @"^([\+][0-9]{2}\s*[0-9]{10})$";
        // this pattern used for validate the Mobile Number
        public UserRegestrationProblem(string mobileNumber) // constructer
        {
            this.Mobile = mobileNumber;
        }
        public string ValidateMobileNum() // this method used for the validating mobile number
        {
            if (Regex.IsMatch(Mobile, MobileNum))
            {
                return "Valid";
            }
            else
            {
                return "NotValid";
            }
            //The End
        }
    }
}
