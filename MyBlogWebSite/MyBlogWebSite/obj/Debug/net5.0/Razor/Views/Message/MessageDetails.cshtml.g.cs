#pragma checksum "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Message\MessageDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "057d0602a377772750ec49ec524a13c76d1c549a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_MessageDetails), @"mvc.1.0.view", @"/Views/Message/MessageDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"057d0602a377772750ec49ec524a13c76d1c549a", @"/Views/Message/MessageDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"595588c3751d172a12546818535eccfb82e24d70", @"/Views/_ViewImports.cshtml")]
    public class Views_Message_MessageDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Message>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Message\MessageDetails.cshtml"
  
    ViewData["Title"] = "UpdateExperience";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid mt-4\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n            <h3");
            BeginWriteAttribute("class", " class=\"", 232, "\"", 240, 0);
            EndWriteAttribute();
            WriteLiteral(">Mesaj Detayları</h3>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12 grid-margin stretch-card\">\r\n            <div class=\"card\">\r\n                <div class=\"card-body\">\r\n\r\n");
#nullable restore
#line 18 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Message\MessageDetails.cshtml"
                     using (Html.BeginForm("MessageDetails", "Message", FormMethod.Post))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Message\MessageDetails.cshtml"
                   Write(Html.HiddenFor(x => x.MessageID));

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"form-group\">\r\n                            <label class=\"form-label\">Adı Soyadı:</label>\r\n                            ");
#nullable restore
#line 23 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Message\MessageDetails.cshtml"
                       Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <br />\r\n                        <div class=\"form-group\">\r\n                            <label class=\"form-label\">Mail:</label>\r\n                            ");
#nullable restore
#line 28 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Message\MessageDetails.cshtml"
                       Write(Html.TextBoxFor(x => x.Mail, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <br />\r\n                        <div class=\"form-group\">\r\n                            <label class=\"form-label\">Tarih:</label>\r\n                            ");
#nullable restore
#line 33 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Message\MessageDetails.cshtml"
                       Write(Html.TextBoxFor(x => x.Date, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <br />\r\n                        <div class=\"form-group\">\r\n                            <label class=\"form-label\">Mesaj:</label>\r\n                            ");
#nullable restore
#line 38 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Message\MessageDetails.cshtml"
                       Write(Html.TextAreaFor(x => x.Content, 5, 10, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <br />\r\n                        <a href=\"/Message/Index/\" class=\"btn btn-secondary ml-3\">Listeye Geri Dön</a>\r\n");
#nullable restore
#line 42 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Message\MessageDetails.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Message> Html { get; private set; }
    }
}
#pragma warning restore 1591
