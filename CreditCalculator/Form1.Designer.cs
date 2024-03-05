namespace CreditCalculator
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_loanAmount = new System.Windows.Forms.TextBox();
            this.txt_loanPeriod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_interestRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_totalCost = new System.Windows.Forms.Label();
            this.lbl_repaymentAmount = new System.Windows.Forms.Label();
            this.lbl_loanAmount = new System.Windows.Forms.Label();
            this.lbl_interestTotal = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Przelicz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.calculate_Click);
            // 
            // txt_loanAmount
            // 
            this.txt_loanAmount.Location = new System.Drawing.Point(296, 56);
            this.txt_loanAmount.Name = "txt_loanAmount";
            this.txt_loanAmount.Size = new System.Drawing.Size(100, 22);
            this.txt_loanAmount.TabIndex = 1;
            this.txt_loanAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_loanAmount_KeyPress);
            // 
            // txt_loanPeriod
            // 
            this.txt_loanPeriod.Location = new System.Drawing.Point(296, 93);
            this.txt_loanPeriod.Name = "txt_loanPeriod";
            this.txt_loanPeriod.Size = new System.Drawing.Size(100, 22);
            this.txt_loanPeriod.TabIndex = 2;
            this.txt_loanPeriod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_loanPeriod_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kwota kredytu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Okres kredytowania (w latach)";
            // 
            // txt_interestRate
            // 
            this.txt_interestRate.Location = new System.Drawing.Point(296, 131);
            this.txt_interestRate.Name = "txt_interestRate";
            this.txt_interestRate.Size = new System.Drawing.Size(100, 22);
            this.txt_interestRate.TabIndex = 5;
            this.txt_interestRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_interestRate_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Oprocentowanie";
            // 
            // lbl_totalCost
            // 
            this.lbl_totalCost.AutoSize = true;
            this.lbl_totalCost.Location = new System.Drawing.Point(41, 287);
            this.lbl_totalCost.Name = "lbl_totalCost";
            this.lbl_totalCost.Size = new System.Drawing.Size(149, 16);
            this.lbl_totalCost.TabIndex = 7;
            this.lbl_totalCost.Text = "Całkowity koszt kretytu: ";
            // 
            // lbl_repaymentAmount
            // 
            this.lbl_repaymentAmount.AutoSize = true;
            this.lbl_repaymentAmount.Location = new System.Drawing.Point(41, 389);
            this.lbl_repaymentAmount.Name = "lbl_repaymentAmount";
            this.lbl_repaymentAmount.Size = new System.Drawing.Size(102, 16);
            this.lbl_repaymentAmount.TabIndex = 8;
            this.lbl_repaymentAmount.Text = "Wysokość raty: ";
            // 
            // lbl_loanAmount
            // 
            this.lbl_loanAmount.AutoSize = true;
            this.lbl_loanAmount.Location = new System.Drawing.Point(41, 321);
            this.lbl_loanAmount.Name = "lbl_loanAmount";
            this.lbl_loanAmount.Size = new System.Drawing.Size(117, 16);
            this.lbl_loanAmount.TabIndex = 9;
            this.lbl_loanAmount.Text = "Pożyczona kwota: ";
            // 
            // lbl_interestTotal
            // 
            this.lbl_interestTotal.AutoSize = true;
            this.lbl_interestTotal.Location = new System.Drawing.Point(41, 355);
            this.lbl_interestTotal.Name = "lbl_interestTotal";
            this.lbl_interestTotal.Size = new System.Drawing.Size(115, 16);
            this.lbl_interestTotal.TabIndex = 10;
            this.lbl_interestTotal.Text = "Wartość odsetek: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(459, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(657, 426);
            this.dataGridView1.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_interestTotal);
            this.Controls.Add(this.lbl_loanAmount);
            this.Controls.Add(this.lbl_repaymentAmount);
            this.Controls.Add(this.lbl_totalCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_interestRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_loanPeriod);
            this.Controls.Add(this.txt_loanAmount);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "Kalkulator kredytu hipotecznego";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_loanAmount;
        private System.Windows.Forms.TextBox txt_loanPeriod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_interestRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_totalCost;
        private System.Windows.Forms.Label lbl_repaymentAmount;
        private System.Windows.Forms.Label lbl_loanAmount;
        private System.Windows.Forms.Label lbl_interestTotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

