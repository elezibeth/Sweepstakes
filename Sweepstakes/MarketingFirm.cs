﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {

        //members
        public string name;
        List<Contestant> contestants;
        public List<Sweepstakes> sweepstakes;
        SweepstakesStackManager stack;
        SweepstakesQueueManager queue;
        

        //ctr
        public MarketingFirm(string name)
        {
            sweepstakes = new List<Sweepstakes>();
            contestants = new List<Contestant>();
            this.name = name;
            stack = new SweepstakesStackManager("stack");
            queue = new SweepstakesQueueManager("queue");

            
            

        }


        //methods
        //add note here about dependency injection: by using dependency injection here, we can 
        //use the marketing firm's stack manager or the marketing firm's queue manager.
        //I do not have to identify the method by which I insert the sweepstakes into the manager.

        public Sweepstakes CreateASweepstakes(ISweepstakesManager manager, string nameOfSweepStakes, string nameofManager)
        {

            Sweepstakes sweepstakes = new Sweepstakes(nameOfSweepStakes);
            manager.InsertSweepstakes(sweepstakes);
        
        }
        public void AddContestant(Sweepstakes sweepstakes, Contestant contestant)
        {
            sweepstakes.RegisterContestant(contestant);
        }
        
    }
}
