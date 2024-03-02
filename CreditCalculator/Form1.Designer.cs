namespace CreditCalculator
{
    partial class btn_calculate
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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_loanAmount = new System.Windows.Forms.TextBox();
            this.txt_loanPeriod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_interestRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Przelicz";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txt_loanAmount
            // 
            this.txt_loanAmount.Location = new System.Drawing.Point(235, 56);
            this.txt_loanAmount.Name = "txt_loanAmount";
            this.txt_loanAmount.Size = new System.Drawing.Size(100, 22);
            this.txt_loanAmount.TabIndex = 1;
            // 
            // txt_loanPeriod
            // 
            this.txt_loanPeriod.Location = new System.Drawing.Point(235, 93);
            this.txt_loanPeriod.Name = "txt_loanPeriod";
            this.txt_loanPeriod.Size = new System.Drawing.Size(100, 22);
            this.txt_loanPeriod.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 62);
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
            this.txt_interestRate.Location = new System.Drawing.Point(235, 131);
            this.txt_interestRate.Name = "txt_interestRate";
            this.txt_interestRate.Size = new System.Drawing.Size(100, 22);
            this.txt_interestRate.TabIndex = 5;
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
            // btn_calculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_interestRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_loanPeriod);
            this.Controls.Add(this.txt_loanAmount);
            this.Controls.Add(this.button1);
            this.Name = "btn_calculate";
            this.Text = "Kalkulator kredytu hipotecznego";
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
    }
}

