#pragma checksum "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Testimonial\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd9e357111bdaaa467c8fa2f58ece6145b06f2e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Testimonial_Update), @"mvc.1.0.view", @"/Views/Testimonial/Update.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd9e357111bdaaa467c8fa2f58ece6145b06f2e7", @"/Views/Testimonial/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"595588c3751d172a12546818535eccfb82e24d70", @"/Views/_ViewImports.cshtml")]
    public class Views_Testimonial_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Testimonial>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Testimonial\Update.cshtml"
  
    ViewData["Title"] = "Update";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container-fluid mt-4\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n            <h3");
            BeginWriteAttribute("class", " class=\"", 228, "\"", 236, 0);
            EndWriteAttribute();
            WriteLiteral(">Referans Detay Sayfası</h3>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12 grid-margin stretch-card\">\r\n            <div class=\"card\">\r\n                <div class=\"card-body\">\r\n\r\n");
#nullable restore
#line 19 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Testimonial\Update.cshtml"
                     using (Html.BeginForm("Update", "Testimonial", FormMethod.Post))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Testimonial\Update.cshtml"
                   Write(Html.HiddenFor(x => x.TestimonialsID));

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"form-group\">\r\n                            <label class=\"form-label\">Ad Soyad:</label>\r\n                            ");
#nullable restore
#line 24 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Testimonial\Update.cshtml"
                       Write(Html.TextBoxFor(x => x.ClientName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <br />\r\n                        <div class=\"form-group\">\r\n                            <label class=\"form-label\">Şirket:</label>\r\n                            ");
#nullable restore
#line 29 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Testimonial\Update.cshtml"
                       Write(Html.TextBoxFor(x => x.Company, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <br />\r\n                        <div class=\"form-group\">\r\n                            <label class=\"form-label\">Resim Yolu:</label>\r\n                            ");
#nullable restore
#line 34 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Testimonial\Update.cshtml"
                       Write(Html.TextBoxFor(x => x.ImageUrl, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <br />\r\n                        <div class=\"form-group\">\r\n                            <label class=\"form-label\">Yorum:</label>\r\n                            ");
#nullable restore
#line 39 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Testimonial\Update.cshtml"
                       Write(Html.TextAreaFor(x => x.Comment, 5, 10, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <br />\r\n                        <button class=\"btn btn-primary\" type=\"submit\">Kaydet</button>\r\n                        <a href=\"/Testimonial/Index/\" class=\"btn btn-secondary ml-3\">İptal</a>\r\n");
#nullable restore
#line 44 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Testimonial\Update.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Testimonial> Html { get; private set; }
    }
}
#pragma warning restore 1591
