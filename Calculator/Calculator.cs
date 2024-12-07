using System.Data;

namespace Calculator
{
    public partial class Calculator : Form
    {
        Count calculatorUser = new Count();
        public Calculator()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            resultWindow.Clear();
        }

        private void eraseButton_Click(object sender, EventArgs e)
        {
            if (resultWindow.Text.Length > 0) resultWindow.Text = resultWindow.Text[..^1].ToString();
        }

        private void buttonNumberOne_Click(object sender, EventArgs e)
        {
            if (calculatorUser.resultUser)
            {
                resultWindow.Text = "1";
                calculatorUser.resultUser = false;
            }
            else
            {
                resultWindow.Text += "1";
            }
        }

        private void buttonNumberTwo_Click(object sender, EventArgs e)
        {
            if (calculatorUser.resultUser)
            {
                resultWindow.Text = "2";
                calculatorUser.resultUser = false;
            }
            else
            {
                resultWindow.Text += "2";
            }
        }

        private void buttonNumberThree_Click(object sender, EventArgs e)
        {
            if (calculatorUser.resultUser)
            {
                resultWindow.Text = "3";
                calculatorUser.resultUser = false;
            }
            else
            {
                resultWindow.Text += "3";
            }
        }

        private void buttonNumberFour_Click(object sender, EventArgs e)
        {
            if (calculatorUser.resultUser)
            {
                resultWindow.Text = "4";
                calculatorUser.resultUser = false;
            }
            else
            {
                resultWindow.Text += "4";
            }
        }

        private void buttonNumberFive_Click(object sender, EventArgs e)
        {
            if (calculatorUser.resultUser)
            {
                resultWindow.Text = "5";
                calculatorUser.resultUser = false;
            }
            else
            {
                resultWindow.Text += "5";
            }
        }

        private void buttonNumberSix_Click(object sender, EventArgs e)
        {
            if (calculatorUser.resultUser)
            {
                resultWindow.Text = "6";
                calculatorUser.resultUser = false;
            }
            else
            {
                resultWindow.Text += "6";
            }
        }

        private void buttonNumberSeven_Click(object sender, EventArgs e)
        {
            if (calculatorUser.resultUser)
            {
                resultWindow.Text = "7";
                calculatorUser.resultUser = false;
            }
            else
            {
                resultWindow.Text += "7";
            }
        }

        private void buttonNumberEight_Click(object sender, EventArgs e)
        {
            if (calculatorUser.resultUser)
            {
                resultWindow.Text = "8";
                calculatorUser.resultUser = false;
            }
            else
            {
                resultWindow.Text += "8";
            }
        }

        private void buttonNumberNine_Click(object sender, EventArgs e)
        {
            if (calculatorUser.resultUser)
            {
                resultWindow.Text = "9";
                calculatorUser.resultUser = false;
            }
            else
            {
                resultWindow.Text += "9";
            }
        }

        private void buttonNumberNull_Click(object sender, EventArgs e)
        {
            if (calculatorUser.resultUser)
            {
                resultWindow.Text = "0";
                calculatorUser.resultUser = false;
            }
            else
            {
                resultWindow.Text += "0";
            }
        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            try
            {
                actionButton('+');
            }
            catch { }
        }

        private void subtractionButton_Click(object sender, EventArgs e)
        {
            try
            {
                actionButton('-');
            }
            catch { }
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            try
            {
                actionButton('*');
            }
            catch { }
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            try
            {
                actionButton('/');
            }
            catch { }
        }

        public void actionButton(char c)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(resultWindow.Text))
                {
                    if (resultWindow.Text[^1] == '+' || resultWindow.Text[^1] == '-' || resultWindow.Text[^1] == '*' || resultWindow.Text[^1] == '/')
                    {
                        resultWindow.Text = resultWindow.Text[..^1].ToString() + c;
                    }
                    else
                    {
                        resultWindow.Text += c;
                    }
                }
            }
            catch { }
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            string str = resultWindow.Text;
            calculatorUser.CalculateMethod(ref str);
            resultWindow.Text = str;
        }
    }
}
