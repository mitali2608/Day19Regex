using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day19Regex
{
    class UserRegDetails
    {
        //UC1- User first name

        public static string FirstName = "^[A-Z][a-z]{3,}$";

        public bool validateFirstName(string FN)
        {
            return Regex.IsMatch(FN, FirstName);
        }

        //UC2- User Last name

        public static string LastName = "^[A-Z][a-z]{3,}$";

        public bool validateLastName(string LN)
        {
            return Regex.IsMatch(LN, FirstName);
        }

        //UC3- User email address

        public static string Email = "^[a-zA-Z0-9]+([.#_$+-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$";

        public bool validateEmail(string mail)
        {
            return Regex.IsMatch(mail, Email);
        }

        //UC4- user mobile number

        public static string Number = "^[91][0-9]{10}";

        public bool validateNumber(string num)
        {
            return Regex.IsMatch(num, Number);
        }

        //UC5&UC6&UC7&UC8- User Password

        public static string Password = @"^((?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*`~_+]).{8,20})$";

        public bool validatePassword(string pas)
        {
            return Regex.IsMatch(pas, Password);
        }
    }
}
