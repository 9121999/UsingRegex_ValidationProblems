using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration_UsingRegex
{
    public  class CheckEmail
    {
        const string EmailFirstCond = "^[a-z]";
        const string EmailSecondCond = "^[a-zA-Z]+[@][a-zA-Z]{2,}$";

        public void ValidateEmailFirstCond(string input)
        {
            if (Regex.IsMatch(input, EmailFirstCond))
                Console.WriteLine("{0} Email Id is Match", input);
            else
                Console.WriteLine("{0}  Email Id is not Match ", input);

        }
        public void ValidateEmailSecondPart(string input)
        {
            if (Regex.IsMatch(input, EmailSecondCond))
                Console.WriteLine("{0} Email Id is Match", input);
            else
                Console.WriteLine("{0} Email Id is not Match", input);

        }
    }
}
