using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExcelClass = Microsoft.Office.Interop.Excel;

namespace PLApp.Controller
{
    internal class ExcelManager
    {
        private ExcelClass.Application xlApp;
        private ExcelClass.Workbook xlWorkBook;

        public void OpenExcel(String ExcelPath)
        {
            try
            {
                xlApp = new ExcelClass.Application();
                xlApp.DisplayAlerts = false;
                xlWorkBook = xlApp.Workbooks.Open(ExcelPath);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ExcelClass.Worksheet GetSheet(String sheetName)
        {
            try
            {
                ExcelClass.Worksheet worksheet = (ExcelClass.Worksheet)xlWorkBook.Worksheets.Item[sheetName];
                return worksheet;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ExcelClass.Worksheet GetSheet(int sheetIndex)
        {
            try
            {
                ExcelClass.Worksheet worksheet = (ExcelClass.Worksheet)xlWorkBook.Worksheets.Item[sheetIndex];
                return worksheet;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CloseSheet()
        {
            xlWorkBook.Close();
            xlApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook);
        }

        public void saveExcel(string filePath)
        {
            xlWorkBook.SaveAs(filePath);
        }


    }
}
