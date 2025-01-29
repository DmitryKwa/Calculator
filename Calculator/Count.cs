using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Count
    {
        public bool resultUser = false;

        public void CalculateMethod(ref string str)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(str))
                {
                    if (str[^1] == '+' || str[^1] == '-' || str[^1] == '*' || str[^1] == '/' || str[^1] == '^')
                    {
                        if (str[^2] == '+' || str[^2] == '-' || str[^2] == '*' || str[^2] == '/' || str[^2] == '^')
                        {
                            str = str[..^2];
                        }
                        else
                        {
                            str = str[..^1];
                        }
                    }

                    //str = RootExtraction(str);

                    str = RaisingToAPower(str);

                    str = RootExtraction(str);

                    str = str.Replace(',', '.');

                    if (str != "Не определено!")
                    {
                        DataTable dataTable = new DataTable();
                        str = dataTable.Compute(str, null).ToString();
                        double db = double.Parse(str);

                        if (double.IsInfinity(db))
                        {
                            str = "Деление на ноль!";
                        }
                        else
                        {
                            db = Math.Round(db, 10);
                            str = db.ToString();
                        }
                    }

                    resultUser = true;
                }
            }
            catch (Exception ex) { _ = MessageBox.Show(ex.Message,"Ошибка!"); }
        }

        private string RaisingToAPower(string s)
        {
            try
            {
                if (s.Contains("^"))
                {
                    char[] c1 = { '+', '-', '*', '/' };

                    string[] str1 = s.Split(c1);
                    
                    string s2 = Regex.Replace(s, "[0-9]", " ", RegexOptions.IgnoreCase);
                    s2 = s2.Replace("^", "");
                    s2 = s2.Replace("  ", " ").Trim();

                    string[] str2 = Regex.Split(s2, " ");

                    for (int i = 0; i < str1.Length; i++)
                    {
                        if (str1[i].Contains('^'))
                        {
                            string[] con = str1[i].Split('^');

                            str1[i] = Math.Pow(double.Parse(con[0]), double.Parse(con[1])).ToString();

                            if (con.Length > 2)
                            {
                                Array.Resize(ref con, con.Length + 1);
                                con[con.Length - 1] = "1";

                                for (int j = 2; j < con.Length; j++) 
                                    str1[i] = Math.Pow(double.Parse(str1[i]), double.Parse(con[j])).ToString();
                            }
                        }
                    }

                    s = str1[0];
                    for (int i = 0; i < str1.Length - 1; i++)
                    {
                        s += str2[i];
                        s += str1[i + 1];
                    }

                    return s;
                } 
                else
                    return s;
            }
            catch (Exception ex) { _ = MessageBox.Show(ex.Message, "Ошибка!"); return s; }
        }

        private string RootExtraction(string s)
        {
            try
            {
                if (s.Contains("√") && !s.Contains("√-"))
                {
                    char[] c1 = { '+', '-', '*', '/' };

                    string[] str1 = s.Split(c1);
                    string s2 = Regex.Replace(s, "[0-9]", " ", RegexOptions.IgnoreCase);
                    s2 = s2.Replace("√", " ").Trim();
                    s2 = s2.Replace("  ", " ").Trim();

                    string[] str2 = Regex.Split(s2, " ");

                    for (int i = 0; i < str1.Length; i++)
                    {
                        if (str1[i].Contains("√"))
                        {
                            str1[i] = str1[i].Replace("√", "");

                            str1[i] = Math.Sqrt(double.Parse(str1[i])).ToString();
                        }
                    }

                    s = str1[0];
                    for (int i = 0; i < str1.Length - 1; i++)
                    {
                        s += str2[i];
                        s += str1[i + 1];
                    }

                    return s;
                }
                else if (s.Contains("√-"))
                {
                    return s = "Не определено!";
                }
                else
                    return s;
            }
            catch (Exception ex) { _ = MessageBox.Show(ex.Message, "Ошибка!"); return s; }
        }
    }
}