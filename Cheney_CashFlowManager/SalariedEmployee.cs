using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheney_CashFlowManager
{
    class SalariedEmployee : Employee
    {
        private decimal _weeklysalary;
        public SalariedEmployee(string First, string Last, string SSN, decimal WeeklySalary) : base(First, Last, SSN, LedgerType.Salaried)
        {
            _weeklysalary = WeeklySalary;
        }
        public override decimal Earnings()
        {
            return _weeklysalary;
        }    
        public override string ToString()
        {
            return string.Format("\n"
                                +"Salaried employee: " + FirstName + " " + LastName +"\n" 
                                +"SSN: " + SSN + "\n"
                                + "Weekly Salary: {0:C}\n"
                                + "Earned: {1:C}\n"
                                + "", _weeklysalary, _weeklysalary);
        }
    }
}
