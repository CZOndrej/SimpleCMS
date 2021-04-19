using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleCMS.Data.Repositories;
using SimpleCMS.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCMS.Controllers
{
    public class HomeController : Controller
    {
        private readonly PageRepository _pageRepository;

        public HomeController(PageRepository pageRepository)
        {
            _pageRepository = pageRepository;
        }
        public IActionResult Index(string name)
        {
            if (name != null)
            {
                Page page = _pageRepository.GetPageByName(name);
                return View(page);

            }
            return View();
        }

       
    }
}
