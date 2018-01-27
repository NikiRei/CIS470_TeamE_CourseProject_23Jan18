using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CIS470_TeamE_CourseProject_23Jan18.Controllers
{
    public class SalesPersonController : Controller
    {
        //
        // GET: /SalesPerson/

        public IActionResult Index()
        {
            return View();
        }

        //GET: /SalesPerson/Welcome
        public IActionResult Welcome(string employeeName, int id)
        {
            ViewData["Message"] = "Hello " + employeeName;
            ViewData["Employee ID: "] = id;

            return View();
        }
        
    }
}
