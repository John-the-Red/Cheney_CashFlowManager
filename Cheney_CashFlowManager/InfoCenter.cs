using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheney_CashFlowManager
{
    class InfoCenter
    {
        IPayable[] Payables = new IPayable[50];
        private int i = 0;
        public void Add(IPayable _payable)
        {
            Payables[i] = _payable;
            i++;
        }
        public string TotalWeeklyPayout()
        {
            decimal TotalCharges = 0M;
            for (int i = 0; i < Payables.Length; i++)
            {
                if (Payables[i] != null)
                {
                    TotalCharges += Payables[i].GetPayableAmount();
                }
            }
            return string.Format("{0:C}", TotalCharges);
        }
        public string SalaryPayout()
        {
            decimal SalaryCharges = 0M;
            for (int i = 0; i < Payables.Length; i++)
            {
                if (Payables[i] != null)
                {
                    if (Payables[i].Type == LedgerType.Salaried)
                    {
                        SalaryCharges += Payables[i].GetPayableAmount();
                    }
                }
            }
            return string.Format("{0:C}", SalaryCharges);
        }
        public string HourlyPayout()
        {
            decimal HourlyCharges = 0M;
            for (int i = 0; i < Payables.Length; i++)
            {
                if (Payables[i] != null)
                {
                    if (Payables[i].Type == LedgerType.Hourly)
                    {
                        HourlyCharges += Payables[i].GetPayableAmount();
                    }
                }
            }
            return string.Format("{0:C}", HourlyCharges);
        }
        public string InvoicePayout()
        {
            decimal Invoice = 0M;
            for (int i = 0; i < Payables.Length; i++)
            {
                if (Payables[i] != null)
                {
                    if (Payables[i].Type == LedgerType.Invoice)
                    {
                        Invoice += Payables[i].GetPayableAmount();
                    }
                }
            }
            return string.Format("{0:C}", Invoice);
        }
        public string Salary()
        {
            string AllSalaries = null;
           for(int i = 0; i < Payables.Length; i++)
            {
                if (Payables[i] != null)
                {
                    if (Payables[i].Type == LedgerType.Salaried)
                    {
                        AllSalaries += Payables[i].ToString();
                    }
                } 
            }
            return AllSalaries;
        }
        public string Hourly()
        {
            string AllHourly = null;
            for (int i = 0; i < Payables.Length; i++)
            {
                if (Payables[i] != null)
                {
                    if (Payables[i].Type == LedgerType.Hourly)
                    {
                        AllHourly += Payables[i].ToString();
                    }
                }
            }
            return AllHourly;
        }
        public string Invoice()
        {
            string AllInvoice = null;
            for (int i = 0; i < Payables.Length; i++)
            {
                if (Payables[i] != null)
                {
                    if (Payables[i].Type == LedgerType.Invoice)
                    {
                        AllInvoice += Payables[i].ToString();
                    }
                }
            }
            return AllInvoice;
        }

    }
}
