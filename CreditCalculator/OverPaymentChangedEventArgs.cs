using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCalculator
{

    public class OverPaymentChangedEventArgs : EventArgs
    {
        public int RowIndex { get; }
        public decimal OverPayment { get; }

        public OverPaymentChangedEventArgs(int rowIndex, decimal overPayment)
        {
            RowIndex = rowIndex;
            OverPayment = overPayment;
        }
    }

}
