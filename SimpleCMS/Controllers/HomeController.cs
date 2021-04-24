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
        public IActionResult Index(int id)
        {
            if (id != 0)
            {
                Page page = _pageRepository.GetById(id);
                return View(page);

            }
            return View();
        }

       
    }
}
