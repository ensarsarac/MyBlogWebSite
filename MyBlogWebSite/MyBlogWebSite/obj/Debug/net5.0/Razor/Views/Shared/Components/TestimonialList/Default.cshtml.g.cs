#pragma checksum "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Shared\Components\TestimonialList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "daddf4e1590db22f29cae204bd596184f697abf6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TestimonialList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TestimonialList/Default.cshtml")]
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
#line 1 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\_ViewImports.cshtml"
using MyBlogWebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\_ViewImports.cshtml"
using MyBlogWebSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\_ViewImports.cshtml"
using MyBlogWebSite.Areas.Writer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"daddf4e1590db22f29cae204bd596184f697abf6", @"/Views/Shared/Components/TestimonialList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"595588c3751d172a12546818535eccfb82e24d70", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TestimonialList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Testimonial>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("me-md-3 rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("96"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("96"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("client 1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"section px-3 px-lg-4 pt-5\" id=\"testimonials\">\r\n    <div class=\"container-narrow\">\r\n        <div class=\"text-center mb-5\">\r\n            <h2 class=\"marker marker-center\">Referanslarım</h2>\r\n        </div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 10 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Shared\Components\TestimonialList\Default.cshtml"
             foreach (var item in Model)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-12 mb-5\" data-aos=\"fade-right\" data-aos-delay=\"100\">\r\n                    <div class=\"d-flex ms-md-3\"><span><i class=\"fas fa-2x fa-quote-left\"></i></span><span class=\"m-2\">");
#nullable restore
#line 14 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Shared\Components\TestimonialList\Default.cshtml"
                                                                                                                 Write(item.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n                    <div class=\"d-flex justify-content-end align-items-end\">\r\n                        <div class=\"text-end me-2\">\r\n                            <div class=\"fw-bolder\">");
#nullable restore
#line 17 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Shared\Components\TestimonialList\Default.cshtml"
                                              Write(item.ClientName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <div class=\"text-small\">");
#nullable restore
#line 18 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Shared\Components\TestimonialList\Default.cshtml"
                                               Write(item.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </div>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "daddf4e1590db22f29cae204bd596184f697abf67069", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 910, "~/UserImage/", 910, 12, true);
#nullable restore
#line 19 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Shared\Components\TestimonialList\Default.cshtml"
AddHtmlAttributeValue("", 922, item.ImageUrl, 922, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 22 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Shared\Components\TestimonialList\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n\r\n\r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Testimonial>> Html { get; private set; }
    }
}
#pragma warning restore 1591
