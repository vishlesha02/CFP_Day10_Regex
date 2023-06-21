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


        private String pattern2 = @"^[A-Z][a-z]{2,}$";

        public void LastName() 
        {

            Console.WriteLine("Enter Last Name");
            String lastname = Console.ReadLine();

            Regex obj2=new Regex(pattern2);


            if (obj2.IsMatch(lastname))
            {
                Console.WriteLine($"Last Name : {lastname} is valid ");
            }
        
            else 
            {
                Console.WriteLine($"Last Name : {lastname} is not valid "); 
            }
        }


        private String pattern3 = @"^[a-z]{3}+[\.][a-z]{3}+[@][a-z]{2}+[\.][a-z]{2}+[\.][a-z]{2}$";

        public void Email()
        { 
            Console.WriteLine("Enter Your E-Mail-Id");
            String email = Console.ReadLine();

            Regex obj3=new Regex(pattern3);

            if (obj3.IsMatch(email)) 
            {
                Console.WriteLine($"Email-Id : {email} is valid");
            }
        
            else
            {
                Console.WriteLine($"Email-Id : {email} is not valid");
            }
        }

        private String pattern4 = @"^\+?\d{2}\s\d{10}$";

        public void Number()
        { 
            Console.WriteLine("Enter Phone Number");
            String no = Console.ReadLine();

            Regex obj4=new Regex(pattern4);
            if (obj4.IsMatch(no)) 
            {
                Console.WriteLine($"Mobile Number : {no} is valid");
            
            }
            else
            {

                Console.WriteLine($"Mobile Number : {no} is not valid");
            }
        }

        private String pattern5 = @"^[A-Za-z]{8,}$";
        public void Password()
        { 
            Console.WriteLine("Enter the Password");
            String pass = Console.ReadLine();

            Regex obj5=new Regex(pattern5);

            if (obj5.IsMatch(pass)) 
            {
                Console.WriteLine($"Password : {pass} is valid");
            }
            else
            {
                Console.WriteLine($"Password : {pass} is not valid");

            }
        }

        private String pattern6 = @"^(?=.*[A-Z])[A-Za-z]{8,}$";
        public void Password2()
        {
            Console.WriteLine("Enter the Password");
            String pass2 = Console.ReadLine();

            Regex obj5 = new Regex(pattern6);

            if (obj5.IsMatch(pass2))
            {
                Console.WriteLine($"Password : {pass2} is valid");
            }
            else
            {
                Console.WriteLine($"Password : {pass2} is not valid");

            }
        }

    }
}
