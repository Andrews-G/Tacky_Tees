
namespace Tacky_Tees
{
    partial class SelectCustomerForm
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
            this.explanationLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerListDataGridView = new System.Windows.Forms.DataGridView();
            this.selectCustomerButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // explanationLabel
            // 
            this.explanationLabel.AutoSize = true;
            this.explanationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explanationLabel.Location = new System.Drawing.Point(254, 34);
            this.explanationLabel.Name = "explanationLabel";
            this.explanationLabel.Size = new System.Drawing.Size(501, 20);
            this.explanationLabel.TabIndex = 0;
            this.explanationLabel.Text = "Please enter customer information to search for an existing customer. ";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(607, 86);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(136, 20);
            this.emailTextBox.TabIndex = 19;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(521, 89);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Email:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(272, 89);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Last Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.Location = new System.Drawing.Point(359, 86);
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(136, 20);
            this.lNameTextBox.TabIndex = 17;
            this.lNameTextBox.TextChanged += new System.EventHandler(this.lNameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 89);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "First Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.Location = new System.Drawing.Point(110, 86);
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(136, 20);
            this.fNameTextBox.TabIndex = 16;
            this.fNameTextBox.TextChanged += new System.EventHandler(this.fNameTextBox_TextChanged);
            // 
            // phoneLabel
            // 
            this.phoneLabel.Location = new System.Drawing.Point(769, 84);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(51, 23);
            this.phoneLabel.TabIndex = 33;
            this.phoneLabel.Text = "Phone:";
            this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(846, 86);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(136, 20);
            this.phoneTextBox.TabIndex = 34;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.phoneTextBox_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.resetFormToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // resetFormToolStripMenuItem
            // 
            this.resetFormToolStripMenuItem.Name = "resetFormToolStripMenuItem";
            this.resetFormToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.resetFormToolStripMenuItem.Text = "&Reset Form";
            this.resetFormToolStripMenuItem.Click += new System.EventHandler(this.resetFormToolStripMenuItem_Click);
            // 
            // customerListDataGridView
            // 
            this.customerListDataGridView.AllowUserToAddRows = false;
            this.customerListDataGridView.AllowUserToDeleteRows = false;
            this.customerListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerListDataGridView.Location = new System.Drawing.Point(12, 128);
            this.customerListDataGridView.MultiSelect = false;
            this.customerListDataGridView.Name = "customerListDataGridView";
            this.customerListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerListDataGridView.Size = new System.Drawing.Size(981, 278);
            this.customerListDataGridView.TabIndex = 36;
            // 
            // selectCustomerButton
            // 
            this.selectCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectCustomerButton.Location = new System.Drawing.Point(386, 420);
            this.selectCustomerButton.Name = "selectCustomerButton";
            this.selectCustomerButton.Size = new System.Drawing.Size(237, 35);
            this.selectCustomerButton.TabIndex = 37;
            this.selectCustomerButton.Text = "Select Customer";
            this.selectCustomerButton.UseVisualStyleBackColor = true;
            this.selectCustomerButton.Click += new System.EventHandler(this.selectCustomerButton_Click);
            // 
            // SelectCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 476);
            this.Controls.Add(this.selectCustomerButton);
            this.Controls.Add(this.customerListDataGridView);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fNameTextBox);
            this.Controls.Add(this.explanationLabel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "SelectCustomerForm";
            this.Text = "SelectCustomerForm";
            this.Load += new System.EventHandler(this.SelectCustomerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label explanationLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetFormToolStripMenuItem;
        private System.Windows.Forms.DataGridView customerListDataGridView;
        private System.Windows.Forms.Button selectCustomerButton;
    }
}