using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration_UsingRegex
{
    internal class Pin_Code_Validation
    {
        const string PIN_CODE_PATTERN = "^[0-9]{6}$";
        string PIN_CODE_PATTERN2 = "^[0-9]{3}[ ]{0,1}[0-9]{3}$";

        public void TestPinCode(string input)
        {
            if (Regex.IsMatch(input, PIN_CODE_PATTERN))
                Console.WriteLine("Pin Code Matches");
            else
                Console.WriteLine("Pin Code Regex Failed");
        }
        public void TestPinCode2(string input)
        {
            if (Regex.IsMatch(input, PIN_CODE_PATTERN2))
                Console.WriteLine("Pin Code Matches");
            else
                Console.WriteLine("Pin Code Regex Failed");
        }
        public void TestPinCode3(string input)
        {
            if (Regex.IsMatch(input, PIN_CODE_PATTERN))
                Console.WriteLine("Pin Code Matches");
            else
                Console.WriteLine("Pin Code Regex Failed");
        }
        public void TestPinCode4(string input)
        {
            if (Regex.IsMatch(input, PIN_CODE_PATTERN2))
                Console.WriteLine("Pin Code Matches");
            else
                Console.WriteLine("Pin Code Regex Failed");
        }
    }
}
