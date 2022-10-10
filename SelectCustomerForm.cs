using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Tacky_Tees
{
    public partial class SelectCustomerForm : Form
    {
        public SelectCustomerForm()
        // Form load event: set location of form on screen
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(225, 40);
        }

        // Create DataTable object
        DataTable customerList = new DataTable();

        private DataTable GetCustomerList()
        // Retrieve customer list from SQL database
        {
            string connString = ConfigurationManager.ConnectionStrings["Tacky_TeesDB.Properties.Settings.Tacky_TeesConnectionString"].ConnectionString;

            // Create new SQL connection
            using (SqlConnection con = new SqlConnection(connString))
            {
                // SQL query
                using (SqlCommand cmd = new SqlCommand("SELECT *FROM CustomerInfo", con))
                {
                    //Open  SQL connection
                    con.Open();

                    // Execute Query
                    SqlDataReader reader = cmd.ExecuteReader();

                    //Load customerList into reader
                    customerList.Load(reader);
                    con.Close();
                }
            }
            //Return customerList
            return customerList;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        // Add ability to close form from the tool strip menu
        {
            this.Close();
        }

        private void resetFormToolStripMenuItem_Click(object sender, EventArgs e)
        // Add ability to clear form from the tool strip menu
        {
            fNameTextBox.Clear();
            lNameTextBox.Clear();
            emailTextBox.Clear();
            phoneTextBox.Clear();
        }

        private void fNameTextBox_TextChanged(object sender, EventArgs e)
        // Event handler for fNameTextBox, call FilterStringByColumn method
        {
            FilterStringByColumn("CustomerFName", fNameTextBox);
        }


        private void lNameTextBox_TextChanged(object sender, EventArgs e)
        // Event handler for lNameTextBox, call FilterStringByColumn method
        {
            FilterStringByColumn("CustomerLName", lNameTextBox);
        }


        private void emailTextBox_TextChanged(object sender, EventArgs e)
        // Event handler for emailTextBox, call FilterStringByColumn method
        {
            FilterStringByColumn("CustomerEmail", emailTextBox);
        }


        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        // Event handler for phoneTextBox, call FilterStringByColumn method
        {
            FilterStringByColumn("CustomerPhone", phoneTextBox);
        }


        private void SelectCustomerForm_Load(object sender, EventArgs e)
        // Assign data source to customerListDataGridView
        {
            customerListDataGridView.DataSource = GetCustomerList();
        }

        private void FilterStringByColumn(string columnName, TextBox txtBox)
        // Method for filtering columns based on user entered string
        {
            DataView CustomerList = customerList.DefaultView;

            CustomerList.RowFilter = columnName + " LIKE '%" + txtBox.Text + "%'";
        }

        private void selectCustomerButton_Click(object sender, EventArgs e)
        // Click event for the selectCustomerButton, assign customerID variable
        {
            var currentRow = customerListDataGridView.CurrentRow.Index;

            var customerIDNum = customerListDataGridView.Rows[currentRow].Cells[0].Value.ToString();

            // parse string to int and assign to FormHandlerClass int variable customerID
            DataHandlerClass.customerID = int.Parse(customerIDNum);

            // for new order, open OrderForm and close current form
            if (DataHandlerClass.OrderType == "New")
            {
                this.Hide();
                OrderForm form2 = new OrderForm();
                form2.ShowDialog();
                this.Close();
            }

            else
            {
                this.Hide();
                SelectOrderToEditForm form3 = new SelectOrderToEditForm();
                form3.ShowDialog();
                this.Close();
            }
        }
    }
}
