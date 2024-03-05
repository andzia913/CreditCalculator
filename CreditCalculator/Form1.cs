using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void calculate_Click(object sender, EventArgs e)
        {

            dataGridView1.Columns.Clear();
            Loan loan;
            try 
            {
                loan = new Loan(Convert.ToDecimal(txt_loanAmount.Text), Convert.ToDecimal(txt_interestRate.Text), Convert.ToInt32(txt_loanPeriod.Text));
            }catch
            {
                MessageBox.Show("Wprowadzono niepoprawne dane");
                return;
            }
            RepaymentSchedule repaymentSchedule = new RepaymentSchedule();

            decimal totalCost = repaymentSchedule.CalculateTotalCost(loan);
            lbl_totalCost.Text = "Całkowity koszt kredytu: " + (totalCost + loan.LoanAmount).ToString("N2") + " zł";
            lbl_loanAmount.Text = "Wartość pożyczki: " + loan.LoanAmount.ToString("N2") + " zł";
            lbl_interestTotal.Text = "Suma odsetek: " +  totalCost.ToString("N2") + " zł";
            lbl_repaymentAmount.Text = "Miesięczna rata: " + loan.CalculateMonthlyPayment().ToString("N2") + " zł";

   
            List<Repayment> schedule = repaymentSchedule.CalculateRepaymentSchedule(loan);

            dataGridView1.Columns.Add("indexColumn", "Lp.");
            dataGridView1.Columns.Add("paymentAmountColumn", "Rata");
            dataGridView1.Columns.Add("principalAmountColumn", "Kapitał");
            dataGridView1.Columns.Add("interestAmountColumn", "Odsetki");
            dataGridView1.Columns.Add("remainingBalanceColumn", "Pozostały do spłaty kapitał");


            foreach (Repayment r in schedule)
            {
                dataGridView1.Rows.Add(r.PaymentNumber, r.PaymentAmount.ToString("N2"), r.PrincipalAmount.ToString("N2"), r.InterestAmount.ToString("N2"), r.RemainingBalance.ToString("N2"));
            }
            
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
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void allowOnlyDecimalNumbers(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back);
        }

    }
}
