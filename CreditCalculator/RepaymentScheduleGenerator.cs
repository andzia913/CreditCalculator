using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCalculator
{
    internal class RepaymentScheduleGenerator
    {

        public List<Repayment> LoanCalculator(Loan loan)
            {
            decimal monthlyPayment = CalculateMonthlyPayment(loan);

            List<Repayment> repaymentSchedule = new List<Repayment>();

            decimal monthlyInterestRate = loan.MonthlyInterestRate();
            int totalNumberOfPayments = loan.TotalNumberOfPayments();
            decimal remainingBalance = loan.LoanAmount;

            for (int paymentNumber = 1; paymentNumber <= totalNumberOfPayments; paymentNumber++)
            {
                decimal interestAmount = remainingBalance * monthlyInterestRate;
                decimal principalAmount = monthlyPayment - interestAmount;

                if (remainingBalance < principalAmount)
                {
                    principalAmount = remainingBalance;
                }

                repaymentSchedule.Add(new Repayment(paymentNumber, monthlyPayment, principalAmount, interestAmount, remainingBalance));

                remainingBalance -= principalAmount;
            }

            return repaymentSchedule;
        }
        private decimal CalculateMonthlyPayment(Loan loan)
        {
            // TODO: Fix the bug in the formula, there is no loan in this formula
            decimal monthlyInterestRate = loan.MonthlyInterestRate();
            int totalNumberOfPayments = loan.TotalNumberOfPayments();

            decimal monthlyPayment = loan.LoanAmount * (monthlyInterestRate * (decimal)Math.Pow((double)(1 + monthlyInterestRate), totalNumberOfPayments)) /
                                     ((decimal)Math.Pow((double)(1 + monthlyInterestRate), totalNumberOfPayments) - 1);

            return monthlyPayment;
        }

        public decimal CalculateTotalCost(Loan loan)
        {
            List<Repayment> repaymentSchedule = LoanCalculator(loan);
            return repaymentSchedule.Sum(x => x.PaymentAmount) - loan.LoanAmount;
        }

    }
}
