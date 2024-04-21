using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinancialApp
{
    public partial class MainForm : Form
    {
        private string connectionString = "Data Source=WIN-UTO8MRF8D69;Initial Catalog=Operations;Integrated Security=True";

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            decimal incomeAmount = decimal.Parse(txtIncomeAmount.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Incomes (amount) VALUES (@amount)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@amount", incomeAmount);
                command.ExecuteNonQuery();

                MessageBox.Show("Доходы успешно добавлены.");

                connection.Close();
            }
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            decimal expenseAmount = decimal.Parse(txtExpenseAmount.Text);
            string expenseCategory = txtExpenseCategory.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Проверяем существует ли категория расходов
                int categoryId = GetOrCreateCategoryId(connection, expenseCategory);

                string query = "INSERT INTO Expenses (expense, ID_category) VALUES (@expense, @categoryId)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@expense", expenseAmount);
                command.Parameters.AddWithValue("@categoryId", categoryId);
                command.ExecuteNonQuery();

                MessageBox.Show("Расходы успешно добавлены.");

                connection.Close();
            }
        }

        private void btnAddSavings_Click(object sender, EventArgs e)
        {
            decimal savingsAmount = decimal.Parse(txtSavingsAmount.Text);
            string savingsCategory = txtSavingsCategory.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Проверяем существует ли категория сбережений
                int categoryId = GetOrCreateCategoryId(connection, savingsCategory);

                string query = "INSERT INTO Savings (savings, ID_category) VALUES (@savings, @categoryId)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@savings", savingsAmount);
                command.Parameters.AddWithValue("@categoryId", categoryId);
                command.ExecuteNonQuery();

                MessageBox.Show("Сбережения успешно добавлены.");

                connection.Close();
            }
        }

        private int GetOrCreateCategoryId(SqlConnection connection, string category)
        {
            string query = "SELECT ID_category FROM Categories WHERE category = @category";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@category", category);

            object result = command.ExecuteScalar();

            if (result != null)
            {
                return (int)result;
            }
            else
            {
                query = "INSERT INTO Categories (category) VALUES (@category); SELECT SCOPE_IDENTITY();";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@category", category);

                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        private void btnViewSummary_Click(object sender, EventArgs e)
        {
            decimal totalIncome = 0;
            decimal totalExpenses = 0;
            decimal totalSavings = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Вычисляем общую сумму доходов
                string query = "SELECT SUM(amount) FROM Incomes";
                SqlCommand command = new SqlCommand(query, connection);
                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    totalIncome = Convert.ToDecimal(result);
                }

                // Вычисляем общую сумму расходов
                query = "SELECT SUM(expense) FROM Expenses";
                command = new SqlCommand(query, connection);
                result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    totalExpenses = Convert.ToDecimal(result);
                }

                // Вычисляем общую сумму сбережений
                query = "SELECT SUM(savings) FROM Savings";
                command = new SqlCommand(query, connection);
                result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    totalSavings = Convert.ToDecimal(result);
                }

                connection.Close();
            }

            decimal remainingBalance = totalIncome - totalExpenses - totalSavings;

            MessageBox.Show($"Общие финансы:\n\n" +
                            $"Доходы: {totalIncome}\n" +
                            $"Расходы: {totalExpenses}\n" +
                            $"Сбережения: {totalSavings}\n\n" +
                            $"Остаток на счете: {remainingBalance}");
        }

        private void txtSavingsCategory_TextChanged(object sender, EventArgs e)
        {

        }
    }
}