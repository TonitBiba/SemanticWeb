#pragma checksum "C:\Users\tonit\Source\Repos\SemanticWebFinal\ApplicationUW\ApplicationUW\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f72c23d2ea481da2a7bdece8b1b8ba135494aa31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\tonit\Source\Repos\SemanticWebFinal\ApplicationUW\ApplicationUW\Views\_ViewImports.cshtml"
using ApplicationUW;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tonit\Source\Repos\SemanticWebFinal\ApplicationUW\ApplicationUW\Views\_ViewImports.cshtml"
using ApplicationUW.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f72c23d2ea481da2a7bdece8b1b8ba135494aa31", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ecb2fac2f7d20bf30ede4c99f2409a654f4e5d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplicationUW.Models.QueryOntology>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-update", new global::Microsoft.AspNetCore.Html.HtmlString("#queryResult"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-complete", new global::Microsoft.AspNetCore.Html.HtmlString("onCompleted()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\tonit\Source\Repos\SemanticWebFinal\ApplicationUW\ApplicationUW\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Mirëserdhët</h1>
    <p>Aplikacioni i zhvilluar në kuadër të projektit në lëndën ""Uebi Semantik"" i cili ekzekuton SPARQL dhe SWRL query.</p>
</div>

<h4>Ekzekutimi i SPARQL pyetësorëve</h4>
<br />
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f72c23d2ea481da2a7bdece8b1b8ba135494aa315543", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 15 "C:\Users\tonit\Source\Repos\SemanticWebFinal\ApplicationUW\ApplicationUW\Views\Home\Index.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            ");
#nullable restore
#line 18 "C:\Users\tonit\Source\Repos\SemanticWebFinal\ApplicationUW\ApplicationUW\Views\Home\Index.cshtml"
       Write(Html.LabelFor(m => m.Ontology, new { @class = "required" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 19 "C:\Users\tonit\Source\Repos\SemanticWebFinal\ApplicationUW\ApplicationUW\Views\Home\Index.cshtml"
       Write(Html.DropDownListFor(m => m.Ontology, new List<SelectListItem> { new SelectListItem { Value = "1", Text = "Instagram" }, new SelectListItem { Value = "2", Text = "My Heritage" } }, "Zgjedhe", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 20 "C:\Users\tonit\Source\Repos\SemanticWebFinal\ApplicationUW\ApplicationUW\Views\Home\Index.cshtml"
       Write(Html.ValidationMessageFor(m => m.Ontology, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-12\">\r\n            ");
#nullable restore
#line 23 "C:\Users\tonit\Source\Repos\SemanticWebFinal\ApplicationUW\ApplicationUW\Views\Home\Index.cshtml"
       Write(Html.LabelFor(m => m.Query, new { @class = "required" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 24 "C:\Users\tonit\Source\Repos\SemanticWebFinal\ApplicationUW\ApplicationUW\Views\Home\Index.cshtml"
       Write(Html.TextAreaFor(m => m.Query, new { @class = "form-control", placeholder = "SELECT DISTINCT ?Concept WHERE {[] a ?Concept}" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 25 "C:\Users\tonit\Source\Repos\SemanticWebFinal\ApplicationUW\ApplicationUW\Views\Home\Index.cshtml"
       Write(Html.ValidationMessageFor(m => m.Query, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-2\">\r\n            ");
#nullable restore
#line 28 "C:\Users\tonit\Source\Repos\SemanticWebFinal\ApplicationUW\ApplicationUW\Views\Home\Index.cshtml"
       Write(Html.Label("btnSubmit", null, new { style = "visibility:hidden" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n            <button id=\"btnSubmit\" type=\"submit\" class=\"btn btn-primary w-100\">Kërko</button>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 14 "C:\Users\tonit\Source\Repos\SemanticWebFinal\ApplicationUW\ApplicationUW\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 362, Url.Action("_Index"), 362, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div id=\"queryResult\"></div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        function onCompleted() {\r\n            hideLoading()\r\n\r\n            $(\'#tblShowResult\').DataTable()\r\n        }\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplicationUW.Models.QueryOntology> Html { get; private set; }
    }
}
#pragma warning restore 1591
