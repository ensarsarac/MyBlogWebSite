#pragma checksum "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Shared\Components\DashboardContact\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a551f9c77acc281f81cf658085125c5799f74ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_DashboardContact_Default), @"mvc.1.0.view", @"/Views/Shared/Components/DashboardContact/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a551f9c77acc281f81cf658085125c5799f74ae", @"/Views/Shared/Components/DashboardContact/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"595588c3751d172a12546818535eccfb82e24d70", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_DashboardContact_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Contact>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"col-md-4 grid-margin stretch-card\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <div class=\"d-flex\">\r\n                <h4 class=\"card-title\">");
#nullable restore
#line 8 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Shared\Components\DashboardContact\Default.cshtml"
                                  Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            </div>\r\n            <div class=\"preview-list\">\r\n\r\n                <div>\r\n                    <p class=\"text-muted\">");
#nullable restore
#line 13 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Shared\Components\DashboardContact\Default.cshtml"
                                     Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n\r\n                <br /><br />\r\n                <div class=\"d-flex align-items-center\">\r\n                    <i class=\"mr-3 icon-md mdi mdi-mail text-primary \"></i>\r\n                    <p class=\"mt-2\">");
#nullable restore
#line 19 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Shared\Components\DashboardContact\Default.cshtml"
                               Write(Model.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n\r\n                <br />\r\n                <div class=\"d-flex align-items-center\">\r\n                    <i class=\"mr-3 icon-md mdi mdi-phone text-warning \"></i>\r\n                    <p class=\"mt-2\">");
#nullable restore
#line 25 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Shared\Components\DashboardContact\Default.cshtml"
                               Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n\r\n                <div class=\"text-center\">\r\n                    <p class=\"text-muted mt-5\">Bana Ulaş!</p>\r\n                </div>\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Contact> Html { get; private set; }
    }
}
#pragma warning restore 1591
