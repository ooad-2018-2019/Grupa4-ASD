#pragma checksum "C:\Users\HP\Downloads\HospitalisOOAD (4)\HospitalisOOAD\Views\Izvjestajs\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4cabed506b66f20f6bacbba246f54df4516d570"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Izvjestajs_Details), @"mvc.1.0.view", @"/Views/Izvjestajs/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Izvjestajs/Details.cshtml", typeof(AspNetCore.Views_Izvjestajs_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4cabed506b66f20f6bacbba246f54df4516d570", @"/Views/Izvjestajs/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"920630ffba29559c173fef7c8e76641c5b4741b6", @"/Views/_ViewImports.cshtml")]
    public class Views_Izvjestajs_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HospitalisOOAD.Models.Izvjestaj>
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
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\HP\Downloads\HospitalisOOAD (4)\HospitalisOOAD\Views\Izvjestajs\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#line 6 "C:\Users\HP\Downloads\HospitalisOOAD (4)\HospitalisOOAD\Views\Izvjestajs\Details.cshtml"
  
    Layout = "_Layout2";

#line default
#line hidden
            BeginContext(118, 138, true);
            WriteLiteral("\r\n<h2 style=\"height: 30px;\"></h2>\r\n\r\n<div>\r\n    <h4>Izvještaj</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(257, 52, false);
#line 17 "C:\Users\HP\Downloads\HospitalisOOAD (4)\HospitalisOOAD\Views\Izvjestajs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.rezultatPregleda));

#line default
#line hidden
            EndContext();
            BeginContext(309, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(353, 48, false);
#line 20 "C:\Users\HP\Downloads\HospitalisOOAD (4)\HospitalisOOAD\Views\Izvjestajs\Details.cshtml"
       Write(Html.DisplayFor(model => model.rezultatPregleda));

#line default
#line hidden
            EndContext();
            BeginContext(401, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(445, 50, false);
#line 23 "C:\Users\HP\Downloads\HospitalisOOAD (4)\HospitalisOOAD\Views\Izvjestajs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.datumIzdavanja));

#line default
#line hidden
            EndContext();
            BeginContext(495, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(539, 46, false);
#line 26 "C:\Users\HP\Downloads\HospitalisOOAD (4)\HospitalisOOAD\Views\Izvjestajs\Details.cshtml"
       Write(Html.DisplayFor(model => model.datumIzdavanja));

#line default
#line hidden
            EndContext();
            BeginContext(585, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(629, 44, false);
#line 29 "C:\Users\HP\Downloads\HospitalisOOAD (4)\HospitalisOOAD\Views\Izvjestajs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Korisnik));

#line default
#line hidden
            EndContext();
            BeginContext(673, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(717, 43, false);
#line 32 "C:\Users\HP\Downloads\HospitalisOOAD (4)\HospitalisOOAD\Views\Izvjestajs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Korisnik.ID));

#line default
#line hidden
            EndContext();
            BeginContext(760, 85, true);
            WriteLiteral("                  <!--diskriminator-->\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(845, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c1dbe359ad046bbad6e9346c685ba5d", async() => {
                BeginContext(867, 16, true);
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
            BeginContext(887, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HospitalisOOAD.Models.Izvjestaj> Html { get; private set; }
    }
}
#pragma warning restore 1591
