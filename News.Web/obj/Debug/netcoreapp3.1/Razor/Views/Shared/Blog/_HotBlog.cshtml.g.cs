#pragma checksum "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Blog\_HotBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a64eddfd7f6618ba6ea8672c7a047a63d41f753"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Blog__HotBlog), @"mvc.1.0.view", @"/Views/Shared/Blog/_HotBlog.cshtml")]
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
#line 1 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Blog\_HotBlog.cshtml"
using News.Core.Services.Interfaces;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a64eddfd7f6618ba6ea8672c7a047a63d41f753", @"/Views/Shared/Blog/_HotBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5197f1a9049ae75ea291bddcdfd20d8dbece3d9d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Blog__HotBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Blog\_HotBlog.cshtml"
  
    var hotBlogs = blogServie.GetHotBlog();

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Blog\_HotBlog.cshtml"
 foreach (var item in hotBlogs)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li><a");
            BeginWriteAttribute("href", " href=\"", 169, "\"", 198, 2);
            WriteAttributeValue("", 176, "/ShowBlog/", 176, 10, true);
#nullable restore
#line 8 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Blog\_HotBlog.cshtml"
WriteAttributeValue("", 186, item.BlogId, 186, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 8 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Blog\_HotBlog.cshtml"
                                    Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 9 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Blog\_HotBlog.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IBlogService blogServie { get; private set; } = default!;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
