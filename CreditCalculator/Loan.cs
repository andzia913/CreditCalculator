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
       

        public decimal MonthlyInterestRate()
        {
            return InterestRate / 12 / 100; 
        }

        public int TotalNumberOfPayments()
        {
            return LoanPeriod * 12; 
        }
        public decimal CalculateMonthlyPayment()
        {

            decimal monthlyPayment = LoanAmount * (1 + (decimal)Math.Pow((double)MonthlyInterestRate(), TotalNumberOfPayments()) * (1 + MonthlyInterestRate() - 1) / ((decimal)Math.Pow((1 + (double)MonthlyInterestRate()), TotalNumberOfPayments())) - 1);
            return monthlyPayment;
        }
    }
}
