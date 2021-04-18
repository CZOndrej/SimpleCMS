using SimpleCMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCMS.Data.Repositories
{
    public class PageRepository
    {
        private readonly ApplicationDbContext _context;

        public PageRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Page GetPageById(int id)
        {
            Page page = _context.Pages.SingleOrDefault(p => p.PageId == id);
            _context.Entry(page).Collection(s => s.Sections).Load();
            foreach (Section section in page.Sections)
            {
                _context.Entry(section).Collection(s => s.Blocks).Load();
            }

            return page;
        }


    }
}
