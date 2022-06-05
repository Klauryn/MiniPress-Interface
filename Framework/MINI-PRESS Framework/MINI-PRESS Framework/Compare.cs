using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Forms.DataVisualization.Charting;

namespace MINI_PRESS_Framework
{
    public partial class Compare : Form
    {
        public static Compare instance;
        public string path = Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location).FullName; // return the application.exe current folder

        public Compare()
        {
            InitializeComponent();
            instance = this;
        }

        private void Compare_Load(object sender, EventArgs e)
        {
            string Deneme = "";
        }
        /*************************************\    EXCEL ROWS AND COLUMNS    /*******************************************/
        public void Excel_RowAndColumn()
        {
            string fileName = Path.Combine(path, "Reference\\Açık Tip 7_5 Ton_3.csv"); 
            Excel _excel = new Excel(fileName, 1);
            Tuple<int, int> _tuple = _excel.RowsAndColumns();
            _excel.Save();
            _excel.Close();
        }
        /*************************************\    EXCEL OPEN FILE    /*******************************************/
        public void Excel_OpenFile(string data, string seriesName)
        {
            chart1.Series.Add(seriesName).ChartType = SeriesChartType.Point;
            chart1.Series.FindByName(seriesName).MarkerSize = 3;

            chart1.ChartAreas[0].AxisY.Maximum = 6500;
            chart1.ChartAreas[0].AxisX.Minimum = 230;

            //chart1.Titles.Add("Line Chart Example");

            string fileName = Path.Combine(path, data);
            string[] csvLines = File.ReadAllLines(fileName);
            var firstNames = new List<double>();
            var secondNames = new List<double>();

            for (int i = 1; i < csvLines.Length; i++)
            {
                string[] rowData = csvLines[i].Split(';');
                firstNames.Add(double.Parse(rowData[0]));
                secondNames.Add(double.Parse(rowData[1]));
            }

            Excel _excel = new Excel(fileName, 1);

            for (int i = 1; i < csvLines.Length/*_tuple.Item1*/; i++)
            {
                chart1.Series[seriesName].Points.AddXY(firstNames[i - 1], secondNames[i - 1]);
            }
            _excel.Save();
            _excel.Close();
        }

        /*************************************\    EXCEL WRİTE DATA    /*******************************************/
        public void Excel_WriteData()
        {
            string fileName = Path.Combine(path, "Excel\\Created.xlsx");
            Excel _excel = new Excel(fileName, 1);
            _excel.WritetoCell(0, 0, "kuçu");
            _excel.Save();

            /*fileName = Path.Combine(path, "Excel\\WriteDataTest.xlsx");
            _excel.SaveAs(fileName);*/
            _excel.Close();
        }

        /*************************************\    EXCEL CREATE FILE    /*******************************************/
        public void Excel_CreateFile()
        {
            Excel _excel = new Excel();
            _excel.CreateNewFile();
            string fileName = Path.Combine(path, "Excel\\Created.xlsx");
            _excel.SaveAs(fileName);
            _excel.Close();
        }
        /*************************************\    CALL EXCEL TO CHART    /*******************************************/
        private void button1_Click(object sender, EventArgs e)
        {
            Excel_OpenFile("Reference\\Açık Tip 7_5 Ton_3.csv", "B1");
            Excel_OpenFile("Reference\\Açık Tip 7_5 Ton_2.csv", "B2");
        }
    }
}
