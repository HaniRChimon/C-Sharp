#pragma checksum "/Users/HaniC/Desktop/Review Course/C#/Dojo_Dachi/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf113833e7fe74c87797c2cf3a6326fc528ae888"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/Users/HaniC/Desktop/Review Course/C#/Dojo_Dachi/Views/_ViewImports.cshtml"
using Dojo_Dachi;

#line default
#line hidden
#line 2 "/Users/HaniC/Desktop/Review Course/C#/Dojo_Dachi/Views/_ViewImports.cshtml"
using Dojo_Dachi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf113833e7fe74c87797c2cf3a6326fc528ae888", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce0d4e49454b28a56b0357a525aa162d4f86f304", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(35, 209, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf113833e7fe74c87797c2cf3a6326fc528ae8883281", async() => {
                BeginContext(41, 196, true);
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\r\n    <title>Dojo_Dachi</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(244, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(246, 752, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf113833e7fe74c87797c2cf3a6326fc528ae8884655", async() => {
                BeginContext(252, 10, true);
                WriteLiteral("\r\n    <h1>");
                EndContext();
                BeginContext(263, 15, false);
#line 10 "/Users/HaniC/Desktop/Review Course/C#/Dojo_Dachi/Views/Home/Index.cshtml"
   Write(ViewBag.Message);

#line default
#line hidden
                EndContext();
                BeginContext(278, 332, true);
                WriteLiteral(@"</h1>
<div id=""petBox"">
    <div id=""buttons"">
        <button><a href=""/feed"">Feed</a></button>
        <button><a href=""/play"">Play</a></button>
        <button><a href=""/work"">Work</a></button>
        <button><a href=""/sleep"">Sleep</a></button>
    </div>
    <div class=""thing"">
        <h4>HAPPINESS</h4>
        <p>");
                EndContext();
                BeginContext(611, 17, false);
#line 20 "/Users/HaniC/Desktop/Review Course/C#/Dojo_Dachi/Views/Home/Index.cshtml"
      Write(ViewBag.Happiness);

#line default
#line hidden
                EndContext();
                BeginContext(628, 81, true);
                WriteLiteral("</p>\r\n    </div>\r\n    <div class=\"thing\">\r\n        <h4>FULLNESS</h4>\r\n        <p>");
                EndContext();
                BeginContext(710, 16, false);
#line 24 "/Users/HaniC/Desktop/Review Course/C#/Dojo_Dachi/Views/Home/Index.cshtml"
      Write(ViewBag.Fullness);

#line default
#line hidden
                EndContext();
                BeginContext(726, 79, true);
                WriteLiteral("</p>\r\n    </div>\r\n    <div class=\"thing\">\r\n        <h4>ENERGY</h4>\r\n        <p>");
                EndContext();
                BeginContext(806, 14, false);
#line 28 "/Users/HaniC/Desktop/Review Course/C#/Dojo_Dachi/Views/Home/Index.cshtml"
      Write(ViewBag.Energy);

#line default
#line hidden
                EndContext();
                BeginContext(820, 78, true);
                WriteLiteral("</p>\r\n    </div>\r\n    <div class=\"thing\">\r\n        <h4>MEALS</h4>\r\n        <p>");
                EndContext();
                BeginContext(899, 13, false);
#line 32 "/Users/HaniC/Desktop/Review Course/C#/Dojo_Dachi/Views/Home/Index.cshtml"
      Write(ViewBag.Meals);

#line default
#line hidden
                EndContext();
                BeginContext(912, 79, true);
                WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n\r\n\r\n<button><a href=\"/restart\">Restart</a></button>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(998, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591