#pragma checksum "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d26caf52270fe8a4e2c82125b06cf36b9479dc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_Index), @"mvc.1.0.view", @"/Views/Usuarios/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuarios/Index.cshtml", typeof(AspNetCore.Views_Usuarios_Index))]
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
#line 1 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Index.cshtml"
using Eosweb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d26caf52270fe8a4e2c82125b06cf36b9479dc2", @"/Views/Usuarios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eca8a1f8476f0eec4d90446ae923c2fd5b2cea45", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Eosweb.Models.Usuario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/select2/dist/css/select2.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables/datatables.net-bs/css/dataTables.bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables/datatables.net-buttons-bs/css/buttons.bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables/datatables.net-fixedheader-bs/css/fixedHeader.bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables/datatables.net-responsive-bs/css/responsive.bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables/datatables.net-scroller-bs/css/scroller.bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Administrador", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Estudiante", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Index.cshtml"
  
    ViewData["Title"] = "Usuarios";
    ViewBag.Title = "Usuarios en el Sistema";

#line default
#line hidden
            BeginContext(151, 23, true);
            WriteLiteral("\r\n<!-- Datatables -->\r\n");
            EndContext();
            BeginContext(174, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4bcedd44cd424c0f94418d64590f93a9", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "038be0164e064b1788fe0e638e04252a", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8e919803e14f43169a3b0a97f1980645", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5faf1e53571a4cf4bd1b99ab4eb7a3e5", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2cb7764e8e2c4b5ab7980589942b4087", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "771bfe01ba934506acc243381ae1b960", async() => {
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
            BeginContext(781, 178, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"right_col\" role=\"main\">\r\n    <div class=\"\">\r\n        <!--Titulo-->\r\n        <div class=\"page-title\">\r\n            <div class=\"title_left\">\r\n                <h3>");
            EndContext();
            BeginContext(960, 13, false);
#line 23 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Index.cshtml"
               Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(973, 341, true);
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
            BeginWriteAttribute("href", " href=\"", 1314, "\"", 1349, 1);
#line 33 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Index.cshtml"
WriteAttributeValue("", 1321, Url.Action("Index", "Home"), 1321, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1350, 992, true);
            WriteLiteral(@">Inicio</a></li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">Lista de Usuarios</li>
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
                        <h2><i class=""fa fa-th-list""></i> Agregar un Usuario</h2>
                        <ul class=""nav navbar-right panel_toolbox"">
                            <li></li>
                            <li></li>
                            <li></li>
                        </ul>
                        <div class=""clearfix""></div>
                    </div>
                    <div class=""x_content"">
                        <!--Content-->
");
            EndContext();
#line 60 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Index.cshtml"
                         using (Html.BeginForm("Crear", "Usuarios", FormMethod.Post, new { enctype = "multipart/form-data", @style = "border:none", data_parley_validate = false }))
                        {

#line default
#line hidden
            BeginContext(2551, 1596, true);
            WriteLiteral(@"                        <div data-parsley-validate>
                            <table class=""table table-striped table-bordered table-responsive"" >
                                <thead>
                                    <tr>
                                        <th>Rut</th>
                                        <th>Nombre</th>
                                        <th>Correo Electrónico</th>
                                        <th>Tipo de Usuario</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td class=""text-justify""><input class=""form-control col-md-2 col-xs-12"" type=""text"" name=""Rut"" placeholder=""Ejemplo: 18123456"" data-parsley-pattern=""\d{0,1}\d{7}"" data-parsley-trigger=""change"" required></td>
                                        <td class=""text-justify""><input class=""form-control col-md-2 col-xs-12"" type=""text"" nam");
            WriteLiteral(@"e=""Nombre"" data-parsley-trigger=""change"" data-parsley-length=""[4, 20]"" data-parsley-minwords=""2"" name=""Nombre"" placeholder=""Nombre y Apellido. Ejemplo: Juan Perez"" required></td>
                                        <td class=""text-justify""><input class=""form-control col-md-2 col-xs-12"" type=""email"" name=""Correo"" data-parsley-trigger=""change"" required></td>
                                        <td width=""30%"" >
                                            <select class=""form-control"" name=""Tipo"" required>
                                                    ");
            EndContext();
            BeginContext(4147, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09aa4a3bd8374601938533732a593a8b", async() => {
                BeginContext(4178, 13, true);
                WriteLiteral("Administrador");
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
            BeginContext(4200, 54, true);
            WriteLiteral("\r\n                                                    ");
            EndContext();
            BeginContext(4254, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e7326ce405f4eb6be7aa25c787b38e6", async() => {
                BeginContext(4282, 10, true);
                WriteLiteral("Estudiante");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4301, 598, true);
            WriteLiteral(@"
                                            </select>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                        <div class=""ln_solid""></div>
                            <div class=""form-group"">
                                <div class="""">
                                <button id=""send"" type=""submit"" class=""btn btn-success"">Crear Cuenta</button>
                            </div>
                            </div>
");
            EndContext();
#line 93 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(4926, 1137, true);
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
                                    <th>Rut</th>
                                    <th>Nombre</th>
                                    <th>Correo Electrónico</th>
                                    <th>Tipo de Usuario</th>
                                    <th></th>
 ");
            WriteLiteral("                               </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
            EndContext();
#line 122 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Index.cshtml"
                                 foreach (var i in Model)
                                {

#line default
#line hidden
            BeginContext(6157, 97, true);
            WriteLiteral("                                    <tr>\r\n                                        <td width=\"7%\">");
            EndContext();
            BeginContext(6255, 5, false);
#line 125 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Index.cshtml"
                                                  Write(i.Rut);

#line default
#line hidden
            EndContext();
            BeginContext(6260, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(6312, 8, false);
#line 126 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Index.cshtml"
                                       Write(i.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(6320, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(6372, 19, false);
#line 127 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Index.cshtml"
                                       Write(i.CorreoElectronico);

#line default
#line hidden
            EndContext();
            BeginContext(6391, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(6443, 6, false);
#line 128 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Index.cshtml"
                                       Write(i.Tipo);

#line default
#line hidden
            EndContext();
            BeginContext(6449, 118, true);
            WriteLiteral("</td>\r\n                                        <td width=\"7%\">Button</td>\r\n                                    </tr>\r\n");
            EndContext();
#line 131 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Usuarios\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(6602, 252, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Eosweb.Models.Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
