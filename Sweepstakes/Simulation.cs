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
            
            
        }

       
    }
}
