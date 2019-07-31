#pragma checksum "/Users/tibor/Worx/10xone/Views/FinancialItems/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b103c974074d4b74dea4b11f2f20ecf427e28fdc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FinancialItems_Index), @"mvc.1.0.view", @"/Views/FinancialItems/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FinancialItems/Index.cshtml", typeof(AspNetCore.Views_FinancialItems_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b103c974074d4b74dea4b11f2f20ecf427e28fdc", @"/Views/FinancialItems/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ee098459ea483f873895e55b0a37cbc3422cf2e", @"/Views/_ViewImports.cshtml")]
    public class Views_FinancialItems_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TenXOne.ViewModels.FinancialItemsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "FinancialItems", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("POST"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-mode", new global::Microsoft.AspNetCore.Html.HtmlString("replace"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-update", new global::Microsoft.AspNetCore.Html.HtmlString("#financial-items-list"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "/Users/tibor/Worx/10xone/Views/FinancialItems/Index.cshtml"
  
    ViewData["Title"] = "Financial Items";

#line default
#line hidden
            DefineSection("Scripts", async() => {
                BeginContext(120, 378, true);
                WriteLiteral(@"
    <script>
        // Set selected partner at edit dropdown
        $(document).on('click', '.edit-financial-item', function() {
            $('[data-partner-select-num=""' + $(this).data('item-num') + '""]').val($(this).data('selected-partner-id'));
        });

        function hideModal() {
            $('.modal-backdrop').remove();
        }
    </script>
    ");
                EndContext();
                BeginContext(499, 52, false);
#line 16 "/Users/tibor/Worx/10xone/Views/FinancialItems/Index.cshtml"
Write(await Html.PartialAsync("_ValidationScriptsPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(551, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(556, 84, true);
            WriteLiteral("<div class=\"financial-items-container\">\r\n    <div class=\"page-header\">\r\n        <h1>");
            EndContext();
            BeginContext(641, 17, false);
#line 20 "/Users/tibor/Worx/10xone/Views/FinancialItems/Index.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(658, 391, true);
            WriteLiteral(@"</h1>
        <button 
            class=""new-item-btn btn btn-warning"" 
            data-toggle=""collapse"" 
            data-target=""#new-financial-item"" 
            aria-expanded=""false"" 
            aria-controls=""#new-financial-item"">
            <i class=""fa fa-plus-square fa-2x""></i>
        </button>
    </div>
    <div class=""collapse"" id=""new-financial-item"">
        ");
            EndContext();
            BeginContext(1049, 301, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b103c974074d4b74dea4b11f2f20ecf427e28fdc7171", async() => {
                BeginContext(1266, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1281, 52, false);
#line 36 "/Users/tibor/Worx/10xone/Views/FinancialItems/Index.cshtml"
       Write(await Html.PartialAsync("_FinancialItemFormPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(1333, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1350, 858, true);
            WriteLiteral(@"
    </div>
    <div class=""item-list-container container mt-4"">
        <div class=""row"">
            <table class=""table table-striped table-dark"">
                <thead>
                    <tr>
                        <th scope=""col"">
                            #
                        </th>
                        <th scope=""col"">
                            Partner
                        </th>
                        <th scope=""col"">
                            Date
                        </th>
                        <th scope=""col"">
                            Amount
                        </th>
                        <th>
                            Actions
                        </th>
                    </tr>
                </thead>
                <tbody id=""financial-items-list"">
                    ");
            EndContext();
            BeginContext(2209, 53, false);
#line 62 "/Users/tibor/Worx/10xone/Views/FinancialItems/Index.cshtml"
               Write(await Html.PartialAsync("_FinancialItemsListPartial"));

#line default
#line hidden
            EndContext();
            BeginContext(2262, 98, true);
            WriteLiteral("\r\n                </tbody>            \r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TenXOne.ViewModels.FinancialItemsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
