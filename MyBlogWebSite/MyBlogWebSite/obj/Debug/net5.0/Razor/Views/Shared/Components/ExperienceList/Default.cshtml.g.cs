#pragma checksum "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Shared\Components\ExperienceList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8bc015f0b6f958d62ad5ac19410fe39dcf64bae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ExperienceList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ExperienceList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8bc015f0b6f958d62ad5ac19410fe39dcf64bae", @"/Views/Shared/Components/ExperienceList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"595588c3751d172a12546818535eccfb82e24d70", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ExperienceList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Experience>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"section px-3 px-lg-4 pt-5\" id=\"experience\">\r\n    <div class=\"container-narrow\">\r\n        <div class=\"text-center mb-5\">\r\n            <h2 class=\"marker marker-center\">Deneyimlerim</h2>\r\n        </div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 9 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Shared\Components\ExperienceList\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-md-12"">
                    <div class=""card mb-3"" data-aos=""fade-right"" data-aos-delay=""100"">
                        <div class=""card-header px-3 py-2"">
                            <div class=""d-flex justify-content-between"">
                                <div>
                                    <h3 class=""h5 mb-1"">");
#nullable restore
#line 16 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Shared\Components\ExperienceList\Default.cshtml"
                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                    <div class=\"text-muted text-small\">");
#nullable restore
#line 17 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Shared\Components\ExperienceList\Default.cshtml"
                                                                  Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                </div><img");
            BeginWriteAttribute("src", " src=\"", 831, "\"", 851, 1);
#nullable restore
#line 18 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Shared\Components\ExperienceList\Default.cshtml"
WriteAttributeValue("", 837, item.ImageUrl, 837, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"48\" height=\"48\" alt=\"ui-ux\" />\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"card-body px-3 py-2\">\r\n                            <p>");
#nullable restore
#line 22 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Shared\Components\ExperienceList\Default.cshtml"
                          Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <hr />\r\n");
#nullable restore
#line 27 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Shared\Components\ExperienceList\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Experience>> Html { get; private set; }
    }
}
#pragma warning restore 1591
