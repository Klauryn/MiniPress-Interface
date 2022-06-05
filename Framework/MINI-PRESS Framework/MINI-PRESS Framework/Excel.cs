using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace MINI_PRESS_Framework
{
    class Excel
    {
        /***********************************\   CREATE EXCEL APPLICATION    /*****************************************/
        string path = "";
        _Application excel = new _Excel.Application();  //Excel Application oluşturuldu.
        Workbook wb;                                    //Workbook oluşturuldu.
        Worksheet ws;                                   //Worksheet oluşturuldu.
        public Excel()
        {
            ;
        }

        /********************************\   PATH AND SHEET EXCEL CONSTRUCTOR   /*************************************/
        public Excel(string path, int Sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = excel.Worksheets[Sheet];
        }

        /************************************\    CALL ROWS AND COLUMNS   /*******************************************/
        public Tuple<int, int> RowsAndColumns()
        {
            _Excel.Range _Range = ws.UsedRange;
            int nRows = _Range.Rows.Count;
            int nCols = _Range.Columns.Count;
            return new Tuple<int, int>(nRows, nCols);
        }

        /*************************************\     READ CELL    /*******************************************/
        public object ReadCell(int i, int j)
        {

            if (ws.Cells[i, j].Value2 != null)
            {
                object sendData = ws.Cells[i, j].Value2;
                return sendData;
            }
            else
            {
                return "";
            }
        }

        /*************************************\    WRİTE CELL    /*******************************************/
        public void WritetoCell(int i, int j, string value)
        {
            i++; j++;
            ws.Cells[i, j].Value2 = value;
        }

        /*************************************\    SAVE    /*******************************************/
        public void Save()
        {
            wb.Save();
        }

        /*************************************\    SAVE AS    /*******************************************/
        public void SaveAs(string path)
        {
            wb.SaveAs(path);
        }

        /*************************************\    CLOSE    /*******************************************/
        public void Close()
        {
            wb.Close();
        }

        /**********************************\    CREATE NEW FILE    /*******************************************/
        public void CreateNewFile()
        {
            this.wb = excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
        }

        /*public int deneme()
        {
            _Excel.Range _Range = ws.UsedRange;
            int x = _Range.ReadingOrder;
            return x;
        }*/
    }
}

