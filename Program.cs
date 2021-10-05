using System;

namespace Day19Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            #region UC1
            UserRegDetails uc1 = new UserRegDetails();
            Console.WriteLine("First Name - ");
            string input = Console.ReadLine();
            Console.WriteLine(uc1.validateFirstName(input));
            #endregion

            #region UC2
            UserRegDetails uc2 = new UserRegDetails();
            Console.WriteLine("Last Name - ");
            string input2 = Console.ReadLine();
            Console.WriteLine(uc2.validateFirstName(input2));
            #endregion

            #region UC3
            UserRegDetails uc3 = new UserRegDetails();
            Console.WriteLine("Email - ");
            string input3 = Console.ReadLine();
            Console.WriteLine(uc3.validateEmail(input3));
            #endregion

            #region UC4
            UserRegDetails uc4 = new UserRegDetails();
            Console.WriteLine("Phone Number - ");
            string input4 = Console.ReadLine();
            Console.WriteLine(uc4.validateNumber(input4));
            #endregion

            #region UC5 - UC8
            UserRegDetails uc5_8 = new UserRegDetails();
            Console.WriteLine("Enter Password - ");
            string input5 = Console.ReadLine();
            Console.WriteLine(uc5_8.validatePassword(input5));
            #endregion

            #region UC9 - Valid Emails
            Console.WriteLine("   Valid Emails   ");

            string VM1 = "abc@yahoo.com";
            Console.WriteLine(uc3.validateEmail(VM1));

            string VM2 = "abc-100@yahoo.com";
            Console.WriteLine(uc3.validateEmail(VM2));

            string VM3 = "abc.100@yahoo.com";
            Console.WriteLine(uc3.validateEmail(VM3));

            string VM4 = "abc111@abc.com";
            Console.WriteLine(uc3.validateEmail(VM4));

            string VM5 = "abc.100@abc.com.au";
            Console.WriteLine(uc3.validateEmail(VM5));

            string VM6 = "abc@1.com";
            Console.WriteLine(uc3.validateEmail(VM6));

            string VM7 = "abc@gmail.com.com";
            Console.WriteLine(uc3.validateEmail(VM7));

            string VM8 = "abc+100@gmail.com";
            Console.WriteLine(uc3.validateEmail(VM8));
            #endregion


            #region UC9 - Invalid Emails
            Console.WriteLine("  Invalid Emails   ");

            string IM1 = "abc";
            Console.WriteLine(uc3.validateEmail(IM1));

            string IM2 = "abc@.com.my";
            Console.WriteLine(uc3.validateEmail(IM2));

            string IM3 = "abc123@gmail.a";
            Console.WriteLine(uc3.validateEmail(IM3));

            string IM4 = "abc123@.com";
            Console.WriteLine(uc3.validateEmail(IM4));

            string IM5 = "abc123@.com.com";
            Console.WriteLine(uc3.validateEmail(IM5));

            string IM6 = ".abc@abc.com";
            Console.WriteLine(uc3.validateEmail(IM6));

            string IM7 = "abc()*@gmail.com";
            Console.WriteLine(uc3.validateEmail(IM7));

            string IM8 = "abc@%*.com";
            Console.WriteLine(uc3.validateEmail(IM8));

            string IM9 = "abc..2002@gmail.com";
            Console.WriteLine(uc3.validateEmail(IM9));

            string IM10 = "abc.@gmail.com";
            Console.WriteLine(uc3.validateEmail(IM10));

            string IM11 = "abc@abc@gmail.com";
            Console.WriteLine(uc3.validateEmail(IM11));

            string IM12 = "abc@gmail.com.1a";
            Console.WriteLine(uc3.validateEmail(IM12));

            string IM13 = "abc@gmail.com.aa.au";
            Console.WriteLine(uc3.validateEmail(IM13));
            #endregion

            Console.ReadKey();
        }
    }
}
