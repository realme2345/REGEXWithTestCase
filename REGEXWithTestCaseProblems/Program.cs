using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REGEXWithTestCaseProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to REGEX with test case problems");
            UserRegestrationProblem userRegestrationProblem = new UserRegestrationProblem("+91 8919892334");
            //creating a object for a class
            userRegestrationProblem.ValidateMobileNum();

        }
    }
}
