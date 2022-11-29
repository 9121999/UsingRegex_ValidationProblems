﻿
namespace UserRegistration_UsingRegex
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Select Options");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine(" 1.PinCodeValidation \n 2.CheckPinCodeWithSpecialChar");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Pin_Code_Validation pincode = new Pin_Code_Validation();
                        string option1 = Convert.ToString(Console.ReadLine());
                        pincode.TestPinCode(option1);
                        break;
                    case 2:
                        Pin_Code_Validation pinCode2 = new Pin_Code_Validation();
                        string option2 = Convert.ToString(Console.ReadLine());
                        pinCode2.TestPinCode2(option2);
                        break;
                    default:
                        flag = false;
                        Console.WriteLine("Try Again");
                        break;
                    
                }
            }
        }
    }
}