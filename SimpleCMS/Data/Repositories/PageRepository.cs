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

        public Page GetById(int id)
        {
            Page page = _context.Pages.SingleOrDefault(p => p.PageId == id);
                _context.Entry(page).Collection(s => s.Sections).Load();
                foreach (Section section in page.Sections)
                {
                    _context.Entry(section).Collection(s => s.Blocks).Load();
                }
            

            return page;
        }

        public ICollection<Page> GetPages()
        {
            return _context.Pages.ToList();
        }

        public Page GetByName(string name)
        {
            int id = _context.Pages.Where(p => p.NavName == name).Select(p => p.PageId).SingleOrDefault();
            return GetById(id);
        }

        public void Create(string headLine, string navName, string subHeadLine, string imagePath = null)
        {
            Page page = new Page
            {
                Headline = headLine,
                NavName = navName,
                Subheadline = subHeadLine,
                ImagePath = imagePath,
                HasImage = imagePath == null ? false : true,
                Sections = null,
            };
            _context.Pages.Add(page);
            _context.SaveChanges();
        }

    }
}
