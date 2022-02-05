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
        public string LastName;
        public static string Pattern = "^[A-Z][A-Z a-z]{3,}$"; // this pattern used for validate the name
        public UserRegestrationProblem(string lastName) // this method is used for validating last name
        {
            this.LastName = lastName;
        }
        public string ValidatingLastName()
        { 
        
            if (Regex.IsMatch(LastName,Pattern))
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
