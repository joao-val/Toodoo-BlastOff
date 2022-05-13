using Sorteio_Toodoo.entities;
using System.Collections.Generic;


namespace Sorteio_Toodoo.services
{
    public class SaveWinners
    {

        public SaveWinners()
        {
            WinnersList = ExcelControl.ReadExcel("Winners_List.xlsx");
        }

        public List<Employee> WinnersList { get; set; }

        //public void Save(Employee employee1)
        //{
        //    string route = "L:\\Joao\\CSharp\\Toodoo\\BlastOff\\Projects\\Lista_de_premiados.xlsx";

        //    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
        //    Microsoft.Office.Interop.Excel.Workbook sheet = excel.Workbooks.Open(route);
        //    Microsoft.Office.Interop.Excel.Worksheet ws = excel.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;

        //    Excel.Range range = ws.UsedRange;
        //    int countRecords = range.Rows.Count;
        //    countRecords++;

        //    ws.Cells[countRecords, 1] = employee1.Name;
        //    sheet.Close(true, Type.Missing, Type.Missing);

        //}

        //public List<Employee> ReadExcel()
        //{
        //    FileInfo existingFile = new FileInfo("L:\\Joao\\CSharp\\Toodoo\\BlastOff\\Projects\\Lista_de_premiados.xlsx");

        //    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        //    using (ExcelPackage package = new ExcelPackage(existingFile))
        //    {
        //        ExcelWorksheet worksheet = package.Workbook.Worksheets["Planilha1"];
        //        int rowSize = worksheet.Dimension.End.Row;

        //        for (int row = 2; row <= rowSize; row++)
        //        {
        //            var employee = new Employee();
        //            employee.Id = row;
        //            employee.Name = worksheet.Cells[row, 1].Value.ToString();

        //            WinnersList.Add(employee);
        //        }
        //    }

        //    return WinnersList;
        //}

        public bool Compare(string name)
        {
            var test = true;
            var employeeList = new Drawing();

            foreach (var winner in WinnersList)
            {
                if (winner.Name.Equals(name))
                {
                    test = false;
                }
            }

            return test;
        }
    }
}
