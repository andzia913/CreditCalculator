using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace CreditCalculator
{
    internal class RepaymentSchedule
    {
        public int repaymentsCount;
        public Loan loan;
        public List<Repayment> repaymentsList;

        public List<Repayment> CalculateRepaymentSchedule(Loan loan)
        {
            this.loan = loan;
            decimal monthlyPayment = loan.CalculateMonthlyPayment();

            List<Repayment> repaymentSchedule = new List<Repayment>();

            decimal monthlyInterestRate = loan.MonthlyInterestRate();
            int totalNumberOfPayments = loan.TotalNumberOfPayments();
            decimal remainingBalance = loan.LoanAmount;
            decimal cyclicOverPayment = loan.CyclicOverPayment;
            decimal oneTimeOverPayment = loan.OneTimeOverPayment;
            List<OverPaymentChangedEventArgs> personalizedOverPayment = loan.PersonalizedOverPayment;

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
                
                 else if (personalizedOverPayment != null){
                    decimal interestAmount = remainingBalance * monthlyInterestRate;
                    decimal principalAmount = monthlyPayment - interestAmount;
                    if (remainingBalance < principalAmount) principalAmount = remainingBalance;
                    decimal currentPrincipalAmount = principalAmount;

                    decimal overPaymentToRow;
                    var personalizedPayment = personalizedOverPayment.FirstOrDefault(obj => obj.RowIndex+1 == paymentNumber);
                    if (personalizedPayment != null)
                    {
                        currentPrincipalAmount += personalizedPayment.OverPayment;
                        overPaymentToRow = personalizedPayment.OverPayment;
                    }
                    else
                    {
                        overPaymentToRow = cyclicOverPayment;
                    }
                    remainingBalance -= currentPrincipalAmount;
                    if (remainingBalance <= 0) remainingBalance = 0;
                    repaymentSchedule.Add(new Repayment(paymentNumber, monthlyPayment, principalAmount, interestAmount, remainingBalance, overPaymentToRow));
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
            }

            repaymentsCount = repaymentSchedule.Count;
            this.repaymentsList = repaymentSchedule;

            return repaymentSchedule;
        }


        public decimal CalculateTotalCost(Loan loan)
        {
            List<Repayment> repaymentSchedule = CalculateRepaymentSchedule(loan);
            return repaymentSchedule.Sum(x => x.InterestAmount);
        }
    }
}
