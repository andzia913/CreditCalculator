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
            decimal cyclicOverPayment = loan.CyclicOverPayment;
            decimal oneTimeOverPayment = loan.OneTimeOverPayment;
            OverPaymentChangedEventArgs personalizedOverPayment = loan.PersonalizedOverPayment;

            for (int paymentNumber = 1; paymentNumber <= totalNumberOfPayments; paymentNumber++)
            {
                if (remainingBalance <= 0) break;
                if (cyclicOverPayment != 0)
                {
                    decimal interestAmount = remainingBalance * monthlyInterestRate;
                    decimal principalAmount = monthlyPayment - interestAmount;
                    if (remainingBalance < principalAmount) principalAmount = remainingBalance;
                    
                    decimal currentPrincipalAmount = principalAmount += cyclicOverPayment;
                    remainingBalance -= currentPrincipalAmount;
                    if (remainingBalance <= 0) remainingBalance = 0;
                    repaymentSchedule.Add(new Repayment(paymentNumber, monthlyPayment, principalAmount, interestAmount, remainingBalance, cyclicOverPayment));
                }
                else if (oneTimeOverPayment != 0)
                {
                    decimal interestAmount = remainingBalance * monthlyInterestRate;
                    decimal principalAmount = monthlyPayment - interestAmount;
                    if (remainingBalance < principalAmount) principalAmount = remainingBalance;
                    decimal currentPrincipalAmount = principalAmount;
                    if (paymentNumber == 1) {currentPrincipalAmount += oneTimeOverPayment;}
                    else oneTimeOverPayment = 0;
                    remainingBalance -= currentPrincipalAmount;
                    if (remainingBalance <= 0) remainingBalance = 0;
                    repaymentSchedule.Add(new Repayment(paymentNumber, monthlyPayment, principalAmount, interestAmount, remainingBalance, oneTimeOverPayment));
                }
                
                else
                {
                    decimal interestAmount = remainingBalance * monthlyInterestRate;
                    decimal principalAmount = monthlyPayment - interestAmount;
                    if (remainingBalance < principalAmount) principalAmount = remainingBalance;
                    remainingBalance -= principalAmount;
                    if (remainingBalance <= 0) remainingBalance = 0;
                    repaymentSchedule.Add(new Repayment(paymentNumber, monthlyPayment, principalAmount, interestAmount, remainingBalance, 0));
                };
                 if (personalizedOverPayment != null){
                    decimal interestAmount = remainingBalance * monthlyInterestRate;
                    decimal principalAmount = monthlyPayment - interestAmount;
                    if (remainingBalance < principalAmount) principalAmount = remainingBalance;
                    decimal currentPrincipalAmount = principalAmount;
                    if (paymentNumber == personalizedOverPayment.RowIndex)
                    {
                        currentPrincipalAmount += personalizedOverPayment.OverPayment;
                    }
                    remainingBalance -= currentPrincipalAmount;
                    if (remainingBalance <= 0) remainingBalance = 0;
                    decimal overPaymentToRow;
                    if (paymentNumber == personalizedOverPayment.RowIndex)
                    {
                        overPaymentToRow = personalizedOverPayment.OverPayment;
                    }
                    else overPaymentToRow = cyclicOverPayment;
                    repaymentSchedule.Add(new Repayment(paymentNumber, monthlyPayment, principalAmount, interestAmount, remainingBalance, overPaymentToRow));
                }
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
