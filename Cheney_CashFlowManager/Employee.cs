using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheney_CashFlowManager
{
    public abstract class Employee : IPayable
    {
        private string _first;
        private string _last;
        private string _ssn;
        private LedgerType _type;
        public Employee(string First, string Last, string SSN, LedgerType Type)
        {
            
            _first = First;
            _last = Last;
            _ssn = SSN;
            _type = Type;
        }
        
        public string FirstName
        {
            get { return _first; }
        }
        public string LastName
        {
            get { return _last; }
        }
        public string SSN
        {
            get { return _ssn; }
        }
        
        public abstract decimal Earnings();
        
        public decimal GetPayableAmount()
        {
            return Earnings();
        }
        public LedgerType Type
        {
            get { return _type; }
        }
    }
}

