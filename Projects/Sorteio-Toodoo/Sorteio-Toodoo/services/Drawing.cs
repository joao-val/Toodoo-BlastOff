using Sorteio_Toodoo.entities;
using System.Collections.Generic;
using OfficeOpenXml;
using System.IO;
using System;

namespace Sorteio_Toodoo.services
{
    public class Drawing
    {
        public Drawing()
        {
            EmployeeList = ExcelControl.ReadExcel("Lista_de_funcionarios.xlsx");
        }

        public List<Employee> EmployeeList { get; set; }

        //public List<Employee> ReadExcel()
        //{
        //    string path = Path.GetFullPath("Lista_de_funcionarios.xlsx");
        //    FileInfo existingFile = new FileInfo(path);

        //    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        //    using (ExcelPackage package = new ExcelPackage(existingFile))
        //    {
        //        ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
        //        int colSize = worksheet.Dimension.End.Column;
        //        int rowSize = worksheet.Dimension.End.Row;

        //        for (int row = 2; row <= rowSize; row++)
        //        {
        //            var employee = new Employee();
        //            employee.Id = row;
        //            employee.Name = worksheet.Cells[row, 1].Value.ToString();

        //            EmployeeList.Add(employee);
        //        }
        //    }

        //    return EmployeeList;
        //}



    }
}
