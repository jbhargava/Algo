using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.ChainR;

namespace ConsoleApp1
{
    public interface iStatus
    {
        string status { get; set; }
        string conditionMet { get; set; }
        iStatus NextStatus { get; set; }
        bool Verify(string stat);
    }

    public class ChainR    
    {
        private iStatus pending, processed, finish;
 
        public ChainR()
        {
            SetChain();
        }

        private void SetChain()
        {
            pending = new AssignStatus();
            processed = new AssignStatus();
            finish = new EndStatus();

            pending.conditionMet = "Pending";
            processed.conditionMet = "Processed";
            finish.conditionMet = "Finish";

            pending.NextStatus = processed;
            processed.NextStatus = finish;
        }

        public void AssignStatus(string stat)
        {
            bool success = pending.Verify(stat);    
        }

    }

    public class AssignStatus : iStatus
    {
        public string status { get; set; }
        public string conditionMet { get; set; } = "";
        public iStatus NextStatus { get; set; } = null;
        public bool Verify(string stat)
        {
            if (!stat.Equals(conditionMet, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Status not found, moved to next ==> " + stat);
                return NextStatus.Verify(stat);
            }
            else
            {
                Console.WriteLine("Status  found");
                return true;
            }
        }
    }

    public class EndStatus : iStatus
    {
        public string status { get; set; }
        public string conditionMet { get; set; } = "";
        public iStatus NextStatus { get; set; } = null;
        public bool Verify(string stat)
        {
            Console.WriteLine("End  reached");
            return false;
        }

    }
}
