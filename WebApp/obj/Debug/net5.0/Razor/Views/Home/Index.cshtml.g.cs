#pragma checksum "C:\Users\admin\Desktop\WebApp\WebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e48e606a2fe17123f26f1407edb321a628db47b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\admin\Desktop\WebApp\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e48e606a2fe17123f26f1407edb321a628db47b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee2e25ed8b2fdc34cc2ed11280fba0ebc34d2baa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("url", "/home/index/{0}", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::WebApp.PaginationTagHelper __WebApp_PaginationTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pagination", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e48e606a2fe17123f26f1407edb321a628db47b3196", async() => {
            }
            );
            __WebApp_PaginationTagHelper = CreateTagHelper<global::WebApp.PaginationTagHelper>();
            __tagHelperExecutionContext.Add(__WebApp_PaginationTagHelper);
#nullable restore
#line 6 "C:\Users\admin\Desktop\WebApp\WebApp\Views\Home\Index.cshtml"
__WebApp_PaginationTagHelper.Size = 10;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("size", __WebApp_PaginationTagHelper.Size, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __WebApp_PaginationTagHelper.Url = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 6 "C:\Users\admin\Desktop\WebApp\WebApp\Views\Home\Index.cshtml"
__WebApp_PaginationTagHelper.Total = ViewBag.total;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("total", __WebApp_PaginationTagHelper.Total, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <a href=\"/home/list\">List</a>\r\n");
#nullable restore
#line 9 "C:\Users\admin\Desktop\WebApp\WebApp\Views\Home\Index.cshtml"
      
        int p = Convert.ToInt32(ViewContext.RouteData.Values["id"])-1;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\r\n    $($(\'.pagination li.page-item\')[");
#nullable restore
#line 34 "C:\Users\admin\Desktop\WebApp\WebApp\Views\Home\Index.cshtml"
                               Write(p);

#line default
#line hidden
#nullable disable
            WriteLiteral("]).addClass(\'active\');\r\n</script>\r\n    <div class=\"col-3\">\r\n        <ul>\r\n");
#nullable restore
#line 38 "C:\Users\admin\Desktop\WebApp\WebApp\Views\Home\Index.cshtml"
             foreach (Category item in ViewBag.categories)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a");
            BeginWriteAttribute("href", " href=\"", 1095, "\"", 1133, 2);
            WriteAttributeValue("", 1102, "/home/category/", 1102, 15, true);
#nullable restore
#line 40 "C:\Users\admin\Desktop\WebApp\WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 1117, item.CategoryID, 1117, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 40 "C:\Users\admin\Desktop\WebApp\WebApp\Views\Home\Index.cshtml"
                                                         Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 41 "C:\Users\admin\Desktop\WebApp\WebApp\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </ul>\r\n    </div>\r\n    <div class=\"col-9\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 47 "C:\Users\admin\Desktop\WebApp\WebApp\Views\Home\Index.cshtml"
             foreach (Product item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-3\">\r\n                    <h2><a");
            BeginWriteAttribute("href", " href=\"", 1384, "\"", 1419, 2);
            WriteAttributeValue("", 1391, "/home/detail/", 1391, 13, true);
#nullable restore
#line 50 "C:\Users\admin\Desktop\WebApp\WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 1404, item.ProductId, 1404, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 50 "C:\Users\admin\Desktop\WebApp\WebApp\Views\Home\Index.cshtml"
                                                          Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\r\n                    <div>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1502, "\"", 1537, 2);
            WriteAttributeValue("", 1509, "/home/detail/", 1509, 13, true);
#nullable restore
#line 52 "C:\Users\admin\Desktop\WebApp\WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 1522, item.ProductId, 1522, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 1591, "\"", 1632, 2);
            WriteAttributeValue("", 1597, "/Photo/", 1597, 7, true);
#nullable restore
#line 53 "C:\Users\admin\Desktop\WebApp\WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 1604, item.ImageUrl.Split(',')[0], 1604, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1633, "\"", 1656, 1);
#nullable restore
#line 53 "C:\Users\admin\Desktop\WebApp\WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 1639, item.ProductName, 1639, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </a>\r\n\r\n                    </div>\r\n                    <p>Price:<b>");
#nullable restore
#line 57 "C:\Users\admin\Desktop\WebApp\WebApp\Views\Home\Index.cshtml"
                           Write(item.UnitOfPrice.ToString("#,###"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n\r\n                </div>\r\n");
#nullable restore
#line 60 "C:\Users\admin\Desktop\WebApp\WebApp\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591