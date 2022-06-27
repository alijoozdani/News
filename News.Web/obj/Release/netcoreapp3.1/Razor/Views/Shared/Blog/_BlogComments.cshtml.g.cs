#pragma checksum "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Blog\_BlogComments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74cd2c17930e4d457b0c1288136fa18500015255"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Blog__BlogComments), @"mvc.1.0.view", @"/Views/Shared/Blog/_BlogComments.cshtml")]
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
#line 2 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Blog\_BlogComments.cshtml"
using News.Core.Convertor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Blog\_BlogComments.cshtml"
using News.Core.Services.Interfaces;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74cd2c17930e4d457b0c1288136fa18500015255", @"/Views/Shared/Blog/_BlogComments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5197f1a9049ae75ea291bddcdfd20d8dbece3d9d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Blog__BlogComments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<News.Core.DTOs.Blogs.BlogCommentsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("comments-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("send-Comment clearfix"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Blog\_BlogComments.cshtml"
  
    var isAdmin = false;
    if (User.Identity.IsAuthenticated)
    {
        isAdmin = userService.IsUserAdmin(User.Identity.Name);
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"comments\">\r\n    <h5>\r\n        <label class=\"count\"> ");
#nullable restore
#line 14 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Blog\_BlogComments.cshtml"
                         Write(Model.CommentsCount.ToString("#,0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label> نظر در این مقاله\r\n    </h5>\r\n    <ol class=\"comments-list clearfix\">\r\n");
#nullable restore
#line 17 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Blog\_BlogComments.cshtml"
         foreach (var item in Model.BlogComments)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"comment clearfix\">\r\n                <article class=\"comment-wrap clearfix\">\r\n                    <img class=\"responsive-img\" src=\"/images/icons/avatardefault_92824.png\"");
            BeginWriteAttribute("alt", " alt=\"", 731, "\"", 737, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"comment-body\">\r\n                        <div class=\"comment-meta\">\r\n                            <span class=\"author\">");
#nullable restore
#line 24 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Blog\_BlogComments.cshtml"
                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <span class=\"date\">");
#nullable restore
#line 25 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Blog\_BlogComments.cshtml"
                                          Write(item.CreateDate.ToShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div><!-- end:comment-meta -->\r\n                        <p>");
#nullable restore
#line 27 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Blog\_BlogComments.cshtml"
                      Write(item.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1121, "\"", 1160, 3);
            WriteAttributeValue("", 1131, "replyComment(", 1131, 13, true);
#nullable restore
#line 28 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Blog\_BlogComments.cshtml"
WriteAttributeValue("", 1144, item.CommentId, 1144, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1159, ")", 1159, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"comment-reply-link\">پاسخ</a>\r\n");
#nullable restore
#line 29 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Blog\_BlogComments.cshtml"
                         if (User.Identity.IsAuthenticated && isAdmin)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1328, "\"", 1368, 3);
            WriteAttributeValue("", 1338, "DeleteComment(", 1338, 14, true);
#nullable restore
#line 31 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Blog\_BlogComments.cshtml"
WriteAttributeValue("", 1352, item.CommentId, 1352, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1367, ")", 1367, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"comment-edit-link\">حذف</a>\r\n");
#nullable restore
#line 32 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Blog\_BlogComments.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div><!-- end:comment-body -->\r\n                </article>\r\n");
#nullable restore
#line 35 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Blog\_BlogComments.cshtml"
                 if (Model.AnswerComments.Any(a => a.Answer == item.CommentId))
                {
                    foreach (var answer in Model.AnswerComments.Where(a => a.Answer == item.CommentId))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <ul class=""children"">
                            <li class=""comment clearfix"" style=""border-bottom: none; padding-bottom: 0px;"">
                                <article class=""comment-wrap clearfix"">
                                    <img class=""responsive-img"" src=""placeholders/avatar/avatar.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2070, "\"", 2076, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <div class=\"comment-body\">\r\n                                        <div class=\"comment-meta\">\r\n                                            <span class=\"author\">");
#nullable restore
#line 45 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Blog\_BlogComments.cshtml"
                                                            Write(answer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                            <span class=\"date\">");
#nullable restore
#line 46 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Blog\_BlogComments.cshtml"
                                                          Write(answer.CreateDate.ToShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </div><!-- end:comment-meta -->\r\n                                        <p>");
#nullable restore
#line 48 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Blog\_BlogComments.cshtml"
                                      Write(answer.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2578, "\"", 2617, 3);
            WriteAttributeValue("", 2588, "replyComment(", 2588, 13, true);
#nullable restore
#line 49 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Blog\_BlogComments.cshtml"
WriteAttributeValue("", 2601, item.CommentId, 2601, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2616, ")", 2616, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""comment-reply-link"">پاسخ</a>
                                        <a href=""#"" class=""comment-edit-link"">ویرایش</a>
                                    </div><!-- end:comment-body -->
                                </article>
                            </li>
                        </ul><!--end:children-->
");
#nullable restore
#line 55 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Blog\_BlogComments.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </li>\r\n");
#nullable restore
#line 58 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Blog\_BlogComments.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ol><!--end:comments-list-->\r\n");
#nullable restore
#line 60 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Blog\_BlogComments.cshtml"
     if (Model.PageCount > 1)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"comment-pagination clearfix\">\r\n");
#nullable restore
#line 63 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Blog\_BlogComments.cshtml"
             if (Model.CurrentPage > 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 3214, "\"", 3258, 3);
            WriteAttributeValue("", 3224, "ChangePage(", 3224, 11, true);
#nullable restore
#line 65 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Blog\_BlogComments.cshtml"
WriteAttributeValue("", 3235, Model.CurrentPage-1, 3235, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3257, ")", 3257, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"prev page-numbers\">« قبلی</a>\r\n");
#nullable restore
#line 66 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Blog\_BlogComments.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 68 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Blog\_BlogComments.cshtml"
             for (int i = Model.StartPage; i <= Model.EndPage; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 3417, "\"", 3441, 3);
            WriteAttributeValue("", 3427, "ChangePage(", 3427, 11, true);
#nullable restore
#line 70 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Blog\_BlogComments.cshtml"
WriteAttributeValue("", 3438, i, 3438, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3440, ")", 3440, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"page-numbers\">");
#nullable restore
#line 70 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Blog\_BlogComments.cshtml"
                                                            Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 71 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Blog\_BlogComments.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 73 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Views\Shared\Blog\_BlogComments.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"clear\"></div>\r\n</div><!--end:comments-->\r\n<div id=\"respond\">\r\n    <h3>پاسخ بگذار</h3>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74cd2c17930e4d457b0c1288136fa1850001525515044", async() => {
                WriteLiteral(@"
        <input name=""replay"" id=""reply-comment-id"" type=""hidden"" value=""null"">
        <div class=""comment-right"">
            <p class=""input-block"">
                <label class=""required"" for=""comment-name"">نام:</label>
                <input class=""valid"" type=""text"" name=""comment_name"" id=""comment-name""");
                BeginWriteAttribute("value", " value=\"", 3987, "\"", 3995, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            </p>\r\n            <p class=\"input-block\">\r\n                <label class=\"required\" for=\"comment-email\">ایمیل:</label>\r\n                <input type=\"email\" class=\"valid\" name=\"comment_email\" id=\"comment-email\"");
                BeginWriteAttribute("value", " value=\"", 4219, "\"", 4227, 0);
                EndWriteAttribute();
                WriteLiteral(@">
            </p>
        </div>
        <div class=""comment-left"">
            <p class=""textarea-block"">
                <label class=""required"" for=""comment-message"">پیام:</label>
                <textarea rows=""6"" cols=""88"" id=""comment-message"" name=""comment_text""></textarea>
            </p>
        </div>
        <div class=""clear""></div>
        <p class=""comment-button"">
            <input type=""submit"" id=""submit-comment"" value=""ارسال نظر"">
        </p>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <div id=\"response\"></div>\r\n</div><!--end:respond-->\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IUserService userService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<News.Core.DTOs.Blogs.BlogCommentsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
