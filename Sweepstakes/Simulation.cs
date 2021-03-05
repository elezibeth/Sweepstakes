using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation
    {
        
        string[] array;
        List<MarketingFirm> marketingFirms;
        MarketingFirm mktfrm;
        List<Contestant> contestants;
        
        

        public Simulation()
        {
            mktfrm = CreateMarketingFirmWithManager();
          
        }

        public MarketingFirm CreateMarketingFirmWithManager()
        {
            string prompt = "Please enter the name of your management firm";
            string reply = UserInterface.GetUserInputForStringPrompt(prompt);
            MarketingFirm mktfrm1 = new MarketingFirm(reply);
            return mktfrm1;

        }
        public void Run()
        {
            mktfrm.CreateASweepstakes(mktfrm.manager);
            Contestant con1 = mktfrm.GetContestantInformation();
            Contestant con2 = mktfrm.GetContestantInformation();
            Contestant con3 = mktfrm.GetContestantInformation();
            Sweepstakes sweep = mktfrm.GetSweepstakes(mktfrm.manager);
            sweep.RegisterContestant(con1);
            sweep.RegisterContestant(con2);
            sweep.RegisterContestant(con3);
            Contestant winner = sweep.PickWinner();
            sweep.PrintContestantInfo(winner);

            
        }

       
    }
}
