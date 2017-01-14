using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace sofiaWater
{
    public partial class Form1 : Form
    {
        // we will use this like a storage 
        // for all patterns.
        private Dictionary<string, string> patterns;

        public Form1()
        {
            InitializeComponent();
            string numericPattern = "^[1-9]+[0-9]*$";
            this.Text = "Collector of data for Sofia Water company.";
            this.resetForm();
            this.patterns = new Dictionary<string, string>();
            this.patterns.Add(customerNumber.Name.ToString(), "^[0-9]{4}$");
            // The idea here is to made check multilintuage. This will ensure that
            // pattern will match three names of every alphabet. For example:
            // First Second Thirth or Първо Второ Трето. 
            // This will match [Uppercase letter][repetition of lower case letters] three times.
            this.patterns.Add(customerName.Name.ToString(), @"^(?:[\p{Lu}][\p{Ll}]+ ){2}[\p{Lu}][\p{Ll}]+$");
            this.patterns.Add(coldWaterOldCount.Name.ToString(), numericPattern);
            this.patterns.Add(coldWaterNewCount.Name.ToString(), numericPattern);
            this.patterns.Add(warmWaterOldCount.Name.ToString(), numericPattern);
            this.patterns.Add(warmWaterNewCount.Name.ToString(), numericPattern);
        }

        private void RecursivelyHadnleTextBoxes(Control c)
        {
            for (int x = 0; x < c.Controls.Count; x++)
            {
                if (c.Controls.Count > 0)
                {
                    RecursivelyHadnleTextBoxes(c.Controls[x]);
                }
            }

            if (c is TextBox)
            {
                c.Text = String.Empty;
                c.BackColor = SystemColors.Window;
                c.Tag = false;
            }
        }

        private bool isDataCorrect()
        {
            return (bool)customerNumber.Tag &&
                   (bool)customerName.Tag &&
                   (bool)coldWaterOldCount.Tag &&
                   (bool)coldWaterNewCount.Tag &&
                   (bool)warmWaterOldCount.Tag &&
                   (bool)warmWaterNewCount.Tag;
        }

        private void resetForm()
        {
            RecursivelyHadnleTextBoxes(this);
            calculateButton.Enabled = false;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            this.resetForm();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int oldColdWaterValue, newColdWaterValue, oldWarmWaterValue, newWarmWaterValue;
            double selectedPrice, resultPrice;
            StringBuilder fullNameAndCustomerNumber = new StringBuilder();
            selectedPrice = double.Parse(pricesBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text);
            oldColdWaterValue = int.Parse(coldWaterOldCount.Text);
            newColdWaterValue = int.Parse(coldWaterNewCount.Text);
            oldWarmWaterValue = int.Parse(warmWaterOldCount.Text);
            newWarmWaterValue = int.Parse(warmWaterNewCount.Text);
            if (newColdWaterValue >= oldColdWaterValue && newWarmWaterValue >= oldWarmWaterValue)
            {
                resultPrice = ((newColdWaterValue - oldColdWaterValue) + (newWarmWaterValue - oldWarmWaterValue)) * selectedPrice;
                bill.Text = resultPrice.ToString();
                fullNameAndCustomerNumber.Append(customerName.Text);
                fullNameAndCustomerNumber.Append(" ");
                fullNameAndCustomerNumber.Append(customerNumber.Text);
                nameAndCustomerNumber.Text = fullNameAndCustomerNumber.ToString();
            } else
            {
                incorrectDataError.Visible = true;
            }
        }


        private void validateInputData(object inputObject, EventArgs e)
        {
            TextBox sender = inputObject as TextBox;
            if (Regex.IsMatch(sender.Text, this.patterns[sender.Name.ToString()]))
            {
                sender.BackColor = SystemColors.Window;
                sender.Tag = true;
            }
            else
            {
                sender.BackColor = Color.Red;
                sender.Tag = false;
            }

            incorrectDataError.Visible = false;
            calculateButton.Enabled = this.isDataCorrect();
        }
    }
}
