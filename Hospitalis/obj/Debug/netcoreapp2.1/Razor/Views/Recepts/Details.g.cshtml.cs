#pragma checksum "C:\Users\HP\Downloads\HospitalisOOAD (4)\HospitalisOOAD\Views\Recepts\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b3d9c5cc89da303fd88dbd5c84a4721ab2f657f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recepts_Details), @"mvc.1.0.view", @"/Views/Recepts/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Recepts/Details.cshtml", typeof(AspNetCore.Views_Recepts_Details))]
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
#line 1 "C:\Users\HP\Downloads\HospitalisOOAD (4)\HospitalisOOAD\Views\_ViewImports.cshtml"
using HospitalisOOAD;

#line default
#line hidden
#line 2 "C:\Users\HP\Downloads\HospitalisOOAD (4)\HospitalisOOAD\Views\_ViewImports.cshtml"
using HospitalisOOAD.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b3d9c5cc89da303fd88dbd5c84a4721ab2f657f", @"/Views/Recepts/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"920630ffba29559c173fef7c8e76641c5b4741b6", @"/Views/_ViewImports.cshtml")]
    public class Views_Recepts_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HospitalisOOAD.Models.Recept>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\HP\Downloads\HospitalisOOAD (4)\HospitalisOOAD\Views\Recepts\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#line 6 "C:\Users\HP\Downloads\HospitalisOOAD (4)\HospitalisOOAD\Views\Recepts\Details.cshtml"
  
    Layout = "_Layout2";

#line default
#line hidden
            BeginContext(115, 137, true);
            WriteLiteral("\r\n\r\n<h2 style=\"height: 30px;\"></h2>\r\n\r\n<div>\r\n    <h4>Recept</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(253, 47, false);
#line 18 "C:\Users\HP\Downloads\HospitalisOOAD (4)\HospitalisOOAD\Views\Recepts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.nazivLijeka));

#line default
#line hidden
            EndContext();
            BeginContext(300, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(344, 43, false);
#line 21 "C:\Users\HP\Downloads\HospitalisOOAD (4)\HospitalisOOAD\Views\Recepts\Details.cshtml"
       Write(Html.DisplayFor(model => model.nazivLijeka));

#line default
#line hidden
            EndContext();
            BeginContext(387, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(431, 50, false);
#line 24 "C:\Users\HP\Downloads\HospitalisOOAD (4)\HospitalisOOAD\Views\Recepts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.datumIzdavanja));

#line default
#line hidden
            EndContext();
            BeginContext(481, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(525, 46, false);
#line 27 "C:\Users\HP\Downloads\HospitalisOOAD (4)\HospitalisOOAD\Views\Recepts\Details.cshtml"
       Write(Html.DisplayFor(model => model.datumIzdavanja));

#line default
#line hidden
            EndContext();
            BeginContext(571, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(615, 44, false);
#line 30 "C:\Users\HP\Downloads\HospitalisOOAD (4)\HospitalisOOAD\Views\Recepts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Korisnik));

#line default
#line hidden
            EndContext();
            BeginContext(659, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(703, 43, false);
#line 33 "C:\Users\HP\Downloads\HospitalisOOAD (4)\HospitalisOOAD\Views\Recepts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Korisnik.ID));

#line default
#line hidden
            EndContext();
            BeginContext(746, 87, true);
            WriteLiteral("                    <!--diskriminator-->\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(833, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e03eec5b6764b6aae9980d804af68a9", async() => {
                BeginContext(855, 16, true);
                WriteLiteral("Povratak u listu");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(875, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HospitalisOOAD.Models.Recept> Html { get; private set; }
    }
}
#pragma warning restore 1591
