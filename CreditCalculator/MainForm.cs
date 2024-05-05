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
        private RepaymentScheduleForm repaymentScheduleForm;
        private RepaymentScheduleForm repaymentScheduleFormWithOverpayment;

        private void calculate_Click(object sender, EventArgs e)
        {

            try 
            {
                loan = new Loan(Convert.ToDecimal(txt_loanAmount.Text), Convert.ToDecimal(txt_interestRate.Text), Convert.ToInt32(txt_loanPeriod.Text));
            }catch
            {
                MessageBox.Show("Wprowadzono niepoprawne dane");
                return;
            }
            displayLoanData(loan, repaymentSchedule, lbl_totalCost, lbl_loanAmount, lbl_interestTotal, lbl_repaymentAmount);
            if(loanWithOverPayment != null)
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

        private void btn_overPayment_Click(object sender, EventArgs e)
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

        private void OverPaymentChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void btn_OpenScheduleLoan_Click(object sender, EventArgs e)
        {
            if (repaymentScheduleForm == null && loan != null)
            {
                repaymentScheduleForm = new RepaymentScheduleForm(loan);
            }
            repaymentScheduleForm?.ShowDialog(); // Zmieniłem .Show() na .ShowDialog(), aby zablokować dostęp do głównego formularza podczas otwartego okna, można to zmienić w zależności od potrzeb.
        }
        private void RepaymentScheduleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            repaymentScheduleForm = null; // Ustawiamy pole repaymentScheduleForm na null po zamknięciu formularza
        }

        private void btn_openScheduleWithOverpayment_Click(object sender, EventArgs e)
        {
            if(repaymentScheduleFormWithOverpayment == null && loanWithOverPayment != null)
            {
                repaymentScheduleFormWithOverpayment = new RepaymentScheduleForm(loanWithOverPayment);
                repaymentScheduleFormWithOverpayment.OverPaymentChanged += repaymentScheduleFormWithOverpayment_OverPaymentChanged;
            }
            repaymentScheduleFormWithOverpayment?.ShowDialog();
        }
        public event EventHandler LoanChanged;

        private void repaymentScheduleFormWithOverpayment_OverPaymentChanged(object sender, OverPaymentChangedEventArgs e)
        {
            int rowIndex = e.RowIndex;
            decimal overPayment = e.OverPayment;
            loanWithOverPayment.PersonalizedOverPayment = new OverPaymentChangedEventArgs(rowIndex, overPayment);
            repaymentScheduleFormWithOverpayment.RepaymentScheduleForm_Load(sender, e);
        }
    }
}
