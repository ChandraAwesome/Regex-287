using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Regex_287
{
    internal class aFollowedbyB
    {
        public string pattern = "^[a-b]{4}$";

        public string website = @"^(www\.[a-z]+\.[a-z]+)$";

        public string images = "^([a-z0-9]+)(\\.png)";
        public bool Regex1Match(string Str)
        {
            return Regex.IsMatch(Str, pattern);
        }

        public static void Regexunderscore(string Str)
        {

            Str = "abc_def_ghi_jkl mn_opq rstuvwxyz";

            // Define the pattern for sequences of lowercase letters joined by an underscore
            string pattern = @"\b[a-z]+(_[a-z]+)*\b";

            // Find matches using regular expression
            MatchCollection matches = Regex.Matches(Str, pattern);

            // Print the matched sequences
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }

        }

        public bool Regexwebsite(string Str)
        {
            return Regex.IsMatch(Str, website);
        }

        public bool Regeximages(string Str)
        {
            return Regex.IsMatch(Str, images);
        }

        public static void RegexHtml(string Str1)
        {
            string htmlpattern = @"<[^>]+>";

            MatchCollection htmlmatch = Regex.Matches(Str1,htmlpattern);

            Console.WriteLine("HTML tags in the code are :");

            foreach(Match match in htmlmatch)
            {
                Console.WriteLine(match.Value);
            }
         } 

        public static void Occurances(string Str2) 
        {
            int counts = 0;

            string pattern = "fox(es)?";

            MatchCollection countmatch = Regex.Matches(Str2,pattern);

            Console.WriteLine("Occurances are : ");

            foreach(Match count in countmatch) 
            {
                Console.WriteLine(count.Value);
                counts++;
            }

            Console.WriteLine(counts);
        }
    
    }

}
