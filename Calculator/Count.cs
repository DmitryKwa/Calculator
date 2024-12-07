using System;
using System.Collections.Generic;
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
            if (!string.IsNullOrWhiteSpace(str))
            {
                if (str[^1] == '+' || str[^1] == '-' || str[^1] == '*' || str[^1] == '/')
                {
                    str = str[..^1];
                }
                str = str.Replace(',', '.');

                DataTable dataTable = new DataTable();
                str = dataTable.Compute(str, null).ToString();
                double db = double.Parse(str);
                db = Math.Round(db, 4);
                str = db.ToString();
                resultUser = true;
            }
        }
    }
}
