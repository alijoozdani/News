#pragma checksum "D:\Workspace\C#\Asp.NetCore\News\News.Web\Pages\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1f611f4503d217b6c428b27ac416159b216c763"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Index), @"mvc.1.0.razor-page", @"/Pages/Admin/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1f611f4503d217b6c428b27ac416159b216c763", @"/Pages/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5197f1a9049ae75ea291bddcdfd20d8dbece3d9d", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Admin_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 3 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Pages\Admin\Index.cshtml"
  
    var menu = "dashbord";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1f611f4503d217b6c428b27ac416159b216c7633548", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 7 "D:\Workspace\C#\Asp.NetCore\News\News.Web\Pages\Admin\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = menu;

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
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <h1>
            داشبرد
            <small>کنترل پنل</small>
        </h1>
        <ol class=""breadcrumb"">
            <li><a href=""#""><i class=""fa fa-dashboard""></i> خانه</a></li>
            <li class=""active"">داشبرد</li>
        </ol>
    </section>

    <!-- Main content -->
    <section class=""content"">
        <!-- Small boxes (Stat box) -->
        <div class=""row"">
            <div class=""col-lg-3 col-xs-6"">
                <!-- small box -->
                <div class=""small-box bg-aqua"">
                    <div class=""inner"">
                        <h3>150</h3>

                        <p>سفارش جدید</p>
                    </div>
                    <div class=""icon"">
                        <i class=""ion ion-bag""></i>
                    </div>
                    <a href=""#"" class=""small-box-footer"">اطلاعات بیشتر <i class=""fa fa-arrow-circle-left""><");
            WriteLiteral(@"/i></a>
                </div>
            </div>
            <!-- ./col -->
            <div class=""col-lg-3 col-xs-6"">
                <!-- small box -->
                <div class=""small-box bg-green"">
                    <div class=""inner"">
                        <h3>53<sup style=""font-size: 20px"">%</sup></h3>

                        <p>افزایش امتیاز</p>
                    </div>
                    <div class=""icon"">
                        <i class=""ion ion-stats-bars""></i>
                    </div>
                    <a href=""#"" class=""small-box-footer"">اطلاعات بیشتر <i class=""fa fa-arrow-circle-left""></i></a>
                </div>
            </div>
            <!-- ./col -->
            <div class=""col-lg-3 col-xs-6"">
                <!-- small box -->
                <div class=""small-box bg-yellow"">
                    <div class=""inner"">
                        <h3>44</h3>

                        <p>کاربران ثبت شده</p>
                    </div>
                  ");
            WriteLiteral(@"  <div class=""icon"">
                        <i class=""ion ion-person-add""></i>
                    </div>
                    <a href=""#"" class=""small-box-footer"">اطلاعات بیشتر <i class=""fa fa-arrow-circle-left""></i></a>
                </div>
            </div>
            <!-- ./col -->
            <div class=""col-lg-3 col-xs-6"">
                <!-- small box -->
                <div class=""small-box bg-red"">
                    <div class=""inner"">
                        <h3>65</h3>

                        <p>بازدید جدید</p>
                    </div>
                    <div class=""icon"">
                        <i class=""ion ion-pie-graph""></i>
                    </div>
                    <a href=""#"" class=""small-box-footer"">اطلاعات بیشتر <i class=""fa fa-arrow-circle-left""></i></a>
                </div>
            </div>
            <!-- ./col -->
        </div>
        <!-- /.row -->
        

    </section>
    <!-- /.content -->
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<News.Web.Pages.Admin.IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<News.Web.Pages.Admin.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<News.Web.Pages.Admin.IndexModel>)PageContext?.ViewData;
        public News.Web.Pages.Admin.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
