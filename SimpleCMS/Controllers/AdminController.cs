using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SimpleCMS.Data.Repositories;
using SimpleCMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCMS.Controllers
{   
    [Authorize (Roles = "SysAdmin")]
    public class AdminController : Controller
    {
        private readonly PageRepository _pageRepository;

        public AdminController(PageRepository pageRepository)
        {
            _pageRepository = pageRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult AddPage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddPage(Page page)
        {
            await _pageRepository.Create(page.Headline, page.NavName, page.Subheadline);

            return View();
        }
        

    }
}
