#pragma checksum "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cb399c393983fddf9b282fde911501ddb70d6f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Identificador_Index), @"mvc.1.0.view", @"/Views/Identificador/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Identificador/Index.cshtml", typeof(AspNetCore.Views_Identificador_Index))]
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
#line 1 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\_ViewImports.cshtml"
using Eosweb;

#line default
#line hidden
#line 1 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
using Eosweb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cb399c393983fddf9b282fde911501ddb70d6f3", @"/Views/Identificador/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eca8a1f8476f0eec4d90446ae923c2fd5b2cea45", @"/Views/_ViewImports.cshtml")]
    public class Views_Identificador_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Eosweb.Models.Identificador>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/select2/dist/css/select2.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables/datatables.net-bs/css/dataTables.bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables/datatables.net-buttons-bs/css/buttons.bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables/datatables.net-fixedheader-bs/css/fixedHeader.bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables/datatables.net-responsive-bs/css/responsive.bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables/datatables.net-scroller-bs/css/scroller.bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
  
    ViewData["Title"] = "Identificador";
    ViewBag.Title = "Identificador";

#line default
#line hidden
            BeginContext(153, 21, true);
            WriteLiteral("<!-- Datatables -->\r\n");
            EndContext();
            BeginContext(174, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a5106c76310e421cadd439ca6c107f3d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(245, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(247, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4428f398ad4e4bc68c2325867eedaf8b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(345, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(347, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f0837f0dbcd6440e9e9dc19ce3338c9f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(450, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(452, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d8699b382ec4a779332ea1506b2b843", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(563, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(565, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "34a632a85b6f44908d07c760c1e55530", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(674, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(676, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "112a049491d24e9490fc02f1b866ae5d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(781, 176, true);
            WriteLiteral("\r\n\r\n<div class=\"right_col\" role=\"main\">\r\n    <div class=\"\">\r\n        <!--Titulo-->\r\n        <div class=\"page-title\">\r\n            <div class=\"title_left\">\r\n                <h3>");
            EndContext();
            BeginContext(958, 13, false);
#line 21 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
               Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(971, 341, true);
            WriteLiteral(@"</h3>
            </div>
        </div>
        <br />
        <!--/ Titulo-->
        <!--Breadcrumb-->
        <div class=""row"">
            <div class=""col-md-12 col-sm-12 col-xs-12"">
                <nav aria-label=""breadcrumb"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item""><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1312, "\"", 1347, 1);
#line 31 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
WriteAttributeValue("", 1319, Url.Action("Index", "Home"), 1319, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1348, 302, true);
            WriteLiteral(@">Inicio</a></li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">Identificador</li>
                    </ol>
                </nav>
            </div>
        </div>
        <!--/ Breadcrumb-->

        <div class=""clearfix""></div>
        <!--Contenido -->

");
            EndContext();
#line 42 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
         if(@ViewBag.Tipo == "Administrador") {

#line default
#line hidden
            BeginContext(1699, 510, true);
            WriteLiteral(@"            <!--crear un dato-->
            <div class="""">
                <!--Form -->
                <div class=""col-md-12 col-sm-12 col-xs-12"">
                    <div class=""x_panel"">
                        <div class=""x_title"">
                            <h2><i class=""fa fa-th-list""></i> Agregar un dato</h2>
                            <div class=""clearfix""></div>
                        </div>
                        <div class=""x_content"">
                            <!--Content-->
");
            EndContext();
#line 54 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
                             using (Html.BeginForm("Crear", "Identificador", FormMethod.Post, new { enctype = "multipart/form-data", @style = "border:none", data_parley_validate = false }))
                            {

#line default
#line hidden
            BeginContext(2431, 1892, true);
            WriteLiteral(@"                            <div data-parsley-validate>
                                <table class=""table table-striped table-bordered table-responsive"" >
                                    <thead>
                                        <tr>
                                            <th>Compuesto</th>
                                            <th>Formula</th>
                                            <th>Masa</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td class=""text-justify""><input type=""text"" class=""form-control"" name=""Compuesto"" rows=""1""data-parsley-minlength=""1"" data-parsley-pattern=""([a-zA-ZñÑáéíóúÁÉÍÓÚ\s]|(\-)|(\,)|[0-9])+"" data-parsley-trigger=""change"" required></td>
                                            <td class=""text-justify""><input type=""text"" class=""form-control"" name=""Formula"" rows=""1"" ");
            WriteLiteral(@"data-parsley-minlength=""1"" data-parsley-pattern=""([A-Z]+|[0-9])+"" data-parsley-trigger=""change"" required></td>
                                            <td class=""text-justify""><input type=""text"" class=""form-control"" name=""M"" rows=""1"" data-parsley-pattern=""([0-9])+|(\.([0-9]+))"" data-parsley-trigger=""change"" required></td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                            <div class=""ln_solid""></div>
                                <div class=""form-group"">
                                    <div class="""">
                                    <button id=""send"" type=""submit"" class=""btn btn-success"">Agregar Dato</button>
                                    </div>
                                </div>
");
            EndContext();
#line 80 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(4354, 163, true);
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n                <!--end Form-->\r\n            </div>\r\n            <!--/end -->\r\n");
            EndContext();
#line 87 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(4528, 765, true);
            WriteLiteral(@"
        <div class="""">
            <!--Lista -->
            <div class=""col-md-12 col-sm-12 col-xs-12"">
                <div class=""x_panel"">
                    <div class=""x_title"">
                        <h2><i class=""fa fa-th-list""></i> </h2>
                        <div class=""clearfix""></div>
                    </div>
                    <div class=""x_content"">
                        <!--Content-->
                        <table id=""datatable"" class=""table table-striped table-bordered table-responsive"">
                            <thead>
                                <tr>
                                    <th>Compuesto</th>
                                    <th>Formula</th>
                                    <th>M</th>
");
            EndContext();
#line 105 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
                                     if(@ViewBag.Tipo == "Administrador") {

#line default
#line hidden
            BeginContext(5370, 47, true);
            WriteLiteral("                                    <th></th>\r\n");
            EndContext();
#line 107 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(5456, 118, true);
            WriteLiteral("                                </tr>\r\n                            </thead>\r\n\r\n\r\n                            <tbody>\r\n");
            EndContext();
#line 113 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
                                 foreach (var i in Model)
                                {

#line default
#line hidden
            BeginContext(5668, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(5747, 11, false);
#line 116 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
                                   Write(i.Compuesto);

#line default
#line hidden
            EndContext();
            BeginContext(5758, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(5806, 9, false);
#line 117 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
                                   Write(i.Formula);

#line default
#line hidden
            EndContext();
            BeginContext(5815, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(5863, 3, false);
#line 118 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
                                   Write(i.M);

#line default
#line hidden
            EndContext();
            BeginContext(5866, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 119 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
                                     if(@ViewBag.Tipo == "Administrador") {

#line default
#line hidden
            BeginContext(5950, 161, true);
            WriteLiteral("                                    <td width=\"7%\"><a href=\"\"  class=\"btn btn-round btn-info\" data-title=\"modificar\" data-toggle=\"modal\" data-target=\"#modificar\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 6111, "\"", 6178, 13);
            WriteAttributeValue("", 6121, "Modificar(\'", 6121, 11, true);
#line 120 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
WriteAttributeValue("", 6132, i.Id, 6132, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 6137, "\',", 6137, 2, true);
            WriteAttributeValue(" ", 6139, "\'", 6140, 2, true);
#line 120 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
WriteAttributeValue("", 6141, i.Compuesto, 6141, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 6153, "\',", 6153, 2, true);
            WriteAttributeValue(" ", 6155, "\'", 6156, 2, true);
#line 120 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
WriteAttributeValue("", 6157, i.Formula, 6157, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 6167, "\'", 6167, 1, true);
            WriteAttributeValue(" ", 6168, ",", 6169, 2, true);
            WriteAttributeValue(" ", 6170, "\'", 6171, 2, true);
#line 120 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
WriteAttributeValue("", 6172, i.M, 6172, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 6176, "\')", 6176, 2, true);
            EndWriteAttribute();
            BeginContext(6179, 144, true);
            WriteLiteral("><i class=\"fa fa-pencil\"></i></a> <a href=\"\"  class=\"btn btn-round btn-danger\" data-title=\"eliminar\" data-toggle=\"modal\" data-target=\"#eliminar\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 6323, "\"", 6350, 3);
            WriteAttributeValue("", 6333, "Eliminar(\'", 6333, 10, true);
#line 120 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
WriteAttributeValue("", 6343, i.Id, 6343, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 6348, "\')", 6348, 2, true);
            EndWriteAttribute();
            BeginContext(6351, 39, true);
            WriteLiteral("><i class=\"fa fa-close\"></i></a></td>\r\n");
            EndContext();
#line 121 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(6429, 39, true);
            WriteLiteral("                                </tr>\r\n");
            EndContext();
#line 123 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(6503, 1336, true);
            WriteLiteral(@"                            </tbody>
                        </table>
                        <!--/ Content-->
                    </div>
                </div>
            </div>
            <!--end Lista-->
        </div>

    </div>
</div>

<script type=""text/javascript"">
    Eliminar = function (id) {
        document.getElementById(""id-eliminar"").setAttribute(""value"", id);
    };

    Modificar = function (id, compuesto, formula, m) {
        document.getElementById(""m-id"").setAttribute(""value"", id);
        document.getElementById(""m-comp"").setAttribute(""value"", compuesto);
        document.getElementById(""m-form"").setAttribute(""value"", formula);
        document.getElementById(""m-m"").setAttribute(""value"", m);
    };
</script>

<!--Modal Modificar F-->
<div class=""modal fade bd-example-modal-lg"" id=""modificar"" tabindex=""-1"" role=""dialog"" aria-labelledby=""modificar"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div c");
            WriteLiteral(@"lass=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
                <h4 class=""modal-title""><i class=""fa fa-pencil-square-o""></i> Modificar</h4>
            </div>
");
            EndContext();
#line 159 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
             using (Html.BeginForm("Modificar", "Identificador", FormMethod.Post, new { enctype = "multipart/form-data", @style = "border:none", data_parley_validate = false }))
            {

#line default
#line hidden
            BeginContext(8033, 2733, true);
            WriteLiteral(@"                <div class=""modal-body form-horizontal form-label-left"" data-parsley-validate>
                        <div class=""form-group"">
                            <div class=""alert alert-info alert-dismissible fade in"" role=""alert"">
                                <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close""><span aria-hidden=""true"">×</span>
                                </button>
                                <i class=""fa fa-info-circle fa-lg""></i> Para modificar el dato; edite la casilla con el número actual y/o seleccionar el compuesto que corresponda. 
                                Si por el contrario, usted desea que el dato permanezca; no seleccione ningún compuesto y/o borre o mantenga el dato para cada casilla.
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""control-label col-md-3 col-sm-3 col-xs-12"">Compuesto *:</label>
                 ");
            WriteLiteral(@"           <div class=""col-md-9 col-sm-9 col-xs-9"">
                                <input type=""text"" class=""form-control"" id=""m-comp"" name=""Compuesto"" rows=""1""data-parsley-minlength=""1"" data-parsley-pattern=""([a-zA-ZñÑáéíóúÁÉÍÓÚ\s]|(\-)|(\,)|[0-9])+"" data-parsley-trigger=""change"" required>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""control-label col-md-3 col-sm-3 col-xs-12"">Fórmula *:</label>
                            <div class=""col-md-9 col-sm-9 col-xs-9"">
                                <input type=""text"" class=""form-control"" id=""m-form"" name=""Formula"" rows=""1"" data-parsley-minlength=""1"" data-parsley-pattern=""([A-Z]+|[0-9])+"" data-parsley-trigger=""change"" required>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""control-label col-md-3 col-sm-3 col-xs-12"">Masa *:</label>
 ");
            WriteLiteral(@"                           <div class=""col-md-9 col-sm-9 col-xs-9"">
                                <input class=""form-control"" id=""m-m"" name=""M"" rows=""1"" data-parsley-pattern=""([0-9])+|(\.([0-9]+))"" data-parsley-trigger=""change"" required>
                            </div>
                        </div>
                        
                </div>
                <div class=""modal-footer"">
                    <input type=""hidden"" name=""Id"" id=""m-id"">
                    <button type=""submit"" class=""btn btn-success"">Modificar</button>
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancelar</button>
                </div>
");
            EndContext();
#line 195 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(10781, 601, true);
            WriteLiteral(@"        </div>
    </div>
</div>

<!--Modal Eliminar F-->
<div class=""modal fade bd-example-modal-lg"" id=""eliminar"" tabindex=""-1"" role=""dialog"" aria-labelledby=""eliminar"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
                <h4 class=""modal-title""><i class=""fa fa-close""></i> Eliminar</h4>
            </div>
");
            EndContext();
#line 210 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
             using (Html.BeginForm("Eliminar", "Identificador", FormMethod.Post, new { @style = "border:none" }))
            {

#line default
#line hidden
            BeginContext(11512, 483, true);
            WriteLiteral(@"                <div class=""modal-body"">
                    <p id=""hab-message"">¿Está seguro que desea eliminar?</p>
                </div>
                <div class=""modal-footer"">
                    <input type=""hidden"" id=""id-eliminar"" name=""Id"" value="""" />
                    <button type=""submit"" class=""btn btn-primary"">Aceptar</button>
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cerrar</button>
                </div>
");
            EndContext();
#line 220 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(12010, 34, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Eosweb.Models.Identificador>> Html { get; private set; }
    }
}
#pragma warning restore 1591
