#pragma checksum "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Shared\Components\NewAdminNavbarMessage\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9a78d7b994cf3dbd41b581eb0cbfd668bea6466"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_NewAdminNavbarMessage_Default), @"mvc.1.0.view", @"/Views/Shared/Components/NewAdminNavbarMessage/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9a78d7b994cf3dbd41b581eb0cbfd668bea6466", @"/Views/Shared/Components/NewAdminNavbarMessage/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"595588c3751d172a12546818535eccfb82e24d70", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_NewAdminNavbarMessage_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WriterMessage>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"    <li class=""nav-item dropdown border-left"">
        <a class=""nav-link count-indicator dropdown-toggle"" id=""messageDropdown"" href=""#"" data-toggle=""dropdown"" aria-expanded=""false"">
            <i class=""mdi mdi-email""></i>
            <span class=""count bg-success""></span>
        </a>
        <div class=""dropdown-menu dropdown-menu-right navbar-dropdown preview-list"" aria-labelledby=""messageDropdown"">
            <h6 class=""p-3 mb-0"">Mesajlar</h6>
");
#nullable restore
#line 10 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Shared\Components\NewAdminNavbarMessage\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"dropdown-divider\"></div>\r\n                <a class=\"dropdown-item preview-item\"");
            BeginWriteAttribute("href", " href=\"", 656, "\"", 701, 3);
            WriteAttributeValue("", 663, "/AdminMessage/MessageDetails/", 663, 29, true);
#nullable restore
#line 13 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Shared\Components\NewAdminNavbarMessage\Default.cshtml"
WriteAttributeValue("", 692, item.ID, 692, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 700, "/", 700, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                  \r\n                    ");
#nullable restore
#line 15 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Shared\Components\NewAdminNavbarMessage\Default.cshtml"
               Write(await Component.InvokeAsync("NewAdminNavbarMessageUserImage",item.Sender));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                    <div class=\"preview-item-content\">\r\n                        <p class=\"preview-subject ellipsis mb-1\">");
#nullable restore
#line 17 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Shared\Components\NewAdminNavbarMessage\Default.cshtml"
                                                            Write(item.SenderName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" sana bir mesaj gönderdi.</p>\r\n                        <p class=\"text-muted mb-0\"> ");
#nullable restore
#line 18 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Shared\Components\NewAdminNavbarMessage\Default.cshtml"
                                               Write(item.Date.ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                    </div>\r\n                </a>\r\n");
#nullable restore
#line 21 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Shared\Components\NewAdminNavbarMessage\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n            <p class=\"p-3 mb-0 text-center\">4 new messages</p>\r\n        </div>\r\n    </li>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WriterMessage>> Html { get; private set; }
    }
}
#pragma warning restore 1591
