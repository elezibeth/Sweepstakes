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

        public UserInterface()
        {
            array = new string[100];
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
           switch (number)
            {
                case "1":
                    CreateMarketingFirm();

            }


            

        }
        public void CreateMarketingFirm()
        {
            Console.WriteLine("Please enter the name of the marketing firm");
            string marketingFirmName = Console.ReadLine();
            MarketingFirm mktfrm = new MarketingFirm(marketingFirmName);
            //save mktfrm;
        }

    }
}
