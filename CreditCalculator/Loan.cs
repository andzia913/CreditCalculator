using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCalculator
{
    internal class Loan
    {
        
        public decimal LoanAmount { get; set; } 
        public decimal InterestRate { get; set; } 
        public int LoanPeriod { get; set; } 

        public Loan(decimal loanAmount, decimal interestRate, int loanPeriod)
        {
            LoanAmount = loanAmount;
            InterestRate = interestRate;
            LoanPeriod = loanPeriod;
        }
        public decimal CalculateTotalCost(decimal monthlyPayment)
        {
            int totalNumberOfPayments = CalculateTotalNumberOfPayments();
            return monthlyPayment * totalNumberOfPayments - LoanAmount;
        }

        public decimal CalculateMonthlyInterestRate()
        {
            return InterestRate / 12 / 100; 
        }

        public int CalculateTotalNumberOfPayments()
        {
            return LoanPeriod * 12; 
        }
    }
}
