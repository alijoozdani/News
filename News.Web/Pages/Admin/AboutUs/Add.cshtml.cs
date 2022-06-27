using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using News.Core.Services.Interfaces;

namespace News.Web.Pages.Admin.AboutUs
{
    

    public class AddModel : PageModel
    {
        private IAboutUsService _aboutUs;
        public AddModel(IAboutUsService aboutUs)
        {
            _aboutUs = aboutUs;
        }
        [BindProperty]
        public DataLayer.Entities.AboutUs.AboutUs AboutUs { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            var aboutUs = new DataLayer.Entities.AboutUs.AboutUs()
            {
                Text = AboutUs.Text,
                IsDelete = false
            };
            _aboutUs.Insert(aboutUs);
            return RedirectToPage("Index");
        }
    }
}
