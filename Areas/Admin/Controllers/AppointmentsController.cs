using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PisosDeluxeDefinitive.Utility;

namespace PisosDeluxeDefinitive.Areas.Admin.Controllers
{
    [Authorize(Roles = SD.AdminEndUser + "," + SD.SuperAdminEndUser)]
    [Area("Admin")]
    public class AppointmentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
