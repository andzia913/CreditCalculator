using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        Loan loan;
        Loan loanWithOverPayment;
        RepaymentSchedule repaymentSchedule = new RepaymentSchedule();
        RepaymentSchedule repaymentScheduleWithOverPayment = new RepaymentSchedule();
        public RepaymentScheduleForm repaymentScheduleForm;
        public RepaymentScheduleForm repaymentScheduleFormWithOverpayment;

        public void calculate_Click(object sender, EventArgs e)
        {

            try 
            {
                loan = new Loan(Convert.ToDecimal(txt_loanAmount.Text), Convert.ToDecimal(txt_interestRate.Text), Convert.ToInt32(txt_loanPeriod.Text));
            }catch
            {
                MessageBox.Show("Wprowadzono niepoprawne dane");
                return;
            }
            loanWithOverPayment = null;
            repaymentScheduleFormWithOverpayment = null;
            txt_cyclicOverPayment.Text = "";
            txt_oneOverPayment.Text = "";
            displayLoanData(loan, repaymentSchedule, lbl_totalCost, lbl_loanAmount, lbl_interestTotal, lbl_repaymentAmount);
            if(loanWithOverPayment == null)
            {
                lbl_loanAmountOverPayment.Text = "Wartość pożyczki: ";
                lbl_interestTotalOverPayment.Text = "Suma odsetek: ";
                lbl_totalCostOverPayment.Text = "Całkowity koszt kredytu: ";
                lbl_loanPeriod.Text = "Okres kredytowania: ";
                lbl_interestTotalChange.Text = "";
                lbl_loanPeriodChange.Text = "";
            }
        }
        private void displayLoanData(Loan loan, RepaymentSchedule repaymentSchedule, Label totalCost, Label loanAmount, Label interestTotal, Label repaymentAmount = null, Label loanPeriod = null)
        {
            decimal totalCostCalc = repaymentSchedule.CalculateTotalCost(loan);
            totalCost.Text = "Całkowity koszt kredytu: " + (totalCostCalc + loan.LoanAmount).ToString("N2") + " zł";
            loanAmount.Text = "Wartość pożyczki: " + loan.LoanAmount.ToString("N2") + " zł";
            interestTotal.Text = "Suma odsetek: " + totalCostCalc.ToString("N2") + " zł";
            if(repaymentAmount != null) repaymentAmount.Text = "Miesięczna rata: " + loan.CalculateMonthlyPayment().ToString("N2") + " zł";
            if(loanPeriod != null) loanPeriod.Text = "Okres kredytowania: " + repaymentSchedule.repaymentsCount / 12 +" lat";
        }
        private void displayOverPaymentChange()
        {
            lbl_interestTotalChange.Text = "mniej o: "+(repaymentSchedule.CalculateTotalCost(loan) - repaymentSchedule.CalculateTotalCost(loanWithOverPayment)).ToString("N2") + " zł";
            lbl_loanPeriodChange.Text = "skrócony o: " +(loan.LoanPeriod - repaymentScheduleWithOverPayment.repaymentsCount/12).ToString() +" lat";
        }
        private void txt_loanAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            allowOnlyDecimalNumbers(sender, e);

        }

        private void txt_interestRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            allowOnlyDecimalNumbers(sender, e);
        }

        private void txt_loanPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void allowOnlyDecimalNumbers(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back);
        }

        private void btn_cyclicOverPayment_Click(object sender, EventArgs e)
        {
            try
            {
                loanWithOverPayment = new Loan(Convert.ToDecimal(txt_loanAmount.Text), Convert.ToDecimal(txt_interestRate.Text), Convert.ToInt32(txt_loanPeriod.Text));
                loanWithOverPayment.CyclicOverPayment = Convert.ToDecimal(txt_cyclicOverPayment.Text);
            }
            catch
            {
                MessageBox.Show("Wprowadzono niepoprawne dane");
                return;
            }
            displayLoanData(loanWithOverPayment, repaymentScheduleWithOverPayment, lbl_totalCostOverPayment, lbl_loanAmountOverPayment, lbl_interestTotalOverPayment, null ,lbl_loanPeriod);
            displayOverPaymentChange();
        }
        private void btn_oneTimeOverPayment_Click(object sender, EventArgs e)
        {
            if(loanWithOverPayment == null && loan != null)
            {
                loanWithOverPayment = new Loan(Convert.ToDecimal(txt_loanAmount.Text), Convert.ToDecimal(txt_interestRate.Text), Convert.ToInt32(txt_loanPeriod.Text));
            }
            loanWithOverPayment.OneTimeOverPayment = Convert.ToDecimal(txt_oneOverPayment.Text);
            displayLoanData(loanWithOverPayment, repaymentScheduleWithOverPayment, lbl_totalCostOverPayment, lbl_loanAmountOverPayment, lbl_interestTotalOverPayment, null, lbl_loanPeriod);
            displayOverPaymentChange();

        }

        private void OverPaymentChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void btn_OpenScheduleLoan_Click(object sender, EventArgs e)
        {
            if (loan != null)
            {
                repaymentScheduleForm = new RepaymentScheduleForm(loan);
            }
            repaymentScheduleForm?.ShowDialog(); 
        }

        private void btn_openScheduleWithOverpayment_Click(object sender, EventArgs e)
        {
            if(loanWithOverPayment != null)
            {
                repaymentScheduleFormWithOverpayment = new RepaymentScheduleForm(loanWithOverPayment);
                repaymentScheduleFormWithOverpayment.OverPaymentChanged += repaymentScheduleFormWithOverpayment_OverPaymentChanged;
            }
            repaymentScheduleFormWithOverpayment?.ShowDialog();
        }
        public event EventHandler LoanChanged;

        private void repaymentScheduleFormWithOverpayment_OverPaymentChanged(object sender, OverPaymentChangedEventArgs e)
        {
            loanWithOverPayment.PersonalizedOverPayment = e;
            repaymentScheduleFormWithOverpayment.loan = loanWithOverPayment;
            displayOverPaymentChange();
            
        }

        private void btn_editSchedule_Click(object sender, EventArgs e)
        {
            if(loanWithOverPayment == null)
            {
                loanWithOverPayment = new Loan(Convert.ToDecimal(txt_loanAmount.Text), Convert.ToDecimal(txt_interestRate.Text), Convert.ToInt32(txt_loanPeriod.Text));

                repaymentScheduleFormWithOverpayment = new RepaymentScheduleForm(loanWithOverPayment, true);
                repaymentScheduleFormWithOverpayment.OverPaymentChanged += repaymentScheduleFormWithOverpayment_OverPaymentChanged;


            }
            if (loanWithOverPayment != null)
            {
                repaymentScheduleFormWithOverpayment = new RepaymentScheduleForm(loanWithOverPayment, true);
                repaymentScheduleFormWithOverpayment.OverPaymentChanged += repaymentScheduleFormWithOverpayment_OverPaymentChanged;
            }
            repaymentScheduleFormWithOverpayment?.ShowDialog();
        }
    }
}
