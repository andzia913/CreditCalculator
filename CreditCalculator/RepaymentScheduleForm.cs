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
    public partial class RepaymentScheduleForm : Form
    {
        private Loan loan;


        // Publiczny konstruktor, który przyjmuje parametr loan
        public RepaymentScheduleForm(Loan loan)
        {
            InitializeComponent();
            this.loan = loan;
            RepaymentScheduleForm_Load(this, null);
        }

        public void RepaymentScheduleForm_Load(object sender, EventArgs e)
        {
            RepaymentSchedule repaymentSchedule = new RepaymentSchedule();
            dataGridView2.Columns.Clear();
            dataGridView2.ReadOnly = false;

            List<Repayment> schedule = repaymentSchedule.CalculateRepaymentSchedule(loan);

            dataGridView2.Columns.Add("indexColumn", "Lp.");
            dataGridView2.Columns["indexColumn"].ReadOnly = true;

            dataGridView2.Columns.Add("paymentAmountColumn", "Rata");
            dataGridView2.Columns["paymentAmountColumn"].ReadOnly = true;

            dataGridView2.Columns.Add("principalAmountColumn", "Kapitał");
            dataGridView2.Columns["principalAmountColumn"].ReadOnly = true;

            if (loan.CyclicOverPayment != 0)
            {
                dataGridView2.Columns.Add("overPaymentColumn", "Nadpłata");
                dataGridView2.Columns["overPaymentColumn"].ReadOnly = false;
            }
            dataGridView2.Columns.Add("interestAmountColumn", "Odsetki");
            dataGridView2.Columns["interestAmountColumn"].ReadOnly = true;

            dataGridView2.Columns.Add("remainingBalanceColumn", "Pozostały do spłaty kapitał");
            dataGridView2.Columns["remainingBalanceColumn"].ReadOnly = true;


            foreach (Repayment r in schedule)
            {
                int rowIndex = dataGridView2.Rows.Add();

                dataGridView2.Rows[rowIndex].Cells["indexColumn"].Value = r.PaymentNumber;
                dataGridView2.Rows[rowIndex].Cells["principalAmountColumn"].Value = Math.Round(r.PrincipalAmount, 2);
                dataGridView2.Rows[rowIndex].Cells["paymentAmountColumn"].Value = Math.Round(r.PaymentAmount, 2);
                dataGridView2.Rows[rowIndex].Cells["interestAmountColumn"].Value = Math.Round(r.InterestAmount, 2);
                dataGridView2.Rows[rowIndex].Cells["remainingBalanceColumn"].Value = Math.Round(r.RemainingBalance, 2);

                if (loan.CyclicOverPayment != 0)
                {
                    dataGridView2.Rows[rowIndex].Cells["overPaymentColumn"].Value = r.OverPayment.ToString("N2");
                }
            }
        }
        public event EventHandler<OverPaymentChangedEventArgs> OverPaymentChanged;

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView2.Columns["overPaymentColumn"].Index && e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                decimal overPayment = Convert.ToDecimal(dataGridView2.Rows[rowIndex].Cells["overPaymentColumn"].Value);

                // Wysyłamy informacje o zmianie nadpłaty poprzez wywołanie zdarzenia
                OverPaymentChanged?.Invoke(this, new OverPaymentChangedEventArgs(rowIndex, overPayment));
            }

        }


    }
}
