namespace Calculator
{
    public partial class Calculator : Form
    {
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
            resultWindow.Text += "1";
        }

        private void buttonNumberTwo_Click(object sender, EventArgs e)
        {
            resultWindow.Text += "2";
        }

        private void buttonNumberThree_Click(object sender, EventArgs e)
        {
            resultWindow.Text += "3";
        }

        private void buttonNumberFour_Click(object sender, EventArgs e)
        {
            resultWindow.Text += "4";
        }

        private void buttonNumberFive_Click(object sender, EventArgs e)
        {
            resultWindow.Text += "5";
        }

        private void buttonNumberSix_Click(object sender, EventArgs e)
        {
            resultWindow.Text += "6";
        }

        private void buttonNumberSeven_Click(object sender, EventArgs e)
        {
            resultWindow.Text += "7";
        }

        private void buttonNumberEight_Click(object sender, EventArgs e)
        {
            resultWindow.Text += "8";
        }

        private void buttonNumberNine_Click(object sender, EventArgs e)
        {
            resultWindow.Text += "9";
        }

        private void buttonNumberNull_Click(object sender, EventArgs e)
        {
            resultWindow.Text += "0";
        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(resultWindow.Text))
                {
                    if (resultWindow.Text[^1] == '+' || resultWindow.Text[^1] == '-' || resultWindow.Text[^1] == '*' || resultWindow.Text[^1] == '/')
                    {
                        if (resultWindow.Text[^2] == '+' || resultWindow.Text[^2] == '-' || resultWindow.Text[^2] == '*' || resultWindow.Text[^2] == '/')
                        {
                            resultWindow.Text = resultWindow.Text[..^2].ToString() + "+";
                        } 
                        else
                        {
                            resultWindow.Text = resultWindow.Text[..^1].ToString() + "+";
                        }
                    }
                    else
                    {
                        resultWindow.Text += "+";
                    }
                }
            }
            catch { }
        }

        private void subtractionButton_Click(object sender, EventArgs e)
        {
            resultWindow.Text += "-";
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(resultWindow.Text))
                {
                    if (resultWindow.Text[^1] == '+' || resultWindow.Text[^1] == '-' || resultWindow.Text[^1] == '*' || resultWindow.Text[^1] == '/')
                    {
                        if (resultWindow.Text[^2] == '+' || resultWindow.Text[^2] == '-' || resultWindow.Text[^2] == '*' || resultWindow.Text[^2] == '/')
                        {
                            resultWindow.Text = resultWindow.Text[..^2].ToString() + "*";
                        }
                        else
                        {
                            resultWindow.Text = resultWindow.Text[..^1].ToString() + "*";
                        }
                    }
                    else
                    {
                        resultWindow.Text += "*";
                    }
                }
            }
            catch { }
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(resultWindow.Text))
                {
                    if (resultWindow.Text[^1] == '+' || resultWindow.Text[^1] == '-' || resultWindow.Text[^1] == '*' || resultWindow.Text[^1] == '/')
                    {
                        if (resultWindow.Text[^2] == '+' || resultWindow.Text[^2] == '-' || resultWindow.Text[^2] == '*' || resultWindow.Text[^2] == '/')
                        {
                            resultWindow.Text = resultWindow.Text[..^2].ToString() + "/";
                        }
                        else
                        {
                            resultWindow.Text = resultWindow.Text[..^1].ToString() + "/";
                        }
                    }
                    else
                    {
                        resultWindow.Text += "/";
                    }
                }
            }
            catch { }
        }
    }
}
