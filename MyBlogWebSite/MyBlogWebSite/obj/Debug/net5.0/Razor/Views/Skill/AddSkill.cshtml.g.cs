#pragma checksum "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Skill\AddSkill.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4525d5b9ae5975f75d83812889784c96429923fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Skill_AddSkill), @"mvc.1.0.view", @"/Views/Skill/AddSkill.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4525d5b9ae5975f75d83812889784c96429923fe", @"/Views/Skill/AddSkill.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"595588c3751d172a12546818535eccfb82e24d70", @"/Views/_ViewImports.cshtml")]
    public class Views_Skill_AddSkill : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Skill>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Skill\AddSkill.cshtml"
  
    ViewData["Title"] = "AddSkill";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid mt-4"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <h1>Yetenek Ekleme Sayfası</h1>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-lg-12 grid-margin stretch-card"">
            <div class=""card"">
                <div class=""card-body"">

");
#nullable restore
#line 18 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Skill\AddSkill.cshtml"
                     using (Html.BeginForm("AddSkill", "Skill", FormMethod.Post))
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"form-group\">\r\n                            <label class=\"form-label\">Yetenek Adı:</label>\r\n                            ");
#nullable restore
#line 23 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Skill\AddSkill.cshtml"
                       Write(Html.TextBoxFor(x => x.Title, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 24 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Skill\AddSkill.cshtml"
                       Write(Html.ValidationMessageFor(x => x.Title, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <br />\r\n                        <div class=\"form-group\">\r\n                            <label class=\"form-label\">Değer:</label>\r\n                            ");
#nullable restore
#line 29 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Skill\AddSkill.cshtml"
                       Write(Html.TextBoxFor(x => x.Value, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 30 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Skill\AddSkill.cshtml"
                       Write(Html.ValidationMessageFor(x => x.Value, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <br />\r\n                        <button class=\"btn btn-primary\" type=\"submit\">Yetenek Kaydet</button>\r\n                        <a href=\"/Skill/Index/\" class=\"btn btn-secondary ml-3\">İptal</a>\r\n");
#nullable restore
#line 35 "C:\Users\Ensar\source\repos\MyBlogWebSite\MyBlogWebSite\Views\Skill\AddSkill.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Skill> Html { get; private set; }
    }
}
#pragma warning restore 1591
