#pragma checksum "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Default\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe8ee6e26594371fe3adc645863034edec81692b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_Index), @"mvc.1.0.view", @"/Views/Default/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8ee6e26594371fe3adc645863034edec81692b", @"/Views/Default/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"595588c3751d172a12546818535eccfb82e24d70", @"/Views/_ViewImports.cshtml")]
    public class Views_Default_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Default\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<!-- upto 2 directory depth-->\r\n<html lang=\"en-US\">\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Default\Index.cshtml"
Write(await Html.PartialAsync("HeaderPartial.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe8ee6e26594371fe3adc645863034edec81692b4384", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 12 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Default\Index.cshtml"
Write(await Html.PartialAsync("NavbarPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n    <div class=\"page-content\">\r\n        <div id=\"content\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Default\Index.cshtml"
       Write(await Component.InvokeAsync("FeatureList"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 16 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Default\Index.cshtml"
       Write(await Component.InvokeAsync("AboutList"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 17 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Default\Index.cshtml"
       Write(await Component.InvokeAsync("ServiceList"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 18 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Default\Index.cshtml"
       Write(await Component.InvokeAsync("SkillList"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 19 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Default\Index.cshtml"
       Write(await Component.InvokeAsync("PortfolioList"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 20 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Default\Index.cshtml"
       Write(await Component.InvokeAsync("ExperienceList"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 21 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Default\Index.cshtml"
       Write(await Component.InvokeAsync("TestimonialList"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <div class=\"container\">\r\n                <div class=\"row justify-content-center\">\r\n                    ");
#nullable restore
#line 24 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Default\Index.cshtml"
               Write(await Html.PartialAsync("AddTestimonial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                </div>
            </div>

            <div class=""section px-2 px-lg-4 pb-4 pt-5 mb-5"" id=""contact"">
                <div class=""container-narrow"">
                    <div class=""text-center mb-5"">
                        <h2 class=""marker marker-center"">Benimle İletişime Geçin</h2>
                    </div>
                    <div>
                        <div class=""row"">
                            ");
#nullable restore
#line 36 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Default\Index.cshtml"
                       Write(await Html.PartialAsync("SendMessage.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 37 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Default\Index.cshtml"
                       Write(await Component.InvokeAsync("ContactDetails"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            ");
#nullable restore
#line 43 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Default\Index.cshtml"
       Write(await Component.InvokeAsync("FooterDetails"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n    \r\n    ");
#nullable restore
#line 48 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Default\Index.cshtml"
Write(await Html.PartialAsync("ScriptsPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
