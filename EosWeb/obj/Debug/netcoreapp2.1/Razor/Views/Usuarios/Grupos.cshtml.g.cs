#pragma checksum "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Grupos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a8602b0d2c8dc7fbc9b7ded11a86e9b2ad78486"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_Grupos), @"mvc.1.0.view", @"/Views/Usuarios/Grupos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuarios/Grupos.cshtml", typeof(AspNetCore.Views_Usuarios_Grupos))]
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
#line 1 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Grupos.cshtml"
using Eosweb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a8602b0d2c8dc7fbc9b7ded11a86e9b2ad78486", @"/Views/Usuarios/Grupos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eca8a1f8476f0eec4d90446ae923c2fd5b2cea45", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_Grupos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Grupos.cshtml"
  
    ViewData["Title"] = "Grupos";
    ViewBag.Title = "Grupos";

#line default
#line hidden
            BeginContext(97, 23, true);
            WriteLiteral("\r\n<!-- Datatables -->\r\n");
            EndContext();
            BeginContext(120, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8c201fe746b941ee90e299979c3520e9", async() => {
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
            BeginContext(191, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(193, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "36418401555545579ea8d5bf7d21f921", async() => {
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
            BeginContext(291, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(293, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e8f89b8450f84a4a894757fcd7bf23f8", async() => {
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
            BeginContext(396, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(398, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1e881f20159d498eb9e8a1f96030c023", async() => {
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
            BeginContext(509, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(511, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d9cfa03608dd419b9a8d962c6366a2ba", async() => {
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
            BeginContext(620, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(622, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5328c891e7604de7b8ebe7701ca65a30", async() => {
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
            BeginContext(727, 176, true);
            WriteLiteral("\r\n\r\n<div class=\"right_col\" role=\"main\">\r\n    <div class=\"\">\r\n        <!--Titulo-->\r\n        <div class=\"page-title\">\r\n            <div class=\"title_left\">\r\n                <h3>");
            EndContext();
            BeginContext(904, 13, false);
#line 21 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Grupos.cshtml"
               Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(917, 341, true);
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
            BeginWriteAttribute("href", " href=\"", 1258, "\"", 1293, 1);
#line 31 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Grupos.cshtml"
WriteAttributeValue("", 1265, Url.Action("Index", "Home"), 1265, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1294, 1135, true);
            WriteLiteral(@">Inicio</a></li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">Grupos de Usuarios</li>
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
                        <ul class=""nav navbar-right panel_toolbox"">
                            <li></li>
                            <li></li>
                            <li><a href=""""  class=""btn btn-primary"" data-title=""addi"" data-toggle=""modal"" data-target=""#addi"" ><i class=""fa fa-plus fa-lg""></i> Identificador</a></li>
                        </ul>
                        <div class=""clearfix""></div>
  ");
            WriteLiteral("                  </div>\r\n                    <div class=\"x_content\">\r\n                        <!--Content-->\r\n");
            EndContext();
#line 58 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Grupos.cshtml"
                         using (Html.BeginForm("Crear", "Fundamentales", FormMethod.Post, new { enctype = "multipart/form-data", @style = "border:none", data_parley_validate = false }))
                        {

#line default
#line hidden
            BeginContext(2643, 892, true);
            WriteLiteral(@"                        <div data-parsley-validate>
                            <table class=""table table-striped table-bordered table-responsive"" >
                                <thead>
                                    <tr>
                                        <th>Compuesto</th>
                                        <th>T<small>c</small> / K</th>
                                        <th>P<small>c</small> / bar</th>
                                        <th>Z<small>c</small></th>
                                        <th>w</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td width=""30%"" >
                                            <select class=""form-control"" name=""Identificador"" required>
");
            EndContext();
#line 75 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Grupos.cshtml"
                                                 foreach (var id in ViewData["Identificadores"] as IList<Identificador>){

#line default
#line hidden
            BeginContext(3658, 52, true);
            WriteLiteral("                                                    ");
            EndContext();
            BeginContext(3710, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5244e0dad704512b1a686cf54fbcb08", async() => {
                BeginContext(3734, 12, false);
#line 76 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Grupos.cshtml"
                                                                      Write(id.Compuesto);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 76 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Grupos.cshtml"
                                                       WriteLiteral(id.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3755, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 77 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Grupos.cshtml"
                                                }

#line default
#line hidden
            BeginContext(3808, 1501, true);
            WriteLiteral(@"                                            </select>
                                        </td>
                                        <td class=""text-justify""><input class=""form-control col-md-2 col-xs-12"" type=""text"" name=""Tc_K"" data-parsley-pattern=""([0-9])+|(\,([0-9]+))"" data-parsley-trigger=""change"" required></td>
                                        <td class=""text-justify""><input class=""form-control col-md-2 col-xs-12"" type=""text"" name=""Pc_bar"" data-parsley-pattern=""([0-9])+|(\,([0-9]+))"" data-parsley-trigger=""change"" required></td>
                                        <td class=""text-justify""><input class=""form-control col-md-2 col-xs-12"" type=""text"" name=""Zc"" data-parsley-pattern=""([0-9])+|(\,([0-9]+))"" data-parsley-trigger=""change"" required></td>
                                        <td class=""text-justify""><input class=""form-control col-md-2 col-xs-12"" type=""text"" name=""W"" data-parsley-pattern=""([0-9])+|(\,([0-9]+))"" data-parsley-trigger=""change"" required></td>
                 ");
            WriteLiteral(@"                   </tr>
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
#line 94 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Grupos.cshtml"
                        }

#line default
#line hidden
            BeginContext(5336, 1319, true);
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
                                    <th>T<small>c</small> / K</th>
                                    <th>P<small>c</s");
            WriteLiteral(@"mall> / bar</th>
                                    <th>Z<small>c</small></th>
                                    <th>w</th>
                                    <th></th>
                                </tr>
                            </thead>


                            <tbody>
");
            EndContext();
#line 128 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Grupos.cshtml"
                                 foreach (var f in Model)
                                {

#line default
#line hidden
            BeginContext(6749, 38, true);
            WriteLiteral("                                <tr>\r\n");
            EndContext();
#line 131 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Grupos.cshtml"
                                      
                                        var i = f.i;
                                    

#line default
#line hidden
            BeginContext(6920, 40, true);
            WriteLiteral("                                    <td>");
            EndContext();
            BeginContext(6961, 11, false);
#line 134 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Grupos.cshtml"
                                   Write(i.Compuesto);

#line default
#line hidden
            EndContext();
            BeginContext(6972, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(7020, 9, false);
#line 135 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Grupos.cshtml"
                                   Write(i.Formula);

#line default
#line hidden
            EndContext();
            BeginContext(7029, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(7077, 3, false);
#line 136 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Grupos.cshtml"
                                   Write(i.M);

#line default
#line hidden
            EndContext();
            BeginContext(7080, 68, true);
            WriteLiteral("</td>\r\n                                    <td class=\"text-justify\">");
            EndContext();
            BeginContext(7149, 6, false);
#line 137 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Grupos.cshtml"
                                                        Write(f.Tc_K);

#line default
#line hidden
            EndContext();
            BeginContext(7155, 68, true);
            WriteLiteral("</td>\r\n                                    <td class=\"text-justify\">");
            EndContext();
            BeginContext(7224, 8, false);
#line 138 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Grupos.cshtml"
                                                        Write(f.Pc_bar);

#line default
#line hidden
            EndContext();
            BeginContext(7232, 68, true);
            WriteLiteral("</td>\r\n                                    <td class=\"text-justify\">");
            EndContext();
            BeginContext(7301, 4, false);
#line 139 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Grupos.cshtml"
                                                        Write(f.Zc);

#line default
#line hidden
            EndContext();
            BeginContext(7305, 68, true);
            WriteLiteral("</td>\r\n                                    <td class=\"text-justify\">");
            EndContext();
            BeginContext(7374, 3, false);
#line 140 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Grupos.cshtml"
                                                        Write(f.W);

#line default
#line hidden
            EndContext();
            BeginContext(7377, 168, true);
            WriteLiteral("</td>\r\n                                    <td width=\"7%\"><a href=\"\"  class=\"btn btn-round btn-info\" data-title=\"modificar\" data-toggle=\"modal\" data-target=\"#modificar\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 7545, "\"", 7630, 18);
            WriteAttributeValue("", 7555, "Modificar(\'", 7555, 11, true);
#line 141 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Grupos.cshtml"
WriteAttributeValue("", 7566, f.Id, 7566, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 7571, "\',", 7571, 2, true);
            WriteAttributeValue(" ", 7573, "\'", 7574, 2, true);
#line 141 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Grupos.cshtml"
WriteAttributeValue("", 7575, i.Compuesto, 7575, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 7587, "\',", 7587, 2, true);
            WriteAttributeValue(" ", 7589, "\'", 7590, 2, true);
#line 141 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Grupos.cshtml"
WriteAttributeValue("", 7591, f.Tc_K, 7591, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 7598, "\',", 7598, 2, true);
            WriteAttributeValue(" ", 7600, "\'", 7601, 2, true);
#line 141 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Grupos.cshtml"
WriteAttributeValue("", 7602, f.Pc_bar, 7602, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 7611, "\',", 7611, 2, true);
            WriteAttributeValue(" ", 7613, "\'", 7614, 2, true);
#line 141 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Grupos.cshtml"
WriteAttributeValue("", 7615, f.Zc, 7615, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 7620, "\',", 7620, 2, true);
            WriteAttributeValue(" ", 7622, "\'", 7623, 2, true);
#line 141 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Grupos.cshtml"
WriteAttributeValue("", 7624, f.W, 7624, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 7628, "\')", 7628, 2, true);
            EndWriteAttribute();
            BeginContext(7631, 144, true);
            WriteLiteral("><i class=\"fa fa-pencil\"></i></a> <a href=\"\"  class=\"btn btn-round btn-danger\" data-title=\"eliminar\" data-toggle=\"modal\" data-target=\"#eliminar\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 7775, "\"", 7802, 3);
            WriteAttributeValue("", 7785, "Eliminar(\'", 7785, 10, true);
#line 141 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Grupos.cshtml"
WriteAttributeValue("", 7795, f.Id, 7795, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 7800, "\')", 7800, 2, true);
            EndWriteAttribute();
            BeginContext(7803, 78, true);
            WriteLiteral("><i class=\"fa fa-close\"></i></a></td>\r\n                                </tr>\r\n");
            EndContext();
#line 143 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Grupos.cshtml"
                                }

#line default
#line hidden
            BeginContext(7916, 252, true);
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                        <!--/ Content-->\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <!--end Lista-->\r\n        </div>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
