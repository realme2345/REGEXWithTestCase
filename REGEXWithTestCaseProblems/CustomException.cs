using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REGEXWithTestCaseProblems
{
    internal class CustomException:Exception
    {
        public ExceptionType type;
        public enum ExceptionType //declaring the Exception
        {
            INVALID_FIRST_NAME,
            INVALID_LaST_NAME,
            INVALID_EMAIL,
            INVALID_MOBILE,
            INVALID_PASSWORD

        }
        public CustomException(ExceptionType type, string message) : base(message) //this method using for catching the Exception
        {
            this.type = type;
        }
    }
}
