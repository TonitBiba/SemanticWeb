#pragma checksum "C:\Users\USER\Desktop\Instagram Ontology\SemanticWeb\ApplicationUW\ApplicationUW\Views\Home\_Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d51b80969fd3efbcd07b5200d445528cdc4fdf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__Index), @"mvc.1.0.view", @"/Views/Home/_Index.cshtml")]
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
#line 1 "C:\Users\USER\Desktop\Instagram Ontology\SemanticWeb\ApplicationUW\ApplicationUW\Views\_ViewImports.cshtml"
using ApplicationUW;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\Desktop\Instagram Ontology\SemanticWeb\ApplicationUW\ApplicationUW\Views\_ViewImports.cshtml"
using ApplicationUW.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d51b80969fd3efbcd07b5200d445528cdc4fdf1", @"/Views/Home/_Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ecb2fac2f7d20bf30ede4c99f2409a654f4e5d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplicationUW.Models.ResultQueryList>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\USER\Desktop\Instagram Ontology\SemanticWeb\ApplicationUW\ApplicationUW\Views\Home\_Index.cshtml"
  
    int rows = @Model.Rows.Count() / 3;
    int columns = @Model.Columns.Count();

#line default
#line hidden
#nullable disable
            WriteLiteral("<h4>Rezultai i kerkimit</h4>\r\n\r\n<table id=\"tblShowResult\" class=\"display\">\r\n    <thead>\r\n        <tr>\r\n");
#nullable restore
#line 12 "C:\Users\USER\Desktop\Instagram Ontology\SemanticWeb\ApplicationUW\ApplicationUW\Views\Home\_Index.cshtml"
             for (int i = 0; i < columns; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th>");
#nullable restore
#line 14 "C:\Users\USER\Desktop\Instagram Ontology\SemanticWeb\ApplicationUW\ApplicationUW\Views\Home\_Index.cshtml"
               Write(Model.Columns[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 15 "C:\Users\USER\Desktop\Instagram Ontology\SemanticWeb\ApplicationUW\ApplicationUW\Views\Home\_Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 19 "C:\Users\USER\Desktop\Instagram Ontology\SemanticWeb\ApplicationUW\ApplicationUW\Views\Home\_Index.cshtml"
         for (int i = 0; i < rows; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n");
#nullable restore
#line 22 "C:\Users\USER\Desktop\Instagram Ontology\SemanticWeb\ApplicationUW\ApplicationUW\Views\Home\_Index.cshtml"
                 for (int j = 0; j < columns; j++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 24 "C:\Users\USER\Desktop\Instagram Ontology\SemanticWeb\ApplicationUW\ApplicationUW\Views\Home\_Index.cshtml"
                   Write(Model.Rows.ElementAt(i * columns + j));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 25 "C:\Users\USER\Desktop\Instagram Ontology\SemanticWeb\ApplicationUW\ApplicationUW\Views\Home\_Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 27 "C:\Users\USER\Desktop\Instagram Ontology\SemanticWeb\ApplicationUW\ApplicationUW\Views\Home\_Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplicationUW.Models.ResultQueryList> Html { get; private set; }
    }
}
#pragma warning restore 1591
