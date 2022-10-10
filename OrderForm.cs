/************************************************************************
 * Tacky Tees
 * Grant Andrews
 * 7/26/2022
 * This program allows the user to enter a t-shirt order by selecting the
 * size and color, entering custom colors are permitted. The user may enter 
 * a custom message for the t-shirt as well. There is an option for a discount 
 * for preferred customers (10%). The user must enter the number of shirts being
 * ordered. When the user submits the order, the price, tax, and order total
 * are displayed to the user.
 *///////////////////////////////////////////////////////////////////////
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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        public string typeOfOrder;

        // Assign customerID variable from DataHandlerClass
        string customerID = DataHandlerClass.customerID.ToString();

        // Initialize variables to pass to NewOrder method after assignment
        string shirtSize, shirtColor, customMessage, preferredCustomerDiscount, numberOfShirts, orderPrice, tax, totalOrderPrice;

        private void submitOrderButton_Click(object sender, EventArgs e)
            // This event handler calls the Show Summary method, and updates the SQL database with either a new order or and edit to an order
        {

            //If the order type is "new", call the NewOrderNumber method of the DataHandlerClass to generate a new order number,
            // update the SQL database with the NewOrder method of the DataHandlerClass, and close the form
            if (typeOfOrder == "New")
            {

                // Ensure there is no bad data before performing calculations, inform user of any issues
                CustomMessage();
                if (this.customMessage == "Invalid")
                {
                    MessageBox.Show("Custom messages can be no longer than 30 characters, including spaces.");
                }


                else if (numberOfShirtsTextBox.Text == "")
                {
                    MessageBox.Show("You must enter the number of shirts.");
                }

                // If no bad data, proceed
                else
                {
                    ShowSummary();
                    string orderNumber = DataHandlerClass.NewOrderNumber();
                    DataHandlerClass.NewOrder(customerID, orderNumber, shirtSize, shirtColor, customMessage, preferredCustomerDiscount, numberOfShirts,
                        orderPrice, tax, totalOrderPrice);
                    this.Close();
                }

            }

            // If the order type is "edit", update the appropriate order in  the SQL database by calling the UpdateOrder method of the DataHandlerClass,
            // and close the form
            else
            {
                // Ensure there is no bad data before performing calculations, inform user of any issues
                CustomMessage();
                if (this.customMessage == "Invalid")
                {
                    MessageBox.Show("Custom messages can be no longer than 30 characters, including spaces.");
                }


                else if (numberOfShirtsTextBox.Text == "")
                {
                    MessageBox.Show("You must enter the number of shirts.");
                }

                // If no bad data, proceed
                else
                {
                    ShowSummary();
                    string orderNumber = DataHandlerClass.orderID.ToString();
                    string customerID = DataHandlerClass.customerID.ToString();
                    DataHandlerClass.UpdateOrder(customerID, orderNumber, shirtSize, shirtColor, customMessage, preferredCustomerDiscount, numberOfShirts,
                            orderPrice, tax, totalOrderPrice);
                    this.Close();
                }
            }


        }


        private void clearButton_Click(object sender, EventArgs e)
            // This event handler calls the ClearForm method
        {
            ClearForm();
        }


        public void customRadioButton_CheckedChanged(object sender, EventArgs e)
            // This event handler will enable the customColorListBox when the user
            // selects the customRadioButton
        {
            if (customRadioButton.Checked == true)
            {
                customColorListBox.Enabled = true;
                customColorListBox.SelectedIndex = 0;
            }
            else
            {
                customColorListBox.Enabled = false;
                customColorListBox.SelectedIndex = -1;
            }
        }


        private void messageCheckBox_CheckedChanged(object sender, EventArgs e)
            // This event handler will enable the messageTextBox when the user 
            // selects the messageCheckBox
        {
            if (messageCheckBox.Checked == true)
            {
                messageTextBox.Enabled = true;
            }
            else
            {
                messageTextBox.Text = null;
                messageTextBox.Enabled = false;
                this.customMessage = "No Message";
            }
        }


        private void exitButton_Click(object sender, EventArgs e)
            // This event handler will close the form when the user clicks
            // the "Exit" button
        {
            this.Close();
        }


        private decimal ShirtSize()
            // This method determines which radio button is selected and
            // assigns the appropriate price based on the size shirt selected
        {
            // Declare & Assign Constants
            const decimal SMALL = 4;
            const decimal MEDIUM = 5;
            const decimal LARGE = 6;
            const decimal XLARGE = 7;

            // Declare & Initialize Variables
            decimal price = 0;

            //Check size of shirt selected & assign variable for SQL
            if (smallRadioButton.Checked)
            {
                price = SMALL;
                shirtSize = "Small";
            }

            else if (mediumRadioButton.Checked)
            {
                price = MEDIUM;
                shirtSize = "Medium";
            }

            else if (largeRadioButton.Checked)
            {
                price = LARGE;
                shirtSize = "Large";
            }

            else
            {
                price = XLARGE;
                shirtSize = "Xlarge";
            }

            // Return decimal price
            return price;
        }


        private decimal ShirtColor()
            // This method checks radio buttons to determine which color the user has
            // selected for the shirt, then assigns the appropriate price
        {
            // Declare & Assign Constants
            const decimal BASIC = 0;
            const decimal STANDARD = 1;
            const decimal CUSTOM = 2;

            // Declare & Initialize Variables
            decimal colorCost = 0;

            // Check for shirt color & assign variable for SQL
            if (whiteRadioButton.Checked)
            {
                colorCost = BASIC;
                shirtColor = "White";
            }
            else if (blackRadioButton.Checked)
            {
                colorCost = BASIC;
                shirtColor = "Black";
            }
            else if (grayRadioButton.Checked)
            {
                colorCost = BASIC;
                shirtColor = "Gray";
            }
            else if (redRadioButton.Checked)
            {
                colorCost = STANDARD;
                shirtColor = "Red";
            }
            else if (orangeRadioButton.Checked)
            {
                colorCost = STANDARD;
                shirtColor = "Orange";
            }
            else if (yellowRadioButton.Checked)
            {
                colorCost = STANDARD;
                shirtColor = "Yellow";
            }
            else if (greenRadioButton.Checked)
            {
                colorCost = STANDARD;
                shirtColor = "Green";
            }
            else if (blueRadioButton.Checked)
            {
                colorCost = STANDARD;
                shirtColor = "Blue";
            }
            else if (purpleRadioButton.Checked)
            {
                colorCost = STANDARD;
                shirtColor = "Purple";
            }
            else if (customRadioButton.Checked)
            {
                customColorListBox.Enabled = true;
                colorCost = CUSTOM;

                switch (customColorListBox.SelectedItem)
                {
                    case "Rainbow":
                        shirtColor = "Rainbow";
                        break;

                    case "Tie-Dye":
                        shirtColor = "Tie-Dye";
                        break;

                    case "Sun Burst":
                        shirtColor = "Sun Burst";
                        break;

                    case "CheckerBoard":
                        shirtColor = "Checker Board";
                        break;
                }
            }

            // Return decimal colorCost
            return colorCost;
        }


        private decimal CustomMessage()
            // This method handles the custom message that the user entered,
            // all characters are counted towards cost, but whitespace is not.
        {
            // Declare & Assign Constants
            const decimal PRICE_LETTER = .10m;
            string message = messageTextBox.Text.Trim();
            // Declare & initialize Variables
            decimal numLetters = 0;
            decimal messagePrice = 0;

            // Foreach loop to count the number of characters in the message, not including any spaces

            // Ensure message is 30 characters or less, including spaces
            if (message.Length > 30)
            {
                this.customMessage = "Invalid";
            }

            else
            {
                // If message is not NULL
                if (message != "")
                {
                    foreach (char x in message)
                    {
                        if (x != ' ')
                        {
                            numLetters++;
                        }
                    }

                    // Calculate price of the message
                    messagePrice = numLetters * PRICE_LETTER;

                    // Assign vairable for SQL
                    this.customMessage = messageTextBox.Text;
                }

                // If message is NULL
                else
                {
                    messagePrice = 0;

                    // Assign variable for SQL
                    this.customMessage = "No Message";
                }
            }

            // Return decimal messagePrice
            return messagePrice;
        }


        private decimal NumberOfShirts()
            // This method determines how many shirts the user wishes to order based
            // on what they have entered into the TextBox
        {
            // Declare & initialize Variables
            decimal numShirts = 0;

            // Check to make sure the TextBox is not empty
            if (numberOfShirtsTextBox.Text != "")
            {
                // Attempt to parse the string into an integer
                if (int.TryParse(numberOfShirtsTextBox.Text, out int shirts))
                {
                    // Check that number of shirts entered is valid
                    if (shirts >= 1 && shirts <= 30)
                    {
                        numShirts = shirts;
                    }

                    // If user enters less than one shirt, show MessageBox
                    else if (shirts < 1)
                    {
                        MessageBox.Show("You must order at least one shirt.");
                    }

                    // If user attempts to order more than 30 shirts, show MessageBox
                    else if (shirts > 30)
                    {
                        MessageBox.Show("You cannot place an order for more than 30 shirts.");
                    }
                }

                // If user enters anything other than an integer, show MessageBox
                else
                {
                    MessageBox.Show("Please enter a whole number only!");
                }
            }

            // If user left TextBox blank, show MessageBox
            else
            {
                MessageBox.Show("You must enter the number of shirts.");
            }

            // Assign to variable for SQL using ToString method
            numberOfShirts = numShirts.ToString();

            // Return decimal numShirts
            return numShirts;
        }


        private void Tax(in decimal priceOfShirts, out decimal totalTax)
            // This method calculates the tax on the shirts
        {
            // Declare & Assign Constants
            const decimal TAX = .05m;

            totalTax = priceOfShirts * TAX;

            // Assign variable for SQL using ToString method
            tax = totalTax.ToString("C");
        }


        private decimal Discount()
            // This method calculates the discount (if any)
        {
            // Declare & Assign Constants
            const decimal DISCOUNT = .10m;

            // Declare & Initialize Variables
            decimal totalBefore;
            decimal totalAfter;
            decimal discountAmount;

            // Calculate discount
            totalBefore = (ShirtSize() + ShirtColor() + CustomMessage()) * NumberOfShirts();
            discountAmount = totalBefore * DISCOUNT;
            totalAfter = totalBefore - discountAmount;

            return totalAfter;
        }


        private void ShowSummary()
        // This method displays the cost of the t-shirt order to the user
        {
            // Declare & initialize Variables
            decimal priceShirts;
            decimal taxOnShirts;
            decimal orderTotal;

            // Check if the discount CheckBox is selected! If not, calculate the
            // price of the order WITHOUT a discount. If selected, calculate the price 
            // of the order WITH the discount by calling the Discount method
            if (!discountCheckBox.Checked)
            {
                priceShirts = (ShirtSize() + ShirtColor() + CustomMessage()) * NumberOfShirts();
                preferredCustomerDiscount = "No";

                // Assing variable for SQL using ToString method
                orderPrice = priceShirts.ToString("C");
            }
            else
            {
                priceShirts = Discount();
                preferredCustomerDiscount = "Yes";

                // Assing variable for SQL using ToString method
                orderPrice = priceShirts.ToString("C");
            }

            // Calculate tax on the order, notice this is performed after the discount
            // (if any) is applied
            Tax(in priceShirts, out taxOnShirts);

            // Sum the price with the tax charge to get the orderTotal
            orderTotal = priceShirts + taxOnShirts;

            // Assing variable for SQL using ToString method
            totalOrderPrice = orderTotal.ToString("C");

            // Display results to user if orderTotal does not equal 0
            // orderTotal will equal 0 if user does not enter number of shirts
            // before clicking submitOrderButton
            if (orderTotal != 0)
            {
                priceDisplayLabel.Text = priceShirts.ToString("C");
                taxDisplayLabel.Text = taxOnShirts.ToString("C");
                totalDisplayLabel.Text = orderTotal.ToString("C");
            }
        }


        private void ClearForm()
            // This method clears the form so that the user can start over
        {
            // Reset RadioButtons and CheckBoxes
            smallRadioButton.Checked = true;
            whiteRadioButton.Checked = true;
            discountCheckBox.Checked = false;
            messageCheckBox.Checked = false;

            // Clear TextBoxes
            messageTextBox.Text = "";
            numberOfShirtsTextBox.Text = "";

            // Disable TextBoxes
            messageTextBox.Enabled = false;

            // Clear Display Labels
            priceDisplayLabel.Text = "";
            taxDisplayLabel.Text = "";
            totalDisplayLabel.Text = "";
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

            if (DataHandlerClass.orderID == 0)
            {
                // This event handler pre-selects radio buttons when the form
                // is loaded, it also disables the TextBoxes until they are needed
                {
                    typeOfOrder = "New";
                    smallRadioButton.Checked = true;
                    whiteRadioButton.Checked = true;
                    messageTextBox.Enabled = false;
                    customColorListBox.Enabled = false;
                }
            }

            else
            {
                typeOfOrder = "Edit";
                string customerIDNumber = DataHandlerClass.customerID.ToString();
                string orderIDNumber = DataHandlerClass.orderID.ToString();
                string shirtSize = DataHandlerClass.shirtSize;
                string shirtColor = DataHandlerClass.shirtColor;
                string customMessage = DataHandlerClass.customMessage;
                string preferredCustomerDiscount = DataHandlerClass.preferredCustomerDiscount;
                string numberOfShirts = DataHandlerClass.numberOfShirts;

                customRadioButton.Checked = false;
                messageCheckBox.Checked = false;
                discountCheckBox.Checked = false;

                // Select appropriate shirtSize radio button
                if (shirtSize == "Small")
                {
                    smallRadioButton.Checked = true;
                }
                else if (shirtSize == "Medium")
                {
                    mediumRadioButton.Checked = true;
                }
                else if (shirtSize == "Large")
                {
                    largeRadioButton.Checked = true;
                }
                else if (shirtSize == "Xlarge")
                {
                    xLargeRadioButton.Checked = true;
                }


                // Select appropriate shirtColor radio button
                if (shirtColor == "Rainbow")
                {
                    customRadioButton.Checked = true;
                    customColorListBox.SelectedIndex = 0;
                }
                else if (shirtColor == "Tie-Dye")
                {
                    customRadioButton.Checked = true;
                    customColorListBox.SelectedIndex = 1;
                }
                else if (shirtColor == "Sun Burst")
                {
                    customRadioButton.Checked = true;
                    customColorListBox.SelectedIndex = 3;
                }
                else if (shirtColor == "Checker Board")
                {
                    customRadioButton.Checked = true;
                    customColorListBox.SelectedIndex = 4;
                }
                else if (shirtColor == "White")
                {
                    whiteRadioButton.Checked = true;
                }
                else if (shirtColor == "Black")
                {
                    blackRadioButton.Checked = true;
                }
                else if (shirtColor == "Gray")
                {
                    grayRadioButton.Checked = true;
                }
                else if (shirtColor == "Red")
                {
                    redRadioButton.Checked = true;
                }
                else if (shirtColor == "Orange")
                {
                    orangeRadioButton.Checked = true;
                }
                else if (shirtColor == "Yellow")
                {
                    yellowRadioButton.Checked = true;
                }
                else if (shirtColor == "Green")
                {
                    greenRadioButton.Checked = true;
                }
                else if (shirtColor == "Blue")
                {
                    blueRadioButton.Checked = true;
                }
                else if (shirtColor == "Purple")
                {
                    purpleRadioButton.Checked = true;
                }

                // Apply custom message, if present
                if (customMessage != "No Message")
                {
                    messageCheckBox.Checked = true;
                    messageTextBox.Text = customMessage;
                }

                // Select customer discount, if present
                if (preferredCustomerDiscount == "Yes")
                {
                    discountCheckBox.Checked = true;
                }

                numberOfShirtsTextBox.Text = numberOfShirts;

            }

        }
    }
}
