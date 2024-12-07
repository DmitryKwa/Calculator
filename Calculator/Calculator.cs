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
            numberButton('1');
        }

        private void buttonNumberTwo_Click(object sender, EventArgs e)
        {
            numberButton('2');
        }

        private void buttonNumberThree_Click(object sender, EventArgs e)
        {
            numberButton('3');
        }

        private void buttonNumberFour_Click(object sender, EventArgs e)
        {
            numberButton('4');
        }

        private void buttonNumberFive_Click(object sender, EventArgs e)
        {
            numberButton('5');
        }

        private void buttonNumberSix_Click(object sender, EventArgs e)
        {
            numberButton('6');
        }

        private void buttonNumberSeven_Click(object sender, EventArgs e)
        {
            numberButton('7');
        }

        private void buttonNumberEight_Click(object sender, EventArgs e)
        {
            numberButton('8');
        }

        private void buttonNumberNine_Click(object sender, EventArgs e)
        {
            numberButton('9');
        }

        private void buttonNumberNull_Click(object sender, EventArgs e)
        {
            numberButton('0');
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

        private void actionButton(char c)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(resultWindow.Text))
                {
                    if(calculatorUser.resultUser) calculatorUser.resultUser = false;

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

        private void numberButton(char c)
        {
            try
            {
                if (calculatorUser.resultUser)
                {
                    resultWindow.Text = c.ToString();
                    calculatorUser.resultUser = false;
                }
                else
                {
                    resultWindow.Text += c;
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
