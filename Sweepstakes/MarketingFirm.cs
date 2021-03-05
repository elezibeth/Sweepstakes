using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class MarketingFirm
    {

        //members
        public string name;
        
        
        public SweepstakesStackManager stack;
        public SweepstakesQueueManager queue;
        public ISweepstakesManager manager;
        
       
       

        //ctr
        public MarketingFirm(string name)
        {
            
            
            this.name = name;
            
            manager = CreateSweepstakesManager();//factory design implementation - I do not have to choose the sweepstakes manager for the user.
           
            

            
            

        }


        //methods
        //add note here about dependency injection: by using dependency injection here, we can 
        //use the marketing firm's stack manager or the marketing firm's queue manager.
        //I do not have to identify or write the method by which I insert the sweepstakes into the manager.
        //This benefits potential users by increasing the flexibility of sweepstakes management.

        public Sweepstakes CreateASweepstakes(ISweepstakesManager manager)
        {
            string prompt = "please enter the name of your sweepstakes.";
            string nameOfSweepStakes = UserInterface.GetUserInputForStringPrompt(prompt);
            
            Sweepstakes sweepstakes1 = new Sweepstakes(nameOfSweepStakes);
            
            manager.InsertSweepstakes(sweepstakes1);// here, I can call the manager created in the constructor, whithout knowing what kind of manager was instantiated by the user.
            //the InsertSweepstakes() will call the appropriate method, determined by the choice made by the user.
            Sweepstakes sweep = manager.GetSweepstakes();
            return sweep;

        
        }
        public Contestant GetContestantInformation()
        {
            string prompt1 = "Please enter your first name.";
            string firstName = UserInterface.GetUserInputForStringPrompt(prompt1);
            string prompt2 = "Please enter your last name.";
            string lastName = UserInterface.GetUserInputForStringPrompt(prompt2);
            string prompt3 = "Please enter your email address.";
            string eMailAddress = UserInterface.GetUserInputForStringPrompt(prompt3);
            int registrationNumber = eMailAddress.GetHashCode();
            Contestant contestant = new Contestant(firstName, lastName, eMailAddress, registrationNumber);
            return contestant;

        }
    

         public void AddContestant(Sweepstakes sweepstakes, Contestant contestant)
        {
            sweepstakes.RegisterContestant(contestant);
        }
        public ISweepstakesManager CreateSweepstakesManager()
        {
            string prompt = "would you like a stack or queue manager? type 'stack' for stack, any other entry will return a queue.";
            string userInput = UserInterface.GetUserInputForStringPrompt(prompt);
            switch (userInput)
            {
                case "stack":
                    stack = new SweepstakesStackManager("stack");
                    return stack;
                    break;
                
                default:
                    queue = new SweepstakesQueueManager("queue");
                    return queue;
                    break;
                    
                    
            }
        }

        
    }
}
