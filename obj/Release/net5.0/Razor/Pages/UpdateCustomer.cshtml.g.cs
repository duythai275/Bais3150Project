#pragma checksum "C:\Data\NAIT\BAIST3150 - Software Tools\BAIS3150Project\Pages\UpdateCustomer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ea50427bf9e2a0baab137f1f852c30bcb790335"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BAIS3150Project.Pages.Pages_UpdateCustomer), @"mvc.1.0.razor-page", @"/Pages/UpdateCustomer.cshtml")]
namespace BAIS3150Project.Pages
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
#line 1 "C:\Data\NAIT\BAIST3150 - Software Tools\BAIS3150Project\Pages\_ViewImports.cshtml"
using BAIS3150Project.Pages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ea50427bf9e2a0baab137f1f852c30bcb790335", @"/Pages/UpdateCustomer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44e8e54bad5b281c520a6affcab169ae9056787b", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_UpdateCustomer : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Update"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Data\NAIT\BAIST3150 - Software Tools\BAIS3150Project\Pages\UpdateCustomer.cshtml"
  
    Layout = "_Layout";
    ViewData["Tittle"] = "Update Customer";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Update Customer</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ea50427bf9e2a0baab137f1f852c30bcb7903355816", async() => {
                WriteLiteral("\r\n    <table>\r\n        <tr>\r\n            <td>Customer Id:</td>\r\n            <td>\r\n                <input type=\"text\" name=\"SearchCustomerId\" />\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 16 "C:\Data\NAIT\BAIST3150 - Software Tools\BAIS3150Project\Pages\UpdateCustomer.cshtml"
           Write(Html.ValidationMessage("SearchCustomerId"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td colspan=\"2\" align=\"right\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0ea50427bf9e2a0baab137f1f852c30bcb7903356675", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>Customer Id:</td>\r\n            <td>\r\n                <input type=\"text\" hidden name=\"CustomerId\"");
                BeginWriteAttribute("value", " value=\"", 769, "\"", 794, 1);
#nullable restore
#line 27 "C:\Data\NAIT\BAIST3150 - Software Tools\BAIS3150Project\Pages\UpdateCustomer.cshtml"
WriteAttributeValue("", 777, Model.CustomerId, 777, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <input type=\"text\" disabled");
                BeginWriteAttribute("value", " value=\"", 843, "\"", 868, 1);
#nullable restore
#line 28 "C:\Data\NAIT\BAIST3150 - Software Tools\BAIS3150Project\Pages\UpdateCustomer.cshtml"
WriteAttributeValue("", 851, Model.CustomerId, 851, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Data\NAIT\BAIST3150 - Software Tools\BAIS3150Project\Pages\UpdateCustomer.cshtml"
           Write(Html.ValidationMessage("CustomerId"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>Customer Name:</td>\r\n            <td>\r\n                <input type=\"text\" name=\"CustomerName\"");
                BeginWriteAttribute("value", " value=\"", 1123, "\"", 1150, 1);
#nullable restore
#line 37 "C:\Data\NAIT\BAIST3150 - Software Tools\BAIS3150Project\Pages\UpdateCustomer.cshtml"
WriteAttributeValue("", 1131, Model.CustomerName, 1131, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Data\NAIT\BAIST3150 - Software Tools\BAIS3150Project\Pages\UpdateCustomer.cshtml"
           Write(Html.ValidationMessage("CustomerName"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>Address:</td>\r\n            <td>\r\n                <input type=\"text\" name=\"Address\"");
                BeginWriteAttribute("value", " value=\"", 1396, "\"", 1418, 1);
#nullable restore
#line 46 "C:\Data\NAIT\BAIST3150 - Software Tools\BAIS3150Project\Pages\UpdateCustomer.cshtml"
WriteAttributeValue("", 1404, Model.Address, 1404, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Data\NAIT\BAIST3150 - Software Tools\BAIS3150Project\Pages\UpdateCustomer.cshtml"
           Write(Html.ValidationMessage("Address"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>City:</td>\r\n            <td>\r\n                <input type=\"text\" name=\"City\"");
                BeginWriteAttribute("value", " value=\"", 1653, "\"", 1672, 1);
#nullable restore
#line 55 "C:\Data\NAIT\BAIST3150 - Software Tools\BAIS3150Project\Pages\UpdateCustomer.cshtml"
WriteAttributeValue("", 1661, Model.City, 1661, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Data\NAIT\BAIST3150 - Software Tools\BAIS3150Project\Pages\UpdateCustomer.cshtml"
           Write(Html.ValidationMessage("City"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>Province:</td>\r\n            <td>\r\n                <input type=\"text\" name=\"Province\"");
                BeginWriteAttribute("value", " value=\"", 1912, "\"", 1935, 1);
#nullable restore
#line 64 "C:\Data\NAIT\BAIST3150 - Software Tools\BAIS3150Project\Pages\UpdateCustomer.cshtml"
WriteAttributeValue("", 1920, Model.Province, 1920, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "C:\Data\NAIT\BAIST3150 - Software Tools\BAIS3150Project\Pages\UpdateCustomer.cshtml"
           Write(Html.ValidationMessage("Province"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>Postal Code:</td>\r\n            <td>\r\n                <input type=\"text\" name=\"PostalCode\"");
                BeginWriteAttribute("value", " value=\"", 2184, "\"", 2209, 1);
#nullable restore
#line 73 "C:\Data\NAIT\BAIST3150 - Software Tools\BAIS3150Project\Pages\UpdateCustomer.cshtml"
WriteAttributeValue("", 2192, Model.PostalCode, 2192, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "C:\Data\NAIT\BAIST3150 - Software Tools\BAIS3150Project\Pages\UpdateCustomer.cshtml"
           Write(Html.ValidationMessage("PostalCode"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td colspan=\"2\" align=\"right\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0ea50427bf9e2a0baab137f1f852c30bcb79033513828", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 86 "C:\Data\NAIT\BAIST3150 - Software Tools\BAIS3150Project\Pages\UpdateCustomer.cshtml"
Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BAIS3150Project.Pages.UpdateCustomerModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BAIS3150Project.Pages.UpdateCustomerModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BAIS3150Project.Pages.UpdateCustomerModel>)PageContext?.ViewData;
        public BAIS3150Project.Pages.UpdateCustomerModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591