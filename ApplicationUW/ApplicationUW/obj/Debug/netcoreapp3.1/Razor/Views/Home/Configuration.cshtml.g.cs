#pragma checksum "C:\Users\USER\Desktop\Instagram Ontology\Verzioni i Fundit\SemanticWeb\ApplicationUW\ApplicationUW\Views\Home\Configuration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f351300790b8e1f9c1e126b26242fdbbe035208e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Configuration), @"mvc.1.0.view", @"/Views/Home/Configuration.cshtml")]
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
#line 1 "C:\Users\USER\Desktop\Instagram Ontology\Verzioni i Fundit\SemanticWeb\ApplicationUW\ApplicationUW\Views\_ViewImports.cshtml"
using ApplicationUW;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\USER\Desktop\Instagram Ontology\Verzioni i Fundit\SemanticWeb\ApplicationUW\ApplicationUW\Views\Home\Configuration.cshtml"
using ApplicationUW.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f351300790b8e1f9c1e126b26242fdbbe035208e", @"/Views/Home/Configuration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ecb2fac2f7d20bf30ede4c99f2409a654f4e5d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Configuration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Configuration>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\USER\Desktop\Instagram Ontology\Verzioni i Fundit\SemanticWeb\ApplicationUW\ApplicationUW\Views\Home\Configuration.cshtml"
  
    ViewData["Title"] = "Configuration";
    ErrorMessage error = ViewBag.Error ?? new ErrorMessage();

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Konfigurimet</h1>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\USER\Desktop\Instagram Ontology\Verzioni i Fundit\SemanticWeb\ApplicationUW\ApplicationUW\Views\Home\Configuration.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-5\">\r\n            ");
#nullable restore
#line 14 "C:\Users\USER\Desktop\Instagram Ontology\Verzioni i Fundit\SemanticWeb\ApplicationUW\ApplicationUW\Views\Home\Configuration.cshtml"
       Write(Html.LabelFor(m => m.InstagramPath, new { @class = "required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 15 "C:\Users\USER\Desktop\Instagram Ontology\Verzioni i Fundit\SemanticWeb\ApplicationUW\ApplicationUW\Views\Home\Configuration.cshtml"
       Write(Html.TextBoxFor(m => m.InstagramPath, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 16 "C:\Users\USER\Desktop\Instagram Ontology\Verzioni i Fundit\SemanticWeb\ApplicationUW\ApplicationUW\Views\Home\Configuration.cshtml"
       Write(Html.ValidationMessageFor(m => m.InstagramPath, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-5\">\r\n            ");
#nullable restore
#line 19 "C:\Users\USER\Desktop\Instagram Ontology\Verzioni i Fundit\SemanticWeb\ApplicationUW\ApplicationUW\Views\Home\Configuration.cshtml"
       Write(Html.LabelFor(m => m.MyHeritagePath, new { @class = "required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 20 "C:\Users\USER\Desktop\Instagram Ontology\Verzioni i Fundit\SemanticWeb\ApplicationUW\ApplicationUW\Views\Home\Configuration.cshtml"
       Write(Html.TextBoxFor(m => m.MyHeritagePath, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 21 "C:\Users\USER\Desktop\Instagram Ontology\Verzioni i Fundit\SemanticWeb\ApplicationUW\ApplicationUW\Views\Home\Configuration.cshtml"
       Write(Html.ValidationMessageFor(m => m.MyHeritagePath, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-2\">\r\n            ");
#nullable restore
#line 24 "C:\Users\USER\Desktop\Instagram Ontology\Verzioni i Fundit\SemanticWeb\ApplicationUW\ApplicationUW\Views\Home\Configuration.cshtml"
       Write(Html.Label("btnSubmit", null, new { style = "visibility:hidden" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n            <button id=\"btnSubmit\" type=\"submit\" class=\"btn btn-primary w-100\">Ndrysho</button>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 28 "C:\Users\USER\Desktop\Instagram Ontology\Verzioni i Fundit\SemanticWeb\ApplicationUW\ApplicationUW\Views\Home\Configuration.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 31 "C:\Users\USER\Desktop\Instagram Ontology\Verzioni i Fundit\SemanticWeb\ApplicationUW\ApplicationUW\Views\Home\Configuration.cshtml"
     if (ViewBag.Error != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script>\r\n        if (");
#nullable restore
#line 34 "C:\Users\USER\Desktop\Instagram Ontology\Verzioni i Fundit\SemanticWeb\ApplicationUW\ApplicationUW\Views\Home\Configuration.cshtml"
       Write(error.ErrorNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" ==1) {
            Swal.fire({
                icon: 'success',
                title: 'Sukses',
                text: 'Të dhënat janë ruajtur me sukses',
                timer: 1500
            })
        } else {
            Swal.fire({
                icon: 'error',
                title: 'Gabim',
                text: """);
#nullable restore
#line 45 "C:\Users\USER\Desktop\Instagram Ontology\Verzioni i Fundit\SemanticWeb\ApplicationUW\ApplicationUW\Views\Home\Configuration.cshtml"
                  Write(error.ErrorDescription);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                confirmButtonText:\'Në rregull\'\r\n            })\r\n        }\r\n        </script>\r\n");
#nullable restore
#line 50 "C:\Users\USER\Desktop\Instagram Ontology\Verzioni i Fundit\SemanticWeb\ApplicationUW\ApplicationUW\Views\Home\Configuration.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Configuration> Html { get; private set; }
    }
}
#pragma warning restore 1591
