using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheney_CashFlowManager
{
    class HourlyEmployee : Employee
    {
        private decimal _weeklyWage;
        private int _hoursworked;
        private decimal _hourlywage;
        public HourlyEmployee(string First, string Last, string SSN, decimal HourlyWage, int HoursWorked) : base(First, Last, SSN, LedgerType.Hourly)
        {
            _hourlywage = HourlyWage;
            _hoursworked = HoursWorked;
            if (HoursWorked > 40)
            {
                _weeklyWage = (40 * _hourlywage) + ((_hoursworked - 40) * (_hourlywage * 1.5M));
                
            }
            else
            {
                _weeklyWage = HourlyWage * HoursWorked;
            }
        }
        public override decimal Earnings()
        {
            return _weeklyWage;
        }
        public override string ToString()
        {
            return string.Format("\n"
                                +"Hourly employee: " + FirstName + " " + LastName + "\n"
                                +"SSN: " + SSN +"\n"
                                +"Hourly wage Salary: {0:C}\n"
                                +"Hours Worked: {1:0.00}\n"
                                +"Earned: {2:C}"
                                +"\n",_hourlywage, _hoursworked,_weeklyWage);
        }
    }
}
