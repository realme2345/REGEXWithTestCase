using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace REGEXWithTestCaseProblems
{
    public class UserRegestrationProblem
    {
        public string Email;
        public static string Pattern = @"^([A-Za-z0-9]*\.[A-Za-z0-9]*)@([A-Za-z0-9]*)((\.(\w){2,3})+)$"; // this pattern used for validate the Email
        public UserRegestrationProblem(string Email) // this method is used for validating Email
        {
            this.Email = Email;
        }
        public string ValidatingEmail()
        { 
        
            if (Regex.IsMatch(Email,Pattern))
            {
               // Console.WriteLine("{0} is valid", Email);
                return "Valid";
            }
            else
            {
               //Console.WriteLine("{0} is not valid", Email);
                return "NotValid";
            }
            //The End
        }
    }
}
