using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
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
          
            int size = dictionary.Count;
            int index = rand.Next(0, size - 1);

            List<Contestant> arr = new List<Contestant>();//int keys are hex. Very difficult to choose random item from a dictionary. Also, this logic of assigning numbers 0-x would return problems if multiple contestants were registered to multiple sweepstakes.
            foreach(KeyValuePair<int, Contestant> contestant in dictionary)
            {
                arr.Add(contestant.Value);//here we identify the contestant randomly by putting each on a list.
            }
            Contestant winner = arr[index];
            int registrationKey = winner.registrationNumber;// the registrationKey is a hex value
          
            foreach(KeyValuePair<int, Contestant> contestant1 in dictionary)
            { 
                if(contestant1.Key == registrationKey)
                {
                    winner =  contestant1.Value;
                    
                }
                
                
            }
            return winner;
  
        }
   
       
        public void RegisterContestant(Contestant contestant)
        {
            
            dictionary.Add(contestant.registrationNumber, contestant);
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            contestant.PrintInfo();
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
