using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCMS.Controllers
{   
    [Authorize (Roles = "SysAdmin")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public Task<IActionResult> AddPage(Page page)
        {

        }
    }
}
