
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
                Console.WriteLine(" 1.PinCodeValidation");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Pin_Code_Validation code = new Pin_Code_Validation();
                        string opt = Convert.ToString(Console.ReadLine());
                        code.TestPinCode(opt);
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