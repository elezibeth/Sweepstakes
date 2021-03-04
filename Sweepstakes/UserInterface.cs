using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class UserInterface
    {
        //members
        string[] array;
        MarketingFirm mktfrm;

        public UserInterface()
        {
            array = new string[100];
            AddOptionsToArray();
            IntroScreen();

        }

        public void IntroScreen()
        {
            Console.WriteLine($"Hello!" +
                $"Welcome to Sweepstakes!" +
                $"What would you like to do?" +
                $"Please choose from the following options.");
            int number = 1;
            foreach (string item in array)
            {
                Console.WriteLine(number + " " + item);
                number++;
            }
            string useriNput = Console.ReadLine();
           switch (useriNput)
            {
                case "1":
                    CreateMarketingFirm();
                    break;
                case "2":
                    Console.WriteLine("Create a sweepstakes");
                    CreateASweepstakes();
                    break;
                case "3":
                    CreateAContestant();
                    break;
                default:
                    Console.WriteLine("Invalid selection");
                    IntroScreen();
                    break;

            }


            

        }
        public void CreateMarketingFirm()
        {
            Console.WriteLine("Please enter the name of the marketing firm");
            string marketingFirmName = Console.ReadLine();
            mktfrm = new MarketingFirm(marketingFirmName);
            //save mktfrm;
           
        }
        public void AddOptionsToArray()
        {
            array[0] = "Create a marketing firm";
            array[1] = "Create a sweepstakes";
            //array[1]

        }
        public void CreateASweepstakes()//-------------------------------------------------------------------------------------------------------------------------------
        {
            mktgfm.
        }
        public void CreateAContestant()
        {
            Console.WriteLine("Please enter your first name.");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name.");
            string lastName = Console.ReadLine();
            Console.WriteLine("Please enter your email address.");
            string eMailAddress = Console.ReadLine();
            int registrationNumber = eMailAddress.GetHashCode();
            Contestant contestant = new Contestant(firstName, lastName, eMailAddress, registrationNumber);
        }

    }
}
