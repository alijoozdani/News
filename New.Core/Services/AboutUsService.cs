using News.Core.Services.Interfaces;
using News.DataLayer.Context;
using News.DataLayer.Entities.AboutUs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace News.Core.Services
{
   public class AboutUsService:IAboutUsService
    {
        private NewsContext _context;
        public AboutUsService(NewsContext context)
        {
            _context = context;
        }

        public AboutUs GetAboutUsById(int id)
        {
            return _context.AboutUs.Find(id);
        }

        public AboutUs GetLast()
        {
            return _context.AboutUs.FirstOrDefault();
        }

        public void Insert(AboutUs aboutUs)
        {
            if (_context.AboutUs.Any()) return;
            _context.AboutUs.Add(aboutUs);
            _context.SaveChanges();
        }

        public void Update(AboutUs aboutUs)
        {
            _context.AboutUs.Update(aboutUs);
            _context.SaveChanges();
        }
    }
}
