#pragma checksum "D:\PRACTICE PROJECT\GYM\GYM\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe891cd2f4f7b9e6d4ed72eb06b9dfafaa66f9bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
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
#line 1 "D:\PRACTICE PROJECT\GYM\GYM\Views\_ViewImports.cshtml"
using GYM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PRACTICE PROJECT\GYM\GYM\Views\_ViewImports.cshtml"
using GYM.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe891cd2f4f7b9e6d4ed72eb06b9dfafaa66f9bf", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"616022f54c4512ed9297f6e8400abbc6283d25b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\PRACTICE PROJECT\GYM\GYM\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section id=\"newsletter\" class=\"parallax-section\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <h1 class=\"text-danger\">Error.</h1>\r\n            <h2 class=\"text-danger\">An error occurred while processing your request.</h2>\r\n\r\n");
#nullable restore
#line 12 "D:\PRACTICE PROJECT\GYM\GYM\Views\Shared\Error.cshtml"
             if (Model.ShowRequestId)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>\r\n                    <strong>Request ID:</strong> <code>");
#nullable restore
#line 15 "D:\PRACTICE PROJECT\GYM\GYM\Views\Shared\Error.cshtml"
                                                  Write(Model.RequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code>\r\n                </p>\r\n");
#nullable restore
#line 17 "D:\PRACTICE PROJECT\GYM\GYM\Views\Shared\Error.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <h3>Development Mode</h3>
            <p>
                Swapping to <strong>Development</strong> environment will display more detailed information about the error that occurred.
            </p>
            <p>
                <strong>The Development environment shouldn't be enabled for deployed applications.</strong>
                It can result in displaying sensitive information from exceptions to end users.
                For local debugging, enable the <strong>Development</strong> environment by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>
                and restarting the app.
            </p>
            </div>
    </div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591