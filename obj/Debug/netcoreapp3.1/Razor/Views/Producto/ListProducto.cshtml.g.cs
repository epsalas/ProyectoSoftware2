#pragma checksum "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\ListProducto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28bfdbd3ce50964139ef1e890586157b3b91dbf3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producto_ListProducto), @"mvc.1.0.view", @"/Views/Producto/ListProducto.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\_ViewImports.cshtml"
using FyJCel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\_ViewImports.cshtml"
using FyJCel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28bfdbd3ce50964139ef1e890586157b3b91dbf3", @"/Views/Producto/ListProducto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ba09d8f07e0801623da7733e814a171bdcd5c0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Producto_ListProducto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FyJCel.Models.Producto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductosSelect", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<!-- bootstrap Navbar  !-->
  <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"">
  <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
  <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js""></script>
  <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js""></script>
<!--
<h2>Lista Productos</h2>
!-->
<style>
* {
  box-sizing: border-box;
}

.zoom {
  padding: 50px;
  background-color: white;
  transition: transform .2s;
  width: 200px;
  height: 100px;
  margin: 0 auto;
}

.zoom:hover {
  -ms-transform: scale(1.5); /* IE 9 */
  -webkit-transform: scale(1.5); /* Safari 3-8 */
  transform: scale(1.5); 
}
</style>

<script language='JavaScript'>
    function Buscar(){
        var txt = document.getElementById(""txtBuscar"").value;

        if(txt == """" ){
            alert(""Por favor ingrese un texto para buscar"");
        }
        else{
            window.location.");
            WriteLiteral(@"href = ""/Producto/Buscar?texto="" + txt;
        }      
    }

     function agente()
        {
          window.open(""/images/chatbot5.html"", ""_blank"", ""toolbar=yes,scrollbars=yes,resizable=yes,top=500,left=500,width=400,height=400"");
        }

    function producto(){
        window.open(""http://localhost:52330/Views/Producto/productos.html"", ""ventana1"", ""toolbar=yes,scrollbars=yes,resizable=yes,top=500,left=500,width=400,height=400"");
    }
              
</script>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28bfdbd3ce50964139ef1e890586157b3b91dbf35464", async() => {
                WriteLiteral(@"
<table border=""1"" width=""1100"">
    <tr>
        <!-- <td width=""200"">Logo EASYMARKET</td> -->
        <td wisth=""900"">
            <nav class=""navbar navbar-expand-sm bg-dark navbar-dark"">
                <!--<form class=""form-inline"" action=""/action_page.php"">-->
                    <input width=""700"" name=""txtBuscar"" id=""txtBuscar"" class=""form-control mr-sm-2"" type=""text"" placeholder=""Search"">
                    <a href=""javascript:Buscar()""  class=""btn btn-success"">Search</a>&nbsp
                    <button type=""submit""  class=""btn btn-primary"" >Agregar</button>
                    <img src=""/images/chat.png"" class=""img-responsive"" alt=""Responsive image"" width=""75"" height=""40"" onclick=""javascript:agente()"" >
               <!-- </form>-->
            </nav>
        </td>
    </tr>
</table>

<br>

");
#nullable restore
#line 74 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\ListProducto.cshtml"
  
    if(ViewBag.mensajeGrabar != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"alert alert-primary alert-dismissible fade show\" role=\"alert\">\n        <strong>");
#nullable restore
#line 78 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\ListProducto.cshtml"
           Write(ViewBag.mensajeGrabar);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\n            <span aria-hidden=\"true\">&times;</span>\n        </button>\n        </div>\n");
#nullable restore
#line 83 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\ListProducto.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n<table class=\"table table-hover\">\n    <thead class=\"thead-dark\">\n        <tr>\n                <!-- <th scope=\"col\">\n                    #\n                </th> -->\n                <th scope=\"col\">\n                   Imagen del Producto <!--");
#nullable restore
#line 94 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\ListProducto.cshtml"
                                      Write(Html.DisplayNameFor(model => model.prod_imagen));

#line default
#line hidden
#nullable disable
                WriteLiteral("-->\n                </th>\n\n                <th scope=\"col\">\n                    Detalles <!--");
#nullable restore
#line 98 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\ListProducto.cshtml"
                            Write(Html.DisplayNameFor(model => model.prod_detalle));

#line default
#line hidden
#nullable disable
                WriteLiteral("-->\n                </th>\n                <th scope=\"col\">\n                    Precio <!--");
#nullable restore
#line 101 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\ListProducto.cshtml"
                          Write(Html.DisplayNameFor(model => model.prod_precio));

#line default
#line hidden
#nullable disable
                WriteLiteral("-->\n                </th>\n                <th scope=\"col\">Sel.</th>\n        </tr>\n    </thead>\n    <tbody>\n\n");
#nullable restore
#line 108 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\ListProducto.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
                WriteLiteral("        <tr>\n            <td class=\"zoom\">\n \t\t\t\t<img");
                BeginWriteAttribute("src", " src=\"", 3524, "\"", 3577, 1);
#nullable restore
#line 112 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\ListProducto.cshtml"
WriteAttributeValue("", 3530, Html.DisplayFor(modelItem => item.prod_imagen), 3530, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("  width=\"350\" height=\"200\">\n            </td>\n            <td>\n                <strong >\n                    <!-- <input type=\"\" name=\"");
#nullable restore
#line 116 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\ListProducto.cshtml"
                                         Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\" id=\"hdnNumeros\">-->\n                    <a href=\"javascript:producto()\" style=\"color: black;\">");
#nullable restore
#line 117 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\ListProducto.cshtml"
                                                                     Write(Html.DisplayFor(modelItem => item.prod_nombre));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </a>\n                    \n                    \n                </strong>\n                <p><br><textarea disabled cols=\"75\" rows=\"6\" style=\"resize: none; border-style: none;\">");
#nullable restore
#line 121 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\ListProducto.cshtml"
                                                                                                  Write(Html.DisplayFor(modelItem => item.prod_detalle));

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea> </p>\n            </td>\n            <td>\n                ");
#nullable restore
#line 124 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\ListProducto.cshtml"
           Write(Html.DisplayFor(modelItem => item.prod_precio));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </td>\n            \n            <td width=\"50\"><input type=\"checkbox\" name=\"productids\"");
                BeginWriteAttribute("value", " value=\"", 4333, "\"", 4349, 1);
#nullable restore
#line 127 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\ListProducto.cshtml"
WriteAttributeValue("", 4341, item.ID, 4341, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> \n            </td>\n                    \n        </tr>\n");
#nullable restore
#line 131 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\ListProducto.cshtml"
}        

#line default
#line hidden
#nullable disable
                WriteLiteral("    </tbody>\n</table>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 135 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\ListProducto.cshtml"
 if(ViewBag.Message!=null){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <script type=\"text/javascript\">\n                window.onload = function(){\n                    alert(\"");
#nullable restore
#line 138 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\ListProducto.cshtml"
                      Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\n                };\n            </script>\n");
#nullable restore
#line 141 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\ListProducto.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FyJCel.Models.Producto>> Html { get; private set; }
    }
}
#pragma warning restore 1591