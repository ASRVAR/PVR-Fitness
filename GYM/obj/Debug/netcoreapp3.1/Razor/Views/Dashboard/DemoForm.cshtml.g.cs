#pragma checksum "D:\PRACTICE PROJECT\GYM\GYM\Views\Dashboard\DemoForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b85c5eaae21410cb386e12667e8ef669712166ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_DemoForm), @"mvc.1.0.view", @"/Views/Dashboard/DemoForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b85c5eaae21410cb386e12667e8ef669712166ab", @"/Views/Dashboard/DemoForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"616022f54c4512ed9297f6e8400abbc6283d25b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_DemoForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\PRACTICE PROJECT\GYM\GYM\Views\Dashboard\DemoForm.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutDashboard.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""content-wrapper"">
    <!-- Container-fluid starts -->
    <div class=""container-fluid"">
        <!-- Main content starts -->
        <div>
            <!-- Row Starts -->
            <div class=""row"">
                <div class=""col-sm-12 p-0"">
                    <div class=""main-header"">
                        <h4>General Elements</h4>
                        <ol class=""breadcrumb breadcrumb-title breadcrumb-arrow"">
                            <li class=""breadcrumb-item"">
                                <a href=""index.html""><i class=""icofont icofont-home""></i></a>
                            </li>
                            <li class=""breadcrumb-item"">
                                <a href=""#"">Forms Components</a>
                            </li>
                            <li class=""breadcrumb-item"">
                                <a href=""form-elements-bootstrap.html"">General Elements</a>
                            </li>
                        </ol>
              ");
            WriteLiteral(@"      </div>
                </div>
            </div>
            <!-- Row end -->
            <!-- Row start -->
            <div class=""row"">
                <!-- Form Control starts -->
                <div class=""col-lg-12"">
                    <div class=""card"">
                        <div class=""card-header"">
                            <h5 class=""card-header-text"">Input Types</h5>
                            <div class=""f-right"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 1610, "\"", 1617, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-toggle=""modal"" data-target=""#input-type-Modal""><i class=""icofont icofont-code-alt""></i></a>
                            </div>
                        </div>
                       
                        <!-- end of modal -->

                        <div class=""card-block"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b85c5eaae21410cb386e12667e8ef669712166ab5441", async() => {
                WriteLiteral(@"
                                <div class=""col-md-4"">
                                    <div class=""form-group"">
                                        <label for=""exampleInputEmail1"" class=""form-control-label"">Email address Pawan</label>
                                        <input type=""email"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp"" placeholder=""Enter email"">
                                      </div>
                                </div>
                                <div class=""col-md-4"">
                                    <div class=""form-group"">
                                        <label for=""exampleInputPassword1"" class=""form-control-label"">Password</label>
                                        <input type=""password"" class=""form-control"" id=""exampleInputPassword1"" placeholder=""Password"">
                                    </div>
                                </div>
                                <div class=""col-md-4"">
              ");
                WriteLiteral(@"                      <div class=""form-group"">
                                        <label for=""exampleInputPassword1"" class=""form-control-label"">Password</label>
                                        <input type=""password"" class=""form-control"" id=""exampleInputPassword1"" placeholder=""Password"">
                                    </div>
                                </div>
                                <div class=""col-md-4"">
                                    <div class=""form-group"">
                                        <label for=""exampleInputEmail1"" class=""form-control-label"">Email address Pawan</label>
                                        <input type=""email"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp"" placeholder=""Enter email"">
                                       </div>
                                </div>
                                <div class=""col-md-4"">
                                    <div class=""form-group"">
                       ");
                WriteLiteral(@"                 <label for=""exampleInputPassword1"" class=""form-control-label"">Password</label>
                                        <input type=""password"" class=""form-control"" id=""exampleInputPassword1"" placeholder=""Password"">
                                    </div>
                                </div>
                                <div class=""col-md-4"">
                                    <div class=""form-group"">
                                        <label for=""exampleInputPassword1"" class=""form-control-label"">Password</label>
                                        <input type=""password"" class=""form-control"" id=""exampleInputPassword1"" placeholder=""Password"">
                                    </div>
                                </div>

                                  
                                    <button type=""submit"" class=""btn btn-success waves-effect waves-light m-r-30"">Submit</button>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <!-- Form Control ends -->
              
            </div>
            <!-- Row end -->
           
        </div>
        <!-- Main content ends -->
    </div>
    <!-- Container-fluid ends -->
</div>");
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
