#pragma checksum "C:\Users\SAMSUNG\Desktop\Proyecto---MascotaFeliz--c--Christian_Calvache_M\MascotaFeliz.app.Frontend\Pages\VisitasPyP\ListaVisitasPyP.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "672c082bbdb21ed45b1d67425ab1a3f3bf448d93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.App.Frontend.Pages.VisitasPyP.Pages_VisitasPyP_ListaVisitasPyP), @"mvc.1.0.razor-page", @"/Pages/VisitasPyP/ListaVisitasPyP.cshtml")]
namespace MascotaFeliz.App.Frontend.Pages.VisitasPyP
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
#line 1 "C:\Users\SAMSUNG\Desktop\Proyecto---MascotaFeliz--c--Christian_Calvache_M\MascotaFeliz.app.Frontend\Pages\_ViewImports.cshtml"
using MascotaFeliz.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"672c082bbdb21ed45b1d67425ab1a3f3bf448d93", @"/Pages/VisitasPyP/ListaVisitasPyP.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d90b2b40ba8c1257b37c8db6b0a6d90a6076caca", @"/Pages/_ViewImports.cshtml")]
    public class Pages_VisitasPyP_ListaVisitasPyP : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./DetallesVisitasPyP", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./EditarVisitasPyP", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <style>
    * {
        margin: 0;
        padding: 0;
        box-sizing: border-box;
    }

    body,
    html {
        height: 100%;
        padding: 0;
        margin: 0;
        font-family: 'Sniglet', cursive;
    }

    h1 {

        font-weight: normal;
        font-size: 3em;
        font-style: bold;
        font-family: 'Raleway', sans-serif;
        margin: 0 auto;
        margin-top: 10px;
        width: 500px;
        color: #F90;
        text-align: center;

    }

    header {
        height: 120px;
        background: url('http://www.geertjanhendriks.nl/codepen/form/golf.png') repeat-x bottom;
    }

    #form {
        max-width: 100%;
        background-color: #98d4f3;
        overflow: hidden;
        position: relative;

    }

    form {
        margin-top: -25px;
        margin: 0 auto;
        padding-top: -10px;
        color: rgb(47, 107, 137);
        position: relative;
    }

    label,
    input,
    textarea {
        display: block;
    }

    .titulo {
        color: #bla");
            WriteLiteral(@"ck;
        font-size: 30px;
        text-align: center;
        margin-bottom: 20px;
    }

    input,
    textarea {
        width: 500px;
        border: none;
        border-radius: 20px;
        outline: none;
        padding: 8px;
        font-family: 'Sniglet', cursive;
        font-size: 1em;
        color: #676767;
        transition: border 0.5s;
        -webkit-transition: border 0.5s;
        -moz-transition: border 0.5s;
        -o-transition: border 0.5s;
        border: solid 3px #98d4f3;
        -webkit-box-sizing: border-box;
        -moz-box-sizing: border-box;
        box-sizing: border-box;

    }

    input:focus,
    textarea:focus {
        border: solid 3px #77bde0;
    }

    textarea {
        height: 100px;
        resize: none;
        overflow: auto;
    }

    input[type=""submit""] {
        background-color: #F90;
        color: white;
        height: 50px;
        cursor: pointer;
        margin-top: 30px;
        font-size: 1.29em;
        font-family: 'Sniglet', cursive;
     ");
            WriteLiteral(@"   -webkit-transition: background-color 0.5s;
        -moz-transition: background-color 0.5s;
        -o-transition: background-color 0.5s;
        transition: background-color 0.5s;
    }

    input[type=""submit""]:hover {
        background-color: #e58f0e;

    }

    label {
        font-size: 1.5em;
        margin-top: 20px;
        padding-left: 20px;
    }

    .formgroup,
    .formgroup-active,
    .formgroup-error {
        background-repeat: no-repeat;
        background-position: right bottom;
        background-size: 10.5%;
        transition: background-image 0.7s;
        -webkit-transition: background-image 0.7s;
        -moz-transition: background-image 0.7s;
        -o-transition: background-image 0.7s;
        width: 566px;
        padding-top: 2px;
    }

    .formgroup {
        margin-top: -15px;
        background-image: url('http://www.geertjanhendriks.nl/codepen/form/pixel.gif');
    }

    .formgroup-active {
        background-image: url('http://www.geertjanhendriks.nl/codepen/form/oct");
            WriteLiteral(@"o.png');
    }

    .formgroup-error {
        background-image: url('http://www.geertjanhendriks.nl/codepen/form/octo-error.png');
        color: red;
    }

    .card{
        margin-bottom: 50px;
    }

    .button1{
        margin-left: 1000px;
    }
    .btn{
        margin-left: 50px;
    }
    </style>
    <header>
        <h1>Mascota Feliz</h1>
    </header>
    <div id=""form"">
        <div class=""row"">
            <div class=""col-2"">
                <label for=""name"">Buscar Visita</label>
            </div>
            <div class=""col-8 mt-4"">
              <input aria-label=""search"" type=""search"" placeholder=""Buscar Mascota""  class=""form-control"" >
            </div>
          </div>
          <div class=""row"">
            <div class=""col-lg-8 offset-lg-2 mt-4"">
                <!-- Tarjeta que contiene la tabla-->
                <div class=""card"">
                    <div class=""card-body text-center"">
                        <label class=""titulo"">VisitasPyP</label>
                        <table ");
            WriteLiteral(@"id=""Tabla"" class=""table table-info table-striped mt-4"">
                            <!--Cabecera de la tabla -->
                            <thead>
                              <tr>
                                <!--Nombre columnas-->
                                <th scope=""col"">Fecha Visita</th>
                                <th scope=""col"">Temperatura</th>
                                <th scope=""col"">Peso</th>
                                <th scope=""col"">Frecuencia Respiratoria</th>
                                <th scope=""col"">Frecuencia Cardiaca</th>
                                <th scope=""col"">Estado Animo</th>
                                <th scope=""col"">Recomendaciones</th>
                                </tr>
                            </thead>
");
#nullable restore
#line 195 "C:\Users\SAMSUNG\Desktop\Proyecto---MascotaFeliz--c--Christian_Calvache_M\MascotaFeliz.app.Frontend\Pages\VisitasPyP\ListaVisitasPyP.cshtml"
                             foreach(var visitaPyP in Model.listaVisitasPyP)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\n                                    <!--Nombre columnas-->\n                                    <td>");
#nullable restore
#line 200 "C:\Users\SAMSUNG\Desktop\Proyecto---MascotaFeliz--c--Christian_Calvache_M\MascotaFeliz.app.Frontend\Pages\VisitasPyP\ListaVisitasPyP.cshtml"
                                   Write(visitaPyP.FechaVisita);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 201 "C:\Users\SAMSUNG\Desktop\Proyecto---MascotaFeliz--c--Christian_Calvache_M\MascotaFeliz.app.Frontend\Pages\VisitasPyP\ListaVisitasPyP.cshtml"
                                   Write(visitaPyP.Temperatura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 202 "C:\Users\SAMSUNG\Desktop\Proyecto---MascotaFeliz--c--Christian_Calvache_M\MascotaFeliz.app.Frontend\Pages\VisitasPyP\ListaVisitasPyP.cshtml"
                                   Write(visitaPyP.Peso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 203 "C:\Users\SAMSUNG\Desktop\Proyecto---MascotaFeliz--c--Christian_Calvache_M\MascotaFeliz.app.Frontend\Pages\VisitasPyP\ListaVisitasPyP.cshtml"
                                   Write(visitaPyP.FrecuenciaRespiratoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 204 "C:\Users\SAMSUNG\Desktop\Proyecto---MascotaFeliz--c--Christian_Calvache_M\MascotaFeliz.app.Frontend\Pages\VisitasPyP\ListaVisitasPyP.cshtml"
                                   Write(visitaPyP.FrecuenciaCardiaca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 205 "C:\Users\SAMSUNG\Desktop\Proyecto---MascotaFeliz--c--Christian_Calvache_M\MascotaFeliz.app.Frontend\Pages\VisitasPyP\ListaVisitasPyP.cshtml"
                                   Write(visitaPyP.EstadoAnimo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 206 "C:\Users\SAMSUNG\Desktop\Proyecto---MascotaFeliz--c--Christian_Calvache_M\MascotaFeliz.app.Frontend\Pages\VisitasPyP\ListaVisitasPyP.cshtml"
                                   Write(visitaPyP.Recomendaciones);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "672c082bbdb21ed45b1d67425ab1a3f3bf448d9312286", async() => {
                WriteLiteral("\n                                            Detalles\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-visitaPyPId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 208 "C:\Users\SAMSUNG\Desktop\Proyecto---MascotaFeliz--c--Christian_Calvache_M\MascotaFeliz.app.Frontend\Pages\VisitasPyP\ListaVisitasPyP.cshtml"
                                                                                                                     WriteLiteral(visitaPyP.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["visitaPyPId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-visitaPyPId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["visitaPyPId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                    </td>\n                                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "672c082bbdb21ed45b1d67425ab1a3f3bf448d9314868", async() => {
                WriteLiteral("\n                                            Editar\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-visitaPyPId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 212 "C:\Users\SAMSUNG\Desktop\Proyecto---MascotaFeliz--c--Christian_Calvache_M\MascotaFeliz.app.Frontend\Pages\VisitasPyP\ListaVisitasPyP.cshtml"
                                                                                                                   WriteLiteral(visitaPyP.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["visitaPyPId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-visitaPyPId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["visitaPyPId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                    </td>\n                                </tr>\n");
#nullable restore
#line 217 "C:\Users\SAMSUNG\Desktop\Proyecto---MascotaFeliz--c--Christian_Calvache_M\MascotaFeliz.app.Frontend\Pages\VisitasPyP\ListaVisitasPyP.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                          </table>
                        <!--Boton primary que significa azul -->
                        <button class=""btn btn-info float-end"" name=""redirect"" class=""button1"" onClick=""redirect2()"">Nueva Visita</button>
                        <button class=""btn btn-info float-start"" name=""redirect"" class=""button2"" onClick=""redirect()"">Volver</button>
                    </div>
                </div>
            </div>
    
        </div>
    </div>
");
            WriteLiteral("    <script type=\"text/javascript\">\n        function redirect()\n        {\n        window.location.href=\"/Index\";\n        }\n        function redirect2()\n        {\n        window.location.href=\"/VisitasPyP/CrearVisitasPyP\";\n        }\n    </script>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MascotaFeliz.App.Frontend.Pages.ListaVisitasPyPModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.ListaVisitasPyPModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.ListaVisitasPyPModel>)PageContext?.ViewData;
        public MascotaFeliz.App.Frontend.Pages.ListaVisitasPyPModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
