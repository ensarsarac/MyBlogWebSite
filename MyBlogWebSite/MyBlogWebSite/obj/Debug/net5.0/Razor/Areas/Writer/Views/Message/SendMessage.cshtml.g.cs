#pragma checksum "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Areas\Writer\Views\Message\SendMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "659f01250b5e4d400b89ddd9e45d6fe600484660"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Message_SendMessage), @"mvc.1.0.view", @"/Areas/Writer/Views/Message/SendMessage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"659f01250b5e4d400b89ddd9e45d6fe600484660", @"/Areas/Writer/Views/Message/SendMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c7f57cad24e65874cdc4c936a76043c7a76e464", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    public class Areas_Writer_Views_Message_SendMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WriterMessage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Areas\Writer\Views\Message\SendMessage.cshtml"
  
    ViewData["Title"] = "SendMessage";
    Layout = "~/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-12\">\r\n            <h2>Mesaj Gönder</h2>\r\n            <hr />\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-12\">\r\n");
#nullable restore
#line 19 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Areas\Writer\Views\Message\SendMessage.cshtml"
             using (Html.BeginForm("SendMessage", "Message", FormMethod.Post))
            {

             


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 25 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Areas\Writer\Views\Message\SendMessage.cshtml"
               Write(Html.Label("Alıcının Mail Adresi: "));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 26 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Areas\Writer\Views\Message\SendMessage.cshtml"
               Write(Html.TextBoxFor(x => x.Receiver, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral("                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 30 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Areas\Writer\Views\Message\SendMessage.cshtml"
               Write(Html.Label("Konu: "));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 31 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Areas\Writer\Views\Message\SendMessage.cshtml"
               Write(Html.TextBoxFor(x => x.Subject, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral("                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 35 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Areas\Writer\Views\Message\SendMessage.cshtml"
               Write(Html.Label("Mesaj: "));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 36 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Areas\Writer\Views\Message\SendMessage.cshtml"
               Write(Html.TextAreaFor(x => x.MessageContent, 10, 6, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <button type=\"submit\" class=\"btn btn-primary\">Mesaj Gönder</button>\r\n");
#nullable restore
#line 39 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Areas\Writer\Views\Message\SendMessage.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WriterMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591
