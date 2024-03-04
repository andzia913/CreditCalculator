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

        Loan loan;

        private void button1_Click(object sender, EventArgs e)
        {
            loan = new Loan(Convert.ToDecimal(txt_loanAmount.Text), Convert.ToDecimal(txt_interestRate.Text), Convert.ToInt32(txt_loanPeriod.Text));

            decimal totalCost = new RepaymentSchedule().CalculateTotalCost(loan);
            lbl_totalCost.Text += (totalCost + loan.LoanAmount).ToString();
            lbl_loanAmount.Text += loan.LoanAmount.ToString();
            lbl_interestTotal.Text += totalCost.ToString();
            lbl_repaymentAmount.Text += loan.CalculateMonthlyPayment().ToString();

        }
    }
}
