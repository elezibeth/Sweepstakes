using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        //members
        Dictionary<int, Contestant> dictionary;
        public string nameOfContest;

        public Sweepstakes(string contestName)
        {
            nameOfContest = contestName;
            dictionary = new Dictionary<int, Contestant>();
            

        }

        //methods
        public Contestant PickWinner()
        {


            Random rand = new Random();
            List<int> key1 = Enumerable.ToList(dictionary.Keys);
            int size = dictionary.Count;
            int index = rand.Next(0, size);
            int winnerKey = key1[index];

            Contestant winner = dictionary.//--------------------------------------------------------------------------------too long on this problem
                
        



           
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"The winner is {contestant.firstName} {contestant.lastName}." +
                $"The email of this contestant is {contestant.eMailAddress}." +
                $"The registration number of this contestant is {contestant.registrationNumber}.);
        }
        public void RegisterContestant(Contestant contestant)
        {
            dictionary.Add(contestant.registrationNumber, contestant.lastName);
        }
    }
}
