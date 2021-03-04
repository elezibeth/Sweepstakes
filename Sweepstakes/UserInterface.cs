using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class UserInterface
    {
        //members
        string[] array;
        List<MarketingFirm> marketingFirms;
        MarketingFirm mktfrm;
        List<Contestant> contestants;

        public UserInterface()
        {
            contestants = new List<Contestant>();
            marketingFirms = new List<MarketingFirm>();
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
                    Console.WriteLine("Create a marketing firm");
                    CreateMarketingFirm();
                    break;
                case "2":
                    Console.WriteLine("Create a sweepstakes");
                    CreateASweepstakes();
                    break;
                case "3":
                    Console.WriteLine("Create a contestant");
                    CreateAContestant();
                    break;
                case "4":
                    Console.WriteLine("manage a sweepstakes");
                    ManageSweepstakes();
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
            marketingFirms.Add(mktfrm);
            //save mktfrm;

        }
        public void AddOptionsToArray()
        {
            array[0] = "Create a marketing firm";
            array[1] = "Create a sweepstakes";
            array[2] = "Create a contestant";
            array[3] = "Manage a sweepstakes";
            array[4] = "";
            //array[1]

        }
        public void ChooseAWinner()
        {

            Contestant contestant = mktfrm.sweepstakes[0].PickWinner();

            Console.WriteLine($"The winner is {contestant.firstName} {contestant.lastName}." +
            $"The email of this contestant is {contestant.eMailAddress}." +
            $"The registration number of this contestant is {contestant.registrationNumber}.");


        }
        public void RegisterContestant()
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
        public void CreateASweepstakes()//-------------------------------------------------------------------------------------------------------------------------------
        {
            Console.WriteLine("Would you like to use the Sweepstakes stack manager or the queue manager? type '1' for stack and '2' for queue.");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":

            }
        }
        public void ManageSweepstakes()
        {
            Console.WriteLine("Choose your Marketing firm from the following list");
            foreach (MarketingFirm marketingFirm in marketingFirms)
            {
                Console.WriteLine($" {(marketingFirm[] + 1)} {marketingFirm.name}");
            }
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Please chose from the sweepstakes to manage");
            foreach (Sweepstakes sweepstakes in marketingFirms[number].sweepstakes)
            {
                Console.WriteLine($" {marketingFirms[number].sweepstakes[] + 1} {marketingFirms[number].sweepstakes[].nameOfContest} ");
            }
            int number1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("What would you like to do?");
            //Console.WriteLine($" 1.Create a Sweepstakes," +
            //    $"2. Register a Contestant," +
            //    $"3. Pick a winner?");
            marketingFirms[number].sweepstakes[number1].

        }
        public static OutPutText(string text)
        {
            Console.WriteLine(text);
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
            Console.WriteLine($"Your new contestant is {firstName}. Add contestant to your marketing firm? Type 'y' or 'n'. and press enter");
            string input = Console.ReadLine();
            switch (input)
            {
                case "y":
                    foreach (MarketingFirm item in marketingFirms)
                    {
                        Console.WriteLine($"{(marketingFirms[] + 1)} {item}");
                    }
                    string input2 = Console.ReadLine();
                    int input3 = Convert.ToInt32(input2) - 1;
                    marketingFirms[input3].AddContestant(contestant);
                    break;
                default:
                    contestants.Add(contestant);
                    Console.WriteLine("contestant saved temporarily.");
                    break;

            }


        }
       



    
    public void ChooseAWinner()
    {
            
        Console.WriteLine($"The winner is {contestant.firstName} {contestant.lastName}." +
        $"The email of this contestant is {contestant.eMailAddress}." +
        $"The registration number of this contestant is {contestant.registrationNumber}.);


        }


}
}
