using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExportPDF.Models;
using Rotativa;
namespace ExportPDF.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ProductModel pm = new ProductModel();
            ViewBag.listProducts = pm.findAll();
            return View();
        }
        public ActionResult ExportPDF()
        {
            return new ActionAsPdf("Index")
            {
                FileName = Server.MapPath("~/Content/ListProduct.pdf")
            };
        }
    }
}