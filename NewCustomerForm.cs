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

namespace Tacky_Tees
{
    public partial class NewCustomerForm : Form
    {
        // Create new SQL connection
        SqlConnection con = new SqlConnection(@"Data Source=GRANT-DESKTOP\SQLEXPRESS;Initial Catalog=Tacky-Tees;Integrated Security=True");

        public NewCustomerForm()
        // Form load event: set location of form on screen
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(225, 40);
        }

        private int AutoIDNumber()
            // A method to retrieve the highest CustomerID number and increment it by one
        {
            //Open SQL connection
            con.Open();

            // SQL query
            SqlCommand cmd = new SqlCommand("SELECT count(CustomerID) FROM [CustomerInfo]", con);

            // Execute SQL query
            int i = Convert.ToInt32(cmd.ExecuteScalar());

            // Close SQL connection
            con.Close();

            // Increment by one
            i++;

            // Return "i"
            return i;
        }


        private void submitCustomerButton_Click(object sender, EventArgs e)
        // Event handler to update SQL database with new customer information
        {
            // Call method to generate a new CustomerID number
            int i = AutoIDNumber();

            // Attempt to update SQL database
            try
            {
                // Open connection
                con.Open();

                // SQL query
                SqlCommand cmd = new SqlCommand
                ("INSERT INTO CustomerInfo(CustomerID,CustomerFName,CustomerLName,CustomerEmail,CustomerPhone,CustomerAddress,CustomerCity,CustomerState,CustomerZip)" +
                "values('" + i + "', '" + fNameTextBox.Text + "', '" + lNameTextBox.Text + "', '" + emailTextBox.Text + "', '" + phoneTextBox.Text + "'," +
                " '" + addressTextBox.Text + "', '" + cityTextBox.Text + "', '" + stateTextBox.Text + "', '" + zipTextBox.Text + "')", con);

                // Execute Query
                cmd.ExecuteNonQuery();

                // Inform user the new customer has been added
                MessageBox.Show("New Customer Added");
            }

            // If SQL query unsuccessful, display error message
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Close SQL connection
            con.Close();

            // Update the customerID in the DataHandlerClass
            DataHandlerClass.customerID = i;

            // Hide this form
            this.Hide();

            // Create new instance of OrderForm
            OrderForm form2 = new OrderForm();

            // Show OrderForm
            form2.ShowDialog();

            // Close this form
            this.Close();
        }
    }
}
