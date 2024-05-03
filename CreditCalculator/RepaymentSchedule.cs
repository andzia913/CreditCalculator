using System;
using System.Collections.Generic;
using System.Linq;


namespace CreditCalculator
{
    internal class RepaymentSchedule
    {
        public int repaymentsCount;

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
                if (remainingBalance <= 0)
                {
                    break; // Przerywamy pętlę, jeśli pozostała kwota do spłaty wynosi zero lub mniej
                }

                decimal interestAmount = remainingBalance * monthlyInterestRate;
                decimal principalAmount = monthlyPayment - interestAmount;

                // Sprawdzamy, czy pozostała kwota do spłaty jest mniejsza niż główna część spłaty
                if (remainingBalance < principalAmount)
                {
                    // Jeśli tak, ustalamy główną część spłaty jako pozostałą kwotę do spłaty
                    principalAmount = remainingBalance;
                }

                // Dodajemy nadpłatę do głównej części spłaty, jeśli istnieje
                principalAmount += overPayment;

                // Sprawdzamy, czy nadpłata nie spowoduje ujemnej pozostałej kwoty do spłaty
                remainingBalance -= principalAmount;
                if (remainingBalance < 0)
                {
                    remainingBalance = 0;
                }

                repaymentSchedule.Add(new Repayment(paymentNumber, monthlyPayment, principalAmount, interestAmount, remainingBalance, overPayment));
            }

            repaymentsCount = repaymentSchedule.Count;

            return repaymentSchedule;
        }

        public decimal CalculateTotalCost(Loan loan)
        {
            List<Repayment> repaymentSchedule = CalculateRepaymentSchedule(loan);
            return repaymentSchedule.Sum(x => x.InterestAmount);
        }
    }
}
