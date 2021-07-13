using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum AssignmentStatus
    {
        None,
        Approve,
        Denied,
    }
    public interface IPOStatus
    {
        string CurrentStatus { get; set; }
        string NewStatus { get; set; }
    }

    public interface IApprover
    {
        string CurrentStatus { get; set; }
        AssignmentStatus AssignStatus(IPOStatus postatus);
    }

    public interface IHandler
    {
        AssignmentStatus Assignment(IPOStatus poStatus);
        void RegisterNext(IHandler next);
    }

    public class POStatus : IPOStatus
    {
        public string CurrentStatus { get; set; }
        public string NewStatus { get; set; }
    }

    public class Approver : IApprover
    {
        public Approver(string currStat)
        {
            CurrentStatus = currStat;
        }
        public string CurrentStatus { get; set; }
        public AssignmentStatus AssignStatus(IPOStatus postatus)
        {
            if (postatus.CurrentStatus == "")
            {
                postatus.CurrentStatus = "Pending";
                return AssignmentStatus.Approve;
            }
            else if (postatus.CurrentStatus == "Pending")
            {
                postatus.NewStatus = "processes";
                return AssignmentStatus.Approve;
            }
            else if (postatus.CurrentStatus == "Processes")
            {
                postatus.NewStatus = "Processes";
                return AssignmentStatus.Approve;
            }
            else
                return AssignmentStatus.Denied;
        }
    }

    public class Handler : IHandler
    {
        private readonly IApprover _approver;
        private IHandler _next;

        public Handler(IApprover approver)
        {
            _approver = approver;
            _next = EndOfChainExpenseHandler.Instance;
        }


        public AssignmentStatus Assignment(IPOStatus poStatus)
        {
            AssignmentStatus response = _approver.AssignStatus(poStatus);

            if (response == AssignmentStatus.Denied)
            {
                return _next.Assignment(poStatus);
            }

            return response;
        }

        public void RegisterNext(IHandler next)
        {
            _next = next;
        }
    }

    public class EndOfChainExpenseHandler : IHandler
    {
        private EndOfChainExpenseHandler() { }

        public static EndOfChainExpenseHandler Instance
        {
            get { return _instance; }
        }

        public AssignmentStatus Assignment(IPOStatus expenseReport)
        {
            return AssignmentStatus.Denied;
        }

        public void RegisterNext(IHandler next)
        {
            throw new InvalidOperationException("End of chain handler must be the end of the chain!");
        }

        private static readonly EndOfChainExpenseHandler _instance = new EndOfChainExpenseHandler();
    }


    public class ChainOfResponsibility
    {
        Handler pending, pro;
        public ChainOfResponsibility()
        {
            pending = new Handler(new Approver("Pending"));

            pro = new Handler(new Approver("Processed"));
        } 

        public void run()
        {
            pending.RegisterNext(pro);
            IPOStatus stat = new POStatus();
            stat.CurrentStatus = "x";


            AssignmentStatus response = pending.Assignment(stat);

        }
    }
}
