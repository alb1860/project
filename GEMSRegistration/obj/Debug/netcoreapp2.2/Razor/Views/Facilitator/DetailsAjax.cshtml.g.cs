#pragma checksum "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Facilitator\DetailsAjax.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a370fb539343b7a2f27ee5959a22dc4cbdc91fc8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Facilitator_DetailsAjax), @"mvc.1.0.view", @"/Views/Facilitator/DetailsAjax.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Facilitator/DetailsAjax.cshtml", typeof(AspNetCore.Views_Facilitator_DetailsAjax))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a370fb539343b7a2f27ee5959a22dc4cbdc91fc8", @"/Views/Facilitator/DetailsAjax.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b8453b01f78480feb0132b49b7df0a8b052be03", @"/Views/_ViewImports.cshtml")]
    public class Views_Facilitator_DetailsAjax : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GEMSRegistration.Models.Facilitator>
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
#line 4 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Facilitator\DetailsAjax.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(138, 146, true);
            WriteLiteral("\r\n<script>\r\n        function GetFacilitatorWorkshops(facilitatorId) {\r\n            $.ajax({\r\n                type: \"POST\",\r\n                url: \"");
            EndContext();
            BeginContext(285, 51, false);
#line 13 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Facilitator\DetailsAjax.cshtml"
                 Write(Url.Action("GetFacilitatorWorkshops","Facilitator"));

#line default
#line hidden
            EndContext();
            BeginContext(336, 642, true);
            WriteLiteral(@""",
                data: { id : facilitatorId },
                success: function (_FacilitatorWorkshops)
                {
                    $(""#pvWorkshopsFac"").html(_FacilitatorWorkshops);
                },
                error: function ()
                {
                    alert(""No workshops scheduled"" + facilitatorId);
                }
            });
        }
</script>
<h3 align=""center""> GEMS Registration</h3>
<h4 align=""center"">Facilitator Workshop Details</h4>
<div class=""container"">
    <div>
        <hr />
        <dl class=""dl-horizontal"">

            <dt class=""col-sm-2"">
                ");
            EndContext();
            BeginContext(979, 41, false);
#line 34 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Facilitator\DetailsAjax.cshtml"
           Write(Html.DisplayNameFor(model => model.FName));

#line default
#line hidden
            EndContext();
            BeginContext(1020, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1094, 37, false);
#line 37 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Facilitator\DetailsAjax.cshtml"
           Write(Html.DisplayFor(model => model.FName));

#line default
#line hidden
            EndContext();
            BeginContext(1131, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(1204, 41, false);
#line 40 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Facilitator\DetailsAjax.cshtml"
           Write(Html.DisplayNameFor(model => model.LName));

#line default
#line hidden
            EndContext();
            BeginContext(1245, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1319, 37, false);
#line 43 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Facilitator\DetailsAjax.cshtml"
           Write(Html.DisplayFor(model => model.LName));

#line default
#line hidden
            EndContext();
            BeginContext(1356, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(1429, 41, false);
#line 46 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Facilitator\DetailsAjax.cshtml"
           Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1470, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1544, 37, false);
#line 49 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Facilitator\DetailsAjax.cshtml"
           Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1581, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(1654, 41, false);
#line 52 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Facilitator\DetailsAjax.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1695, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1769, 37, false);
#line 55 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Facilitator\DetailsAjax.cshtml"
           Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1806, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(1879, 47, false);
#line 58 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Facilitator\DetailsAjax.cshtml"
           Write(Html.DisplayNameFor(model => model.Affiliation));

#line default
#line hidden
            EndContext();
            BeginContext(1926, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(2000, 43, false);
#line 61 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Facilitator\DetailsAjax.cshtml"
           Write(Html.DisplayFor(model => model.Affiliation));

#line default
#line hidden
            EndContext();
            BeginContext(2043, 147, true);
            WriteLiteral("\r\n            </dd>\r\n\r\n        </dl>\r\n    </div>\r\n    <div id=\"pvWorkshopsFac\">\r\n\r\n    </div>\r\n\r\n    <div>\r\n        <button class=\"btn btn-default\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2190, "\"", 2234, 3);
            WriteAttributeValue("", 2200, "GetFacilitatorWorkshops(", 2200, 24, true);
#line 71 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Facilitator\DetailsAjax.cshtml"
WriteAttributeValue("", 2224, Model.ID, 2224, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 2233, ")", 2233, 1, true);
            EndWriteAttribute();
            BeginContext(2235, 36, true);
            WriteLiteral(">Show Workshops</button> |\r\n        ");
            EndContext();
            BeginContext(2271, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a370fb539343b7a2f27ee5959a22dc4cbdc91fc811417", async() => {
                BeginContext(2317, 4, true);
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
#line 72 "C:\Users\cebco\OneDrive\Desktop\Organization\Info Systems Courses\App Dev\Final Exam\GEMSRegistration\GEMSRegistration\Views\Facilitator\DetailsAjax.cshtml"
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
            BeginContext(2325, 12, true);
            WriteLiteral(" |\r\n        ");
            EndContext();
            BeginContext(2337, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a370fb539343b7a2f27ee5959a22dc4cbdc91fc813824", async() => {
                BeginContext(2359, 12, true);
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
            BeginContext(2375, 105, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GEMSRegistration.Models.Facilitator> Html { get; private set; }
    }
}
#pragma warning restore 1591
