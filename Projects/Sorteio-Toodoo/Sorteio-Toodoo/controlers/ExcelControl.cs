using OfficeOpenXml;
using Sorteio_Toodoo.entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorteio_Toodoo.services
{
    public abstract class ExcelControl
    {
        public static List<Employee> ReadExcel(string fileName)
        {
            var employeeList = new List<Employee>();

            string path = Path.GetFullPath(fileName);
            FileInfo existingFile = new FileInfo(path);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            
            if (existingFile.Exists)
            {
                using (ExcelPackage package = new ExcelPackage(path))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    int colSize = worksheet.Dimension.End.Column;
                    int rowSize = worksheet.Dimension.End.Row;

                    for (int row = 2; row <= rowSize; row++)
                    {
                        var employee = new Employee();
                        employee.Id = row;
                        employee.Name = worksheet.Cells[row, 1].Value.ToString();

                        employeeList.Add(employee);
                    }
                }
            }
            return employeeList;
        }

        public static void Save(Employee employee, string fileName)
        {
            string path = Path.GetFullPath(fileName);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            
            if (!File.Exists(path))
            {
                ExcelPackage excel = new ExcelPackage(path);
                var worksheet = excel.Workbook.Worksheets.Add("Planilha1");
                worksheet.Cells[1,1].Value = employee.Name;
                FileStream fs = File.Create(path);
                fs.Close();
                File.WriteAllBytes(path, excel.GetAsByteArray());
            }
            else
            {
                FileInfo existingFile = new FileInfo(path);
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                ExcelPackage excel = new ExcelPackage(existingFile);
                var worksheeet = excel.Workbook.Worksheets[0];
                var rows = worksheeet.Rows.Count()+1;
                worksheeet.InsertRow(rows, 1);
                worksheeet.Cells[rows,1].Value = employee.Name;
                File.WriteAllBytes(path, excel.GetAsByteArray());
            }
        }

    }
}
