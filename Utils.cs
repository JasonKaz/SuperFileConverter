using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFileConverter
{
    public static class Utils
    {
        public static string DecimalToPercent(double? dec)
        {
            return string.Format("{0}%", dec * 100);
        }

        public static string DecimalToPercent(string strDec)
        {
            double dec;

            double.TryParse(strDec, out dec);

            return DecimalToPercent(dec);
        }
    }
}
