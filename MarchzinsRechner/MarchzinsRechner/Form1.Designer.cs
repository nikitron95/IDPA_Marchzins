namespace MarchzinsRechner
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
            inputAccountBalance = new TextBox();
            inputBirthday = new TextBox();
            inputInterest = new TextBox();
            outputMarchInterestTextBox = new Label();
            getMarchInterestButton = new Button();
            label1 = new Label();
            Kontostand = new Label();
            label2 = new Label();
            label3 = new Label();
            offsetTaxTextBox = new Label();
            actualInterestTextBox = new Label();
            SuspendLayout();
            // 
            // inputAccountBalance
            // 
            inputAccountBalance.Location = new Point(243, 65);
            inputAccountBalance.Margin = new Padding(2);
            inputAccountBalance.Name = "inputAccountBalance";
            inputAccountBalance.Size = new Size(185, 23);
            inputAccountBalance.TabIndex = 0;
            inputAccountBalance.TextChanged += textBox1_TextChanged;
            // 
            // inputBirthday
            // 
            inputBirthday.Location = new Point(243, 118);
            inputBirthday.Margin = new Padding(2);
            inputBirthday.Name = "inputBirthday";
            inputBirthday.Size = new Size(185, 23);
            inputBirthday.TabIndex = 1;
            inputBirthday.TextChanged += textBox2_TextChanged;
            // 
            // inputInterest
            // 
            inputInterest.Location = new Point(243, 169);
            inputInterest.Margin = new Padding(2);
            inputInterest.Name = "inputInterest";
            inputInterest.Size = new Size(185, 23);
            inputInterest.TabIndex = 2;
            inputInterest.TextChanged += textBox3_TextChanged;
            // 
            // outputMarchInterestTextBox
            // 
            outputMarchInterestTextBox.Anchor = AnchorStyles.Top;
            outputMarchInterestTextBox.AutoSize = true;
            outputMarchInterestTextBox.Location = new Point(301, 234);
            outputMarchInterestTextBox.Margin = new Padding(2, 0, 2, 0);
            outputMarchInterestTextBox.MinimumSize = new Size(21, 0);
            outputMarchInterestTextBox.Name = "outputMarchInterestTextBox";
            outputMarchInterestTextBox.Size = new Size(61, 15);
            outputMarchInterestTextBox.TabIndex = 3;
            outputMarchInterestTextBox.Text = "Marchzins";
            outputMarchInterestTextBox.TextAlign = ContentAlignment.MiddleCenter;
            outputMarchInterestTextBox.Click += outputMarchInterest_Click;
            // 
            // getMarchInterestButton
            // 
            getMarchInterestButton.Location = new Point(253, 199);
            getMarchInterestButton.Margin = new Padding(2);
            getMarchInterestButton.Name = "getMarchInterestButton";
            getMarchInterestButton.Size = new Size(159, 22);
            getMarchInterestButton.TabIndex = 4;
            getMarchInterestButton.Text = "Marchzins Berechnen";
            getMarchInterestButton.UseVisualStyleBackColor = true;
            getMarchInterestButton.Click += getMarchInterest_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(210, 10);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 5;
            // 
            // Kontostand
            // 
            Kontostand.AutoSize = true;
            Kontostand.Location = new Point(243, 45);
            Kontostand.Margin = new Padding(2, 0, 2, 0);
            Kontostand.Name = "Kontostand";
            Kontostand.Size = new Size(68, 15);
            Kontostand.TabIndex = 6;
            Kontostand.Text = "Kontostand";
            Kontostand.Click += Kontostand_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(243, 101);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 7;
            label2.Text = "Geburtsdatum";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(243, 152);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 8;
            label3.Text = "Zins";
            // 
            // offsetTaxTextBox
            // 
            offsetTaxTextBox.Anchor = AnchorStyles.Top;
            offsetTaxTextBox.AutoSize = true;
            offsetTaxTextBox.Location = new Point(278, 261);
            offsetTaxTextBox.Margin = new Padding(2, 0, 2, 0);
            offsetTaxTextBox.MinimumSize = new Size(21, 0);
            offsetTaxTextBox.Name = "offsetTaxTextBox";
            offsetTaxTextBox.Size = new Size(106, 15);
            offsetTaxTextBox.TabIndex = 9;
            offsetTaxTextBox.Text = "Verrechnungsteuer";
            offsetTaxTextBox.TextAlign = ContentAlignment.MiddleCenter;
            offsetTaxTextBox.Click += offsetTaxTextBox_Click;
            // 
            // actualInterestTextBox
            // 
            actualInterestTextBox.Anchor = AnchorStyles.Top;
            actualInterestTextBox.AutoSize = true;
            actualInterestTextBox.Location = new Point(269, 286);
            actualInterestTextBox.Margin = new Padding(2, 0, 2, 0);
            actualInterestTextBox.MinimumSize = new Size(21, 0);
            actualInterestTextBox.Name = "actualInterestTextBox";
            actualInterestTextBox.Size = new Size(124, 15);
            actualInterestTextBox.TabIndex = 10;
            actualInterestTextBox.Text = "Erhaltender Marchzins";
            actualInterestTextBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 337);
            Controls.Add(actualInterestTextBox);
            Controls.Add(offsetTaxTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Kontostand);
            Controls.Add(label1);
            Controls.Add(getMarchInterestButton);
            Controls.Add(outputMarchInterestTextBox);
            Controls.Add(inputInterest);
            Controls.Add(inputBirthday);
            Controls.Add(inputAccountBalance);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputAccountBalance;
        private TextBox inputBirthday;
        private TextBox inputInterest;
        private Label outputMarchInterestTextBox;
        private Button getMarchInterestButton;
        protected Label label1;
        private Label Kontostand;
        private Label label2;
        private Label label3;
        private Label offsetTaxTextBox;
        private Label actualInterestTextBox;
    }
}