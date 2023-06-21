using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexRegistration
{
    internal class Registration
    {
        private String pattern = @"^[A-Z][a-z]{2}$";
        public void FirstName()
        {

            Console.WriteLine("Enter First Name");
            String firstname = Console.ReadLine();
                
            Regex obj=new Regex(pattern);

            if (obj.IsMatch(firstname))
            {
                Console.WriteLine($"firstname : {firstname} is a valid Name");

            }
            else 
            {
                Console.WriteLine($"firstname : {firstname} is not a valid Name");

            }


        }
    }
}
