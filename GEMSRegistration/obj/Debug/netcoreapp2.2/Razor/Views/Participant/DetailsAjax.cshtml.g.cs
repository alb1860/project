#pragma checksum "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Participant\DetailsAjax.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3e6db5de24fdaf055360a607664d140734b0d26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Participant_DetailsAjax), @"mvc.1.0.view", @"/Views/Participant/DetailsAjax.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Participant/DetailsAjax.cshtml", typeof(AspNetCore.Views_Participant_DetailsAjax))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3e6db5de24fdaf055360a607664d140734b0d26", @"/Views/Participant/DetailsAjax.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b8453b01f78480feb0132b49b7df0a8b052be03", @"/Views/_ViewImports.cshtml")]
    public class Views_Participant_DetailsAjax : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GEMSRegistration.Models.Participant>
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
            BeginContext(44, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Participant\DetailsAjax.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(138, 146, true);
            WriteLiteral("\r\n<script>\r\n        function GetParticipantWorkshops(participantId) {\r\n            $.ajax({\r\n                type: \"POST\",\r\n                url: \"");
            EndContext();
            BeginContext(285, 51, false);
#line 13 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Participant\DetailsAjax.cshtml"
                 Write(Url.Action("GetParticipantWorkshops","Participant"));

#line default
#line hidden
            EndContext();
            BeginContext(336, 649, true);
            WriteLiteral(@""",
                data: { id : participantId },
                success: function (_ParticipantWorkshops)
                {
                    $(""#pvWorkshops"").html(_ParticipantWorkshops);
                },
                error: function ()
                {
                    alert(""No workshops scheduled"" + participantId);
                }
            });
        }
</script>
<h3 align=""center""> GEMS Registration</h3>
<h4 align=""center"">Participant Workshop Details</h4>
<br />
<div class=""container"">
    <div>
        <hr />
        <dl class=""dl-horizontal"">


            <dt class=""col-sm-2"">
                ");
            EndContext();
            BeginContext(986, 41, false);
#line 36 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Participant\DetailsAjax.cshtml"
           Write(Html.DisplayNameFor(model => model.FName));

#line default
#line hidden
            EndContext();
            BeginContext(1027, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1101, 37, false);
#line 39 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Participant\DetailsAjax.cshtml"
           Write(Html.DisplayFor(model => model.FName));

#line default
#line hidden
            EndContext();
            BeginContext(1138, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(1211, 41, false);
#line 42 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Participant\DetailsAjax.cshtml"
           Write(Html.DisplayNameFor(model => model.LName));

#line default
#line hidden
            EndContext();
            BeginContext(1252, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1326, 37, false);
#line 45 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Participant\DetailsAjax.cshtml"
           Write(Html.DisplayFor(model => model.LName));

#line default
#line hidden
            EndContext();
            BeginContext(1363, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(1436, 41, false);
#line 48 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Participant\DetailsAjax.cshtml"
           Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1477, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1551, 37, false);
#line 51 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Participant\DetailsAjax.cshtml"
           Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1588, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(1661, 41, false);
#line 54 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Participant\DetailsAjax.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1702, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1776, 37, false);
#line 57 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Participant\DetailsAjax.cshtml"
           Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1813, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(1886, 48, false);
#line 60 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Participant\DetailsAjax.cshtml"
           Write(Html.DisplayNameFor(model => model.ContactFName));

#line default
#line hidden
            EndContext();
            BeginContext(1934, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(2008, 44, false);
#line 63 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Participant\DetailsAjax.cshtml"
           Write(Html.DisplayFor(model => model.ContactFName));

#line default
#line hidden
            EndContext();
            BeginContext(2052, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(2125, 48, false);
#line 66 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Participant\DetailsAjax.cshtml"
           Write(Html.DisplayNameFor(model => model.ContactLName));

#line default
#line hidden
            EndContext();
            BeginContext(2173, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(2247, 44, false);
#line 69 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Participant\DetailsAjax.cshtml"
           Write(Html.DisplayFor(model => model.ContactLName));

#line default
#line hidden
            EndContext();
            BeginContext(2291, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(2364, 39, false);
#line 72 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Participant\DetailsAjax.cshtml"
           Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
            EndContext();
            BeginContext(2403, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(2477, 35, false);
#line 75 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Participant\DetailsAjax.cshtml"
           Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
            EndContext();
            BeginContext(2512, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(2585, 52, false);
#line 78 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Participant\DetailsAjax.cshtml"
           Write(Html.DisplayNameFor(model => model.RegistrationDate));

#line default
#line hidden
            EndContext();
            BeginContext(2637, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(2711, 48, false);
#line 81 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Participant\DetailsAjax.cshtml"
           Write(Html.DisplayFor(model => model.RegistrationDate));

#line default
#line hidden
            EndContext();
            BeginContext(2759, 144, true);
            WriteLiteral("\r\n            </dd>\r\n\r\n        </dl>\r\n    </div>\r\n\r\n    <div id=\"pvWorkshops\">\r\n\r\n    </div>\r\n    <div>\r\n        <button class=\"btn btn-default\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2903, "\"", 2947, 3);
            WriteAttributeValue("", 2913, "GetParticipantWorkshops(", 2913, 24, true);
#line 91 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Participant\DetailsAjax.cshtml"
WriteAttributeValue("", 2937, Model.ID, 2937, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 2946, ")", 2946, 1, true);
            EndWriteAttribute();
            BeginContext(2948, 36, true);
            WriteLiteral(">Show Workshops</button> |\r\n        ");
            EndContext();
            BeginContext(2984, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3e6db5de24fdaf055360a607664d140734b0d2614524", async() => {
                BeginContext(3030, 4, true);
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
#line 92 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Participant\DetailsAjax.cshtml"
                               WriteLiteral(Model.ID);

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
            BeginContext(3038, 12, true);
            WriteLiteral(" |\r\n        ");
            EndContext();
            BeginContext(3050, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3e6db5de24fdaf055360a607664d140734b0d2616931", async() => {
                BeginContext(3072, 12, true);
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
            BeginContext(3088, 105, true);
            WriteLiteral("\r\n\r\n    </div>\r\n    <div><p align=\"center\">Angelia Bendolph<br />May 7, 2020 </p></div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GEMSRegistration.Models.Participant> Html { get; private set; }
    }
}
#pragma warning restore 1591
