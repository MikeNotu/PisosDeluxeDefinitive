using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PisosDeluxeDefinitive.Data;

namespace PisosDeluxeDefinitive.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminUsersController : Controller
    {

        private readonly ApplicationDbContext _db;

        public AdminUsersController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.ApplicationUser.ToList());
        }
    }
}
