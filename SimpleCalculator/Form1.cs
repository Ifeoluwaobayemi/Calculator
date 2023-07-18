using System;
using Calculator.Core.Logic;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        Operations operations = new Operations();

        public double Result { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = operations.Add(firstNumberBox.Text, secondNumberBox.Text);
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = operations.Subtract(firstNumberBox.Text, secondNumberBox.Text);
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = operations.Multiply(firstNumberBox.Text, secondNumberBox.Text);
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = operations.Divide(firstNumberBox.Text, secondNumberBox.Text);
        }
    }
}