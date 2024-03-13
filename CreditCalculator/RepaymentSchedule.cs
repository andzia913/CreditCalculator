using System;
using System.Collections.Generic;
using System.Linq;


namespace CreditCalculator
{
    internal class RepaymentSchedule
    {

        public List<Repayment> CalculateRepaymentSchedule(Loan loan)
        {
            decimal monthlyPayment = loan.CalculateMonthlyPayment();

            List<Repayment> repaymentSchedule = new List<Repayment>();

            decimal monthlyInterestRate = loan.MonthlyInterestRate();
            int totalNumberOfPayments = loan.TotalNumberOfPayments();
            decimal remainingBalance = loan.LoanAmount;
            decimal overPayment = loan.OverPayment;

            for (int paymentNumber = 1; paymentNumber <= totalNumberOfPayments; paymentNumber++)
            {
                decimal interestAmount = remainingBalance * monthlyInterestRate;
                decimal principalAmount = monthlyPayment - interestAmount;

                if (remainingBalance < principalAmount)
                {
                    principalAmount = remainingBalance;
                }

                repaymentSchedule.Add(new Repayment(paymentNumber, monthlyPayment, principalAmount, interestAmount, remainingBalance, overPayment));

                remainingBalance -= principalAmount + overPayment;
            }

            return repaymentSchedule;
        
    }
        public decimal CalculateTotalCost(Loan loan)
        {
            List<Repayment> repaymentSchedule = CalculateRepaymentSchedule(loan);
            return repaymentSchedule.Sum(x => x.InterestAmount);
        }
    }
}
