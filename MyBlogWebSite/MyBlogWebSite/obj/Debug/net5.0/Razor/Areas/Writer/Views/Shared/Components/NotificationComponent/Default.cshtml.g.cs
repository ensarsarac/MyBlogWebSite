#pragma checksum "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Areas\Writer\Views\Shared\Components\NotificationComponent\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe17e386a44972d43999f31afba59f6e8fb50256"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Shared_Components_NotificationComponent_Default), @"mvc.1.0.view", @"/Areas/Writer/Views/Shared/Components/NotificationComponent/Default.cshtml")]
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
#line 1 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Areas\Writer\Views\_ViewImports.cshtml"
using MyBlogWebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Areas\Writer\Views\_ViewImports.cshtml"
using MyBlogWebSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Areas\Writer\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe17e386a44972d43999f31afba59f6e8fb50256", @"/Areas/Writer/Views/Shared/Components/NotificationComponent/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c7f57cad24e65874cdc4c936a76043c7a76e464", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    public class Areas_Writer_Views_Shared_Components_NotificationComponent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Announcement>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<li class=""nav-item dropdown"">
    <a class=""nav-link count-indicator dropdown-toggle"" id=""notificationDropdown"" href=""#"" data-toggle=""dropdown"">
        <i class=""icon-bell mx-0""></i>
        <span class=""count""></span>
    </a>
    <div class=""dropdown-menu dropdown-menu-right navbar-dropdown preview-list"" aria-labelledby=""notificationDropdown"">
        <p class=""mb-0 font-weight-normal float-left dropdown-header"">Bildirimler</p>
");
#nullable restore
#line 11 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Areas\Writer\Views\Shared\Components\NotificationComponent\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <a class=""dropdown-item preview-item"">

                <div class=""preview-thumbnail"">
                    <div class=""preview-icon bg-success"">
                        <i class=""ti-info-alt mx-0""></i>
                    </div>
                </div>

                <div class=""preview-item-content"">
                    <h6 class=""preview-subject font-weight-normal"">");
#nullable restore
#line 22 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Areas\Writer\Views\Shared\Components\NotificationComponent\Default.cshtml"
                                                              Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    <p class=\"font-weight-light small-text mb-0 text-muted\">\r\n                        ");
#nullable restore
#line 24 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Areas\Writer\Views\Shared\Components\NotificationComponent\Default.cshtml"
                   Write(item.Date.ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n\r\n            </a>\r\n");
#nullable restore
#line 29 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Areas\Writer\Views\Shared\Components\NotificationComponent\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Announcement>> Html { get; private set; }
    }
}
#pragma warning restore 1591
