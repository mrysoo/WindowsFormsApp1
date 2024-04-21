namespace FinancialApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIncomeAmount = new System.Windows.Forms.TextBox();
            this.txtExpenseAmount = new System.Windows.Forms.TextBox();
            this.txtExpenseCategory = new System.Windows.Forms.TextBox();
            this.txtSavingsAmount = new System.Windows.Forms.TextBox();
            this.txtSavingsCategory = new System.Windows.Forms.TextBox();
            this.btnAddIncome = new System.Windows.Forms.Button();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.btnAddSavings = new System.Windows.Forms.Button();
            this.btnViewSummary = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIncomeAmount
            // 
            this.txtIncomeAmount.Location = new System.Drawing.Point(131, 67);
            this.txtIncomeAmount.Name = "txtIncomeAmount";
            this.txtIncomeAmount.Size = new System.Drawing.Size(100, 20);
            this.txtIncomeAmount.TabIndex = 0;
            // 
            // txtExpenseAmount
            // 
            this.txtExpenseAmount.Location = new System.Drawing.Point(475, 67);
            this.txtExpenseAmount.Name = "txtExpenseAmount";
            this.txtExpenseAmount.Size = new System.Drawing.Size(100, 20);
            this.txtExpenseAmount.TabIndex = 1;
            // 
            // txtExpenseCategory
            // 
            this.txtExpenseCategory.Location = new System.Drawing.Point(475, 110);
            this.txtExpenseCategory.Name = "txtExpenseCategory";
            this.txtExpenseCategory.Size = new System.Drawing.Size(100, 20);
            this.txtExpenseCategory.TabIndex = 2;
            // 
            // txtSavingsAmount
            // 
            this.txtSavingsAmount.Location = new System.Drawing.Point(960, 67);
            this.txtSavingsAmount.Name = "txtSavingsAmount";
            this.txtSavingsAmount.Size = new System.Drawing.Size(100, 20);
            this.txtSavingsAmount.TabIndex = 3;
            // 
            // txtSavingsCategory
            // 
            this.txtSavingsCategory.Location = new System.Drawing.Point(960, 110);
            this.txtSavingsCategory.Name = "txtSavingsCategory";
            this.txtSavingsCategory.Size = new System.Drawing.Size(100, 20);
            this.txtSavingsCategory.TabIndex = 4;
            this.txtSavingsCategory.TextChanged += new System.EventHandler(this.txtSavingsCategory_TextChanged);
            // 
            // btnAddIncome
            // 
            this.btnAddIncome.Location = new System.Drawing.Point(78, 27);
            this.btnAddIncome.Name = "btnAddIncome";
            this.btnAddIncome.Size = new System.Drawing.Size(100, 23);
            this.btnAddIncome.TabIndex = 5;
            this.btnAddIncome.Text = "Ввести доходы";
            this.btnAddIncome.UseVisualStyleBackColor = true;
            this.btnAddIncome.Click += new System.EventHandler(this.btnAddIncome_Click);
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.Location = new System.Drawing.Point(413, 26);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(100, 24);
            this.btnAddExpense.TabIndex = 6;
            this.btnAddExpense.Text = "Ввести расходы";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            // 
            // btnAddSavings
            // 
            this.btnAddSavings.Location = new System.Drawing.Point(830, 26);
            this.btnAddSavings.Name = "btnAddSavings";
            this.btnAddSavings.Size = new System.Drawing.Size(124, 24);
            this.btnAddSavings.TabIndex = 7;
            this.btnAddSavings.Text = "Ввести сбережения";
            this.btnAddSavings.UseVisualStyleBackColor = true;
            // 
            // btnViewSummary
            // 
            this.btnViewSummary.Location = new System.Drawing.Point(413, 177);
            this.btnViewSummary.Name = "btnViewSummary";
            this.btnViewSummary.Size = new System.Drawing.Size(162, 23);
            this.btnViewSummary.TabIndex = 8;
            this.btnViewSummary.Text = "Общая сумма на счете";
            this.btnViewSummary.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ввести сумму расходов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ввести категорию расходов:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(676, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ввести сумму сбережений(откладываемых средств):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(654, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ввести категорию сбережений(откладываемых средств):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ввести сумму доходов:";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1074, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewSummary);
            this.Controls.Add(this.btnAddSavings);
            this.Controls.Add(this.btnAddExpense);
            this.Controls.Add(this.btnAddIncome);
            this.Controls.Add(this.txtSavingsCategory);
            this.Controls.Add(this.txtSavingsAmount);
            this.Controls.Add(this.txtExpenseCategory);
            this.Controls.Add(this.txtExpenseAmount);
            this.Controls.Add(this.txtIncomeAmount);
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddIncome_Click;
        private System.Windows.Forms.TextBox textBoxIncomeCategory;
        private System.Windows.Forms.TextBox textBoxIncomeAmount;
        private System.Windows.Forms.TextBox IncomeTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIncomeAmount;
        private System.Windows.Forms.TextBox txtExpenseAmount;
        private System.Windows.Forms.TextBox txtExpenseCategory;
        private System.Windows.Forms.TextBox txtSavingsAmount;
        private System.Windows.Forms.TextBox txtSavingsCategory;
        private System.Windows.Forms.Button btnAddIncome;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.Button btnAddSavings;
        private System.Windows.Forms.Button btnViewSummary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

