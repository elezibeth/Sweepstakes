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
        Contestant contestant;

        public Sweepstakes(string contestName)
        {
            nameOfContest = contestName;
            dictionary = new Dictionary<int, Contestant>();
            

        }

        //methods
        public Contestant PickWinner()
        {


            Random rand = new Random();
            
            int size = dictionary.Count;
            int index = rand.Next(0, size - 1);
            List<Contestant> arr = new List<string>();
            foreach(KeyValuePair<int, Contestant> in dictionary)
            {
                arr.Add(Contestant);
            }
            Contestant winner = arr[index];
            int registrationKey = winner.registrationNumber;
         
            foreach(KeyValuePair<int, Contestant> contestant in dictionary)
            {
                if(contestant.Key == registrationKey)
                {
                    return contestant.Value;
                }
            }

 
        }
       
        public void RegisterContestant(Contestant contestant)
        {
            dictionary.Add(contestant.registrationNumber, contestant.lastName);
        }
    }
}
//(15 points) As a developer, I want to create a Sweepstakes class that uses the Dictionary data structure
//as an underlying structure. The Sweepstakes class will have the following methods with full
//implementation (write the functionality) of each method:

//Sweepstakes(string name)
//- void RegisterContestant(Contestant contestant)
//- Contestant PickWinner()
//- void PrintContestantInfo(Contestant contestant)
