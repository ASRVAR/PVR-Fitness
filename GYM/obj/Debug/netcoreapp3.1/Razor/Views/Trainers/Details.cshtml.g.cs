#pragma checksum "D:\PRACTICE PROJECT\GYM\GYM\Views\Trainers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cca8014c732a0022edb45fdda52750795c08cdd1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Trainers_Details), @"mvc.1.0.view", @"/Views/Trainers/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cca8014c732a0022edb45fdda52750795c08cdd1", @"/Views/Trainers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"616022f54c4512ed9297f6e8400abbc6283d25b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Trainers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GYM.Models.Trainers>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive img-rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\PRACTICE PROJECT\GYM\GYM\Views\Trainers\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_LayoutDashboard.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content-wrapper"">
    <!-- Container-fluid starts -->
    <div class=""container-fluid"">
        <!-- Main content starts -->
        <div class=""row"">
            <div class=""col-sm-12 p-0"">
                <div class=""main-header"">
                    <h4>Fitness Trainers Details </h4>
                    <ol class=""breadcrumb breadcrumb-title breadcrumb-arrow"">
                        <li class=""breadcrumb-item"">
                            <a asp-for=""Index"">
                                <i class=""icofont icofont-home""></i>
                            </a>
                        </li>
                        <li class=""breadcrumb-item"">
                            <a href=""#!""> Trainers Details </a>
                        </li>

                    </ol>
                </div>
            </div>
        </div>

        <div class=""row box-shadow"">
            <div class=""col-sm-12"">
                <div class=""card"">
                    <div class=""card-header"">");
            WriteLiteral("\r\n                        <h5 class=\"card-header-text\"> Details Only</h5>\r\n                        <div class=\"f-right\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1305, "\"", 1312, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-toggle=""modal"" data-target=""#shadow-top"">
                                <i class=""icofont icofont-code-alt""></i>
                            </a>
                        </div>

                    </div>
                    <div class=""modal fade modal-flex"" id=""shadow-top"" tabindex=""-1"" role=""dialog"">
                        <div class=""modal-dialog modal-lg"" role=""document"">
                            <div class=""modal-content"">
                                <div class=""modal-header"">
                                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                        <span aria-hidden=""true"">&times;</span>
                                    </button>
                                    <h5 class=""modal-title"">Code Explanation for Top Side Shadow </h5>
                                </div>
                                <!-- end of modal-header -->
                                <!-- end of modal-body -->
  ");
            WriteLiteral(@"                          </div>
                            <!-- end of modal-content -->
                        </div>
                        <!-- end of modal-dialog -->
                    </div>
                    <!-- end of modal -->

                    <div class=""row card-block box-list"">
                        <div class=""col-lg-6"">
                            <dl class=""row"">

                                <dt class=""col-sm-2"">
                                    ");
#nullable restore
#line 66 "D:\PRACTICE PROJECT\GYM\GYM\Views\Trainers\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-10\">\r\n                                    ");
#nullable restore
#line 69 "D:\PRACTICE PROJECT\GYM\GYM\Views\Trainers\Details.cshtml"
                               Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                                <dt class=\"col-sm-2\">\r\n                                    ");
#nullable restore
#line 72 "D:\PRACTICE PROJECT\GYM\GYM\Views\Trainers\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.TrainerType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-10\">\r\n                                    ");
#nullable restore
#line 75 "D:\PRACTICE PROJECT\GYM\GYM\Views\Trainers\Details.cshtml"
                               Write(Html.DisplayFor(model => model.TrainerType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                                <dt class=\"col-sm-2\">\r\n                                    ");
#nullable restore
#line 78 "D:\PRACTICE PROJECT\GYM\GYM\Views\Trainers\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.Facebook));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-10\">\r\n                                    ");
#nullable restore
#line 81 "D:\PRACTICE PROJECT\GYM\GYM\Views\Trainers\Details.cshtml"
                               Write(Html.DisplayFor(model => model.Facebook));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                                <dt class=\"col-sm-2\">\r\n                                    ");
#nullable restore
#line 84 "D:\PRACTICE PROJECT\GYM\GYM\Views\Trainers\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.Twitter));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-10\">\r\n                                    ");
#nullable restore
#line 87 "D:\PRACTICE PROJECT\GYM\GYM\Views\Trainers\Details.cshtml"
                               Write(Html.DisplayFor(model => model.Twitter));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                                <dt class=\"col-sm-2\">\r\n                                    ");
#nullable restore
#line 90 "D:\PRACTICE PROJECT\GYM\GYM\Views\Trainers\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.Behance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-10\">\r\n                                    ");
#nullable restore
#line 93 "D:\PRACTICE PROJECT\GYM\GYM\Views\Trainers\Details.cshtml"
                               Write(Html.DisplayFor(model => model.Behance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                                <dt class=\"col-sm-2\">\r\n                                    ");
#nullable restore
#line 96 "D:\PRACTICE PROJECT\GYM\GYM\Views\Trainers\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-10\">\r\n                                    ");
#nullable restore
#line 99 "D:\PRACTICE PROJECT\GYM\GYM\Views\Trainers\Details.cshtml"
                               Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n\r\n                                <dt class=\"col-sm-2\">\r\n                                    ");
#nullable restore
#line 103 "D:\PRACTICE PROJECT\GYM\GYM\Views\Trainers\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-10\">\r\n                                    ");
#nullable restore
#line 106 "D:\PRACTICE PROJECT\GYM\GYM\Views\Trainers\Details.cshtml"
                               Write(Html.DisplayFor(model => model.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                                <dt class=\"col-sm-2\">\r\n                                    ");
#nullable restore
#line 109 "D:\PRACTICE PROJECT\GYM\GYM\Views\Trainers\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.ModifiedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-10\">\r\n                                    ");
#nullable restore
#line 112 "D:\PRACTICE PROJECT\GYM\GYM\Views\Trainers\Details.cshtml"
                               Write(Html.DisplayFor(model => model.ModifiedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                                <dt class=\"col-sm-2\">\r\n                                    ");
#nullable restore
#line 115 "D:\PRACTICE PROJECT\GYM\GYM\Views\Trainers\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-10\">\r\n                                    ");
#nullable restore
#line 118 "D:\PRACTICE PROJECT\GYM\GYM\Views\Trainers\Details.cshtml"
                               Write(Html.DisplayFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                            </dl>\r\n                            <div>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cca8014c732a0022edb45fdda52750795c08cdd114500", async() => {
                WriteLiteral("Edit");
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
#nullable restore
#line 122 "D:\PRACTICE PROJECT\GYM\GYM\Views\Trainers\Details.cshtml"
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
            WriteLiteral(" |\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cca8014c732a0022edb45fdda52750795c08cdd116678", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-lg-6\">\r\n                          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cca8014c732a0022edb45fdda52750795c08cdd117990", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6301, "~/TrainersImages/", 6301, 17, true);
#nullable restore
#line 127 "D:\PRACTICE PROJECT\GYM\GYM\Views\Trainers\Details.cshtml"
AddHtmlAttributeValue("", 6318, Model.ProfilePhoto, 6318, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                       
                        </div>
                       
                        <!-- end of card-content -->
                    </div>

                    <!-- end of card-main -->
                </div>
                <!-- end of col-sm-12 -->
            </div>
        </div>
    </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GYM.Models.Trainers> Html { get; private set; }
    }
}
#pragma warning restore 1591
