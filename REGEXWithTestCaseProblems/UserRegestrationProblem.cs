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
        public UserRegestrationProblem(string lastName) // this method is used for validating first name
        {
            this.LastName = lastName;
        }
        public string ValidatingFirstName()
        { 
        
            if (Regex.IsMatch(LastName,Pattern))
            {
                //Console.WriteLine("{0} is valid", FirstName);
                return "Valid";
            }
            else
            {
               // Console.WriteLine("{0} is not valid", FirstName);
                return "NotValid";
            }
            //The End
        }
    }
}
