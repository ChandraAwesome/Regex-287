using System;
using System.Text.RegularExpressions;

namespace Regex_287
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            aFollowedbyB regexmatch = new aFollowedbyB();
            Console.WriteLine(regexmatch.Regex1Match("abbb"));

            string Str = "abc_def_ghi_jkl mn_opq rstuvwxyz";
            aFollowedbyB.Regexunderscore(Str);

            Console.WriteLine(regexmatch.Regexwebsite("www.chandra.com") );
            Console.WriteLine(regexmatch.Regeximages("awesome45.png")  ); 
            /***************/
            string Str1 = "<p>The <code>Regex</code> is a compiled representation of a regular expression.</p>";
            aFollowedbyB.RegexHtml(Str1);
            /***************/
            string Str2 = "foxes are omnivorous mammals belonging to several general of the family Canidae fox.";
            aFollowedbyB.Occurances(Str2);
        }

        public static int Add(int num1, int num2)
        {
            var sum = num1 + num2;
            return sum;
        }

        
        
    }
}