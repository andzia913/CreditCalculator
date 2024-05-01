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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_calculate = new System.Windows.Forms.Button();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_overPayment = new System.Windows.Forms.TextBox();
            this.btn_overPayment = new System.Windows.Forms.Button();
            this.btn_OpenScheduleLoan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_calculate
            // 
            this.btn_calculate.BackColor = System.Drawing.Color.White;
            this.btn_calculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_calculate.Font = new System.Drawing.Font("Rubik", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calculate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_calculate.Location = new System.Drawing.Point(178, 170);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(132, 33);
            this.btn_calculate.TabIndex = 0;
            this.btn_calculate.Text = "Przelicz";
            this.btn_calculate.UseVisualStyleBackColor = false;
            this.btn_calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // txt_loanAmount
            // 
            this.txt_loanAmount.Font = new System.Drawing.Font("Rubik", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_loanAmount.Location = new System.Drawing.Point(303, 25);
            this.txt_loanAmount.Name = "txt_loanAmount";
            this.txt_loanAmount.Size = new System.Drawing.Size(100, 27);
            this.txt_loanAmount.TabIndex = 1;
            this.txt_loanAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_loanAmount_KeyPress);
            // 
            // txt_loanPeriod
            // 
            this.txt_loanPeriod.Font = new System.Drawing.Font("Rubik", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_loanPeriod.Location = new System.Drawing.Point(303, 69);
            this.txt_loanPeriod.Name = "txt_loanPeriod";
            this.txt_loanPeriod.Size = new System.Drawing.Size(100, 27);
            this.txt_loanPeriod.TabIndex = 2;
            this.txt_loanPeriod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_loanPeriod_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(129, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kwota kredytu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rubik", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Okres kredytowania (w latach)";
            // 
            // txt_interestRate
            // 
            this.txt_interestRate.Font = new System.Drawing.Font("Rubik", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_interestRate.Location = new System.Drawing.Point(303, 120);
            this.txt_interestRate.Name = "txt_interestRate";
            this.txt_interestRate.Size = new System.Drawing.Size(100, 27);
            this.txt_interestRate.TabIndex = 5;
            this.txt_interestRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_interestRate_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rubik", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(114, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Oprocentowanie";
            // 
            // lbl_totalCost
            // 
            this.lbl_totalCost.AutoSize = true;
            this.lbl_totalCost.BackColor = System.Drawing.Color.Transparent;
            this.lbl_totalCost.Font = new System.Drawing.Font("Rubik", 10F);
            this.lbl_totalCost.ForeColor = System.Drawing.Color.Snow;
            this.lbl_totalCost.Location = new System.Drawing.Point(15, 25);
            this.lbl_totalCost.Name = "lbl_totalCost";
            this.lbl_totalCost.Size = new System.Drawing.Size(206, 20);
            this.lbl_totalCost.TabIndex = 7;
            this.lbl_totalCost.Text = "Całkowity koszt kredytu: ";
            // 
            // lbl_repaymentAmount
            // 
            this.lbl_repaymentAmount.AutoSize = true;
            this.lbl_repaymentAmount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_repaymentAmount.Font = new System.Drawing.Font("Rubik", 10F);
            this.lbl_repaymentAmount.ForeColor = System.Drawing.Color.Snow;
            this.lbl_repaymentAmount.Location = new System.Drawing.Point(15, 136);
            this.lbl_repaymentAmount.Name = "lbl_repaymentAmount";
            this.lbl_repaymentAmount.Size = new System.Drawing.Size(130, 20);
            this.lbl_repaymentAmount.TabIndex = 8;
            this.lbl_repaymentAmount.Text = "Wysokość raty: ";
            // 
            // lbl_loanAmount
            // 
            this.lbl_loanAmount.AutoSize = true;
            this.lbl_loanAmount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_loanAmount.Font = new System.Drawing.Font("Rubik", 10F);
            this.lbl_loanAmount.ForeColor = System.Drawing.Color.Snow;
            this.lbl_loanAmount.Location = new System.Drawing.Point(15, 62);
            this.lbl_loanAmount.Name = "lbl_loanAmount";
            this.lbl_loanAmount.Size = new System.Drawing.Size(156, 20);
            this.lbl_loanAmount.TabIndex = 9;
            this.lbl_loanAmount.Text = "Pożyczona kwota: ";
            // 
            // lbl_interestTotal
            // 
            this.lbl_interestTotal.AutoSize = true;
            this.lbl_interestTotal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_interestTotal.Font = new System.Drawing.Font("Rubik", 10F);
            this.lbl_interestTotal.ForeColor = System.Drawing.Color.Snow;
            this.lbl_interestTotal.Location = new System.Drawing.Point(15, 99);
            this.lbl_interestTotal.Name = "lbl_interestTotal";
            this.lbl_interestTotal.Size = new System.Drawing.Size(147, 20);
            this.lbl_interestTotal.TabIndex = 10;
            this.lbl_interestTotal.Text = "Wartość odsetek: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rubik", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(595, 49);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(657, 560);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.OverPaymentChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_loanAmount);
            this.panel1.Controls.Add(this.txt_loanPeriod);
            this.panel1.Controls.Add(this.txt_interestRate);
            this.panel1.Controls.Add(this.btn_calculate);
            this.panel1.Location = new System.Drawing.Point(57, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 218);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lbl_totalCost);
            this.panel2.Controls.Add(this.lbl_loanAmount);
            this.panel2.Controls.Add(this.lbl_interestTotal);
            this.panel2.Controls.Add(this.lbl_repaymentAmount);
            this.panel2.Location = new System.Drawing.Point(57, 284);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 183);
            this.panel2.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rubik", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(29, 507);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(316, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Dodaj cykliczną co miesięczną nadpłate";
            // 
            // txt_overPayment
            // 
            this.txt_overPayment.Font = new System.Drawing.Font("Rubik", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_overPayment.Location = new System.Drawing.Point(102, 530);
            this.txt_overPayment.Name = "txt_overPayment";
            this.txt_overPayment.Size = new System.Drawing.Size(100, 27);
            this.txt_overPayment.TabIndex = 16;
            // 
            // btn_overPayment
            // 
            this.btn_overPayment.BackColor = System.Drawing.Color.White;
            this.btn_overPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_overPayment.Font = new System.Drawing.Font("Rubik", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_overPayment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_overPayment.Location = new System.Drawing.Point(235, 530);
            this.btn_overPayment.Name = "btn_overPayment";
            this.btn_overPayment.Size = new System.Drawing.Size(90, 33);
            this.btn_overPayment.TabIndex = 17;
            this.btn_overPayment.Text = "Dodaj";
            this.btn_overPayment.UseVisualStyleBackColor = false;
            this.btn_overPayment.Click += new System.EventHandler(this.btn_overPayment_Click);
            // 
            // btn_OpenScheduleLoan
            // 
            this.btn_OpenScheduleLoan.Location = new System.Drawing.Point(485, 530);
            this.btn_OpenScheduleLoan.Name = "btn_OpenScheduleLoan";
            this.btn_OpenScheduleLoan.Size = new System.Drawing.Size(75, 23);
            this.btn_OpenScheduleLoan.TabIndex = 18;
            this.btn_OpenScheduleLoan.Text = "Wyświetl harmonogram";
            this.btn_OpenScheduleLoan.UseVisualStyleBackColor = true;
            this.btn_OpenScheduleLoan.Click += new System.EventHandler(this.btn_OpenScheduleLoan_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = global::CreditCalculator.Properties.Resources.black_1072366_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1281, 598);
            this.Controls.Add(this.btn_OpenScheduleLoan);
            this.Controls.Add(this.btn_overPayment);
            this.Controls.Add(this.txt_overPayment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.Text = "Kalkulator kredytu hipotecznego";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calculate;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_overPayment;
        private System.Windows.Forms.Button btn_overPayment;
        private System.Windows.Forms.Button btn_OpenScheduleLoan;
    }
}

