#pragma checksum "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Noticia\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6261c160e1a1822e5b2b2a99a21531faeb63885"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Noticia_Index), @"mvc.1.0.view", @"/Views/Noticia/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Noticia/Index.cshtml", typeof(AspNetCore.Views_Noticia_Index))]
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
#line 1 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Noticia\Index.cshtml"
using Eosweb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6261c160e1a1822e5b2b2a99a21531faeb63885", @"/Views/Noticia/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eca8a1f8476f0eec4d90446ae923c2fd5b2cea45", @"/Views/_ViewImports.cshtml")]
    public class Views_Noticia_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Eosweb.Models.Noticia>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/google-code-prettify/bin/prettify.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Noticia\Index.cshtml"
  
    ViewData["Title"] = "Noticias";
    ViewBag.Title = "Noticias";

#line default
#line hidden
            BeginContext(137, 30, true);
            WriteLiteral("\r\n<!-- bootstrap-wysiwyg -->\r\n");
            EndContext();
            BeginContext(167, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "93b040d6717c4ad7b0646f9a8bc95380", async() => {
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
            BeginContext(245, 176, true);
            WriteLiteral("\r\n\r\n<div class=\"right_col\" role=\"main\">\r\n    <div class=\"\">\r\n        <!--Titulo-->\r\n        <div class=\"page-title\">\r\n            <div class=\"title_left\">\r\n                <h3>");
            EndContext();
            BeginContext(422, 13, false);
#line 17 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Noticia\Index.cshtml"
               Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(435, 341, true);
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
            BeginWriteAttribute("href", " href=\"", 776, "\"", 811, 1);
#line 27 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Noticia\Index.cshtml"
WriteAttributeValue("", 783, Url.Action("Index", "Home"), 783, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(812, 523, true);
            WriteLiteral(@">Inicio</a></li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">Noticias</li>
                    </ol>
                </nav>
            </div>
        </div>
        <!--/ Breadcrumb-->

        <div class=""clearfix""></div>
        <!--Contenido -->
        <div class="""">
            <div class=""col-md-12 col-sm-12 col-xs-12"">
                <div class=""x_panel"">
                    <div class=""x_title"">
                        <h2><i class=""fa fa-th-list""></i> </h2>
");
            EndContext();
#line 42 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Noticia\Index.cshtml"
                         if(@ViewBag.Tipo == "Administrador") {

#line default
#line hidden
            BeginContext(1400, 374, true);
            WriteLiteral(@"                            <ul class=""nav navbar-right panel_toolbox"">
                                <li></li>
                                <li></li>
                                <li><a href=""""  class=""btn btn-primary"" data-title=""add"" data-toggle=""modal"" data-target=""#add"" ><i class=""fa fa-plus fa-lg""></i> Noticia</a></li>
                            </ul>
");
            EndContext();
#line 48 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Noticia\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1801, 239, true);
            WriteLiteral("                        <div class=\"clearfix\"></div>\r\n                    </div>\r\n                    <div class=\"x_content\">\r\n                        <!--Content-->\r\n                            <ul class=\"list-unstyled timeline widget\">\r\n");
            EndContext();
#line 54 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Noticia\Index.cshtml"
                                 foreach (var noticia in Model)
                                {

#line default
#line hidden
            BeginContext(2140, 38, true);
            WriteLiteral("                                <li>\r\n");
            EndContext();
#line 57 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Noticia\Index.cshtml"
                                      
                                        var autor = noticia.autor;
                                    

#line default
#line hidden
            BeginContext(2325, 240, true);
            WriteLiteral("                                    <div class=\"block\">\r\n                                    <div class=\"block_content\">\r\n                                        <h2 class=\"title\">\r\n                                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2565, "\"", 2631, 1);
#line 63 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Noticia\Index.cshtml"
WriteAttributeValue("", 2572, Url.Action("Noticia", "Noticia", new { Id  = @noticia.id}), 2572, 59, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2632, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2634, 14, false);
#line 63 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Noticia\Index.cshtml"
                                                                                                                         Write(noticia.titulo);

#line default
#line hidden
            EndContext();
            BeginContext(2648, 167, true);
            WriteLiteral("</a>\r\n                                                    </h2>\r\n                                        <div class=\"byline\">\r\n                                        ");
            EndContext();
            BeginContext(2816, 13, false);
#line 66 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Noticia\Index.cshtml"
                                   Write(noticia.fecha);

#line default
#line hidden
            EndContext();
            BeginContext(2829, 38, true);
            WriteLiteral(" por <span class=\"badge badge-danger\">");
            EndContext();
            BeginContext(2868, 12, false);
#line 66 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Noticia\Index.cshtml"
                                                                                       Write(autor.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(2880, 184, true);
            WriteLiteral("</span>\r\n                                        </div>\r\n                                    </div>\r\n                                    </div>\r\n                                </li>\r\n");
            EndContext();
#line 71 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Noticia\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(3099, 955, true);
            WriteLiteral(@"                            </ul>
                        <!--Content-->
                    </div>
                </div>
            </div>
        </div>
        <!--Contenido -->
    </div>
</div>

<script type=""text/javascript"">
    VerNoticia= function (id, titulo, cuerpo, fecha, autor) {
            document.getElementById(""fecha-not"").innerHTML= fecha;
        };
</script>

<!--Modal Crear -->
<div class=""modal fade bd-example-modal-lg"" id=""add"" tabindex=""-1"" role=""dialog"" aria-labelledby=""add"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
                <h4 class=""modal-title""><i class=""fa fa-pencil-square-o""></i> Nueva Noticia</h4>
            </div>
");
            EndContext();
#line 98 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Noticia\Index.cshtml"
             using (Html.BeginForm("Crear", "Noticia", FormMethod.Post, new { enctype = "multipart/form-data", @style = "border:none", data_parley_validate = false }))
            {

#line default
#line hidden
            BeginContext(4238, 6286, true);
            WriteLiteral(@"                <div class=""modal-body form-horizontal form-label-left"" data-parsley-validate>
                        <div class=""form-group"">
                            <div class=""alert alert-info alert-dismissible fade in"" role=""alert"">
                                <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close""><span aria-hidden=""true"">×</span>
                                </button>
                                <i class=""fa fa-info-circle fa-lg""></i> ¡Ten en cuenta que la fecha de la publicación se establecerá en cuanto la publiques! :)
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""control-label col-md-3 col-sm-3 col-xs-12"">Título *:</label>
                            <div class=""col-md-9 col-sm-9 col-xs-9"">
                                <input type=""text"" class=""form-control"" name=""Titulo"" rows=""1"" data-parsley-length=""[4, 20]"" data-parsley-mi");
            WriteLiteral(@"nwords=""1"" placeholder=""Ejemplo: ¡Avances!"" data-parsley-trigger=""change"" required>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""control-label col-md-12 col-sm-12 col-xs-12"">Cuerpo *:</label>
                            <!--Noticia-->
                                <div class=""col-md-12 col-sm-12 col-xs-12"">
                                    <div id=""alerts""></div>
                                    <div class=""btn-toolbar editor"" data-role=""editor-toolbar"" data-target=""#editor-one"">
                                        <div class=""btn-group"">
                                            <a class=""btn dropdown-toggle"" data-toggle=""dropdown"" title=""Font Size""><i class=""fa fa-text-height""></i>&nbsp;<b class=""caret""></b></a>
                                            <ul class=""dropdown-menu"">
                                                <li>
                                     ");
            WriteLiteral(@"           <a data-edit=""fontSize 5"">
                                                    <p style=""font-size:17px"">Grande</p>
                                                </a>
                                                </li>
                                                <li>
                                                <a data-edit=""fontSize 2"">
                                                    <p style=""font-size:13px"">Normal</p>
                                                </a>
                                                </li>
                                                <li>
                                                <a data-edit=""fontSize 1"">
                                                    <p style=""font-size:11px"">Pequeño</p>
                                                </a>
                                                </li>
                                            </ul>
                                        </div>

                          ");
            WriteLiteral(@"              <div class=""btn-group"">
                                        <a class=""btn"" data-edit=""bold"" title=""Bold (Ctrl/Cmd+B)""><i class=""fa fa-bold""></i></a>
                                        <a class=""btn"" data-edit=""italic"" title=""Italic (Ctrl/Cmd+I)""><i class=""fa fa-italic""></i></a>
                                        <a class=""btn"" data-edit=""strikethrough"" title=""Strikethrough""><i class=""fa fa-strikethrough""></i></a>
                                        <a class=""btn"" data-edit=""underline"" title=""Underline (Ctrl/Cmd+U)""><i class=""fa fa-underline""></i></a>
                                        </div>

                                        <div class=""btn-group"">
                                        <a class=""btn"" data-edit=""insertunorderedlist"" title=""Bullet list""><i class=""fa fa-list-ul""></i></a>
                                        <a class=""btn"" data-edit=""insertorderedlist"" title=""Number list""><i class=""fa fa-list-ol""></i></a>
                                 ");
            WriteLiteral(@"       <a class=""btn"" data-edit=""outdent"" title=""Reduce indent (Shift+Tab)""><i class=""fa fa-dedent""></i></a>
                                        <a class=""btn"" data-edit=""indent"" title=""Indent (Tab)""><i class=""fa fa-indent""></i></a>
                                        </div>

                                        <div class=""btn-group"">
                                        <a class=""btn"" data-edit=""justifyleft"" title=""Align Left (Ctrl/Cmd+L)""><i class=""fa fa-align-left""></i></a>
                                        <a class=""btn"" data-edit=""justifycenter"" title=""Center (Ctrl/Cmd+E)""><i class=""fa fa-align-center""></i></a>
                                        <a class=""btn"" data-edit=""justifyright"" title=""Align Right (Ctrl/Cmd+R)""><i class=""fa fa-align-right""></i></a>
                                        <a class=""btn"" data-edit=""justifyfull"" title=""Justify (Ctrl/Cmd+J)""><i class=""fa fa-align-justify""></i></a>
                                        </div>

                     ");
            WriteLiteral(@"                   <div class=""btn-group"">
                                        <a class=""btn"" data-edit=""undo"" title=""Undo (Ctrl/Cmd+Z)""><i class=""fa fa-undo""></i></a>
                                        <a class=""btn"" data-edit=""redo"" title=""Redo (Ctrl/Cmd+Y)""><i class=""fa fa-repeat""></i></a>
                                        </div>
                                    </div>
                                    <div id=""editor-one"" class=""editor-wrapper"" placeholder=""Ejemplo: Se agregó contenido nuevo"" ></div>
                                    <textarea name=""descr"" id=""descr"" style=""display:none;""></textarea>
                                </div>
                            <!--end noticia-->
                        </div>
                        
                </div>
                <div class=""modal-footer"">
                    <input type=""hidden"" name=""Cuerpo"" id=""cuerpo-pub"">
                    <button type=""submit"" id=""button-publicar"" class=""btn btn-success"">Publicar<");
            WriteLiteral("/button>\r\n                    <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Cancelar</button>\r\n                </div>\r\n");
            EndContext();
#line 179 "C:\Users\elyna\Documents\Universidad de Talca\2019-2\Diseño y Analisis de Algoritmos\EoS\EosWeb\Views\Noticia\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(10539, 38, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(10594, 408, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('#button-publicar').click(function () {
                //Open modal dialog for edit event
                var v = document.getElementById(""editor-one"");
                var finalvar = v.innerHTML;
                document.getElementById('cuerpo-pub').setAttribute(""value"", finalvar);
            });

        });
    </script>
");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Eosweb.Models.Noticia>> Html { get; private set; }
    }
}
#pragma warning restore 1591
