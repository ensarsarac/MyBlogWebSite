#pragma checksum "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\ContactSubContent\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bd89b77200b209a78128a243a670603311eda4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ContactSubContent_Update), @"mvc.1.0.view", @"/Views/ContactSubContent/Update.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bd89b77200b209a78128a243a670603311eda4f", @"/Views/ContactSubContent/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"595588c3751d172a12546818535eccfb82e24d70", @"/Views/_ViewImports.cshtml")]
    public class Views_ContactSubContent_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Contact>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\ContactSubContent\Update.cshtml"
  
    ViewData["Title"] = "Add";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid mt-4"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <h1>İletişim Bilgisi Düzenle</h1>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-lg-12 grid-margin stretch-card"">
            <div class=""card"">
                <div class=""card-body"">
");
#nullable restore
#line 19 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\ContactSubContent\Update.cshtml"
                     using (Html.BeginForm("Update", "ContactSubContent", FormMethod.Post))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\ContactSubContent\Update.cshtml"
                   Write(Html.HiddenFor(x=>x.ContactID));

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"form-group\">\r\n                            <label class=\"form-label\">Başlık:</label>\r\n                            ");
#nullable restore
#line 24 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\ContactSubContent\Update.cshtml"
                       Write(Html.TextBoxFor(x => x.Title, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <br />\r\n                        <div class=\"form-group\">\r\n                            <label class=\"form-label\">Mail:</label>\r\n                            ");
#nullable restore
#line 29 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\ContactSubContent\Update.cshtml"
                       Write(Html.TextBoxFor(x => x.Mail, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <br />\r\n                        <div class=\"form-group\">\r\n                            <label class=\"form-label\">Telefon:</label>\r\n                            ");
#nullable restore
#line 34 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\ContactSubContent\Update.cshtml"
                       Write(Html.TextBoxFor(x => x.Phone, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <br />\r\n                        <div class=\"form-group\">\r\n                            <label class=\"form-label\">Açıklama:</label>\r\n                            ");
#nullable restore
#line 39 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\ContactSubContent\Update.cshtml"
                       Write(Html.TextAreaFor(x => x.Phone, 10, 6, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <br />\r\n                        <button class=\"btn btn-primary\" type=\"submit\">Güncelle</button>\r\n                        <a href=\"/ContactSub/Index/\" class=\"btn btn-secondary ml-3\">İptal</a>\r\n");
#nullable restore
#line 44 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\ContactSubContent\Update.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
