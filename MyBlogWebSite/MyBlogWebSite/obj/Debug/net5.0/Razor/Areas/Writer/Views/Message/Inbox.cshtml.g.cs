#pragma checksum "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Areas\Writer\Views\Message\Inbox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbc14ccbb63b570d0454246e8db0c54bc82c59ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Message_Inbox), @"mvc.1.0.view", @"/Areas/Writer/Views/Message/Inbox.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbc14ccbb63b570d0454246e8db0c54bc82c59ba", @"/Areas/Writer/Views/Message/Inbox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c7f57cad24e65874cdc4c936a76043c7a76e464", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    public class Areas_Writer_Views_Message_Inbox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WriterMessage>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Areas\Writer\Views\Message\Inbox.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Gelen Kutusu</h3>\r\n<h2>");
#nullable restore
#line 10 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Areas\Writer\Views\Message\Inbox.cshtml"
Write(ViewBag.v);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<table class=\"table table-bordered\">\r\n\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Gönderen</th>\r\n        <th>Konu</th>\r\n        <th>Tarih</th>\r\n        <th>Detaylar</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 22 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Areas\Writer\Views\Message\Inbox.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 25 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Areas\Writer\Views\Message\Inbox.cshtml"
           Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Areas\Writer\Views\Message\Inbox.cshtml"
           Write(item.SenderName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Areas\Writer\Views\Message\Inbox.cshtml"
           Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Areas\Writer\Views\Message\Inbox.cshtml"
           Write(item.Date.ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 594, "\"", 641, 3);
            WriteAttributeValue("", 601, "/Writer/Message/MessageDetails/", 601, 31, true);
#nullable restore
#line 29 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Areas\Writer\Views\Message\Inbox.cshtml"
WriteAttributeValue("", 632, item.ID, 632, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 640, "/", 640, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\" btn-lg>Mesajı Gör</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 31 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Areas\Writer\Views\Message\Inbox.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n");
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
