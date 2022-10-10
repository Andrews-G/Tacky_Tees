using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tacky_Tees
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Variable to determine new order vs edit order
        public string OrderType;

        private void createCustomerButton_Click(object sender, EventArgs e)
        {
            DataHandlerClass.OrderType = "New";
            NewCustomerForm form = new NewCustomerForm();
            form.ShowDialog();
        }

        private void selectCustomerButton_Click(object sender, EventArgs e)
        {
            DataHandlerClass.OrderType = "New";
            SelectCustomerForm form = new SelectCustomerForm();
            form.ShowDialog();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        public void OpenOrderForm()
        {
            SelectCustomerForm form1 = new SelectCustomerForm();
            form1.Close();

            NewCustomerForm form2 = new NewCustomerForm();
            form2.Close();

            OrderForm form3 = new OrderForm();
            form3.ShowDialog();
        }

        private void editOrderButton_Click(object sender, EventArgs e)
        {
            DataHandlerClass.OrderType = "Edit";
            SelectCustomerForm form = new SelectCustomerForm();
            form.ShowDialog();
        }

        private void cancelOrderButton_Click(object sender, EventArgs e)
        {
            DataHandlerClass.OrderType = "Cancel";
            SelectCustomerForm form = new SelectCustomerForm();
            form.ShowDialog();
        }

        private void readyToShipButton_Click(object sender, EventArgs e)
        {
            DataHandlerClass.OrderType = "Ready To Ship";
            SelectCustomerForm form = new SelectCustomerForm();
            form.ShowDialog();
        }

        private void orderShippedButton_Click(object sender, EventArgs e)
        {
            DataHandlerClass.OrderType = "Shipped";
            SelectCustomerForm form = new SelectCustomerForm();
            form.ShowDialog();
        }
    }
}
