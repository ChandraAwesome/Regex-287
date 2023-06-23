namespace User_Registration_using_Regex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC1
            User_Registration Username = new User_Registration();
            Console.WriteLine(Username.Check("Aja"));
            //UC2
            User_Registration lastname= new User_Registration();
            Console.WriteLine(lastname.Checklast("Cha"));
            //UC3
            User_Registration mail= new User_Registration();
            Console.WriteLine(mail.Checkemail("abc.xyz@bl.co.in"));
            //UC4
            User_Registration number= new User_Registration();
            Console.WriteLine(number.Checkphone("91 9630261387"));
            //UC[5_8]
            User_Registration password= new User_Registration();
            Console.WriteLine(password.Checkpassword("Ajay124@"));
        }
    }
}