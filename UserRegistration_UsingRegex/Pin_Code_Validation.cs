﻿using System;
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
        public void TestPinCode(string input)
        {
            if (Regex.IsMatch(input, PIN_CODE_PATTERN))
                Console.WriteLine("Pin Code Matches");
            else
                Console.WriteLine("Pin Code Regex Failed");
        }
    }
}
    