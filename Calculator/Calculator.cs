﻿using System.Data;
using System.Text.RegularExpressions;

namespace Calculator
{
    public partial class Calculator : Form
    {
        Count calculatorUser = new Count();
        public Calculator()
        {
            InitializeComponent();

            calculatorUser.resultUser = true;
            resultWindow.Text = "0";
            windowLabel.Text = "";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            resultWindow.Text = "0";
            windowLabel.Text = "";

            calculatorUser.resultUser = true;
        }

        private void eraseButton_Click(object sender, EventArgs e)
        {
            if (resultWindow.Text.Length > 0)
                resultWindow.Text = resultWindow.Text[..^1].ToString();
            calculatorUser.resultUser = false;

            if (resultWindow.TextLength == 0)
            {
                resultWindow.Text = "0";
                calculatorUser.resultUser = true;
            }
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

        private void buttonComma_Click(object sender, EventArgs e)
        {
            try
            {
                comma();
            }
            catch { }
        }

        private void actionButton(char c)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(resultWindow.Text) && resultWindow.Text != "Деление на ноль!" && resultWindow.Text != "Не определено!")
                {
                    if (calculatorUser.resultUser) calculatorUser.resultUser = false;

                    if (c == '-' && resultWindow.Text == "0") { resultWindow.Text = c.ToString(); calculatorUser.resultUser = false; }

                    if (c != '√')
                    {
                        if (resultWindow.Text[^1] == '√' && (c == '+' || c == '*' || c == '/' || c == '^'))
                        {

                        }
                        else if ((resultWindow.Text[^1] == '+' || resultWindow.Text[^1] == '*' || resultWindow.Text[^1] == '-' || resultWindow.Text[^1] == '/' || resultWindow.Text[^1] == '^') && c == '-')
                        {
                            if (resultWindow.Text[^2] != '+' && resultWindow.Text[^2] != '*' && resultWindow.Text[^2] != '-' && resultWindow.Text[^2] != '/' && resultWindow.Text[^2] == '^')
                            {
                                resultWindow.Text += c;
                            }
                        }
                        else if (resultWindow.Text[^1] == '+' || resultWindow.Text[^1] == '-' || resultWindow.Text[^1] == '*' || resultWindow.Text[^1] == '/' || resultWindow.Text[^1] == '^')
                        {
                            if (resultWindow.Text[^2] == '+' || resultWindow.Text[^2] == '-' || resultWindow.Text[^2] == '*' || resultWindow.Text[^2] == '/' || resultWindow.Text[^2] == '^')
                            {
                                resultWindow.Text = resultWindow.Text[..^2].ToString() + c;
                            }
                            else
                            {
                                resultWindow.Text = resultWindow.Text[..^1].ToString() + c;
                            }
                        }
                        else
                        {
                            resultWindow.Text += c;
                        }
                    }
                    else
                    {
                        if (resultWindow.Text.Length == 1 && resultWindow.Text[^1] == '0')
                        {
                            resultWindow.Text = "√";
                        }
                        else
                        {
                            if (resultWindow.Text[^1] == '+' || resultWindow.Text[^1] == '*' || resultWindow.Text[^1] == '-' || resultWindow.Text[^1] == '/' || resultWindow.Text[^1] == '^' || resultWindow.Text[^1] == '√')
                            {
                                if (resultWindow.Text[^2] == '+' || resultWindow.Text[^2] == '-' || resultWindow.Text[^2] == '*' || resultWindow.Text[^2] == '/' || resultWindow.Text[^2] == '^')
                                {
                                    resultWindow.Text = resultWindow.Text[..^1].ToString() + "√";
                                }
                                else
                                {
                                    resultWindow.Text += "√";
                                }
                            }
                            else
                                resultWindow.Text += "*√";
                        }
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

        private void comma()
        {
            try
            {
                char[] c = { '+', '-', '*', '/' };

                if (resultWindow.Text[^1] != ',' && resultWindow.Text[^1] != '+' && resultWindow.Text[^1] != '-' && resultWindow.Text[^1] != '*' && resultWindow.Text[^1] != '/')
                {
                    string[] str = resultWindow.Text.Split(c);

                    if (!str[str.Length - 1].Contains(','))
                    {
                        resultWindow.Text += ',';
                    }
                }
            }
            catch (Exception ex) { _ = MessageBox.Show(ex.Message); }
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            string str = resultWindow.Text;
            windowLabel.Text = str;
            calculatorUser.CalculateMethod(ref str);
            resultWindow.Text = str;
        }

        private void buttonRaisingToAPower_Click(object sender, EventArgs e)
        {
            try
            {
                char[] c = { '+', '-', '*', '/' };

                string[] str = resultWindow.Text.Split(c);

                if (str[str.Length - 1].Split('^').Length <= 2)
                {
                    actionButton('^');
                }
            }
            catch { }
        }

        private void RootExtraction_Click(object sender, EventArgs e)
        {
            try
            {
                char[] c = { '+', '-', '*', '/' };

                string[] str = resultWindow.Text.Split(c);

                if (Regex.Replace(str[str.Length - 1], "[0-9]", "", RegexOptions.IgnoreCase).Length <= 2)
                {
                    actionButton('√');
                }
            }
            catch { }
        }
    }
}