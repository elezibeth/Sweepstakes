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




        public Contestant(string firstName, string lastName, string eMailAddress, int registrationNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eMailAddress = eMailAddress;
            this.registrationNumber = registrationNumber;
        }

        //methods

       
    }
}
