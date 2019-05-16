
using ExcelToDB.Models;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExcelToDB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Upload(FormCollection formCollection)
        {
            var employeesList= new List<Employee>();

            if (Request != null)
            {
                HttpPostedFileBase file = Request.Files["UploadedFile"];
                //Checking if the file is not empty and creating employees list from the file data
                if ((file != null) && (file.ContentLength > 0) && !string.IsNullOrEmpty(file.FileName))
                {
                    string fileName = file.FileName;
                    string fileContentType = file.ContentType;
                    byte[] fileBytes = new byte[file.ContentLength];
                    var data = file.InputStream.Read(fileBytes, 0, Convert.ToInt32(file.ContentLength));
                    using (var package = new ExcelPackage(file.InputStream))
                    {
                        var currentSheet = package.Workbook.Worksheets;
                        var workSheet = currentSheet.First();
                        var noOfCol = workSheet.Dimension.End.Column;
                        var noOfRow = workSheet.Dimension.End.Row;
                        for (int rowIterator = 2; rowIterator <= noOfRow; rowIterator++)
                        {
                            var employee = new Employee();
                            employee.ID = Convert.ToInt32(workSheet.Cells[rowIterator, 1].Value);
                            employee.FullName = workSheet.Cells[rowIterator, 2].Value.ToString();
                            employee.Department = workSheet.Cells[rowIterator, 3].Value.ToString(); 
                            employeesList.Add(employee);
                        }
                    }
                }
            }
            //Recoring into the DB table
            using (BusinessEntities1 excelToDB = new BusinessEntities1())
            {
                foreach (var item in employeesList)
                {
                    excelToDB.Employees.Add(item);
                }
                excelToDB.SaveChanges();
            }
            return View("Index");
        }
          
    }
}