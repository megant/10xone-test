#pragma checksum "/Users/tibor/Worx/10xone/Views/Statistics/_StatisticItemsListPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db80b5efaa6192163f87329ee7079ec0fc5e47b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Statistics__StatisticItemsListPartial), @"mvc.1.0.view", @"/Views/Statistics/_StatisticItemsListPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Statistics/_StatisticItemsListPartial.cshtml", typeof(AspNetCore.Views_Statistics__StatisticItemsListPartial))]
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
#line 1 "/Users/tibor/Worx/10xone/Views/_ViewImports.cshtml"
using TenXOne;

#line default
#line hidden
#line 2 "/Users/tibor/Worx/10xone/Views/_ViewImports.cshtml"
using TenXOne.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db80b5efaa6192163f87329ee7079ec0fc5e47b5", @"/Views/Statistics/_StatisticItemsListPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ee098459ea483f873895e55b0a37cbc3422cf2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Statistics__StatisticItemsListPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TenXOne.ViewModels.StatisticsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/tibor/Worx/10xone/Views/Statistics/_StatisticItemsListPartial.cshtml"
  int rowNum = 1;

#line default
#line hidden
#line 4 "/Users/tibor/Worx/10xone/Views/Statistics/_StatisticItemsListPartial.cshtml"
     foreach(var item in @Model.StatisticItems)
    {            

#line default
#line hidden
            BeginContext(132, 64, true);
            WriteLiteral("        <tr class=\"financial-item\">\n            <th scope=\"row\">");
            EndContext();
            BeginContext(197, 6, false);
#line 7 "/Users/tibor/Worx/10xone/Views/Statistics/_StatisticItemsListPartial.cshtml"
                       Write(rowNum);

#line default
#line hidden
            EndContext();
            BeginContext(203, 39, true);
            WriteLiteral("</th>\n            <td>\n                ");
            EndContext();
            BeginContext(243, 16, false);
#line 9 "/Users/tibor/Worx/10xone/Views/Statistics/_StatisticItemsListPartial.cshtml"
           Write(item.PartnerName);

#line default
#line hidden
            EndContext();
            BeginContext(259, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(312, 17, false);
#line 12 "/Users/tibor/Worx/10xone/Views/Statistics/_StatisticItemsListPartial.cshtml"
           Write(item.TeamPurchase);

#line default
#line hidden
            EndContext();
            BeginContext(329, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(382, 18, false);
#line 15 "/Users/tibor/Worx/10xone/Views/Statistics/_StatisticItemsListPartial.cshtml"
           Write(item.TotalPurchase);

#line default
#line hidden
            EndContext();
            BeginContext(400, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(453, 19, false);
#line 18 "/Users/tibor/Worx/10xone/Views/Statistics/_StatisticItemsListPartial.cshtml"
           Write(item.TotalComission);

#line default
#line hidden
            EndContext();
            BeginContext(472, 37, true);
            WriteLiteral("\n            </td>\n        </tr>    \n");
            EndContext();
#line 21 "/Users/tibor/Worx/10xone/Views/Statistics/_StatisticItemsListPartial.cshtml"
        rowNum++;
    }

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TenXOne.ViewModels.StatisticsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
