using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using News.Core.Security;
using News.Core.Services.Interfaces;

namespace News.Web.Pages.Admin.ContactUs
{
    [PermissionChecker(13)]
    public class IndexModel : PageModel
    {
        private IContactUsService _contactUs;
        public IndexModel(IContactUsService contactUs)
        {
            _contactUs = contactUs;
        }

        [BindProperty]
        public DataLayer.Entities.ContactUs.ContactUs ContactUs { get; set; }
        public void OnGet()
        {
            ContactUs = _contactUs.GetLast();
        }
    }
}
