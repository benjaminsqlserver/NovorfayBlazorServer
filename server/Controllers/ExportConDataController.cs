using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NovorfayProductCatalogue.Data;

namespace NovorfayProductCatalogue
{
    public partial class ExportConDataController : ExportController
    {
        private readonly ConDataContext context;

        public ExportConDataController(ConDataContext context)
        {
            this.context = context;
        }
        [HttpGet("/export/ConData/products/csv")]
        [HttpGet("/export/ConData/products/csv(fileName='{fileName}')")]
        public FileStreamResult ExportProductsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.Products, Request.Query), fileName);
        }

        [HttpGet("/export/ConData/products/excel")]
        [HttpGet("/export/ConData/products/excel(fileName='{fileName}')")]
        public FileStreamResult ExportProductsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.Products, Request.Query), fileName);
        }
        [HttpGet("/export/ConData/productcategories/csv")]
        [HttpGet("/export/ConData/productcategories/csv(fileName='{fileName}')")]
        public FileStreamResult ExportProductCategoriesToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.ProductCategories, Request.Query), fileName);
        }

        [HttpGet("/export/ConData/productcategories/excel")]
        [HttpGet("/export/ConData/productcategories/excel(fileName='{fileName}')")]
        public FileStreamResult ExportProductCategoriesToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.ProductCategories, Request.Query), fileName);
        }
    }
}
