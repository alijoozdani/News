using Microsoft.AspNetCore.Mvc.RazorPages;
using News.Core.DTOs.ContactUs;
using News.Core.Services.Interfaces;

namespace News.Web.Pages.Admin.ContactUs.HelpForm
{
    public class IndexModel : PageModel
    {
        private IContactUsService _contact;

        public IndexModel(IContactUsService contact)
        {
            _contact = contact;
        }
        public ContactUsFormViewModel ContactUsModel { get; set; }
        public void OnGet(int pageId=1,bool isPosted=false)
        {
            ContactUsModel = _contact.GetContactUses(pageId, 12, isPosted);
        }
    }
}
