using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
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
                    if (str[^1] == '+' || str[^1] == '-' || str[^1] == '*' || str[^1] == '/')
                    {
                        if (str[^2] == '+' || str[^2] == '-' || str[^2] == '*' || str[^2] == '/')
                        {
                            str = str[..^2];
                        }
                        else
                        {
                            str = str[..^1];
                        }
                    }
                    str = str.Replace(',', '.');

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

                    resultUser = true;
                }
            }
            catch (Exception ex) { _ = MessageBox.Show(ex.Message,"Ошибка!"); }
        }
    }
}
