#pragma checksum "C:\Users\001S\Desktop\crud_mvc_xml\crud_mvc_xml\Views\Inventario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50a8b280ad0a5794aae5cafc42e9d66119cdc3a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inventario_Index), @"mvc.1.0.view", @"/Views/Inventario/Index.cshtml")]
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
#line 1 "C:\Users\001S\Desktop\crud_mvc_xml\crud_mvc_xml\Views\_ViewImports.cshtml"
using crud_mvc_xml;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\001S\Desktop\crud_mvc_xml\crud_mvc_xml\Views\_ViewImports.cshtml"
using crud_mvc_xml.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50a8b280ad0a5794aae5cafc42e9d66119cdc3a9", @"/Views/Inventario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d71f4423a2b081edc5967452bb61b680c9064135", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Inventario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<crud_mvc_xml.Models.Inventario>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\001S\Desktop\crud_mvc_xml\crud_mvc_xml\Views\Inventario\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div>\r\n    <h1>\r\n        ");
#nullable restore
#line 11 "C:\Users\001S\Desktop\crud_mvc_xml\crud_mvc_xml\Views\Inventario\Index.cshtml"
   Write(Html.ActionLink("Add Data", "AddEditProject"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </h1>

    <table cellpadding=""10"">
        <tr>
            <th>Nombre</th>
            <th>Proveedor</th>
            <th>Cant Disp</th>
            <th>Precio Cost</th>
            <th>Precio Venta</th>
            <th>Punto Reorden</th>
            <th>Manage</th>
        </tr>
");
#nullable restore
#line 24 "C:\Users\001S\Desktop\crud_mvc_xml\crud_mvc_xml\Views\Inventario\Index.cshtml"
          
            
            foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr style=\"text-align:center\">\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\001S\Desktop\crud_mvc_xml\crud_mvc_xml\Views\Inventario\Index.cshtml"
                   Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\001S\Desktop\crud_mvc_xml\crud_mvc_xml\Views\Inventario\Index.cshtml"
                   Write(item.ProveedorArticulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\001S\Desktop\crud_mvc_xml\crud_mvc_xml\Views\Inventario\Index.cshtml"
                   Write(item.CantidadDisponible);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\001S\Desktop\crud_mvc_xml\crud_mvc_xml\Views\Inventario\Index.cshtml"
                   Write(item.PrecioCosto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\001S\Desktop\crud_mvc_xml\crud_mvc_xml\Views\Inventario\Index.cshtml"
                   Write(item.PrecioVenta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "C:\Users\001S\Desktop\crud_mvc_xml\crud_mvc_xml\Views\Inventario\Index.cshtml"
                   Write(item.PuntoReorden);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "C:\Users\001S\Desktop\crud_mvc_xml\crud_mvc_xml\Views\Inventario\Index.cshtml"
                   Write(Html.ActionLink("Edit", "AddEditProject", new { id = @item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 35 "C:\Users\001S\Desktop\crud_mvc_xml\crud_mvc_xml\Views\Inventario\Index.cshtml"
                                                                                       Write(Html.ActionLink("Delete", "Delete", new { id = @item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 37 "C:\Users\001S\Desktop\crud_mvc_xml\crud_mvc_xml\Views\Inventario\Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<crud_mvc_xml.Models.Inventario>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
