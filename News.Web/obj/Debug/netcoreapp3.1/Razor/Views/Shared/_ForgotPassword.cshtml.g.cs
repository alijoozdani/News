#pragma checksum "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\_ForgotPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e0c52c2847d3e57c058a039077b2c77cc7c9ae2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ForgotPassword), @"mvc.1.0.view", @"/Views/Shared/_ForgotPassword.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e0c52c2847d3e57c058a039077b2c77cc7c9ae2", @"/Views/Shared/_ForgotPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5197f1a9049ae75ea291bddcdfd20d8dbece3d9d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__ForgotPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<News.DataLayer.Entities.User.User>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div style=\"direction: rtl; padding: 20px\">\r\n    <h2>");
#nullable restore
#line 4 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\_ForgotPassword.cshtml"
   Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" عزیز !</h2>\r\n    <p>\r\n       جهت بازیابی حساب کاربری خود روی لینک زیر کلیک کنید\r\n    </p>\r\n    <p>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 223, "\"", 293, 2);
            WriteAttributeValue("", 230, "https://localhost:44307/Account/ResetPassword/", 230, 46, true);
#nullable restore
#line 9 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\_ForgotPassword.cshtml"
WriteAttributeValue("", 276, Model.ActiveCode, 276, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">بازیابی کلمه عبور</a>\r\n    </p>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<News.DataLayer.Entities.User.User> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591