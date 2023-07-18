namespace SimpleCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            firstNumber = new Label();
            secondNumber = new Label();
            result = new Label();
            addButton = new Button();
            subtractButton = new Button();
            multiplyButton = new Button();
            divideButton = new Button();
            firstNumberBox = new TextBox();
            secondNumberBox = new TextBox();
            resultTextBox = new TextBox();
            SuspendLayout();
            // 
            // firstNumber
            // 
            firstNumber.AutoSize = true;
            firstNumber.Location = new Point(41, 121);
            firstNumber.Name = "firstNumber";
            firstNumber.Size = new Size(190, 41);
            firstNumber.TabIndex = 0;
            firstNumber.Text = "First Number";
            // 
            // secondNumber
            // 
            secondNumber.AutoSize = true;
            secondNumber.Location = new Point(41, 196);
            secondNumber.Name = "secondNumber";
            secondNumber.Size = new Size(234, 41);
            secondNumber.TabIndex = 1;
            secondNumber.Text = "Second Number";
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(377, 395);
            result.Name = "result";
            result.Size = new Size(98, 41);
            result.TabIndex = 2;
            result.Text = "Result";
            // 
            // addButton
            // 
            addButton.BackColor = SystemColors.ButtonShadow;
            addButton.Location = new Point(41, 320);
            addButton.Name = "addButton";
            addButton.Size = new Size(188, 58);
            addButton.TabIndex = 5;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // subtractButton
            // 
            subtractButton.BackColor = SystemColors.ButtonShadow;
            subtractButton.Location = new Point(41, 385);
            subtractButton.Name = "subtractButton";
            subtractButton.Size = new Size(188, 58);
            subtractButton.TabIndex = 6;
            subtractButton.Text = "Subtract";
            subtractButton.UseVisualStyleBackColor = false;
            subtractButton.Click += subtractButton_Click;
            // 
            // multiplyButton
            // 
            multiplyButton.BackColor = SystemColors.ButtonShadow;
            multiplyButton.Location = new Point(41, 449);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(188, 58);
            multiplyButton.TabIndex = 7;
            multiplyButton.Text = "Multiply";
            multiplyButton.UseVisualStyleBackColor = false;
            multiplyButton.Click += multiplyButton_Click;
            // 
            // divideButton
            // 
            divideButton.BackColor = SystemColors.ButtonShadow;
            divideButton.Location = new Point(41, 513);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(188, 58);
            divideButton.TabIndex = 8;
            divideButton.Text = "Divide";
            divideButton.UseVisualStyleBackColor = false;
            divideButton.Click += divideButton_Click;
            // 
            // firstNumberBox
            // 
            firstNumberBox.Location = new Point(330, 121);
            firstNumberBox.Name = "firstNumberBox";
            firstNumberBox.Size = new Size(250, 47);
            firstNumberBox.TabIndex = 10;
            // 
            // secondNumberBox
            // 
            secondNumberBox.Location = new Point(330, 196);
            secondNumberBox.Name = "secondNumberBox";
            secondNumberBox.Size = new Size(250, 47);
            secondNumberBox.TabIndex = 11;
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(340, 455);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(250, 47);
            resultTextBox.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 625);
            Controls.Add(resultTextBox);
            Controls.Add(secondNumberBox);
            Controls.Add(firstNumberBox);
            Controls.Add(divideButton);
            Controls.Add(multiplyButton);
            Controls.Add(subtractButton);
            Controls.Add(addButton);
            Controls.Add(result);
            Controls.Add(secondNumber);
            Controls.Add(firstNumber);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNumber;
        private Label secondNumber;
        private Label result;
        private Button addButton;
        private Button subtractButton;
        private Button multiplyButton;
        private Button divideButton;
        private TextBox firstNumberBox;
        private TextBox secondNumberBox;
        private TextBox resultTextBox;
    }
}