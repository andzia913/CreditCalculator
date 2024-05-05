using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCalculator
{
    public class Loan
    {
        
        public decimal LoanAmount { get; set; } 
        public decimal InterestRate { get; set; } 
        public int LoanPeriod { get; set; } 
        public decimal CyclicOverPayment { get; set; }
        public decimal OneTimeOverPayment { get; set; }
        public OverPaymentChangedEventArgs PersonalizedOverPayment { get; set; }


        public Loan(decimal loanAmount, decimal interestRate, int loanPeriod, decimal cyclicOverPayment = 0, decimal oneTimeOverPayment = 0, OverPaymentChangedEventArgs personalizedOverPayment = null)
        {
            LoanAmount = loanAmount;
            InterestRate = interestRate;
            LoanPeriod = loanPeriod;
            CyclicOverPayment = cyclicOverPayment;
            OneTimeOverPayment = oneTimeOverPayment;
            PersonalizedOverPayment = personalizedOverPayment;
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
            decimal monthlyPayment = LoanAmount * ((decimal)Math.Pow(1 + (double)MonthlyInterestRate(), TotalNumberOfPayments()) * MonthlyInterestRate()) / ((decimal)Math.Pow(1 + (double)MonthlyInterestRate(), TotalNumberOfPayments()) - 1);
            return monthlyPayment;
        }
    }
}
