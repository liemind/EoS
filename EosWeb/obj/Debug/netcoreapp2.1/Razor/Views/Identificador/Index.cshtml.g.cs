#pragma checksum "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d532f86761e250e81ef30363bf4c8154c7ff217"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d532f86761e250e81ef30363bf4c8154c7ff217", @"/Views/Identificador/Index.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6e3253ba5ad8437480df4348000139f9", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0c443e4403ce452d9a5d977ea09f971b", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "67cf39f5ea1f486aafc4563e7585ac3a", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bec7fa4443924db2803ec2b049d7c809", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "142fab3a558a4993a28758060c0d2259", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2125ebd703e844a7a41c385507fec7c1", async() => {
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
            BeginContext(1348, 768, true);
            WriteLiteral(@">Inicio</a></li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">Identificador</li>
                    </ol>
                </nav>
            </div>
        </div>
        <!--/ Breadcrumb-->

        <div class=""clearfix""></div>
        <!--Contenido -->

        <!--crear un dato-->
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
#line 53 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
                         using (Html.BeginForm("Crear", "Identificador", FormMethod.Post, new { enctype = "multipart/form-data", @style = "border:none", data_parley_validate = false }))
                        {

#line default
#line hidden
            BeginContext(2330, 1796, true);
            WriteLiteral(@"                        <div data-parsley-validate>
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
                                        <td class=""text-justify""><input type=""text"" class=""form-control"" name=""Formula"" rows=""1"" data-parsley-minlength=""1"" data-parsley-pattern=""([A");
            WriteLiteral(@"-Z]+|[0-9])+"" data-parsley-trigger=""change"" required></td>
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
#line 79 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(4153, 1069, true);
            WriteLiteral(@"                    </div>
                </div>
            </div>
            <!--end Form-->
        </div>
        <!--/end -->

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
                                    <th></th>
                                </tr>
                            </thea");
            WriteLiteral("d>\r\n\r\n\r\n                            <tbody>\r\n");
            EndContext();
#line 109 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
                                 foreach (var i in Model)
                                {

#line default
#line hidden
            BeginContext(5316, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(5395, 11, false);
#line 112 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
                                   Write(i.Compuesto);

#line default
#line hidden
            EndContext();
            BeginContext(5406, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(5454, 9, false);
#line 113 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
                                   Write(i.Formula);

#line default
#line hidden
            EndContext();
            BeginContext(5463, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(5511, 3, false);
#line 114 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
                                   Write(i.M);

#line default
#line hidden
            EndContext();
            BeginContext(5514, 168, true);
            WriteLiteral("</td>\r\n                                    <td width=\"7%\"><a href=\"\"  class=\"btn btn-round btn-info\" data-title=\"modificar\" data-toggle=\"modal\" data-target=\"#modificar\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5682, "\"", 5749, 13);
            WriteAttributeValue("", 5692, "Modificar(\'", 5692, 11, true);
#line 115 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
WriteAttributeValue("", 5703, i.Id, 5703, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 5708, "\',", 5708, 2, true);
            WriteAttributeValue(" ", 5710, "\'", 5711, 2, true);
#line 115 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
WriteAttributeValue("", 5712, i.Compuesto, 5712, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 5724, "\',", 5724, 2, true);
            WriteAttributeValue(" ", 5726, "\'", 5727, 2, true);
#line 115 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
WriteAttributeValue("", 5728, i.Formula, 5728, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 5738, "\'", 5738, 1, true);
            WriteAttributeValue(" ", 5739, ",", 5740, 2, true);
            WriteAttributeValue(" ", 5741, "\'", 5742, 2, true);
#line 115 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
WriteAttributeValue("", 5743, i.M, 5743, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 5747, "\')", 5747, 2, true);
            EndWriteAttribute();
            BeginContext(5750, 144, true);
            WriteLiteral("><i class=\"fa fa-pencil\"></i></a> <a href=\"\"  class=\"btn btn-round btn-danger\" data-title=\"eliminar\" data-toggle=\"modal\" data-target=\"#eliminar\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5894, "\"", 5921, 3);
            WriteAttributeValue("", 5904, "Eliminar(\'", 5904, 10, true);
#line 115 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
WriteAttributeValue("", 5914, i.Id, 5914, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 5919, "\')", 5919, 2, true);
            EndWriteAttribute();
            BeginContext(5922, 78, true);
            WriteLiteral("><i class=\"fa fa-close\"></i></a></td>\r\n                                </tr>\r\n");
            EndContext();
#line 117 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(6035, 1336, true);
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
#line 153 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
             using (Html.BeginForm("Modificar", "Identificador", FormMethod.Post, new { enctype = "multipart/form-data", @style = "border:none", data_parley_validate = false }))
            {

#line default
#line hidden
            BeginContext(7565, 2733, true);
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
#line 189 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(10313, 601, true);
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
#line 204 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
             using (Html.BeginForm("Eliminar", "Identificador", FormMethod.Post, new { @style = "border:none" }))
            {

#line default
#line hidden
            BeginContext(11044, 483, true);
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
#line 214 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Identificador\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(11542, 34, true);
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