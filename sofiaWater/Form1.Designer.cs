namespace sofiaWater
{
    partial class Form1
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
            this.coldWaterOldCount = new System.Windows.Forms.TextBox();
            this.customerName = new System.Windows.Forms.TextBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerNumber = new System.Windows.Forms.TextBox();
            this.customerNumberLabel = new System.Windows.Forms.Label();
            this.countersPanel = new System.Windows.Forms.Panel();
            this.warmWaterNewLabel = new System.Windows.Forms.Label();
            this.warmWaterNewCount = new System.Windows.Forms.TextBox();
            this.warmWaterOldCount = new System.Windows.Forms.TextBox();
            this.warmWaterOldLabel = new System.Windows.Forms.Label();
            this.warmWaterLabel = new System.Windows.Forms.Label();
            this.coldWaterGroupValue = new System.Windows.Forms.Label();
            this.coldWaterOldValue = new System.Windows.Forms.Label();
            this.coldWaterNewLabel = new System.Windows.Forms.Label();
            this.coldWaterNewCount = new System.Windows.Forms.TextBox();
            this.countersLabel = new System.Windows.Forms.Label();
            this.buttonNew = new System.Windows.Forms.Button();
            this.pricesBox = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.calculateButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.billLabel = new System.Windows.Forms.Label();
            this.bill = new System.Windows.Forms.TextBox();
            this.nameAndCustomerNumberLabel = new System.Windows.Forms.Label();
            this.nameAndCustomerNumber = new System.Windows.Forms.TextBox();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.incorrectDataError = new System.Windows.Forms.Label();
            this.countersPanel.SuspendLayout();
            this.pricesBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // coldWaterOldCount
            // 
            this.coldWaterOldCount.Location = new System.Drawing.Point(62, 39);
            this.coldWaterOldCount.Name = "coldWaterOldCount";
            this.coldWaterOldCount.Size = new System.Drawing.Size(73, 20);
            this.coldWaterOldCount.TabIndex = 1;
            this.coldWaterOldCount.TextChanged += new System.EventHandler(this.validateInputData);
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(222, 59);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(275, 20);
            this.customerName.TabIndex = 0;
            this.customerName.TextChanged += new System.EventHandler(this.validateInputData);
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerNameLabel.Location = new System.Drawing.Point(25, 61);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(190, 13);
            this.customerNameLabel.TabIndex = 1;
            this.customerNameLabel.Text = "Customer name (must be three names):";
            // 
            // customerNumber
            // 
            this.customerNumber.Location = new System.Drawing.Point(222, 23);
            this.customerNumber.Name = "customerNumber";
            this.customerNumber.Size = new System.Drawing.Size(100, 20);
            this.customerNumber.TabIndex = 2;
            this.customerNumber.TextChanged += new System.EventHandler(this.validateInputData);
            // 
            // customerNumberLabel
            // 
            this.customerNumberLabel.AutoSize = true;
            this.customerNumberLabel.Location = new System.Drawing.Point(26, 23);
            this.customerNumberLabel.Name = "customerNumberLabel";
            this.customerNumberLabel.Size = new System.Drawing.Size(186, 13);
            this.customerNumberLabel.TabIndex = 3;
            this.customerNumberLabel.Text = "Customer number (must be four digits):";
            // 
            // countersPanel
            // 
            this.countersPanel.Controls.Add(this.warmWaterNewLabel);
            this.countersPanel.Controls.Add(this.warmWaterNewCount);
            this.countersPanel.Controls.Add(this.warmWaterOldCount);
            this.countersPanel.Controls.Add(this.warmWaterOldLabel);
            this.countersPanel.Controls.Add(this.warmWaterLabel);
            this.countersPanel.Controls.Add(this.coldWaterGroupValue);
            this.countersPanel.Controls.Add(this.coldWaterOldValue);
            this.countersPanel.Controls.Add(this.coldWaterNewLabel);
            this.countersPanel.Controls.Add(this.coldWaterOldCount);
            this.countersPanel.Controls.Add(this.coldWaterNewCount);
            this.countersPanel.Location = new System.Drawing.Point(30, 117);
            this.countersPanel.Name = "countersPanel";
            this.countersPanel.Size = new System.Drawing.Size(332, 111);
            this.countersPanel.TabIndex = 4;
            // 
            // warmWaterNewLabel
            // 
            this.warmWaterNewLabel.AutoSize = true;
            this.warmWaterNewLabel.Location = new System.Drawing.Point(182, 68);
            this.warmWaterNewLabel.Name = "warmWaterNewLabel";
            this.warmWaterNewLabel.Size = new System.Drawing.Size(32, 13);
            this.warmWaterNewLabel.TabIndex = 9;
            this.warmWaterNewLabel.Text = "New:";
            // 
            // warmWaterNewCount
            // 
            this.warmWaterNewCount.Location = new System.Drawing.Point(219, 69);
            this.warmWaterNewCount.Name = "warmWaterNewCount";
            this.warmWaterNewCount.Size = new System.Drawing.Size(73, 20);
            this.warmWaterNewCount.TabIndex = 8;
            this.warmWaterNewCount.TextChanged += new System.EventHandler(this.validateInputData);
            // 
            // warmWaterOldCount
            // 
            this.warmWaterOldCount.Location = new System.Drawing.Point(219, 39);
            this.warmWaterOldCount.Name = "warmWaterOldCount";
            this.warmWaterOldCount.Size = new System.Drawing.Size(73, 20);
            this.warmWaterOldCount.TabIndex = 7;
            this.warmWaterOldCount.TextChanged += new System.EventHandler(this.validateInputData);
            // 
            // warmWaterOldLabel
            // 
            this.warmWaterOldLabel.AutoSize = true;
            this.warmWaterOldLabel.Location = new System.Drawing.Point(188, 39);
            this.warmWaterOldLabel.Name = "warmWaterOldLabel";
            this.warmWaterOldLabel.Size = new System.Drawing.Size(26, 13);
            this.warmWaterOldLabel.TabIndex = 6;
            this.warmWaterOldLabel.Text = "Old:";
            // 
            // warmWaterLabel
            // 
            this.warmWaterLabel.AutoSize = true;
            this.warmWaterLabel.Location = new System.Drawing.Point(193, 6);
            this.warmWaterLabel.Name = "warmWaterLabel";
            this.warmWaterLabel.Size = new System.Drawing.Size(67, 13);
            this.warmWaterLabel.TabIndex = 5;
            this.warmWaterLabel.Text = "Warm water:";
            // 
            // coldWaterGroupValue
            // 
            this.coldWaterGroupValue.AutoSize = true;
            this.coldWaterGroupValue.Location = new System.Drawing.Point(23, 6);
            this.coldWaterGroupValue.Name = "coldWaterGroupValue";
            this.coldWaterGroupValue.Size = new System.Drawing.Size(60, 13);
            this.coldWaterGroupValue.TabIndex = 4;
            this.coldWaterGroupValue.Text = "Cold water:";
            // 
            // coldWaterOldValue
            // 
            this.coldWaterOldValue.AutoSize = true;
            this.coldWaterOldValue.Location = new System.Drawing.Point(24, 43);
            this.coldWaterOldValue.Name = "coldWaterOldValue";
            this.coldWaterOldValue.Size = new System.Drawing.Size(26, 13);
            this.coldWaterOldValue.TabIndex = 3;
            this.coldWaterOldValue.Text = "Old:";
            // 
            // coldWaterNewLabel
            // 
            this.coldWaterNewLabel.AutoSize = true;
            this.coldWaterNewLabel.Location = new System.Drawing.Point(21, 75);
            this.coldWaterNewLabel.Name = "coldWaterNewLabel";
            this.coldWaterNewLabel.Size = new System.Drawing.Size(32, 13);
            this.coldWaterNewLabel.TabIndex = 2;
            this.coldWaterNewLabel.Text = "New:";
            // 
            // coldWaterNewCount
            // 
            this.coldWaterNewCount.Location = new System.Drawing.Point(63, 73);
            this.coldWaterNewCount.Name = "coldWaterNewCount";
            this.coldWaterNewCount.Size = new System.Drawing.Size(73, 20);
            this.coldWaterNewCount.TabIndex = 2;
            this.coldWaterNewCount.TextChanged += new System.EventHandler(this.validateInputData);
            // 
            // countersLabel
            // 
            this.countersLabel.AutoSize = true;
            this.countersLabel.Location = new System.Drawing.Point(28, 95);
            this.countersLabel.Name = "countersLabel";
            this.countersLabel.Size = new System.Drawing.Size(52, 13);
            this.countersLabel.TabIndex = 5;
            this.countersLabel.Text = "Counters:";
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(30, 443);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 23);
            this.buttonNew.TabIndex = 6;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // pricesBox
            // 
            this.pricesBox.Controls.Add(this.radioButton4);
            this.pricesBox.Controls.Add(this.radioButton3);
            this.pricesBox.Controls.Add(this.radioButton2);
            this.pricesBox.Controls.Add(this.radioButton1);
            this.pricesBox.Location = new System.Drawing.Point(394, 117);
            this.pricesBox.Name = "pricesBox";
            this.pricesBox.Size = new System.Drawing.Size(103, 111);
            this.pricesBox.TabIndex = 7;
            this.pricesBox.TabStop = false;
            this.pricesBox.Text = "Prices:";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(14, 91);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(46, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "1.15";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(14, 66);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(31, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "1";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(14, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(40, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "0.9";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(14, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(40, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "0.8";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            this.calculateButton.Enabled = false;
            this.calculateButton.Location = new System.Drawing.Point(118, 443);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.billLabel);
            this.panel1.Controls.Add(this.bill);
            this.panel1.Controls.Add(this.nameAndCustomerNumberLabel);
            this.panel1.Controls.Add(this.nameAndCustomerNumber);
            this.panel1.Location = new System.Drawing.Point(30, 275);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 113);
            this.panel1.TabIndex = 9;
            // 
            // billLabel
            // 
            this.billLabel.AutoSize = true;
            this.billLabel.Location = new System.Drawing.Point(129, 73);
            this.billLabel.Name = "billLabel";
            this.billLabel.Size = new System.Drawing.Size(31, 13);
            this.billLabel.TabIndex = 3;
            this.billLabel.Text = "Sum:";
            // 
            // bill
            // 
            this.bill.Enabled = false;
            this.bill.Location = new System.Drawing.Point(170, 71);
            this.bill.Name = "bill";
            this.bill.Size = new System.Drawing.Size(100, 20);
            this.bill.TabIndex = 2;
            // 
            // nameAndCustomerNumberLabel
            // 
            this.nameAndCustomerNumberLabel.AutoSize = true;
            this.nameAndCustomerNumberLabel.Location = new System.Drawing.Point(14, 32);
            this.nameAndCustomerNumberLabel.Name = "nameAndCustomerNumberLabel";
            this.nameAndCustomerNumberLabel.Size = new System.Drawing.Size(143, 13);
            this.nameAndCustomerNumberLabel.TabIndex = 1;
            this.nameAndCustomerNumberLabel.Text = "Name and customer number:";
            // 
            // nameAndCustomerNumber
            // 
            this.nameAndCustomerNumber.Enabled = false;
            this.nameAndCustomerNumber.Location = new System.Drawing.Point(170, 32);
            this.nameAndCustomerNumber.Name = "nameAndCustomerNumber";
            this.nameAndCustomerNumber.Size = new System.Drawing.Size(230, 20);
            this.nameAndCustomerNumber.TabIndex = 0;
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Location = new System.Drawing.Point(31, 256);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(45, 13);
            this.resultsLabel.TabIndex = 10;
            this.resultsLabel.Text = "Results:";
            // 
            // incorrectDataError
            // 
            this.incorrectDataError.AutoSize = true;
            this.incorrectDataError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.incorrectDataError.ForeColor = System.Drawing.Color.Red;
            this.incorrectDataError.Location = new System.Drawing.Point(33, 405);
            this.incorrectDataError.Name = "incorrectDataError";
            this.incorrectDataError.Size = new System.Drawing.Size(405, 13);
            this.incorrectDataError.TabIndex = 11;
            this.incorrectDataError.Text = "Incorrect data.  New counter value must be greated or equal than old!";
            this.incorrectDataError.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 483);
            this.Controls.Add(this.incorrectDataError);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.pricesBox);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.countersLabel);
            this.Controls.Add(this.countersPanel);
            this.Controls.Add(this.customerNumberLabel);
            this.Controls.Add(this.customerNumber);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.customerName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.countersPanel.ResumeLayout(false);
            this.countersPanel.PerformLayout();
            this.pricesBox.ResumeLayout(false);
            this.pricesBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox customerNumber;
        private System.Windows.Forms.Label customerNumberLabel;
        private System.Windows.Forms.Panel countersPanel;
        private System.Windows.Forms.Label countersLabel;
        private System.Windows.Forms.Label coldWaterGroupValue;
        private System.Windows.Forms.Label coldWaterOldValue;
        private System.Windows.Forms.Label coldWaterNewLabel;
        private System.Windows.Forms.TextBox coldWaterNewCount;
        private System.Windows.Forms.Label warmWaterLabel;
        private System.Windows.Forms.TextBox warmWaterOldCount;
        private System.Windows.Forms.Label warmWaterOldLabel;
        private System.Windows.Forms.TextBox warmWaterNewCount;
        private System.Windows.Forms.Label warmWaterNewLabel;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.GroupBox pricesBox;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Label billLabel;
        private System.Windows.Forms.TextBox bill;
        private System.Windows.Forms.Label nameAndCustomerNumberLabel;
        private System.Windows.Forms.TextBox nameAndCustomerNumber;
        private System.Windows.Forms.TextBox coldWaterOldCount;
        private System.Windows.Forms.Label incorrectDataError;
    }
}

