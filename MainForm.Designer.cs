
namespace Tacky_Tees
{
    partial class MainForm
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
            this.selectCustomerButton = new System.Windows.Forms.Button();
            this.createCustomerButton = new System.Windows.Forms.Button();
            this.placeOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.changeOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.cancelOrderButton = new System.Windows.Forms.Button();
            this.editOrderButton = new System.Windows.Forms.Button();
            this.fulfillOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.orderShippedButton = new System.Windows.Forms.Button();
            this.readyToShipButton = new System.Windows.Forms.Button();
            this.placeOrderGroupBox.SuspendLayout();
            this.changeOrderGroupBox.SuspendLayout();
            this.fulfillOrderGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectCustomerButton
            // 
            this.selectCustomerButton.Location = new System.Drawing.Point(26, 39);
            this.selectCustomerButton.Name = "selectCustomerButton";
            this.selectCustomerButton.Size = new System.Drawing.Size(128, 23);
            this.selectCustomerButton.TabIndex = 1;
            this.selectCustomerButton.Text = "Select Customer";
            this.selectCustomerButton.UseVisualStyleBackColor = true;
            this.selectCustomerButton.Click += new System.EventHandler(this.selectCustomerButton_Click);
            // 
            // createCustomerButton
            // 
            this.createCustomerButton.Location = new System.Drawing.Point(26, 85);
            this.createCustomerButton.Name = "createCustomerButton";
            this.createCustomerButton.Size = new System.Drawing.Size(128, 23);
            this.createCustomerButton.TabIndex = 2;
            this.createCustomerButton.Text = "Create New Customer";
            this.createCustomerButton.UseVisualStyleBackColor = true;
            this.createCustomerButton.Click += new System.EventHandler(this.createCustomerButton_Click);
            // 
            // placeOrderGroupBox
            // 
            this.placeOrderGroupBox.Controls.Add(this.createCustomerButton);
            this.placeOrderGroupBox.Controls.Add(this.selectCustomerButton);
            this.placeOrderGroupBox.Location = new System.Drawing.Point(13, 12);
            this.placeOrderGroupBox.Name = "placeOrderGroupBox";
            this.placeOrderGroupBox.Size = new System.Drawing.Size(188, 138);
            this.placeOrderGroupBox.TabIndex = 3;
            this.placeOrderGroupBox.TabStop = false;
            this.placeOrderGroupBox.Text = "Place an Order";
            // 
            // changeOrderGroupBox
            // 
            this.changeOrderGroupBox.Controls.Add(this.cancelOrderButton);
            this.changeOrderGroupBox.Controls.Add(this.editOrderButton);
            this.changeOrderGroupBox.Location = new System.Drawing.Point(244, 12);
            this.changeOrderGroupBox.Name = "changeOrderGroupBox";
            this.changeOrderGroupBox.Size = new System.Drawing.Size(188, 138);
            this.changeOrderGroupBox.TabIndex = 4;
            this.changeOrderGroupBox.TabStop = false;
            this.changeOrderGroupBox.Text = "Change An Order";
            // 
            // cancelOrderButton
            // 
            this.cancelOrderButton.Location = new System.Drawing.Point(26, 85);
            this.cancelOrderButton.Name = "cancelOrderButton";
            this.cancelOrderButton.Size = new System.Drawing.Size(128, 23);
            this.cancelOrderButton.TabIndex = 1;
            this.cancelOrderButton.Text = "Cancel Order";
            this.cancelOrderButton.UseVisualStyleBackColor = true;
            this.cancelOrderButton.Click += new System.EventHandler(this.cancelOrderButton_Click);
            // 
            // editOrderButton
            // 
            this.editOrderButton.Location = new System.Drawing.Point(26, 39);
            this.editOrderButton.Name = "editOrderButton";
            this.editOrderButton.Size = new System.Drawing.Size(128, 23);
            this.editOrderButton.TabIndex = 0;
            this.editOrderButton.Text = "Edit Order";
            this.editOrderButton.UseVisualStyleBackColor = true;
            this.editOrderButton.Click += new System.EventHandler(this.editOrderButton_Click);
            // 
            // fulfillOrderGroupBox
            // 
            this.fulfillOrderGroupBox.Controls.Add(this.orderShippedButton);
            this.fulfillOrderGroupBox.Controls.Add(this.readyToShipButton);
            this.fulfillOrderGroupBox.Location = new System.Drawing.Point(478, 12);
            this.fulfillOrderGroupBox.Name = "fulfillOrderGroupBox";
            this.fulfillOrderGroupBox.Size = new System.Drawing.Size(188, 138);
            this.fulfillOrderGroupBox.TabIndex = 5;
            this.fulfillOrderGroupBox.TabStop = false;
            this.fulfillOrderGroupBox.Text = "Fulfill An Order";
            // 
            // orderShippedButton
            // 
            this.orderShippedButton.Location = new System.Drawing.Point(27, 85);
            this.orderShippedButton.Name = "orderShippedButton";
            this.orderShippedButton.Size = new System.Drawing.Size(128, 23);
            this.orderShippedButton.TabIndex = 1;
            this.orderShippedButton.Text = "Order Shipped";
            this.orderShippedButton.UseVisualStyleBackColor = true;
            this.orderShippedButton.Click += new System.EventHandler(this.orderShippedButton_Click);
            // 
            // readyToShipButton
            // 
            this.readyToShipButton.Location = new System.Drawing.Point(27, 39);
            this.readyToShipButton.Name = "readyToShipButton";
            this.readyToShipButton.Size = new System.Drawing.Size(128, 23);
            this.readyToShipButton.TabIndex = 0;
            this.readyToShipButton.Text = "Order Ready to Ship";
            this.readyToShipButton.UseVisualStyleBackColor = true;
            this.readyToShipButton.Click += new System.EventHandler(this.readyToShipButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 168);
            this.Controls.Add(this.fulfillOrderGroupBox);
            this.Controls.Add(this.changeOrderGroupBox);
            this.Controls.Add(this.placeOrderGroupBox);
            this.Name = "MainForm";
            this.Text = "Tacky Tees";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.placeOrderGroupBox.ResumeLayout(false);
            this.changeOrderGroupBox.ResumeLayout(false);
            this.fulfillOrderGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button selectCustomerButton;
        private System.Windows.Forms.Button createCustomerButton;
        private System.Windows.Forms.GroupBox placeOrderGroupBox;
        private System.Windows.Forms.GroupBox changeOrderGroupBox;
        private System.Windows.Forms.Button cancelOrderButton;
        private System.Windows.Forms.Button editOrderButton;
        private System.Windows.Forms.GroupBox fulfillOrderGroupBox;
        private System.Windows.Forms.Button orderShippedButton;
        private System.Windows.Forms.Button readyToShipButton;
    }
}