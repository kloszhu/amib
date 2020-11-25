using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace amiba.Web.Areas.budget.Controllers
{
    public class ReserveController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
