#pragma checksum "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Writer\SideBarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a2249b2886f85866542ab705ff14a4a635761f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Writer_SideBarPartial), @"mvc.1.0.view", @"/Views/Writer/SideBarPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a2249b2886f85866542ab705ff14a4a635761f4", @"/Views/Writer/SideBarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"595588c3751d172a12546818535eccfb82e24d70", @"/Views/_ViewImports.cshtml")]
    public class Views_Writer_SideBarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<nav class=""sidebar sidebar-offcanvas"" id=""sidebar"">
    <ul class=""nav"">
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/Dashboard/Index/"">
                <i class=""icon-grid menu-icon""></i>
                <span class=""menu-title"">Dashboard</span>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/Profile/Index/"">
                <i class=""ti-microphone menu-icon""></i>
                <span class=""menu-title"">Profil</span>

            </a>

        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/Message/Inbox/"">
                <i class=""ti-notepad menu-icon""></i>
                <span class=""menu-title"">Gelen Kutusu</span>

            </a>

        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/Message/Sendbox/"">
                <i class=""ti-agenda menu-icon""></i>
                <span class=""menu-title"">Gönderilen Kutusu</s");
            WriteLiteral(@"pan>

            </a>

        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/Message/SendMessage/"">
                <i class=""ti-cloud menu-icon""></i>
                <span class=""menu-title"">Mesaj Gönder</span>

            </a>

        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/Default/Index/"">
                <i class=""ti-announcement menu-icon""></i>
                <span class=""menu-title"">Duyurular</span>

            </a>

        </li>

        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/Profile/Index/"">
                <i class=""ti-settings menu-icon""></i>
                <span class=""menu-title"">Ayarlar</span>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/Login/Logout/"">
                <i class=""ti-power-off menu-icon""></i>
                <span class=""menu-title"">Çıkış Yap</span>
            </a>
        </");
            WriteLiteral("li>\r\n");
#nullable restore
#line 63 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Writer\SideBarPartial.cshtml"
         if (User.IsInRole("Admin") || User.IsInRole("Moderator"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <li class=""nav-item"">
                <a class=""nav-link"" href=""/Dashboard/Index/"">
                    <i class=""ti-panel menu-icon""></i>
                    <span class=""menu-title"">Admin Paneline Git</span>
                </a>
            </li>
");
#nullable restore
#line 71 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Writer\SideBarPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</nav>\r\n");
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
