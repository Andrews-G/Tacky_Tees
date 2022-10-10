
namespace Tacky_Tees
{
    partial class SelectOrderToEditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectOrderButton = new System.Windows.Forms.Button();
            this.customerListDataGridView = new System.Windows.Forms.DataGridView();
            this.explanationLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-72, 87);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "First Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1113, 24);
            this.menuStrip1.TabIndex = 47;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // selectOrderButton
            // 
            this.selectOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectOrderButton.Location = new System.Drawing.Point(440, 377);
            this.selectOrderButton.Name = "selectOrderButton";
            this.selectOrderButton.Size = new System.Drawing.Size(237, 35);
            this.selectOrderButton.TabIndex = 58;
            this.selectOrderButton.Text = "Select Order";
            this.selectOrderButton.UseVisualStyleBackColor = true;
            this.selectOrderButton.Click += new System.EventHandler(this.selectOrderButton_Click);
            // 
            // customerListDataGridView
            // 
            this.customerListDataGridView.AllowUserToAddRows = false;
            this.customerListDataGridView.AllowUserToDeleteRows = false;
            this.customerListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerListDataGridView.Location = new System.Drawing.Point(15, 75);
            this.customerListDataGridView.MultiSelect = false;
            this.customerListDataGridView.Name = "customerListDataGridView";
            this.customerListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerListDataGridView.Size = new System.Drawing.Size(1082, 278);
            this.customerListDataGridView.TabIndex = 57;
            // 
            // explanationLabel
            // 
            this.explanationLabel.AutoSize = true;
            this.explanationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explanationLabel.Location = new System.Drawing.Point(436, 28);
            this.explanationLabel.Name = "explanationLabel";
            this.explanationLabel.Size = new System.Drawing.Size(218, 20);
            this.explanationLabel.TabIndex = 48;
            this.explanationLabel.Text = "Please select an order to edit.";
            // 
            // SelectOrderToEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 432);
            this.Controls.Add(this.selectOrderButton);
            this.Controls.Add(this.customerListDataGridView);
            this.Controls.Add(this.explanationLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "SelectOrderToEditForm";
            this.Text = "SelectOrderToEditForm";
            this.Load += new System.EventHandler(this.SelectOrderToEditForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button selectOrderButton;
        private System.Windows.Forms.DataGridView customerListDataGridView;
        private System.Windows.Forms.Label explanationLabel;
    }
}