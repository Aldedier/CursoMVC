using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmpresaGalletas.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Prodcutos
        public ActionResult Index()
        {
            return View();
        }
    }
}