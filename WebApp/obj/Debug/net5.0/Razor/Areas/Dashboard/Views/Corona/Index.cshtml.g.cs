#pragma checksum "C:\Users\admin\Desktop\WebApp\WebApp\Areas\Dashboard\Views\Corona\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "885c8221cf58533419d126d27aa881d6b8abf0b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Dashboard_Views_Corona_Index), @"mvc.1.0.view", @"/Areas/Dashboard/Views/Corona/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"885c8221cf58533419d126d27aa881d6b8abf0b9", @"/Areas/Dashboard/Views/Corona/Index.cshtml")]
    #nullable restore
    public class Areas_Dashboard_Views_Corona_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebApp.Models.Corona>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<table id=""tbl"">
    <thead>
        <tr>
            <th>Update</th>
            <th>Country</th>
            <th>Cases</th>
            <th>Deaths</th>
        </tr>
    </thead>
    <tbody id=""sheet"">    
    </tbody>
</table>
<script>

    $.get('/dashboard/corona/getcoronas', function (d) {
        var a = JSON.parse(d);
        for (var i in a) {
            var o = a[i];
            var html = `<tr>
                        <td>${o['updated']}</td>
                        <td>${o['country']}</td>
                        <td>${o['cases']}</td>
                        <td>${o['deaths']}</td>
                        </tr>`;
            $(sheet).append(html);

        }
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebApp.Models.Corona>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
