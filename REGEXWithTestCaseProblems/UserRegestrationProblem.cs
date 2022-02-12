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
        public static string FirstName { get; set; }
        public static string LastName { get; set;}
        public static string Email { get; set; } 
        public static  string Mobile { get; set; }
        public static string Password { get; set; }
        // Assigning the values
        public UserRegestrationProblem(string firstName,string lastName,string email,string mobile,string password) // constructer
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Mobile = mobile;
            Password = password;
        }
        //Declring the pattern
        public static string FirstNamePattern = "^[A-Z][A-Z a-z]{3,}$";
        public static string LastNamePattern = "^[A-Z][A-Z a-z]{3,}$";
        public static string EmailAddressPattern = @"^([A-Za-z0-9]*\.[A-Za-z0-9]*)@([A-Za-z0-9]*)((\.(\w){2,3}))$";
        public static string MobileNumPattern = @"^([\+][0-9]{2}\s*[0-9]{10})$";
        public static string PasswordPattern = @"^(?=.*[0-9])(?=.*[A-Z])(?=.*[@$!%*#?&])([A-Za-z0-9@$!%*#?&]){8,}$";
        public string ValidateNames()//this method is used for the validating the user names
        {
            if (Regex.IsMatch(FirstName, FirstNamePattern) && (Regex.IsMatch(LastName, LastNamePattern)) && (Regex.IsMatch(Email, EmailAddressPattern)) && (Regex.IsMatch(Mobile, MobileNumPattern)) && (Regex.IsMatch(Password, PasswordPattern)))
            {
                //Console.WriteLine("Happy");
                return "Happy";
            }
            else
            {
                //Console.WriteLine("Sad"); 
                return "Sad";
            }
        }
    }
}
