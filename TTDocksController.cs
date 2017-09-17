using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TTDocks.Controllers
{
    public class TTDocksController : Controller
    {
        // GET: /<controller>/
        public IActionResult TTDocks()
        {
            return View();
        }
    }
}
