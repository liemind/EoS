#pragma checksum "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Home\Perfil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af2c351cc8453c41b606f6723a60df3057a412d9"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af2c351cc8453c41b606f6723a60df3057a412d9", @"/Views/Home/Perfil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eca8a1f8476f0eec4d90446ae923c2fd5b2cea45", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Perfil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
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
            BeginContext(97, 174, true);
            WriteLiteral("\r\n<div class=\"right_col\" role=\"main\">\r\n    <div class=\"\">\r\n        <!--Titulo-->\r\n        <div class=\"page-title\">\r\n            <div class=\"title_left\">\r\n                <h3>");
            EndContext();
            BeginContext(272, 13, false);
#line 13 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Home\Perfil.cshtml"
               Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(285, 341, true);
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
            BeginWriteAttribute("href", " href=\"", 626, "\"", 661, 1);
#line 23 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Home\Perfil.cshtml"
WriteAttributeValue("", 633, Url.Action("Index", "Home"), 633, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(662, 1619, true);
            WriteLiteral(@">Inicio</a></li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">Ver perfil | Nombre Usuario</li>
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
                        <!--Content-->
                        <ul class=""nav nav-tabs bar_tabs"" id=""myTab"" role=""tablist"">
                            <li class=""nav-item"">
                                <a class=""nav-link active"" id=""grupo-tab"" data-toggle=""tab"" href=""#grupo"" role=""tab"" aria-controls=""grupo"" aria-sel");
            WriteLiteral(@"ected=""true"">Mis grupos</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" id=""pass-tab"" data-toggle=""tab"" href=""#pass"" role=""tab"" aria-controls=""pass"" aria-selected=""false"">Configuración</a>
                            </li>
                        </ul>
                        <div class=""tab-content"" id=""myTabContent"">
                            <div class=""tab-pane fade show active"" id=""grupo"" role=""tabpanel"" aria-labelledby=""grupo-tab"">+
                                <!-- Content -->
");
            EndContext();
#line 55 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Home\Perfil.cshtml"
                                 using (Html.BeginForm("CambiarPass", "Fundamentales", FormMethod.Post, new { enctype = "multipart/form-data", @style = "border:none", data_parley_validate = false }))
                                {

#line default
#line hidden
            BeginContext(2517, 1012, true);
            WriteLiteral(@"                                <div data-parsley-validate>
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
#line 72 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Home\Perfil.cshtml"
                                                         foreach (var id in ViewData["Identificadores"] as IList<Identificador>){

#line default
#line hidden
            BeginContext(3660, 60, true);
            WriteLiteral("                                                            ");
            EndContext();
            BeginContext(3720, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "455a8b2ac56745e3b5b1bfcf6ec6b038", async() => {
                BeginContext(3744, 12, false);
#line 73 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Home\Perfil.cshtml"
                                                                              Write(id.Compuesto);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 73 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Home\Perfil.cshtml"
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
            BeginContext(3765, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 74 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Home\Perfil.cshtml"
                                                        }

#line default
#line hidden
            BeginContext(3826, 1629, true);
            WriteLiteral(@"                                                    </select>
                                                </td>
                                                <td class=""text-justify""><input class=""form-control col-md-2 col-xs-12"" type=""text"" name=""Tc_K"" data-parsley-pattern=""([0-9])+|(\,([0-9]+))"" data-parsley-trigger=""change"" required></td>
                                                <td class=""text-justify""><input class=""form-control col-md-2 col-xs-12"" type=""text"" name=""Pc_bar"" data-parsley-pattern=""([0-9])+|(\,([0-9]+))"" data-parsley-trigger=""change"" required></td>
                                                <td class=""text-justify""><input class=""form-control col-md-2 col-xs-12"" type=""text"" name=""Zc"" data-parsley-pattern=""([0-9])+|(\,([0-9]+))"" data-parsley-trigger=""change"" required></td>
                                                <td class=""text-justify""><input class=""form-control col-md-2 col-xs-12"" type=""text"" name=""W"" data-parsley-pattern=""([0-9])+|(\,([0-9]+))"" data-parsley-tr");
            WriteLiteral(@"igger=""change"" required></td>
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
#line 91 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Home\Perfil.cshtml"
                                }

#line default
#line hidden
            BeginContext(5490, 802, true);
            WriteLiteral(@"                                <!--/content -->
                            </div>
                            <div class=""tab-pane fade"" id=""pass"" role=""tabpanel"" aria-labelledby=""pass-tab"">
                                Food truck fixie locavore, accusamus mcsweeney's marfa nulla single-origin coffee squid. Exercitation +1 labore velit, blog sartorial PBR leggings next level wes anderson artisan four loko farm-to-table craft beer twee. Qui photo
                                    booth letterpress, commodo enim craft beer mlkshk aliquip
                            </div>
                        </div>
                        <!--/ Content-->
                    </div>
                </div>
            </div>
            <!--end Lista-->
        </div>

    </div>
</div>");
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