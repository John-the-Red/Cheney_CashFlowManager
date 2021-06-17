using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheney_CashFlowManager
{
    class Invoice : IPayable
    {
        private string _partnumber;
        private int _quantity;
        private string _partdescription;
        private decimal _price;
        private decimal _Total;
        public Invoice(string PartNumber, int Quantity, string PartDescription, decimal Price)
        {
            _partnumber = PartNumber;
            _quantity = Quantity;
            _partdescription = PartDescription;
            _price = Price;
            _Total = _quantity * _price;

        }
        public string PartNumber
        {
            get { return _partnumber; }
        }
        public int Quantity
        {
            get { return _quantity; }
        }
        public string PartDescription
        {
            get { return _partdescription; }
        }
        public decimal Price
        {
            get { return _price; }
        }
        public LedgerType Type
        {
            get { return LedgerType.Invoice; }
        }

        public decimal GetPayableAmount()
        {
            return _Total;
        }
        public override string ToString()
        {
            return string.Format("\n"
                                +"Invoice: " + PartNumber +"\n"
                                +"Quantity: " + _quantity + "\n"
                                +"Part Description: " + PartDescription + "\n"
                                + "Unit Price: {0:C}\n"
                                + "Extended Price: {1:C}"
                                +"\n", _price, _Total);
        }
    }
}
