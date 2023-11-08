using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLApp.Constants
{
    internal class ExcelTools
    {
        public static void AdjustRowHeight(Worksheet sheet, int row, double height)
        {
            sheet.Range[row.ToString() + ":" + row.ToString()].RowHeight = height;

        }
    }
}
