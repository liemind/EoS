#pragma checksum "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Home\Perfil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ccded148a7052bd8676cd93e7a44cbd68a4db15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Perfil), @"mvc.1.0.view", @"/Views/Home/Perfil.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Perfil.cshtml", typeof(AspNetCore.Views_Home_Perfil))]
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
#line 1 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Home\Perfil.cshtml"
using Eosweb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ccded148a7052bd8676cd93e7a44cbd68a4db15", @"/Views/Home/Perfil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eca8a1f8476f0eec4d90446ae923c2fd5b2cea45", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Perfil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(22, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Home\Perfil.cshtml"
  
    ViewData["Title"] = "Perfil";
    ViewBag.Title = "Perfil";

#line default
#line hidden
            BeginContext(97, 23, true);
            WriteLiteral("\r\n<!-- Datatables -->\r\n");
            EndContext();
            BeginContext(120, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7ad4b2105ed945e8943d721bc5a58013", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "60f8bf4667a647369c461be0988e41df", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "831971ca15c2442f9c8f728a769955ce", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2c611f3750f445e7ba6eab03094ac0d3", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "45125786c43a464d85a147762afa84bc", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "444d0742e9d84b66b1f0d03f2a70bde1", async() => {
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
#line 21 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Home\Perfil.cshtml"
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
#line 31 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Home\Perfil.cshtml"
WriteAttributeValue("", 1265, Url.Action("Index", "Home"), 1265, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1294, 110, true);
            WriteLiteral(">Inicio</a></li>\r\n                        <li class=\"breadcrumb-item active\" aria-current=\"page\">Ver perfil | ");
            EndContext();
            BeginContext(1405, 21, false);
#line 32 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Home\Perfil.cshtml"
                                                                                       Write(ViewBag.NombreUsuario);

#line default
#line hidden
            EndContext();
            BeginContext(1426, 4853, true);
            WriteLiteral(@"</li>
                    </ol>
                </nav>
            </div>
        </div>
        <!--/ Breadcrumb-->

        <div class=""clearfix""></div>
        <!--Contenido -->

        <div class="""">
            <!--Profile -->
            <div class=""col-md-12 col-sm-12 col-xs-12"">
                <div class=""x_panel"">
                    <div class=""x_title"">
                        <h2><i class=""fa fa-th-list""></i> </h2>
                        <div class=""clearfix""></div>
                    </div>
                        <div class=""x_content"">
                        <!--Tab panel -->
                            <div class="""" role=""tabpanel"" data-example-id=""togglable-tabs"">
                                <ul id=""myTab"" class=""nav nav-tabs bar_tabs"" role=""tablist"">
                                    <li role=""presentation"" class=""active""><a href=""#tab_content1"" id=""home-tab"" role=""tab"" data-toggle=""tab"" aria-expanded=""true"">Mis grupos</a>
                                   ");
            WriteLiteral(@" </li>
                                    <li role=""presentation"" class=""""><a href=""#tab_content2"" role=""tab"" id=""profile-tab"" data-toggle=""tab"" aria-expanded=""false"">Configuración</a>
                                    </li>
                                </ul>
                                <div id=""myTabContent"" class=""tab-content"">
                                    <div role=""tabpanel"" class=""tab-pane fade active in"" id=""tab_content1"" aria-labelledby=""home-tab"">
                                        <!-- tab 1-->
                                        <div class=""col-11 col-md-11 col-sm-11 col-xs-12""><p class=""lead"">Grupos Actuales</p></div>
                                        <div class=""col-1 col-md-1 col-sm-1 col-xs-12 text-right""><a href=""""  class=""btn btn-primary"" data-title=""grupo"" data-toggle=""modal"" data-target=""#grupo"" ><i class=""fa fa-plus fa-lg""></i> Grupo</a></div>



                                        <!--tabla-->
                                            <tab");
            WriteLiteral(@"le class=""table table-striped table-bordered table-responsive"" >
                                                <thead>
                                                    <tr>
                                                        <th>Llave</th>
                                                        <th>Descripción</th>
                                                    </tr>
                                                </thead>
                                                <tbody>
                                                    <tr>
                                                        <td class=""text-center"" colspan=""2"">No existen datos</td>
                                                    </tr>
                                                </tbody>
                                            </table>
                                        <!--/tabla -->

                                        <p class=""lead"">Todos mis grupos</p>
                                       ");
            WriteLiteral(@" <!--tabla-->
                                        <table id=""datatable"" class=""table table-striped table-bordered table-responsive"">
                                            <thead>
                                                <tr>
                                                    <th>Llave</th>
                                                    <th>Descripción</th>
                                                </tr>
                                            </thead>


                                            <tbody>
                                            </tbody>
                                        </table>
                                        <!--/tabla --> 
                                        <!-- fin tab -->
                                    </div>
                                    <div role=""tabpanel"" class=""tab-pane fade"" id=""tab_content2"" aria-labelledby=""profile-tab"">   
                                        <!-- tab 2 -->
                   ");
            WriteLiteral(@"                         <p class=""lead"">Cambiar Contraseña</p>
                                            <!--aviso -->
                                            <div class=""alert alert-info alert-dismissible fade in"" role=""alert"">
                                                <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close""><span aria-hidden=""true"">×</span></button>
                                                <i class=""fa fa-info-circle fa-lg""></i> Recuerda que si las contraseñas no coinciden los cambios no podrán ser actualizados.
                                            </div>
                                            <!--end aviso-->
                                            <!-- Content -->
");
            EndContext();
#line 110 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Home\Perfil.cshtml"
                                             using (Html.BeginForm("CambiarPass", "Home", FormMethod.Post, new { enctype = "multipart/form-data", @style = "border:none", data_parley_validate = false }))
                                            {

#line default
#line hidden
            BeginContext(6530, 2002, true);
            WriteLiteral(@"                                            <div class=""modal-body form-horizontal form-label-left"" data-parsley-validate>
                                                <div class=""form-group"">
                                                    <label class=""control-label col-md-3 col-sm-3 col-xs-12"">Contraseña actual *:</label>
                                                    <div class=""col-md-9 col-sm-9 col-xs-9"">
                                                        <input class=""form-control"" type=""password"" name=""anterior"" rows=""1""data-parsley-minlength=""1"" data-parsley-pattern=""([a-zA-ZñÑáéíóúÁÉÍÓÚ\s]|(\-)|(\,)|[0-9])+"" data-parsley-trigger=""change"" required>
                                                    </div>
                                                </div>
                                                <div class=""form-group"">
                                                    <label class=""control-label col-md-3 col-sm-3 col-xs-12"">Nueva contraseña *:</label>
        ");
            WriteLiteral(@"                                            <div class=""col-md-9 col-sm-9 col-xs-9"">
                                                        <input class=""form-control col-md-7 col-xs-12"" type=""password"" name=""nuevo"" placeholder=""La nueva contraseña debe ser entre 6 a 8 caracteres"" data-validate-length=""[6,8]"" data-parsley-trigger=""change"">
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""ln_solid""></div>
                                                <div class=""form-group"">
                                                    <div class="""">
                                                    <button id=""send"" type=""submit"" class=""btn btn-success"">Cambiar Contraseña</button>
                                                </div>
                                                </div>
");
            EndContext();
#line 132 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Home\Perfil.cshtml"
                                            }

#line default
#line hidden
            BeginContext(8579, 928, true);
            WriteLiteral(@"                                        <!-- fin tab -->
                                    </div>
                                </div>
                            </div>
                        <!--Tab panel end -->
                    </div>
                </div>
            </div>
            <!--end Lista-->
        </div>

    </div>
</div>

<!--Modal Agregar-->
<div class=""modal fade bd-example-modal-lg"" id=""addi"" tabindex=""-1"" role=""dialog"" aria-labelledby=""addi"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
                <h4 class=""modal-title""><i class=""fa fa-pencil-square-o""></i> Entrar a un grupo</h4>
            </div>
");
            EndContext();
#line 157 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Home\Perfil.cshtml"
             using (Html.BeginForm("UnirseAGrupo", "Grupo", FormMethod.Post, new { enctype = "multipart/form-data", @style = "border:none", data_parley_validate = false }))
            {

#line default
#line hidden
            BeginContext(9696, 826, true);
            WriteLiteral(@"                <div class=""modal-body form-horizontal form-label-left"" data-parsley-validate>

                        <div class=""form-group"">
                            <label class=""control-label col-md-3 col-sm-3 col-xs-12"">Llave *:</label>
                            <div class=""col-md-9 col-sm-9 col-xs-9"">
                                <input type=""text"" class=""form-control"" name=""Llave"" rows=""1""data-parsley-minlength=""1"" data-parsley-pattern=""([a-zA-ZñÑáéíóúÁÉÍÓÚ\s]|(\-)|(\,)|[0-9])+"" data-parsley-trigger=""change"" required>
                            </div>
                        </div>          
                </div>
                <div class=""modal-footer"">
                    <button type=""submit"" class=""btn btn-success"">Unirse</button>
                    <input type=""hidden"" name=""Id""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 10522, "\"", 10548, 1);
#line 170 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Home\Perfil.cshtml"
WriteAttributeValue("", 10530, ViewBag.IdUsuario, 10530, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(10549, 135, true);
            WriteLiteral(">\r\n                    <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Cancelar</button>\r\n                </div>\r\n");
            EndContext();
#line 173 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Home\Perfil.cshtml"
            }

#line default
#line hidden
            BeginContext(10699, 34, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
