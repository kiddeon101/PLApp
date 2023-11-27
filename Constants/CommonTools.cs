using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLApp.Constants
{
    internal class CommonTools
    {
        internal static string ConvertToString(object str)
        {
            try
            {
                if (String.IsNullOrEmpty(Convert.ToString(str)))
                {
                    return "";
                }
                else
                {
                    return str.ToString();
                }
            }
            catch (Exception ex)
            {

            }
            return "";
        }
        internal static int RoundUp(double dbl)
        {
            if (dbl == 0)
            {
                return 1;
            }
            double rounded = Math.Round(dbl);
            if (rounded < dbl || rounded == 0)
            {
                rounded = rounded + 1;
            }


            return (int)rounded;
        }
        internal static DateTime ConvertToDate(object date)
        {
            if(date == null)
            {
                 return DateTime.Parse("01/01/0001");
            }
            try
            {
                DateTime time = DateTime.Parse(date.ToString());
                return time;
            }
            catch (Exception)
            {
                try
                {
                    return DateTime.FromOADate(Convert.ToDouble(date));
                }
                catch (Exception)
                {
                    return DateTime.Parse("01/01/0001");
                }
            }
        }


        internal static DateTime dateParseBeginning(DateTime dateTime)
        {
            string format = "d/M/yyyy";
            DateTime dtBeginning = DateTime.ParseExact(string.Format("{0}/{1}/{2}", 1, dateTime.Month, dateTime.Year), format, CultureInfo.InvariantCulture);
            return GetDateMin(dtBeginning);
        }

        internal static DateTime dateParseEnding(DateTime dateString)
        {
            string format = "d/M/yyyy";
            DateTime dtBeginning = DateTime.ParseExact(string.Format("{0}/{1}/{2}", DateTime.DaysInMonth(dateString.Year, dateString.Month), dateString.Month, dateString.Year), format, CultureInfo.InvariantCulture);
            return GetDateMax(dtBeginning);
        }

        internal static DateTime GetDateMin(DateTime dateTime)
        {
            return dateTime.Date;
        }
        internal static DateTime GetDateMax(DateTime dateTime)
        {
            return dateTime.Date.AddHours(23).AddMinutes(59);
        }

        internal static double ConvertToDouble(object dbl)
        {
            double dblParsed = 0;
            try
            {
                if (dbl != null && double.TryParse(dbl.ToString(), out dblParsed))
                {
                    return dblParsed;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

        internal static int ConvertToInt(object dbl)
        {
            int dblParsed = 0;
            try
            {
                if (dbl != null &&  int.TryParse(dbl.ToString(), out dblParsed))
                {
                    return dblParsed;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        internal static bool ConvertToBool(object bl)
        {
            bool blc = false;
            try
            {
                if (bl != null &&  bool.TryParse(bl.ToString(), out blc))
                {
                    return blc;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
