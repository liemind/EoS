#pragma checksum "C:\Users\Liemind\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\Eosweb\Views\Fundamentales\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bed18ade73c414c4811b963c74d5b4c6610950c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fundamentales_Index), @"mvc.1.0.view", @"/Views/Fundamentales/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Fundamentales/Index.cshtml", typeof(AspNetCore.Views_Fundamentales_Index))]
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
#line 1 "C:\Users\Liemind\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\Eosweb\Views\_ViewImports.cshtml"
using Eosweb;

#line default
#line hidden
#line 1 "C:\Users\Liemind\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\Eosweb\Views\Fundamentales\Index.cshtml"
using Eosweb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bed18ade73c414c4811b963c74d5b4c6610950c", @"/Views/Fundamentales/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eca8a1f8476f0eec4d90446ae923c2fd5b2cea45", @"/Views/_ViewImports.cshtml")]
    public class Views_Fundamentales_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Eosweb.Models.Fundamentales>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/select2/dist/css/select2.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables/datatables.net-bs/css/dataTables.bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables/datatables.net-buttons-bs/css/buttons.bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables/datatables.net-fixedheader-bs/css/fixedHeader.bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables/datatables.net-responsive-bs/css/responsive.bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables/datatables.net-scroller-bs/css/scroller.bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "a", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Liemind\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\Eosweb\Views\Fundamentales\Index.cshtml"
  
    ViewData["Title"] = "Fundamentales";
    ViewBag.Title = "Fundamentales";

#line default
#line hidden
            BeginContext(153, 21, true);
            WriteLiteral("<!-- Datatables -->\r\n");
            EndContext();
            BeginContext(174, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7e6bd72049da41a2a65ecfafaa769549", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7b112f22a1a64b29a53bb1a2ff4685a4", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "16fc3b10816744d7b8e3b9788b0dc633", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "195ba6bad41a416ea0797ac845ebf0f1", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ac855a8719864211a6ae63e1d1d14e51", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8598cf6a3105421ea73cc458afc5fc53", async() => {
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
#line 21 "C:\Users\Liemind\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\Eosweb\Views\Fundamentales\Index.cshtml"
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
#line 31 "C:\Users\Liemind\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\Eosweb\Views\Fundamentales\Index.cshtml"
WriteAttributeValue("", 1319, Url.Action("Index", "Home"), 1319, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1348, 1129, true);
            WriteLiteral(@">Inicio</a></li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">Fundamentales</li>
                    </ol>
                </nav>
            </div>
        </div>
        <!--/ Breadcrumb-->

        <div class=""clearfix""></div>
        <!--Contenido -->

        <!--crear un dato-->
        <div class="""">
            <!--Lista -->
            <div class=""col-md-12 col-sm-12 col-xs-12"">
                <div class=""x_panel"">
                    <div class=""x_title"">
                        <h2><i class=""fa fa-th-list""></i> Agregar un dato</h2>
                        <ul class=""nav navbar-right panel_toolbox"">
                            <li></li>
                            <li></li>
                            <li><a href=""""  class=""btn btn-primary"" data-title=""add"" data-toggle=""modal"" data-target=""#add"" ><i class=""fa fa-plus fa-lg""></i> Identificador</a></li>
                        </ul>
                        <div class=""clearfix""></div>
        ");
            WriteLiteral("            </div>\r\n                    <div class=\"x_content\">\r\n                        <!--Content-->\r\n");
            EndContext();
#line 58 "C:\Users\Liemind\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\Eosweb\Views\Fundamentales\Index.cshtml"
                         using (Html.BeginForm("Crear", "Fundamentales", FormMethod.Post, new { enctype = "multipart/form-data", @style = "border:none", data_parley_validate = false }))
                        {

#line default
#line hidden
            BeginContext(2691, 891, true);
            WriteLiteral(@"                        <div data-parsley-validate>
                            <table class=""table table-striped table-bordered table-responsive"" >
                                <thead>
                                    <tr>
                                        <th>Compuesto</th>
                                        <th>Tc / K</th>
                                        <th>Pc / bar</th>
                                        <th>Zc</th>
                                        <th>w</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td width=""30%"" >
                                            <select class=""form-control"" name=""Identificador"" required>
                                            ");
            EndContext();
            BeginContext(3582, 28, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86e73d7705ab42a484242263f3fc83ba", async() => {
                BeginContext(3600, 1, true);
                WriteLiteral("a");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3610, 1162, true);
            WriteLiteral(@"
                                            </select>
                                        </td>
                                        <td class=""text-justify""><input class=""form-control col-md-2 col-xs-12"" type=""number"" name=""""></td>
                                        <td class=""text-justify""><input class=""form-control col-md-2 col-xs-12"" type=""number"" name=""""></td>
                                        <td class=""text-justify""><input class=""form-control col-md-2 col-xs-12"" type=""number"" name=""""></td>
                                        <td class=""text-justify""><input class=""form-control col-md-2 col-xs-12"" type=""number"" name=""""></td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                        <div class=""ln_solid""></div>
                            <div class=""form-group"">
                                <div class="""">
                                <button id=""s");
            WriteLiteral("end\" type=\"submit\" class=\"btn btn-success\">Agregar Dato</button>\r\n                            </div>\r\n                            </div>\r\n");
            EndContext();
#line 92 "C:\Users\Liemind\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\Eosweb\Views\Fundamentales\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(4799, 1828, true);
            WriteLiteral(@"                    </div>
                </div>
            </div>
            <!--end Lista-->
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
                                    <th>Tc / K</th>
                                    <th>Pc / bar</th>
           ");
            WriteLiteral(@"                         <th>Zc</th>
                                    <th>w</th>
                                    <th></th>
                                </tr>
                            </thead>


                            <tbody>
                                <tr>
                                    <td>Compuesto</td>
                                    <td>CL</td>
                                    <td>M</td>
                                    <td class=""text-justify"">1</td>
                                    <td class=""text-justify"">2</td>
                                    <td class=""text-justify"">3</td>
                                    <td class=""text-justify"">4</td>
                                    <td></td>
                                </tr>
");
            EndContext();
#line 136 "C:\Users\Liemind\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\Eosweb\Views\Fundamentales\Index.cshtml"
                                 foreach (var f in Model)
                                {

#line default
#line hidden
            BeginContext(6721, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(6800, 13, false);
#line 139 "C:\Users\Liemind\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\Eosweb\Views\Fundamentales\Index.cshtml"
                                   Write(f.i.Compuesto);

#line default
#line hidden
            EndContext();
            BeginContext(6813, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(6861, 11, false);
#line 140 "C:\Users\Liemind\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\Eosweb\Views\Fundamentales\Index.cshtml"
                                   Write(f.i.Formula);

#line default
#line hidden
            EndContext();
            BeginContext(6872, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(6920, 5, false);
#line 141 "C:\Users\Liemind\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\Eosweb\Views\Fundamentales\Index.cshtml"
                                   Write(f.i.M);

#line default
#line hidden
            EndContext();
            BeginContext(6925, 68, true);
            WriteLiteral("</td>\r\n                                    <td class=\"text-justify\">");
            EndContext();
            BeginContext(6994, 6, false);
#line 142 "C:\Users\Liemind\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\Eosweb\Views\Fundamentales\Index.cshtml"
                                                        Write(f.Tc_K);

#line default
#line hidden
            EndContext();
            BeginContext(7000, 68, true);
            WriteLiteral("</td>\r\n                                    <td class=\"text-justify\">");
            EndContext();
            BeginContext(7069, 8, false);
#line 143 "C:\Users\Liemind\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\Eosweb\Views\Fundamentales\Index.cshtml"
                                                        Write(f.Pc_bar);

#line default
#line hidden
            EndContext();
            BeginContext(7077, 68, true);
            WriteLiteral("</td>\r\n                                    <td class=\"text-justify\">");
            EndContext();
            BeginContext(7146, 4, false);
#line 144 "C:\Users\Liemind\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\Eosweb\Views\Fundamentales\Index.cshtml"
                                                        Write(f.Zc);

#line default
#line hidden
            EndContext();
            BeginContext(7150, 68, true);
            WriteLiteral("</td>\r\n                                    <td class=\"text-justify\">");
            EndContext();
            BeginContext(7219, 3, false);
#line 145 "C:\Users\Liemind\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\Eosweb\Views\Fundamentales\Index.cshtml"
                                                        Write(f.W);

#line default
#line hidden
            EndContext();
            BeginContext(7222, 46, true);
            WriteLiteral("</td>\r\n                                </tr>\r\n");
            EndContext();
#line 147 "C:\Users\Liemind\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\Eosweb\Views\Fundamentales\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(7303, 252, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Eosweb.Models.Fundamentales>> Html { get; private set; }
    }
}
#pragma warning restore 1591
