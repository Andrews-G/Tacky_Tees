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
    public partial class SelectOrderToEditForm : Form
    {
        public SelectOrderToEditForm()
        {
            InitializeComponent();
        }
        string customerID = DataHandlerClass.customerID.ToString();

        // Create DataTable object
        DataTable orderList = new DataTable();

        private DataTable GetCustomerList()
        // Retrieve customer list from SQL database
        {
            string connString = ConfigurationManager.ConnectionStrings["Tacky_TeesDB.Properties.Settings.Tacky_TeesConnectionString"].ConnectionString;

            // Create new SQL connection
            using (SqlConnection con = new SqlConnection(connString))
            {
                // SQL query
                using (SqlCommand cmd = new SqlCommand("SELECT *FROM OrderTable WHERE CustomerID = customerID", con))
                {
                    //Open  SQL connection
                    con.Open();

                    // Execute Query
                    SqlDataReader reader = cmd.ExecuteReader();

                    //Load customerList into reader
                    orderList.Load(reader);
                    con.Close();
                }
            }
            //Return customerList
            return orderList;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectOrderToEditForm_Load(object sender, EventArgs e)
        {
            customerListDataGridView.DataSource = GetCustomerList();
        }

        private void selectOrderButton_Click(object sender, EventArgs e)
        {
            if (DataHandlerClass.OrderType == "Edit")
            {
                var currentRow = customerListDataGridView.CurrentRow.Index;

                var customerID = customerListDataGridView.Rows[currentRow].Cells[0].Value.ToString();
                var orderIDNum = customerListDataGridView.Rows[currentRow].Cells[1].Value.ToString();
                var shirtSize = customerListDataGridView.Rows[currentRow].Cells[2].Value.ToString();
                var shirtColor = customerListDataGridView.Rows[currentRow].Cells[3].Value.ToString();
                var customMessage = customerListDataGridView.Rows[currentRow].Cells[4].Value.ToString();
                var preferredCustomerDiscount = customerListDataGridView.Rows[currentRow].Cells[5].Value.ToString();
                var numberOfShirts = customerListDataGridView.Rows[currentRow].Cells[6].Value.ToString();


                // parse strings...................................
                DataHandlerClass.customerID = int.Parse(customerID);
                DataHandlerClass.orderID = int.Parse(orderIDNum);
                DataHandlerClass.shirtSize = shirtSize;
                DataHandlerClass.shirtColor = shirtColor;
                DataHandlerClass.customMessage = customMessage;
                DataHandlerClass.preferredCustomerDiscount = preferredCustomerDiscount;
                DataHandlerClass.numberOfShirts = numberOfShirts;

                this.Hide();
                OrderForm form = new OrderForm();
                form.ShowDialog();
                this.Close();
            }


            else if (DataHandlerClass.OrderType == "Cancel")
            {
                var currentRow = customerListDataGridView.CurrentRow.Index;
                var customerID = customerListDataGridView.Rows[currentRow].Cells[0].Value.ToString();
                var orderIDNum = customerListDataGridView.Rows[currentRow].Cells[1].Value.ToString();

                DataHandlerClass.customerID = int.Parse(customerID);
                DataHandlerClass.orderID = int.Parse(orderIDNum);

                DataHandlerClass.ChangeOrderStatus("Canceled", DataHandlerClass.customerID.ToString(), DataHandlerClass.orderID.ToString());

                this.Close();
            }


            else if (DataHandlerClass.OrderType=="Ready To Ship")
            {
                var currentRow = customerListDataGridView.CurrentRow.Index;
                var customerID = customerListDataGridView.Rows[currentRow].Cells[0].Value.ToString();
                var orderIDNum = customerListDataGridView.Rows[currentRow].Cells[1].Value.ToString();

                DataHandlerClass.customerID = int.Parse(customerID);
                DataHandlerClass.orderID = int.Parse(orderIDNum);

                DataHandlerClass.ChangeOrderStatus("Ready To Ship", DataHandlerClass.customerID.ToString(), DataHandlerClass.orderID.ToString());

                this.Close();
            }


            else if (DataHandlerClass.OrderType=="Shipped")
            {
                var currentRow = customerListDataGridView.CurrentRow.Index;
                var customerID = customerListDataGridView.Rows[currentRow].Cells[0].Value.ToString();
                var orderIDNum = customerListDataGridView.Rows[currentRow].Cells[1].Value.ToString();

                DataHandlerClass.customerID = int.Parse(customerID);
                DataHandlerClass.orderID = int.Parse(orderIDNum);

                DataHandlerClass.ChangeOrderStatus("Shipped", DataHandlerClass.customerID.ToString(), DataHandlerClass.orderID.ToString());

                this.Close();
            }
        }
    }
}
