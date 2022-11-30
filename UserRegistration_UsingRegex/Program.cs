
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
                Console.WriteLine(" 1.PinCodeValidation \n 2.CheckPinCodeWithSpecialChar \n 3. ChechAlphabateAtEnd \n 4.CheckWithSpace \n 5. CheckEmailCondition \n 6.CheckEmailSecondCondition \n 7. CheckEmailThirdCondition");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Pin_Code_Validation pinCode = new Pin_Code_Validation();
                        Console.WriteLine("Enter Pincode");
                        string option1 = Convert.ToString(Console.ReadLine());
                        pinCode.TestPinCode(option1);
                        break;
                    case 2:
                        Pin_Code_Validation pinCode2 = new Pin_Code_Validation();
                        Console.WriteLine("Enter Pincode");
                        string option2 = Convert.ToString(Console.ReadLine());
                        pinCode2.TestPinCode2(option2);
                        break;
                    case 3:
                        Pin_Code_Validation pinCode3 = new Pin_Code_Validation();
                        Console.WriteLine("Enter Pincode");
                        string option3 = Convert.ToString(Console.ReadLine());
                        pinCode3.TestPinCode2(option3);
                        break;
                    case 4:
                        Pin_Code_Validation code4 = new Pin_Code_Validation();
                        Console.WriteLine("Enter Pincode");
                        string opt4 = Convert.ToString(Console.ReadLine());
                        code4.TestPinCode4(opt4);
                        break;
                    case 5:
                        CheckEmail checkEmail = new CheckEmail();
                        checkEmail.ValidateEmailFirstCond("@xyz");
                        break;
                    case 6:
                        CheckEmail checkEmail1 = new CheckEmail();
                        checkEmail1.ValidateEmailSecondCond("xyz@bridgelabz");
                        break;
                    case 7:
                        CheckEmail checkEmail2 = new CheckEmail();
                        checkEmail2.ValidateEmailThirdCond("xyz@bridgelabz.com");
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