#pragma checksum "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71b74555a65d3396ead1c1674302835fb2884a59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 2 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Blog\Index.cshtml"
using News.Core.DTOs.Blogs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71b74555a65d3396ead1c1674302835fb2884a59", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5197f1a9049ae75ea291bddcdfd20d8dbece3d9d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ShowBlogsListItemViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Blog/_BoxBlog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "BLog/_Gallery", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Blog/_HotBlog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = ViewData["GroupTitle"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"right-col\">\r\n    <div class=\"breadcrumb clearfix\">\r\n        <span>\r\n            شما اینجا هستید:\r\n        </span>\r\n        <a href=\"/Home\">صفحه اصلی</a>&nbsp;»&nbsp;<a");
            BeginWriteAttribute("href", " href=\"", 309, "\"", 339, 2);
            WriteAttributeValue("", 316, "/BLogs/", 316, 7, true);
#nullable restore
#line 13 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Blog\Index.cshtml"
WriteAttributeValue("", 323, ViewBag.GroupId, 323, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"current-page\">");
#nullable restore
#line 13 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Blog\Index.cshtml"
                                                                                                    Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n    </div><!--end:breadcrumb-->\r\n    <ul class=\"article-list\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "71b74555a65d3396ead1c1674302835fb2884a596653", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 16 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Blog\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <div class=\"divider\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71b74555a65d3396ead1c1674302835fb2884a598253", async() => {
                WriteLiteral("\r\n                <input type=\"hidden\" id=\"take\" name=\"take\"");
                BeginWriteAttribute("value", " value=\"", 657, "\"", 704, 1);
#nullable restore
#line 19 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Blog\Index.cshtml"
WriteAttributeValue("", 665, int.Parse(ViewData["Take"].ToString()), 665, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <input type=\"hidden\" name=\"groupId\"");
                BeginWriteAttribute("value", " value=\"", 761, "\"", 800, 1);
#nullable restore
#line 20 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Blog\Index.cshtml"
WriteAttributeValue("", 769, ViewData["GroupId"].ToString(), 769, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <a onclick=\"moreBlog(10)\" class=\"load-more\">بار بیشتر</a>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </ul>

</div><!--end:right-col-->
<div class=""sidebar"" id=""sidebar-a"">
    <div class=""spacer"">برای دیدن</div>
    <div id=""widget-list-a-sticky-wrapper"" class=""sticky-wrapper"" style=""height: 1674px;"">
        <ul id=""widget-list-a""");
            BeginWriteAttribute("class", " class=\"", 1160, "\"", 1168, 0);
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 1169, "\"", 1177, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <li>\r\n                <aside class=\"widget clearfix\">\r\n                    <h4 class=\"widget-title\">گالری</h4>\r\n                    <ul class=\"gallery clearfix\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "71b74555a65d3396ead1c1674302835fb2884a5911699", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 35 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Blog\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = null;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </ul>
                </aside><!--end:widget-->
            </li>
            <li>
                <aside class=""widget clearfix"">
                    <h4 class=""widget-title"">اخبار داغ</h4>
                    <ul>
                       ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "71b74555a65d3396ead1c1674302835fb2884a5913521", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#nullable restore
#line 43 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Blog\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = null;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </ul>
                </aside><!--end:widget-->
            </li>
            <li style=""margin-bottom: 0px;"">
                <aside class=""widget clearfix"">
                    <div class=""adv-box clearfix"">
                        <a href=""/Home""><img class=""responsive-img hover-effect"" src=""/images/background/Logo.png""");
            BeginWriteAttribute("alt", " alt=\"", 2090, "\"", 2096, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                    </div><!--end:adv-box-->\r\n                </aside><!--end:widget-->\r\n            </li>\r\n        </ul>\r\n    </div><!--widget-list-a-->\r\n</div><!--sidebar-a-->\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        function moreBlog(count) {\r\n            var take = parseInt($(\"#take\").val());\r\n            $(\"#take\").val(take + count);\r\n            $(\"#form\").submit();\r\n        }\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ShowBlogsListItemViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
