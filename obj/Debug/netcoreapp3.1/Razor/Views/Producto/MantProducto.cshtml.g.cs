#pragma checksum "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\MantProducto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7cf8ac0736ccdf3fcbd100ad6540e67d9561514"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producto_MantProducto), @"mvc.1.0.view", @"/Views/Producto/MantProducto.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7cf8ac0736ccdf3fcbd100ad6540e67d9561514", @"/Views/Producto/MantProducto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ba09d8f07e0801623da7733e814a171bdcd5c0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Producto_MantProducto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FyJCel.Models.Producto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditProducto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DelProd", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<!-- bootstrap Navbar  !-->
  <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"">
  <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
  <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js""></script>
  <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js""></script>
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

<h2>Mantenimiento de Productos</h2>


<table class=""table table-hover"">
    <thead class=""thead-dark"">
        <tr>
            <th scope=""col"">
               
            </th>
            <th scope=""col"">
                Imagen del Producto <!--");
#nullable restore
#line 39 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\MantProducto.cshtml"
                                   Write(Html.DisplayNameFor(model => model.prod_imagen));

#line default
#line hidden
#nullable disable
            WriteLiteral("-->\r\n            </th>\r\n\r\n            <th scope=\"col\">\r\n                Detalles <!--");
#nullable restore
#line 43 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\MantProducto.cshtml"
                        Write(Html.DisplayNameFor(model => model.prod_detalle));

#line default
#line hidden
#nullable disable
            WriteLiteral("-->\r\n            </th>\r\n            <th scope=\"col\">\r\n                Precio <!--");
#nullable restore
#line 46 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\MantProducto.cshtml"
                      Write(Html.DisplayNameFor(model => model.prod_precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("-->\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n\r\n");
#nullable restore
#line 52 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\MantProducto.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th scope=\"row\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7cf8ac0736ccdf3fcbd100ad6540e67d95615146235", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\MantProducto.cshtml"
                                               WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7cf8ac0736ccdf3fcbd100ad6540e67d95615148422", async() => {
                WriteLiteral("Del");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\MantProducto.cshtml"
                                          WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </th>\r\n            <td class=\"zoom\">\r\n \t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 1733, "\"", 1786, 1);
#nullable restore
#line 60 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\MantProducto.cshtml"
WriteAttributeValue("", 1739, Html.DisplayFor(modelItem => item.prod_imagen), 1739, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  width=\"350\" height=\"200\">\r\n            </td>\r\n            <td>\r\n                <strong>\r\n                    ");
#nullable restore
#line 64 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\MantProducto.cshtml"
               Write(Html.DisplayFor(modelItem => item.prod_nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </strong>\r\n                <p>\r\n                    <br><textarea disabled cols=\"75\" rows=\"6\" style=\"resize: none; border-style: none;\">");
#nullable restore
#line 67 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\MantProducto.cshtml"
                                                                                                   Write(Html.DisplayFor(modelItem => item.prod_detalle));

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n                </p>\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 71 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\MantProducto.cshtml"
           Write(Html.DisplayFor(modelItem => item.prod_precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>                                 \r\n        </tr>\r\n");
#nullable restore
#line 74 "C:\Users\Core i7\Desktop\Nueva carpeta (3)\Proyecto\FyJCel\Views\Producto\MantProducto.cshtml"
} 

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n    </tbody>\r\n</table>");
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