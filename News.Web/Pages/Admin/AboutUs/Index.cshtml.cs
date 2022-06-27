using Microsoft.AspNetCore.Mvc.RazorPages;
using News.Core.Security;
using News.Core.Services.Interfaces;

namespace News.Web.Pages.Admin.AboutUs
{
    [PermissionChecker(12)]
    public class IndexModel : PageModel
    {
        private IAboutUsService _about;

        public IndexModel(IAboutUsService about)
        {
            _about = about;
        }
        
        public News.DataLayer.Entities.AboutUs.AboutUs AboutUs { get; set; }
        public void OnGet()
        {
            AboutUs = _about.GetLast();
            
        }
    }
}