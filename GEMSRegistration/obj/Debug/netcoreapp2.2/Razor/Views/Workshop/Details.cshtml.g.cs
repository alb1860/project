#pragma checksum "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Workshop\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4b87f14d6295b316b3ec68afe210b5c04e8c944"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Workshop_Details), @"mvc.1.0.view", @"/Views/Workshop/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Workshop/Details.cshtml", typeof(AspNetCore.Views_Workshop_Details))]
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
#line 1 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\_ViewImports.cshtml"
using GEMSRegistration.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4b87f14d6295b316b3ec68afe210b5c04e8c944", @"/Views/Workshop/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b8453b01f78480feb0132b49b7df0a8b052be03", @"/Views/_ViewImports.cshtml")]
    public class Views_Workshop_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GEMSRegistration.Models.Workshop>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Workshop\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(133, 230, true);
            WriteLiteral("<h3 align=\"center\">GEMS Registration</h3>\r\n<h4 align=\"center\">Workshop Details</h4>\r\n<div class=\"container\">\r\n    <div>\r\n        <hr />\r\n        <br />\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(364, 48, false);
#line 15 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Workshop\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.WorkshopName));

#line default
#line hidden
            EndContext();
            BeginContext(412, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(486, 44, false);
#line 18 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Workshop\Details.cshtml"
           Write(Html.DisplayFor(model => model.WorkshopName));

#line default
#line hidden
            EndContext();
            BeginContext(530, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(603, 55, false);
#line 21 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Workshop\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.WorkshopDescription));

#line default
#line hidden
            EndContext();
            BeginContext(658, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(732, 51, false);
#line 24 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Workshop\Details.cshtml"
           Write(Html.DisplayFor(model => model.WorkshopDescription));

#line default
#line hidden
            EndContext();
            BeginContext(783, 161, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                Facilitator Name\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(945, 49, false);
#line 30 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Workshop\Details.cshtml"
           Write(Html.DisplayFor(model => model.Facilitator.FName));

#line default
#line hidden
            EndContext();
            BeginContext(994, 6, true);
            WriteLiteral("&nbsp;");
            EndContext();
            BeginContext(1001, 49, false);
#line 30 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Workshop\Details.cshtml"
                                                                   Write(Html.DisplayFor(model => model.Facilitator.LName));

#line default
#line hidden
            EndContext();
            BeginContext(1050, 161, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                Participant Name\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1212, 49, false);
#line 36 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Workshop\Details.cshtml"
           Write(Html.DisplayFor(model => model.Participant.FName));

#line default
#line hidden
            EndContext();
            BeginContext(1261, 6, true);
            WriteLiteral("&nbsp;");
            EndContext();
            BeginContext(1268, 49, false);
#line 36 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Workshop\Details.cshtml"
                                                                   Write(Html.DisplayFor(model => model.Participant.LName));

#line default
#line hidden
            EndContext();
            BeginContext(1317, 81, true);
            WriteLiteral("\r\n            </dd>\r\n            \r\n        </dl>\r\n    </div>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(1398, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4b87f14d6295b316b3ec68afe210b5c04e8c9448741", async() => {
                BeginContext(1452, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 42 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Workshop\Details.cshtml"
                               WriteLiteral(Model.WorkshopID);

#line default
#line hidden
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
            EndContext();
            BeginContext(1460, 12, true);
            WriteLiteral(" |\r\n        ");
            EndContext();
            BeginContext(1472, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4b87f14d6295b316b3ec68afe210b5c04e8c94411148", async() => {
                BeginContext(1494, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1510, 95, true);
            WriteLiteral("\r\n    </div>\r\n\r\n    <div><p align=\"center\">Angelia Bendolph<br />May 7, 2020 </p></div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GEMSRegistration.Models.Workshop> Html { get; private set; }
    }
}
#pragma warning restore 1591
