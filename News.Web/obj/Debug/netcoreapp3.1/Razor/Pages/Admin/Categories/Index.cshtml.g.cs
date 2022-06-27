#pragma checksum "D:\Workspace\C#\Asp.NetCore\News\News.Web\Pages\Admin\Categories\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad2a2ba37adb275446373768e2493161e45452fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Categories_Index), @"mvc.1.0.razor-page", @"/Pages/Admin/Categories/Index.cshtml")]
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
#line 1 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Pages\_ViewImports.cshtml"
using News.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Pages\_ViewImports.cshtml"
using News.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{handler?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad2a2ba37adb275446373768e2493161e45452fe", @"/Pages/Admin/Categories/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5197f1a9049ae75ea291bddcdfd20d8dbece3d9d", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Admin_Categories_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_MainMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Pages\Admin\Categories\Index.cshtml"
  
    var menuModel = "categories";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ad2a2ba37adb275446373768e2493161e45452fe3702", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 6 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Pages\Admin\Categories\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = menuModel;

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


<div class=""content-wrapper"">
    <section class=""content"">
        <div class=""row"">
            <section class=""col-lg-12 col-md-12"">
                <div class=""box box-info"">
                    <div class=""box-header"">

                        <a href=""/Admin/Categories/Add"" class=""btn btn-success btn-flat"">افزودن گروه</a>
                    </div>
                    <div class=""box-body"">
                        <div class=""table-responsive"">
                            <table class=""table-bordered table table-hover"">
                                <thead>
                                    <tr>
                                        <th>#</th>
                                        <th>عنوان گروه</th>
                                        <th>زیر گروه ها</th>
                                        <td>عملیات</td>
                                    </tr>
                                </thead>

                                <tbody>

");
#nullable restore
#line 32 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Pages\Admin\Categories\Index.cshtml"
                                     foreach (var group in Model.BlogGroups.Where(c => c.ParentId == null))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 35 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Pages\Admin\Categories\Index.cshtml"
                                           Write(group.GroupId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 36 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Pages\Admin\Categories\Index.cshtml"
                                           Write(group.GroupName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>\r\n                                                <ul>\r\n");
#nullable restore
#line 39 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Pages\Admin\Categories\Index.cshtml"
                                                     foreach (var sub in Model.BlogGroups.Where(c => c.ParentId == group.GroupId))
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <li>\r\n                                                            <p>\r\n                                                                ");
#nullable restore
#line 43 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Pages\Admin\Categories\Index.cshtml"
                                                           Write(sub.GroupName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                                <a class=\"btn btn-danger btn-xs pull-left\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2092, "\"", 2126, 3);
            WriteAttributeValue("", 2102, "deleteItem(", 2102, 11, true);
#nullable restore
#line 44 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Pages\Admin\Categories\Index.cshtml"
WriteAttributeValue("", 2113, sub.GroupId, 2113, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2125, ")", 2125, 1, true);
            EndWriteAttribute();
            WriteLiteral(">حذف</a>\r\n                                                                <a class=\"btn btn-xs btn-info pull-left\"");
            BeginWriteAttribute("href", " href=\"", 2241, "\"", 2283, 2);
            WriteAttributeValue("", 2248, "/Admin/Categories/Edit/", 2248, 23, true);
#nullable restore
#line 45 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Pages\Admin\Categories\Index.cshtml"
WriteAttributeValue("", 2271, sub.GroupId, 2271, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">ویرایش</a>\r\n                                                            </p>\r\n                                                        </li>\r\n");
#nullable restore
#line 48 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Pages\Admin\Categories\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </ul>\r\n                                            </td>\r\n                                            <td>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 2687, "\"", 2730, 2);
            WriteAttributeValue("", 2694, "/Admin/Categories/Add/", 2694, 22, true);
#nullable restore
#line 52 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Pages\Admin\Categories\Index.cshtml"
WriteAttributeValue("", 2716, group.GroupId, 2716, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success btn-sm\">افزودن زیرگروه</a>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 2833, "\"", 2877, 2);
            WriteAttributeValue("", 2840, "/Admin/Categories/Edit/", 2840, 23, true);
#nullable restore
#line 53 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Pages\Admin\Categories\Index.cshtml"
WriteAttributeValue("", 2863, group.GroupId, 2863, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning btn-sm\">ویرایش</a>\r\n                                                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2972, "\"", 3008, 3);
            WriteAttributeValue("", 2982, "deleteItem(", 2982, 11, true);
#nullable restore
#line 54 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Pages\Admin\Categories\Index.cshtml"
WriteAttributeValue("", 2993, group.GroupId, 2993, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3007, ")", 3007, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm\">حذف</a>\r\n\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 58 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Pages\Admin\Categories\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n\r\n                    </div>\r\n                </div>\r\n            </section>\r\n        </div>\r\n    </section>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>

        function deleteItem(id) {
            swal({
                title: ""اخطار !!"",
                text: ""آیا از حذف گروه اطمینان دارید؟"",
                icon: ""warning"",
                buttons: [""خیر"", ""بله""]
            }).then((isOk) => {
                if (isOk) {
                    $.ajax({
                        url: ""/Admin/Categories/DeleteGroup?groupID="" + id,
                        type: ""get"",
                        beforeSend: function () {
                            $("".loading"").show();
                        },
                        complete: function () {
                            $("".loading"").hide();
                        }
                    }).done(function (data) {
                        if (data === ""Deleted"") {
                            swal({
                                title: ""اعملیات با موفقیت انجام شد"",
                                icon: ""success"",
                                button: ""باشه""
                 ");
                WriteLiteral(@"           }).then((isOk) => {
                                location.reload();
                            });
                        } else {
                            swal({
                                title: ""اعملیات به مشکل برخورد کرد"",
                                text: "".گروه مورد نظر داری  تعدادی آموزشگاه است "",
                                icon: ""error"",
                                button: ""باشه""
                            });
                        }
                    });
                }
            });

        }
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<News.Web.Pages.Admin.Categories.IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<News.Web.Pages.Admin.Categories.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<News.Web.Pages.Admin.Categories.IndexModel>)PageContext?.ViewData;
        public News.Web.Pages.Admin.Categories.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
