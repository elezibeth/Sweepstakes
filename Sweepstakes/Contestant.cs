using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        //member variables
        public string firstName;
        public string lastName;
        public string eMailAddress;
        public int registrationNumber;




        public Contestant()
        {
            GetUserFirstName();
            GetUserLastName();
            GetUserEmailAddress();
            GetRegistrationNumber();
        }

        //methods

        public void GetUserFirstName()
        {
            Console.WriteLine("Please enter your first name.");
            firstName = Console.ReadLine();
            

        }
        public void GetUserLastName()
        {
            Console.WriteLine("Please enter your last name.");
            lastName = Console.ReadLine();
            
        }
        public void GetUserEmailAddress()
        {
            Console.WriteLine("Please enter your email address.");
            eMailAddress = Console.ReadLine();
           
        }
        public void GetRegistrationNumber()
        {
            
            registrationNumber = eMailAddress.GetHashCode();
        }
    }
}
