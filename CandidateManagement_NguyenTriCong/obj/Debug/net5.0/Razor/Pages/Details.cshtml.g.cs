#pragma checksum "D:\PRN221PE_FA22_TrialTest_NguyenTriCong\CandidateManagement_NguyenTriCong\Pages\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62ce8b0bd91b5d7cd8fb22e34e165ea28ee387a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CandidateManagement_NguyenTriCong.Pages.Pages_Details), @"mvc.1.0.razor-page", @"/Pages/Details.cshtml")]
namespace CandidateManagement_NguyenTriCong.Pages
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
#line 1 "D:\PRN221PE_FA22_TrialTest_NguyenTriCong\CandidateManagement_NguyenTriCong\Pages\_ViewImports.cshtml"
using CandidateManagement_NguyenTriCong;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62ce8b0bd91b5d7cd8fb22e34e165ea28ee387a0", @"/Pages/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0132ff83c0efed7289d795991574b42591bd5f16", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Candidate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "D:\PRN221PE_FA22_TrialTest_NguyenTriCong\CandidateManagement_NguyenTriCong\Pages\Details.cshtml"
 if (ViewBag.Message != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert-danger\">");
#nullable restore
#line 9 "D:\PRN221PE_FA22_TrialTest_NguyenTriCong\CandidateManagement_NguyenTriCong\Pages\Details.cshtml"
                         Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 10 "D:\PRN221PE_FA22_TrialTest_NguyenTriCong\CandidateManagement_NguyenTriCong\Pages\Details.cshtml"
}
else
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Details</h1>\r\n");
            WriteLiteral("    <h3>Detail information!</h3>\r\n    <div>\r\n        <h4>CandidateProfile</h4>\r\n        <hr />\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 22 "D:\PRN221PE_FA22_TrialTest_NguyenTriCong\CandidateManagement_NguyenTriCong\Pages\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.CandidateProfile.Fullname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 25 "D:\PRN221PE_FA22_TrialTest_NguyenTriCong\CandidateManagement_NguyenTriCong\Pages\Details.cshtml"
           Write(Html.DisplayFor(model => model.CandidateProfile.Fullname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 28 "D:\PRN221PE_FA22_TrialTest_NguyenTriCong\CandidateManagement_NguyenTriCong\Pages\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.CandidateProfile.Birthday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 31 "D:\PRN221PE_FA22_TrialTest_NguyenTriCong\CandidateManagement_NguyenTriCong\Pages\Details.cshtml"
           Write(Html.DisplayFor(model => model.CandidateProfile.Birthday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 34 "D:\PRN221PE_FA22_TrialTest_NguyenTriCong\CandidateManagement_NguyenTriCong\Pages\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.CandidateProfile.ProfileShortDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 37 "D:\PRN221PE_FA22_TrialTest_NguyenTriCong\CandidateManagement_NguyenTriCong\Pages\Details.cshtml"
           Write(Html.DisplayFor(model => model.CandidateProfile.ProfileShortDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 40 "D:\PRN221PE_FA22_TrialTest_NguyenTriCong\CandidateManagement_NguyenTriCong\Pages\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.CandidateProfile.ProfileUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 43 "D:\PRN221PE_FA22_TrialTest_NguyenTriCong\CandidateManagement_NguyenTriCong\Pages\Details.cshtml"
           Write(Html.DisplayFor(model => model.CandidateProfile.ProfileUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 46 "D:\PRN221PE_FA22_TrialTest_NguyenTriCong\CandidateManagement_NguyenTriCong\Pages\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.CandidateProfile.Posting));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 49 "D:\PRN221PE_FA22_TrialTest_NguyenTriCong\CandidateManagement_NguyenTriCong\Pages\Details.cshtml"
           Write(Html.DisplayFor(model => model.CandidateProfile.Posting.PostingId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62ce8b0bd91b5d7cd8fb22e34e165ea28ee387a08064", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 56 "D:\PRN221PE_FA22_TrialTest_NguyenTriCong\CandidateManagement_NguyenTriCong\Pages\Details.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CandidateManagement_NguyenTriCong.Pages.DetailsModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CandidateManagement_NguyenTriCong.Pages.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CandidateManagement_NguyenTriCong.Pages.DetailsModel>)PageContext?.ViewData;
        public CandidateManagement_NguyenTriCong.Pages.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
