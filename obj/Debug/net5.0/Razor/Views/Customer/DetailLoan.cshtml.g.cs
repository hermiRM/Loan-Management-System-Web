#pragma checksum "C:\Users\THE-GREEN\Source\Repos\LoanManagementSystem\LoanManagementSystem\Views\Customer\DetailLoan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "411fb436c5c55213c4f1028454a63621aed9ede2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_DetailLoan), @"mvc.1.0.view", @"/Views/Customer/DetailLoan.cshtml")]
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
#line 1 "C:\Users\THE-GREEN\Source\Repos\LoanManagementSystem\LoanManagementSystem\Views\_ViewImports.cshtml"
using LoanManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\THE-GREEN\Source\Repos\LoanManagementSystem\LoanManagementSystem\Views\_ViewImports.cshtml"
using LoanManagementSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"411fb436c5c55213c4f1028454a63621aed9ede2", @"/Views/Customer/DetailLoan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d508e6d3c891b03c46f7e3d5aa14adb343dab55", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_DetailLoan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoanManagementSystem.Models.Loan>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditLoan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewLoan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\THE-GREEN\Source\Repos\LoanManagementSystem\LoanManagementSystem\Views\Customer\DetailLoan.cshtml"
  
    ViewData["Title"] = "Loan";
    ViewBag.LoanActive = "active";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Loan Detail</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\THE-GREEN\Source\Repos\LoanManagementSystem\LoanManagementSystem\Views\Customer\DetailLoan.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\THE-GREEN\Source\Repos\LoanManagementSystem\LoanManagementSystem\Views\Customer\DetailLoan.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\THE-GREEN\Source\Repos\LoanManagementSystem\LoanManagementSystem\Views\Customer\DetailLoan.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\THE-GREEN\Source\Repos\LoanManagementSystem\LoanManagementSystem\Views\Customer\DetailLoan.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\THE-GREEN\Source\Repos\LoanManagementSystem\LoanManagementSystem\Views\Customer\DetailLoan.cshtml"
       Write(Html.DisplayNameFor(model => model.MiddleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\THE-GREEN\Source\Repos\LoanManagementSystem\LoanManagementSystem\Views\Customer\DetailLoan.cshtml"
       Write(Html.DisplayFor(model => model.MiddleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\THE-GREEN\Source\Repos\LoanManagementSystem\LoanManagementSystem\Views\Customer\DetailLoan.cshtml"
       Write(Html.DisplayNameFor(model => model.Sex));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\THE-GREEN\Source\Repos\LoanManagementSystem\LoanManagementSystem\Views\Customer\DetailLoan.cshtml"
       Write(Html.DisplayFor(model => model.Sex));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\THE-GREEN\Source\Repos\LoanManagementSystem\LoanManagementSystem\Views\Customer\DetailLoan.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\THE-GREEN\Source\Repos\LoanManagementSystem\LoanManagementSystem\Views\Customer\DetailLoan.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\THE-GREEN\Source\Repos\LoanManagementSystem\LoanManagementSystem\Views\Customer\DetailLoan.cshtml"
       Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\THE-GREEN\Source\Repos\LoanManagementSystem\LoanManagementSystem\Views\Customer\DetailLoan.cshtml"
       Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n       \r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\THE-GREEN\Source\Repos\LoanManagementSystem\LoanManagementSystem\Views\Customer\DetailLoan.cshtml"
       Write(Html.DisplayNameFor(model => model.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\THE-GREEN\Source\Repos\LoanManagementSystem\LoanManagementSystem\Views\Customer\DetailLoan.cshtml"
       Write(Html.DisplayFor(model => model.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ETB\r\n        </dd>\r\n       \r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 58 "C:\Users\THE-GREEN\Source\Repos\LoanManagementSystem\LoanManagementSystem\Views\Customer\DetailLoan.cshtml"
       Write(Html.DisplayNameFor(model => model.loanPurpose));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 61 "C:\Users\THE-GREEN\Source\Repos\LoanManagementSystem\LoanManagementSystem\Views\Customer\DetailLoan.cshtml"
       Write(Html.DisplayFor(model => model.loanPurpose));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 64 "C:\Users\THE-GREEN\Source\Repos\LoanManagementSystem\LoanManagementSystem\Views\Customer\DetailLoan.cshtml"
       Write(Html.DisplayNameFor(model => model.loanAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 67 "C:\Users\THE-GREEN\Source\Repos\LoanManagementSystem\LoanManagementSystem\Views\Customer\DetailLoan.cshtml"
       Write(Html.DisplayFor(model => model.loanAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ETB\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 70 "C:\Users\THE-GREEN\Source\Repos\LoanManagementSystem\LoanManagementSystem\Views\Customer\DetailLoan.cshtml"
       Write(Html.DisplayNameFor(model => model.LoanGrant));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 73 "C:\Users\THE-GREEN\Source\Repos\LoanManagementSystem\LoanManagementSystem\Views\Customer\DetailLoan.cshtml"
       Write(Html.DisplayFor(model => model.LoanGrant));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 76 "C:\Users\THE-GREEN\Source\Repos\LoanManagementSystem\LoanManagementSystem\Views\Customer\DetailLoan.cshtml"
       Write(Html.DisplayNameFor(model => model.loanDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 79 "C:\Users\THE-GREEN\Source\Repos\LoanManagementSystem\LoanManagementSystem\Views\Customer\DetailLoan.cshtml"
       Write(Html.DisplayFor(model => model.loanDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 82 "C:\Users\THE-GREEN\Source\Repos\LoanManagementSystem\LoanManagementSystem\Views\Customer\DetailLoan.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalPayableAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 85 "C:\Users\THE-GREEN\Source\Repos\LoanManagementSystem\LoanManagementSystem\Views\Customer\DetailLoan.cshtml"
       Write(Html.DisplayFor(model => model.TotalPayableAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ETB\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 88 "C:\Users\THE-GREEN\Source\Repos\LoanManagementSystem\LoanManagementSystem\Views\Customer\DetailLoan.cshtml"
       Write(Html.DisplayNameFor(model => model.MonthlyPayableAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 91 "C:\Users\THE-GREEN\Source\Repos\LoanManagementSystem\LoanManagementSystem\Views\Customer\DetailLoan.cshtml"
       Write(Html.DisplayFor(model => model.MonthlyPayableAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ETB\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 94 "C:\Users\THE-GREEN\Source\Repos\LoanManagementSystem\LoanManagementSystem\Views\Customer\DetailLoan.cshtml"
       Write(Html.DisplayNameFor(model => model.MonthlyPenalty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 97 "C:\Users\THE-GREEN\Source\Repos\LoanManagementSystem\LoanManagementSystem\Views\Customer\DetailLoan.cshtml"
       Write(Html.DisplayFor(model => model.MonthlyPenalty));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ETB\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 100 "C:\Users\THE-GREEN\Source\Repos\LoanManagementSystem\LoanManagementSystem\Views\Customer\DetailLoan.cshtml"
       Write(Html.DisplayNameFor(model => model.RejectionReason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 103 "C:\Users\THE-GREEN\Source\Repos\LoanManagementSystem\LoanManagementSystem\Views\Customer\DetailLoan.cshtml"
       Write(Html.DisplayFor(model => model.RejectionReason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n       \r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "411fb436c5c55213c4f1028454a63621aed9ede215514", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 109 "C:\Users\THE-GREEN\Source\Repos\LoanManagementSystem\LoanManagementSystem\Views\Customer\DetailLoan.cshtml"
                                                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "411fb436c5c55213c4f1028454a63621aed9ede217799", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoanManagementSystem.Models.Loan> Html { get; private set; }
    }
}
#pragma warning restore 1591
