#pragma checksum "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\PagesMascota\ListaMascotas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "487e8101bb9f976c244dd86fcd4c832634abc709"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.App.Frontend.Pages.PagesMascota.Pages_PagesMascota_ListaMascotas), @"mvc.1.0.razor-page", @"/Pages/PagesMascota/ListaMascotas.cshtml")]
namespace MascotaFeliz.App.Frontend.Pages.PagesMascota
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
#line 1 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\_ViewImports.cshtml"
using MascotaFeliz.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"487e8101bb9f976c244dd86fcd4c832634abc709", @"/Pages/PagesMascota/ListaMascotas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cf052204a3bb4119b871dc96742e016457a0b55", @"/Pages/_ViewImports.cshtml")]
    public class Pages_PagesMascota_ListaMascotas : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Estado"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/PagesMascota/DetallesMascota", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/PagesMascota/CreateMascota", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\PagesMascota\ListaMascotas.cshtml"
  
    ViewData["Title"] = "Home page";
    Layout=null;
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Document</title>
    <link rel=""stylesheet"" href=""/css/Estilo.css"">
    <link rel=""preconnect"" href=""https://fonts.googleapis.com/%22%3E"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com/"" crossorigin>
    <link href=""https://fonts.googleapis.com/css2?family=Silkscreen&display=swap"" rel=""stylesheet""


    
  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "487e8101bb9f976c244dd86fcd4c832634abc7094929", async() => {
                WriteLiteral("\r\n\r\n\r\n    <header>\r\n        <div class=\"Encabezado_superior\">\r\n            \r\n            <div class=\"Logo\">\r\n                <img id=\"Logo\" src=\"/Imagenes/perrogato.png\"");
                BeginWriteAttribute("alt", " alt=\"", 813, "\"", 819, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                <br>\r\n                <h1 class=\"titulo\">Bienvenidos</h1>\r\n                <h1 class=\"titulo\">Mascota Feliz</h1>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 971, "\"", 978, 0);
                EndWriteAttribute();
                WriteLiteral("><img  id=\"logopb\" src=\"/Imagenes/Logo pb.png\"");
                BeginWriteAttribute("alt", " alt=\"", 1025, "\"", 1031, 0);
                EndWriteAttribute();
                WriteLiteral(@"  ></a>
               

            </div>





        </div>


        <div class=""Encabezado_Barramenu"">
            <div class=""menu"">
                <nav>
                    <ul>
                        <li  ><a href=""/Index"">Inicio</a> </li>
                        <li><a");
                BeginWriteAttribute("href", " href=\"", 1330, "\"", 1337, 0);
                EndWriteAttribute();
                WriteLiteral(@">Registrar</a>
                            <ul>
                                <li><a href=""/PagesMascota/CreateMascota"">Registrar Mascota</a></li>
                                <li><a href=""/PagesDueno/CreateDueno"">Registrar Dueño</a></li>
                                <li><a href=""/PagesVeterinario/CreateVeterinario"">Registrar Veterinario</a></li>
                            </ul>
                        </li>
                        <li><a");
                BeginWriteAttribute("href", " href=\"", 1796, "\"", 1803, 0);
                EndWriteAttribute();
                WriteLiteral(@">Consultar</a>
                            <ul>
                                <li><a href=""/Front/Consulta.html"">Buscar Mascota</a></li>
                                <li><a href=""/PagesMascota/ListaMascotas"">Mostrar Mascotas</a></li>
                            </ul>
                        </li>

                        <li><a");
                BeginWriteAttribute("href", " href=\"", 2145, "\"", 2152, 0);
                EndWriteAttribute();
                WriteLiteral(@">Sobre Nosotros</a></li>
                    </ul>
                </nav>


            </div>


        </div>
    </header>

    <h1 id=""listadodemascotas"">Listado de mascotas</h1>






 
    <div class=""cajat"">
        <table class=""tabla"">

            <tr>
          
              <th>ID</th>
          
              <th>nombre</th>
          
              <th>Especie</th>

              <th>Raza</th>

              <th>Color</th>

              

              <th>estado</th>
              <th>update</th>

          
            </tr>

            
");
#nullable restore
#line 104 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\PagesMascota\ListaMascotas.cshtml"
             foreach (var Mascota in Model.ListaMascota)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 107 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\PagesMascota\ListaMascotas.cshtml"
                   Write(Mascota.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 108 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\PagesMascota\ListaMascotas.cshtml"
                   Write(Mascota.Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 109 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\PagesMascota\ListaMascotas.cshtml"
                   Write(Mascota.Especie);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 110 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\PagesMascota\ListaMascotas.cshtml"
                   Write(Mascota.Raza);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 111 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\PagesMascota\ListaMascotas.cshtml"
                   Write(Mascota.Color);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    \r\n                    <td >");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "487e8101bb9f976c244dd86fcd4c832634abc70910012", async() => {
                    WriteLiteral("Detalles");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-IdMascota", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 113 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\PagesMascota\ListaMascotas.cshtml"
                                                                                            WriteLiteral(Mascota.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["IdMascota"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-IdMascota", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["IdMascota"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</td>\r\n                    <td >");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "487e8101bb9f976c244dd86fcd4c832634abc70912475", async() => {
                    WriteLiteral("update");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-IdMascota", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 114 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\PagesMascota\ListaMascotas.cshtml"
                                                                                         WriteLiteral(Mascota.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["IdMascota"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-IdMascota", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["IdMascota"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</td>\r\n\r\n\r\n                </tr>\r\n");
#nullable restore
#line 118 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\PagesMascota\ListaMascotas.cshtml"
                
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"          
            
            
          
             
            
            
            
          
      
            
           
            
            
              
          
          </table>
    </div>

   

    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MascotaFeliz.App.Frontend.Pages.ListaMascotasModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.ListaMascotasModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.ListaMascotasModel>)PageContext?.ViewData;
        public MascotaFeliz.App.Frontend.Pages.ListaMascotasModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
