using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheney_CashFlowManager
{
    interface IPayable
    {
       public decimal GetPayableAmount()
        {
            return GetPayableAmount();
        }
       public LedgerType Type { get; }
        
    }
}
