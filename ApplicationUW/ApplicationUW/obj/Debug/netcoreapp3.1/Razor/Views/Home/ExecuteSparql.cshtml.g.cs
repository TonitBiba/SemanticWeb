#pragma checksum "C:\Users\tonit\Source\Repos\SemanticWebFinal\ApplicationUW\ApplicationUW\Views\Home\ExecuteSparql.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cea1bcda82bb05e75e5304eb0430f851ce3b40f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ExecuteSparql), @"mvc.1.0.view", @"/Views/Home/ExecuteSparql.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cea1bcda82bb05e75e5304eb0430f851ce3b40f", @"/Views/Home/ExecuteSparql.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ecb2fac2f7d20bf30ede4c99f2409a654f4e5d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ExecuteSparql : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplicationUW.Models.QueryOntology>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-success", new global::Microsoft.AspNetCore.Html.HtmlString("onSuccess"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\tonit\Source\Repos\SemanticWebFinal\ApplicationUW\ApplicationUW\Views\Home\ExecuteSparql.cshtml"
  
    ViewData["Title"] = "ExecuteSparql";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6cea1bcda82bb05e75e5304eb0430f851ce3b40f5332", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 8 "C:\Users\tonit\Source\Repos\SemanticWebFinal\ApplicationUW\ApplicationUW\Views\Home\ExecuteSparql.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            ");
#nullable restore
#line 11 "C:\Users\tonit\Source\Repos\SemanticWebFinal\ApplicationUW\ApplicationUW\Views\Home\ExecuteSparql.cshtml"
       Write(Html.LabelFor(m => m.Ontology, new { @class = "required" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 12 "C:\Users\tonit\Source\Repos\SemanticWebFinal\ApplicationUW\ApplicationUW\Views\Home\ExecuteSparql.cshtml"
       Write(Html.DropDownListFor(m => m.Ontology, new List<SelectListItem> { new SelectListItem { Value = "1", Text = "Instagram" }, new SelectListItem { Value = "2", Text = "My Heritage" } }, "Zgjedhe", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 13 "C:\Users\tonit\Source\Repos\SemanticWebFinal\ApplicationUW\ApplicationUW\Views\Home\ExecuteSparql.cshtml"
       Write(Html.ValidationMessageFor(m => m.Ontology, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-12\">\r\n            ");
#nullable restore
#line 16 "C:\Users\tonit\Source\Repos\SemanticWebFinal\ApplicationUW\ApplicationUW\Views\Home\ExecuteSparql.cshtml"
       Write(Html.LabelFor(m => m.Query, new { @class = "required" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 17 "C:\Users\tonit\Source\Repos\SemanticWebFinal\ApplicationUW\ApplicationUW\Views\Home\ExecuteSparql.cshtml"
       Write(Html.TextAreaFor(m => m.Query, new { @class = "form-control", placeholder = "SELECT DISTINCT ?Concept WHERE {[] a ?Concept}" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 18 "C:\Users\tonit\Source\Repos\SemanticWebFinal\ApplicationUW\ApplicationUW\Views\Home\ExecuteSparql.cshtml"
       Write(Html.ValidationMessageFor(m => m.Query, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\tonit\Source\Repos\SemanticWebFinal\ApplicationUW\ApplicationUW\Views\Home\ExecuteSparql.cshtml"
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
#line 7 "C:\Users\tonit\Source\Repos\SemanticWebFinal\ApplicationUW\ApplicationUW\Views\Home\ExecuteSparql.cshtml"
AddHtmlAttributeValue("", 110, Url.Action("_ExecuteSPARQL"), 110, 29, false);

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
            WriteLiteral("\r\n\r\n<div id=\"queryResult\"></div>\r\n\r\n<table id=\"tblResult\">\r\n    <thead>\r\n        <tr></tr>\r\n    </thead>\r\n    <tbody></tbody>\r\n</table>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>

        function onSuccess(data) {
            hideLoading()
            var result = JSON.parse(data)
            if (result.length != 0) {
                $('table thead tr').empty()
                $('table tbody').empty()

                for (var i = 0; i < result[0].length; i++) {
                    $('table thead tr').append('<th>' + result[0][i].Key + '</th>');
                }

                for (var i = 0; i < result.length; i++) {
                    $('table tbody').append('<tr></tr>')
                    for (var j = 0; j < result[i].length; j++) {
                        $('table tbody tr').last().append('<td>' + (result[i][j].Value != null ? (result[i][j].Value.value == undefined ? (result[i][j].Value.uri == undefined ? result[i][j].Value.Value : result[i][j].Value.uri) : result[i][j].Value.value) : 0) + '</td>');
                    }
                }
                $('#tblResult').DataTable()
            } else {
                Swal.fire({
        ");
                WriteLiteral(@"            icon: 'info',
                    title: 'Informate',
                    text: ""Nuk ka asnje rezultat"",
                    confirmButtonText: 'Në rregull'
                })
            }
        }
        function onCompleted() {
            $('#btnSubmit').removeAttr('disabled')
        hideLoading()
        }
    </script>
");
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
