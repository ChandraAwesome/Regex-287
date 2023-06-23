using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace User_Registration_using_Regex
{
    public class User_Registration
    {
        //UC1
        public static string FirstName = "^[A-Z a-z]{3}$";
        //UC@
        public static string LastName = "^[A-Z a-z]{3}$";
        //UC3
        public static string Email = "^abc.[a-z]{3}@bl.co.in$";
        //UC4
        public static string PhoneNumber = "^91 9[0-9]{9}$";
        //UC[5-8]
        public static string PassWord = @"^(?=.*[!@#$%^&*()_+\-=\[\]{};':"",.<>\/?\\|`~]).{8,}$";                        //"^[A-Z a-z 0-9]\\{8}$";


        public bool Check(string username)
        {
            return Regex.IsMatch(username, FirstName);
        }
        public bool Checklast(string lastname)
        {
            return Regex.IsMatch(lastname,LastName);
        }
        public bool Checkemail(string email)    
        {
            return Regex.IsMatch(email, Email);
        }
        public bool Checkphone(string phone) 
        {
            return Regex.IsMatch(phone, PhoneNumber);
        }
        public bool Checkpassword(string password) 
        {
            return Regex.IsMatch(password, PassWord);
        }
    }
}
