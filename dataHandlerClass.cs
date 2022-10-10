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
    public class DataHandlerClass
    {
        // Create static string to pass to orderForm form
        public static int customerID;
        public static int orderID = 0;
        public static string shirtSize;
        public static string shirtColor;
        public static string customMessage;
        public static string preferredCustomerDiscount;
        public static string numberOfShirts;
        public static string OrderType;


        // One possible way to create SQL connection at class level
        public static SqlConnection con = new SqlConnection(@"Data Source=GRANT-DESKTOP\SQLEXPRESS;Initial Catalog=Tacky-Tees;Integrated Security=True");

        // Create new SQL connection at the class level
        //private static string connString = ConfigurationManager.ConnectionStrings["Tacky_TeesDB.Properties.Settings.Tacky_TeesConnectionString"].ConnectionString;
        //private static SqlConnection con = new SqlConnection(connString);


        // A method for updating the SQL database with a new customer order
        public static void NewOrder(string @CustomerID, string @OrderNumber, string @ShirtSize, string @ShirtColor, string @CustomMessage,
            string @PreferredCustomerDiscount, string @NumberOfShirts, string @Price, string @Tax, string @OrderTotal)
        {
            // Declare variable for order status
            string orderStatus = "Pending";

            // Attempt to update database
            try
            {
                // Open connection with SQL server
                con.Open();

                // Define SQL Update Query
                SqlCommand cmd = new SqlCommand
                ("INSERT INTO OrderTable(CustomerID,OrderNumber,ShirtSize,ShirtColor,CustomMessage,PreferredCustomerDiscount,NumberOfShirts,Price,Tax,OrderTotal, OrderStatus)" +
                "values('" + @CustomerID + "', '" + @OrderNumber + "', '" + @ShirtSize + "', '" + @ShirtColor + "', '" + @CustomMessage + "'," +
                " '" + @PreferredCustomerDiscount + "', '" + @NumberOfShirts + "', '" + @Price + "', '" + @Tax + "', '" + @OrderTotal + "', '" + orderStatus + "')", con);

                // Execute Query
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Submitted");
            }

            // Display message if SQL Query fails
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Close connection
            con.Close();
        }


        // A method for generating a new order number
        public static string NewOrderNumber()
        {
            // Open connection with SQL server
            con.Open();

            // Define SQL command
            SqlCommand cmd = new SqlCommand("SELECT MAX(OrderNumber) FROM [OrderTable]", con);

            // Check if SQL command returns DBNULL Value, if not DBNULL, then execute if statement
            if (!DBNull.Value.Equals(cmd.ExecuteScalar()))
            {
                // Assign value to int i
                int i = Convert.ToInt32(cmd.ExecuteScalar());

                //Close connection with SQL server
                con.Close();

                // Increment value returned from SQL query by "1"
                i++;

                // Return Value as string
                return i.ToString();
            }

            // If value retutned by SQL Query is DBNULL, execute else statement
            else
            {
                // Close connection with SQL server
                con.Close();

                // Assign string i value as "1"
                string i = "1";

                // Return string i value
                return i;
            }
        }

        public static void UpdateOrder(string @CustomerID, string @OrderNumber, string @ShirtSize, string @ShirtColor, string @CustomMessage,
            string @PreferredCustomerDiscount, string @NumberOfShirts, string @Price, string @Tax, string @OrderTotal)
        {
            // Attempt to update database
            try
            {
                // Open connection with SQL server
                con.Open();

                // Define SQL Update Query
                SqlCommand cmd = new SqlCommand
                    ("UPDATE OrderTable SET ShirtSize = '" + @ShirtSize + "', ShirtColor = '" + @ShirtColor + "', CustomMessage = '" + @CustomMessage + "'," +
                    " PreferredCustomerDiscount = '" + @PreferredCustomerDiscount + "', NumberOfShirts = '" + @NumberOfShirts + "', Price = '" + @Price + "'," +
                    "Tax = '" + @Tax + "', OrderTotal = '" + @OrderTotal + "' WHERE OrderNumber = '" + @OrderNumber + "' AND  CustomerID = '" + @CustomerID + "'", con);

                // Execute Query
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Updated");
            }

            // Display message if SQL Query fails
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Close connection
            con.Close();
        }


        public static void ChangeOrderStatus(string @OrderStatus, string @CustomerID, string @OrderNumber)
        {
            // Attempt to update database
            try
            {
                // Open connection with SQL server
                con.Open();

                // Define SQL Update Query
                SqlCommand cmd = new SqlCommand
                    ("UPDATE OrderTable SET OrderStatus = '" + @OrderStatus + "' WHERE OrderNumber = '" + @OrderNumber + "' AND  CustomerID = '" + @CustomerID + "'", con);

                // Execute Query
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Status Updated");
            }

            // Display message if SQL Query fails
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Close connection
            con.Close();
        }
    }
}
