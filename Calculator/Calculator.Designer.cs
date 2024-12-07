namespace Calculator
{
    partial class Calculator
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
            resultWindow = new TextBox();
            buttonNumberOne = new Button();
            buttonNumberTwo = new Button();
            buttonNumberThree = new Button();
            buttonNumberSix = new Button();
            buttonNumberFive = new Button();
            buttonNumberFour = new Button();
            buttonNumberNine = new Button();
            buttonNumberEight = new Button();
            buttonNumberSeven = new Button();
            clearButton = new Button();
            eraseButton = new Button();
            resultButton = new Button();
            buttonNumberNull = new Button();
            additionButton = new Button();
            subtractionButton = new Button();
            multiplicationButton = new Button();
            divisionButton = new Button();
            SuspendLayout();
            // 
            // resultWindow
            // 
            resultWindow.BorderStyle = BorderStyle.None;
            resultWindow.Location = new Point(12, 12);
            resultWindow.Multiline = true;
            resultWindow.Name = "resultWindow";
            resultWindow.ReadOnly = true;
            resultWindow.Size = new Size(320, 70);
            resultWindow.TabIndex = 0;
            // 
            // buttonNumberOne
            // 
            buttonNumberOne.Location = new Point(12, 169);
            buttonNumberOne.Name = "buttonNumberOne";
            buttonNumberOne.Size = new Size(75, 75);
            buttonNumberOne.TabIndex = 1;
            buttonNumberOne.Text = "1";
            buttonNumberOne.UseVisualStyleBackColor = true;
            buttonNumberOne.Click += buttonNumberOne_Click;
            // 
            // buttonNumberTwo
            // 
            buttonNumberTwo.Location = new Point(93, 169);
            buttonNumberTwo.Name = "buttonNumberTwo";
            buttonNumberTwo.Size = new Size(75, 75);
            buttonNumberTwo.TabIndex = 2;
            buttonNumberTwo.Text = "2";
            buttonNumberTwo.UseVisualStyleBackColor = true;
            buttonNumberTwo.Click += buttonNumberTwo_Click;
            // 
            // buttonNumberThree
            // 
            buttonNumberThree.Location = new Point(174, 169);
            buttonNumberThree.Name = "buttonNumberThree";
            buttonNumberThree.Size = new Size(75, 75);
            buttonNumberThree.TabIndex = 3;
            buttonNumberThree.Text = "3";
            buttonNumberThree.UseVisualStyleBackColor = true;
            buttonNumberThree.Click += buttonNumberThree_Click;
            // 
            // buttonNumberSix
            // 
            buttonNumberSix.Location = new Point(12, 250);
            buttonNumberSix.Name = "buttonNumberSix";
            buttonNumberSix.Size = new Size(75, 75);
            buttonNumberSix.TabIndex = 4;
            buttonNumberSix.Text = "6";
            buttonNumberSix.UseVisualStyleBackColor = true;
            buttonNumberSix.Click += buttonNumberSix_Click;
            // 
            // buttonNumberFive
            // 
            buttonNumberFive.Location = new Point(93, 250);
            buttonNumberFive.Name = "buttonNumberFive";
            buttonNumberFive.Size = new Size(75, 75);
            buttonNumberFive.TabIndex = 5;
            buttonNumberFive.Text = "5";
            buttonNumberFive.UseVisualStyleBackColor = true;
            buttonNumberFive.Click += buttonNumberFive_Click;
            // 
            // buttonNumberFour
            // 
            buttonNumberFour.Location = new Point(176, 250);
            buttonNumberFour.Name = "buttonNumberFour";
            buttonNumberFour.Size = new Size(75, 75);
            buttonNumberFour.TabIndex = 6;
            buttonNumberFour.Text = "4";
            buttonNumberFour.UseVisualStyleBackColor = true;
            buttonNumberFour.Click += buttonNumberFour_Click;
            // 
            // buttonNumberNine
            // 
            buttonNumberNine.Location = new Point(176, 331);
            buttonNumberNine.Name = "buttonNumberNine";
            buttonNumberNine.Size = new Size(75, 75);
            buttonNumberNine.TabIndex = 7;
            buttonNumberNine.Text = "9";
            buttonNumberNine.UseVisualStyleBackColor = true;
            buttonNumberNine.Click += buttonNumberNine_Click;
            // 
            // buttonNumberEight
            // 
            buttonNumberEight.Location = new Point(93, 331);
            buttonNumberEight.Name = "buttonNumberEight";
            buttonNumberEight.Size = new Size(75, 75);
            buttonNumberEight.TabIndex = 8;
            buttonNumberEight.Text = "8";
            buttonNumberEight.UseVisualStyleBackColor = true;
            buttonNumberEight.Click += buttonNumberEight_Click;
            // 
            // buttonNumberSeven
            // 
            buttonNumberSeven.Location = new Point(12, 331);
            buttonNumberSeven.Name = "buttonNumberSeven";
            buttonNumberSeven.Size = new Size(75, 75);
            buttonNumberSeven.TabIndex = 9;
            buttonNumberSeven.Text = "7";
            buttonNumberSeven.UseVisualStyleBackColor = true;
            buttonNumberSeven.Click += buttonNumberSeven_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(12, 88);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 75);
            clearButton.TabIndex = 10;
            clearButton.Text = "C";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // eraseButton
            // 
            eraseButton.Location = new Point(93, 88);
            eraseButton.Name = "eraseButton";
            eraseButton.Size = new Size(156, 75);
            eraseButton.TabIndex = 11;
            eraseButton.Text = ">";
            eraseButton.UseVisualStyleBackColor = true;
            eraseButton.Click += eraseButton_Click;
            // 
            // resultButton
            // 
            resultButton.Location = new Point(93, 412);
            resultButton.Name = "resultButton";
            resultButton.Size = new Size(239, 75);
            resultButton.TabIndex = 12;
            resultButton.Text = "Result";
            resultButton.UseVisualStyleBackColor = true;
            // 
            // buttonNumberNull
            // 
            buttonNumberNull.Location = new Point(12, 412);
            buttonNumberNull.Name = "buttonNumberNull";
            buttonNumberNull.Size = new Size(75, 75);
            buttonNumberNull.TabIndex = 13;
            buttonNumberNull.Text = "0";
            buttonNumberNull.UseVisualStyleBackColor = true;
            buttonNumberNull.Click += buttonNumberNull_Click;
            // 
            // additionButton
            // 
            additionButton.Location = new Point(257, 331);
            additionButton.Name = "additionButton";
            additionButton.Size = new Size(75, 75);
            additionButton.TabIndex = 14;
            additionButton.Text = "+";
            additionButton.UseVisualStyleBackColor = true;
            additionButton.Click += additionButton_Click;
            // 
            // subtractionButton
            // 
            subtractionButton.Location = new Point(257, 250);
            subtractionButton.Name = "subtractionButton";
            subtractionButton.Size = new Size(75, 75);
            subtractionButton.TabIndex = 15;
            subtractionButton.Text = "-";
            subtractionButton.UseVisualStyleBackColor = true;
            subtractionButton.Click += subtractionButton_Click;
            // 
            // multiplicationButton
            // 
            multiplicationButton.Location = new Point(257, 169);
            multiplicationButton.Name = "multiplicationButton";
            multiplicationButton.Size = new Size(75, 75);
            multiplicationButton.TabIndex = 16;
            multiplicationButton.Text = "*";
            multiplicationButton.UseVisualStyleBackColor = true;
            multiplicationButton.Click += multiplicationButton_Click;
            // 
            // divisionButton
            // 
            divisionButton.Location = new Point(257, 88);
            divisionButton.Name = "divisionButton";
            divisionButton.Size = new Size(75, 75);
            divisionButton.TabIndex = 17;
            divisionButton.Text = "/";
            divisionButton.UseVisualStyleBackColor = true;
            divisionButton.Click += divisionButton_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 536);
            Controls.Add(divisionButton);
            Controls.Add(multiplicationButton);
            Controls.Add(subtractionButton);
            Controls.Add(additionButton);
            Controls.Add(buttonNumberNull);
            Controls.Add(resultButton);
            Controls.Add(eraseButton);
            Controls.Add(clearButton);
            Controls.Add(buttonNumberSeven);
            Controls.Add(buttonNumberEight);
            Controls.Add(buttonNumberNine);
            Controls.Add(buttonNumberFour);
            Controls.Add(buttonNumberFive);
            Controls.Add(buttonNumberSix);
            Controls.Add(buttonNumberThree);
            Controls.Add(buttonNumberTwo);
            Controls.Add(buttonNumberOne);
            Controls.Add(resultWindow);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Calculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox resultWindow;
        private Button buttonNumberOne;
        private Button buttonNumberTwo;
        private Button buttonNumberThree;
        private Button buttonNumberSix;
        private Button buttonNumberFive;
        private Button buttonNumberFour;
        private Button buttonNumberNine;
        private Button buttonNumberEight;
        private Button buttonNumberSeven;
        private Button clearButton;
        private Button eraseButton;
        private Button resultButton;
        private Button buttonNumberNull;
        private Button additionButton;
        private Button subtractionButton;
        private Button multiplicationButton;
        private Button divisionButton;
    }
}
