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
            RepaymentScheduleGenerator generator = new RepaymentScheduleGenerator();

            decimal totalCost = generator.CalculateTotalCost(loan);

            lbl_totalCost.Text = "Całkowity koszt kredytu: " + totalCost.ToString();
        }
    }
}
