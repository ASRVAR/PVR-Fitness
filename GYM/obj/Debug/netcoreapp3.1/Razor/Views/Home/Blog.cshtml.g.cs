#pragma checksum "D:\PRACTICE PROJECT\GYM\GYM\Views\Home\Blog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "300f4a632fd229dc35002ff0968e5acfea977912"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Blog), @"mvc.1.0.view", @"/Views/Home/Blog.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"300f4a632fd229dc35002ff0968e5acfea977912", @"/Views/Home/Blog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"616022f54c4512ed9297f6e8400abbc6283d25b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Blog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GYM.Models.Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("blog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("comment-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\PRACTICE PROJECT\GYM\GYM\Views\Home\Blog.cshtml"
  
    ViewData["Title"] = "Blog";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- =========================
    BLOG HEADER SECTION
============================== -->
<section id=""blog-header"" class=""parallax-section"">
    <div class=""container"">
        <div class=""row"">

            <div class=""col-md-offset-2 col-md-8 col-sm-12"">
                <h3 class=""wow bounceIn"" data-wow-delay=""0.9s"">Fitness Blog</h3>
                <h1 class=""wow fadeInUp"" data-wow-delay=""1.6s"">Professional Club</h1>
            </div>


        </div>
    </div>
</section>

<!-- =========================
    BLOG SECTION
============================== -->
<section id=""blog"" class=""parallax-section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8 col-sm-7"">
");
#nullable restore
#line 32 "D:\PRACTICE PROJECT\GYM\GYM\Views\Home\Blog.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"blog-content wow fadeInUp\" data-wow-delay=\"1s\">\r\n                    <h3>");
#nullable restore
#line 35 "D:\PRACTICE PROJECT\GYM\GYM\Views\Home\Blog.cshtml"
                   Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n                    <span class=\"meta-date\"><a href=\"#\">");
#nullable restore
#line 36 "D:\PRACTICE PROJECT\GYM\GYM\Views\Home\Blog.cshtml"
                                                   Write(item.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></span>\r\n                    <span class=\"meta-comments\"><a href=\"#blog-comments\">10 comments</a></span>\r\n                    <span class=\"meta-author\"><a href=\"#blog-author\">");
#nullable restore
#line 38 "D:\PRACTICE PROJECT\GYM\GYM\Views\Home\Blog.cshtml"
                                                                Write(item.WritterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></span>\r\n                    <div class=\"blog-clear\"></div>\r\n\r\n                    <div class=\"blog-image wow fadeInUp\" data-wow-delay=\"0.9s\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "300f4a632fd229dc35002ff0968e5acfea9779127426", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1494, "~/BlogImages/", 1494, 13, true);
#nullable restore
#line 42 "D:\PRACTICE PROJECT\GYM\GYM\Views\Home\Blog.cshtml"
AddHtmlAttributeValue("", 1507, item.BlogPhoto, 1507, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <blockquote>\r\n                        ");
#nullable restore
#line 46 "D:\PRACTICE PROJECT\GYM\GYM\Views\Home\Blog.cshtml"
                   Write(item.PhotoTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </blockquote>\r\n                    <p>");
#nullable restore
#line 48 "D:\PRACTICE PROJECT\GYM\GYM\Views\Home\Blog.cshtml"
                  Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n");
#nullable restore
#line 50 "D:\PRACTICE PROJECT\GYM\GYM\Views\Home\Blog.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <div class=""blog-author wow fadeInUp"" data-wow-delay=""1s"">
                    <div class=""media"">
                        <div class=""media-object pull-left"">
                            <a href=""#""><img src=""../images/blog-author.jpg"" class=""img-responsive img-circle"" alt=""blog""></a>
                        </div>
                        <div class=""media-body"">
                            <h4 class=""media-heading"">Michael Dan</h4>
                            <p>Lorem ipsum dolor sit amet, maecenas eget vestibulum justo imperdiet, wisi risus purus augue vulputate voluptate neque, curabitur.</p>
                        </div>
                    </div>
                </div>

                <div class=""blog-comment wow fadeInUp"" data-wow-delay=""1s"">
                    <h3>2 comments</h3>
                    <div class=""media"">
                        <div class=""media-object pull-left"">
                            <img src=""../images/comment1.jpg"" class=""img-responsive img");
            WriteLiteral(@"-circle"" alt=""blog"">
                        </div>
                        <div class=""media-body"">
                            <h4 class=""media-heading"">Sandar Minn</h4>
                            <h5>18 May 2016</h5>
                            <p>Lorem ipsum dolor sit amet, maecenas eget vestibulum justo imperdiet, wisi risus purus augue vulputate voluptate neque, curabitur.</p>
                            <div class=""media"">
                                <div class=""media-object pull-left"">
                                    <img src=""../images/comment2.jpg"" class=""img-responsive img-circle"" alt=""blog"">
                                </div>
                                <div class=""media-body"">
                                    <h4 class=""media-heading"">George Linn</h4>
                                    <h5>14 May 2016</h5>
                                    <p>Lorem ipsum dolor sit amet, maecenas eget vestibulum justo imperdiet, wisi risus purus augue vulputate voluptate neque, ");
            WriteLiteral(@"curabitur.</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""blog-comment-form wow fadeInUp"" data-wow-delay=""1s"">
                    <h3>Leave a comment</h3>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "300f4a632fd229dc35002ff0968e5acfea97791212336", async() => {
                WriteLiteral(@"
                        <div class=""col-md-6 col-sm-6"">
                            <input type=""text"" class=""form-control"" placeholder=""Name"" name=""name"" required>
                        </div>
                        <div class=""col-md-6 col-sm-6"">
                            <input type=""email"" class=""form-control"" placeholder=""Email"" name=""email"" required>
                        </div>
                        <div class=""col-md-12 col-sm-12"">
                            <textarea class=""form-control"" placeholder=""Message"" rows=""5"" name""message"" required id=""message""></textarea>
                        </div>
                        <div class=""col-md-3 col-sm-3"">
                            <input name=""submit"" type=""submit"" class=""form-control"" id=""submit"" value=""Submit"">
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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

            <div class=""col-md-4 col-sm-5 wow fadeInUp"" data-wow-delay=""1.3s"">

                <div class=""blog-categories"">
                    <h3>Categories</h3>
                    <li><a href=""#"">Body Fitness</a></li>
                    <li><a href=""#"">Get Online Tips</a></li>
                    <li><a href=""#"">Aerobic Exercises</a></li>
                    <li><a href=""#"">Yoga Courses</a></li>
                    <li><a href=""#"">General Health</a></li>
                    <li><a href=""#"">Fit and Lift</a></li>
                </div>

                <div class=""recent-post"">
                    <h3>Recent Posts</h3>
");
#nullable restore
#line 123 "D:\PRACTICE PROJECT\GYM\GYM\Views\Home\Blog.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""media"">
                            <div class=""media-object pull-left"">
                                <a href=""#""><img src=""../images/blog-thumb1.jpg"" class=""img-responsive"" alt=""blog""></a>
                            </div>
                            <div class=""media-body"">
                                <h5>18 Jan 2022</h5>
                                <h4 class=""media-heading""><a href=""#"">");
#nullable restore
#line 131 "D:\PRACTICE PROJECT\GYM\GYM\Views\Home\Blog.cshtml"
                                                                 Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 134 "D:\PRACTICE PROJECT\GYM\GYM\Views\Home\Blog.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""media"">
                <div class=""media-object pull-left"">
                    <a href=""#""><img src=""../images/blog-thumb2.jpg"" class=""img-responsive"" alt=""blog""></a>
                </div>
                <div class=""media-body"">
                    <h5>14 May 2016</h5>
                    <h4 class=""media-heading""><a href=""#"">Explore Gym Services</a></h4>
                </div>
            </div>
            <div class=""media"">
                <div class=""media-object pull-left"">
                    <a href=""#""><img src=""../images/blog-thumb3.jpg"" class=""img-responsive"" alt=""blog""></a>
                </div>
                <div class=""media-body"">
                    <h5>10 May 2016</h5>
                    <h4 class=""media-heading""><a href=""#"">How to practice Aerobics?</a></h4>
                </div>
            </div>
                    </div>

            </div>

        </div>
    </div>
</section>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GYM.Models.Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591