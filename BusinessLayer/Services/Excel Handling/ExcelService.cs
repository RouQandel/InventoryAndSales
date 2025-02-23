using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;

namespace BusinessLayer.Services.Excel_Handling
{
    public class ExcelService
    {



        public void ExportToExcel<T>(ICollection<T> data, string FolderPath)
        {
			ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

			var filePath = Path.Combine(FolderPath, "ExportExcelFile.xlsx");
			

			using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Sheet1");
                PropertyInfo[] properties = typeof(T).GetProperties();

                // Write header
                for (int i = 0; i < properties.Length; i++)
                {
                    worksheet.Cells[1, i + 1].Value = properties[i].Name;
                }

                // Write data
                int row = 2;
                foreach (var item in data)
                {
                    for (int i = 0; i < properties.Length; i++)
                    {
                        var value = properties[i].GetValue(item);
                        worksheet.Cells[row, i + 1].Value = value;
                    }
                    row++;
                }

                // Save the package to the file
                FileInfo file = new FileInfo(filePath);
                package.SaveAs(file);
            }
        }

        //public void ExportExcelFile<T>(ICollection<T> collection)
        //{
        //    string location = "D:\\";
        //    string name = "Test.xlsx";
        //    string filePath = Path.Combine(location, name);

        //    if (!Directory.Exists(location))
        //    {
        //        Directory.CreateDirectory(location);
        //    }
        //    using (var package = new ExcelPackage(new FileInfo(filePath)))
        //    {
        //        var worksheet = package.Workbook.Worksheets.Add("Sheet1");
        //        foreach (var VARIABLE in collection)
        //        {

        //        }

        //        package.Save();
        //    }
        //}

    }
}
