namespace CreditCalculator
{
    partial class WelcomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_closeWelcomeForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_closeWelcomeForm
            // 
            this.btn_closeWelcomeForm.Location = new System.Drawing.Point(200, 369);
            this.btn_closeWelcomeForm.Name = "btn_closeWelcomeForm";
            this.btn_closeWelcomeForm.Size = new System.Drawing.Size(350, 42);
            this.btn_closeWelcomeForm.TabIndex = 0;
            this.btn_closeWelcomeForm.Text = "Przejdz do klakulatora";
            this.btn_closeWelcomeForm.UseVisualStyleBackColor = true;
            this.btn_closeWelcomeForm.Click += new System.EventHandler(this.btn_closeWelcomeForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(320, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Witaj!";
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_closeWelcomeForm);
            this.Name = "WelcomeForm";
            this.Text = "Kalkulator kredytu hipotecznego";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_closeWelcomeForm;
        private System.Windows.Forms.Label label1;
    }
}