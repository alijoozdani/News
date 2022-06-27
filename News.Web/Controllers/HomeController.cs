using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using News.Core.Convertor;
using News.Core.Security;
using News.Core.Services.Interfaces;
using News.DataLayer.Entities.ContactUs;
using News.DataLayer.Entities.RSS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace News.Web.Controllers
{
    public class HomeController : Controller
    {
        private IGroupService _groupService;
        private IBlogService _blogService;
        private IAboutUsService _about;
        private IContactUsService _contactUs;
        private IUserService _userService;
        public HomeController(IGroupService groupService,IBlogService blogService, IAboutUsService about, IContactUsService contactUs, IUserService userService)
        {
            _groupService = groupService;
            _blogService = blogService;
            _about = about;
            _contactUs = contactUs;
            _userService = userService; 
        }
        public IActionResult Index()
        {
            ViewData["Visit"] = _blogService.GetBlogs(0, 4,"", "visit");
            return View(_blogService.GetBlogs(0, 4,"","date"));
        }
        [Route("AboutUs")]
        public IActionResult AboutUs()
        {
            return View(_about.GetLast());
        }

        [Route("Contact-Us")]
        public IActionResult ContactUs()
        {
            return View(_contactUs.GetLast());
        }
        [HttpPost]
        [Route("Contact-Us")]
        public IActionResult ContactUs(ContactUsForm contactUsForm)
        {
            if (!ModelState.IsValid)
                return View(_contactUs.GetLast());

            contactUsForm.CreateDate = DateTime.Now;
            _contactUs.InsertQuestion(contactUsForm);
            TempData["Success"] = true;
            return Redirect("/Contact-Us");
        }

        [Route("/Home/HandleError/{code}")]
        public IActionResult HandlerError(int code)
        {


            if (code >= 500)
            {
                return View("ServerError");
            }

            return View("NotFound");

        }
        public IActionResult GetSubGroup(int id)
        {
            List<SelectListItem> list = new List<SelectListItem>()
            {
                new SelectListItem(){Text = "انتخاب کنید",Value = ""}
            };
            list.AddRange(_groupService.GetSubGroupForManager(id));
            return Json(new SelectList(list, "Value", "Text"));
        }

        [HttpPost]
        public IActionResult UploadBlogImage(IFormFile upload)
        {
            if (upload == null)
            {
                return null;
            }

            if (!upload.IsImage()) return null;
            //برای تکراری نبودن عکس از  یک نام یکتا استفاده می کنیم که شامل عدد نباشد
            var guildName = String.Concat(Guid.NewGuid().ToString("N").Select(c => (char)(c + 17)));
            var fileName = guildName + Path.GetExtension(upload.FileName)?.ToLower();

            var path = Path.Combine(
                Directory.GetCurrentDirectory(), "wwwroot/images/blog/content/", fileName);
            
            using (var stream = new FileStream(path, FileMode.Create))
            {
                upload.CopyTo(stream);
            }
            ImageConvertor imgResizer = new ImageConvertor();
            string thumbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/blog/content/650/", fileName);
            imgResizer.Image_resize(path, thumbPath, 650);

            var url = $"/images/blog/content/650/{fileName}";
            return Json(new { uploaded = true, url });
        }

        [HttpPost]
        public IActionResult NewsLetter(string email)
        {
            if (!_userService.IsExistEmailInRss(email))
            {
                RSS rss = new RSS()
                {
                    EmailAddress = email,
                    CreateDate = DateTime.Now
                };

                _userService.AddEmailToRss(rss);
                TempData["Success"] = true;
                return Redirect("Index");
            }
            return Redirect("Index");
        }
    }
}
