#pragma checksum "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Components\CategoryComponents\CategoryBlogs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6365f5d06ede14182d317aafcbfedd14a7aca852"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryComponents_CategoryBlogs), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryComponents/CategoryBlogs.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\_ViewImports.cshtml"
using News.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\_ViewImports.cshtml"
using News.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Components\CategoryComponents\CategoryBlogs.cshtml"
using News.Core.Services.Interfaces;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6365f5d06ede14182d317aafcbfedd14a7aca852", @"/Views/Shared/Components/CategoryComponents/CategoryBlogs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5197f1a9049ae75ea291bddcdfd20d8dbece3d9d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_CategoryComponents_CategoryBlogs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<News.DataLayer.Entities.Blog.BlogGroup>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Components\CategoryComponents\CategoryBlogs.cshtml"
  
    var userAdmin = false;
    if (User.Identity.IsAuthenticated)
    {
        userAdmin = userService.IsUserAdmin(User.Identity.Name);
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<nav id=\"top-nav\">\r\n    <ul id=\"top-menu\" class=\"clearfix\">\r\n        <li class=\"current-menu-item\">\r\n            <a href=\"/Home\">صفحه اصلی</a>\r\n        </li>\r\n        <li>\r\n            <a href=\"/Blog?groupId=0\">اخبار</a>\r\n            <ul>\r\n");
#nullable restore
#line 19 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Components\CategoryComponents\CategoryBlogs.cshtml"
                 foreach (var group in Model.Where(g => g.ParentId == null))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 677, "\"", 712, 2);
            WriteAttributeValue("", 684, "/Blog?groupId=", 684, 14, true);
#nullable restore
#line 22 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Components\CategoryComponents\CategoryBlogs.cshtml"
WriteAttributeValue("", 698, group.GroupId, 698, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 22 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Components\CategoryComponents\CategoryBlogs.cshtml"
                                                          Write(group.GroupName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 23 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Components\CategoryComponents\CategoryBlogs.cshtml"
                         if (Model.Any(g => g.ParentId == group.GroupId))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <ul>\r\n");
#nullable restore
#line 26 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Components\CategoryComponents\CategoryBlogs.cshtml"
                                 foreach (var sub in Model.Where(g => g.ParentId == group.GroupId))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1050, "\"", 1083, 2);
            WriteAttributeValue("", 1057, "/Blog?groupId=", 1057, 14, true);
#nullable restore
#line 28 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Components\CategoryComponents\CategoryBlogs.cshtml"
WriteAttributeValue("", 1071, sub.GroupId, 1071, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 28 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Components\CategoryComponents\CategoryBlogs.cshtml"
                                                                        Write(sub.GroupName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 29 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Components\CategoryComponents\CategoryBlogs.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n");
#nullable restore
#line 31 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Components\CategoryComponents\CategoryBlogs.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </li>\r\n");
#nullable restore
#line 33 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Components\CategoryComponents\CategoryBlogs.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </li>\r\n        <li><a href=\"/Contact-Us\">تماس باما</a></li>\r\n        <li><a href=\"/AboutUs\">درباره ما</a></li>\r\n");
#nullable restore
#line 38 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Components\CategoryComponents\CategoryBlogs.cshtml"
         if (User.Identity.IsAuthenticated)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n");
#nullable restore
#line 41 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Components\CategoryComponents\CategoryBlogs.cshtml"
                 if (userAdmin == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a href=\"/Admin\">پنل ادمین</a>\r\n");
#nullable restore
#line 44 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Components\CategoryComponents\CategoryBlogs.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a href=\"#\">");
#nullable restore
#line 47 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Components\CategoryComponents\CategoryBlogs.cshtml"
                           Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" عزیز خوش آمدید!</a>\r\n");
#nullable restore
#line 48 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Components\CategoryComponents\CategoryBlogs.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <ul>\r\n                    <li><a href=\"/Logout\">خروج از حساب</a></li>\r\n                </ul>\r\n            </li>\r\n");
#nullable restore
#line 53 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Components\CategoryComponents\CategoryBlogs.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li><a href=\"/Login\">ورود</a></li>\r\n            <li><a href=\"/Register\">ثبت نام</a></li>\r\n");
#nullable restore
#line 58 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Components\CategoryComponents\CategoryBlogs.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</nav><!--end:top-nav-->");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IUserService userService { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<News.DataLayer.Entities.Blog.BlogGroup>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
