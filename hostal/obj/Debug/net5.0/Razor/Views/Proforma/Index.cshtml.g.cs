#pragma checksum "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1af2e921d830bb9774fc6a9c8559d43e1a05f89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Proforma_Index), @"mvc.1.0.view", @"/Views/Proforma/Index.cshtml")]
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
#line 1 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\_ViewImports.cshtml"
using hostal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\_ViewImports.cshtml"
using hostal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1af2e921d830bb9774fc6a9c8559d43e1a05f89", @"/Views/Proforma/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff3a16656f7154a59dda0c221bde40a38494bc10", @"/Views/_ViewImports.cshtml")]
    public class Views_Proforma_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<hostal.Models.Proformass>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edits", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pago", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
  
    ViewData["Title"] = "Carrito";
    IEnumerable<hostal.Models.Proformass> listProformass = new List<Proformass>();   

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1af2e921d830bb9774fc6a9c8559d43e1a05f896091", async() => {
                WriteLiteral(@"
<!--Inicio Banner-->
<div class=""hero-wrap hero-wrap-2"" style=""background-image: url('../images/banner1.jpg'); background-attachment:fixed; height: 400px;"">
      <div class=""overlay"" style=""height: 400px;"" ></div>
        <div class=""container"">
          <div class=""row no-gutters slider-text align-items-center justify-content-center"" data-scrollax-parent=""true"" style=""height: 400px;"">
           <div class=""col-md-8 ftco-animate text-center"">          
             <h1 class=""mb-3 bread"">Reservas</h1>
            </div>
          </div>
       </div>
</div>    
<!--Fin Banner-->
<br>
<br>
<br>


<!----------------------------------PROFORMA HABITACIONES/PRODUCTOS----------------------------------->
<table class=""table table-hover"">
    <thead class=""thead-dark"">
        <tr>
            <th scope=""col"">
                ");
#nullable restore
#line 30 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
           Write(Html.DisplayNameFor(model => listProformass.FirstOrDefault().Proforma.Producto.Imagen));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
           Write(Html.DisplayNameFor(model => listProformass.FirstOrDefault().Proforma.Producto.Nombre));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
           Write(Html.DisplayNameFor(model => listProformass.FirstOrDefault().Proforma.Precio));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 39 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
           Write(Html.DisplayNameFor(model => listProformass.FirstOrDefault().Proforma.Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n             <th>\r\n                 Subtotal\r\n             </th>     \r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 48 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
 foreach (var item in Model) {

    if(item.Proforma.Producto.Id==0){      


    }else{

#line default
#line hidden
#nullable disable
                WriteLiteral("        <tr>\r\n            <td>\r\n                <img class=\"img-responsive\" width=\"230\" height=\"200\"");
                BeginWriteAttribute("src", "\r\n                    src=\"", 1890, "\"", 1955, 2);
                WriteAttributeValue("", 1917, "/images/", 1917, 8, true);
#nullable restore
#line 57 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
WriteAttributeValue("", 1925, item.Proforma.Producto.Imagen, 1925, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1956, "\"", 1992, 1);
#nullable restore
#line 57 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
WriteAttributeValue("", 1962, item.Proforma.Producto.Imagen, 1962, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("  />\r\n                \r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Proforma.Producto.Nombre));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Proforma.Precio));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Proforma.Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>  \r\n            <td>\r\n");
#nullable restore
#line 70 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
                  
                    decimal subtotal = 0;
                     var contarsub = 0;
                    subtotal = item.Proforma.Precio * item.Proforma.Quantity;
                    contarsub++;
                

#line default
#line hidden
#nullable disable
                WriteLiteral("                <p>S/. ");
#nullable restore
#line 76 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
                  Write(subtotal);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            </td>          \r\n            <td>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1af2e921d830bb9774fc6a9c8559d43e1a05f8911784", async() => {
                    WriteLiteral("Editar");
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
#line 79 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1af2e921d830bb9774fc6a9c8559d43e1a05f8914127", async() => {
                    WriteLiteral("Eliminar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 83 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
        }
}

#line default
#line hidden
#nullable disable
                WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
#nullable restore
#line 88 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
      
        decimal totalp = 0;
        var contarp = 0;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
     foreach (var item in Model)
    {           
        totalp = totalp + item.Proforma.Precio * item.Proforma.Quantity;
        contarp++;
           
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n      <p align=\"center\" style=\"font-size: 200%;\">Total S/. ");
#nullable restore
#line 99 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
                                                      Write(totalp);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n<!---------------------------------------PROFORMA SERVICIOS---------------------------------------->\r\n\r\n    <table class=\"table table-hover\">\r\n    <thead class=\"thead-dark\">\r\n        <tr>\r\n            <th scope=\"col\">\r\n                ");
#nullable restore
#line 107 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
           Write(Html.DisplayNameFor(model => listProformass.FirstOrDefault().ProformaServi.Servicio.Imagen));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 110 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
           Write(Html.DisplayNameFor(model => listProformass.FirstOrDefault().ProformaServi.Servicio.Nombre));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 113 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
           Write(Html.DisplayNameFor(model => listProformass.FirstOrDefault().ProformaServi.Precio));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 116 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
           Write(Html.DisplayNameFor(model => listProformass.FirstOrDefault().ProformaServi.Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th> \r\n            <th>\r\n                 Subtotal\r\n             </th>              \r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 125 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
 foreach (var item in Model) {

    if(item.ProformaServi.Servicio.Id==0){      


    }else{

#line default
#line hidden
#nullable disable
                WriteLiteral("        <tr>\r\n            <td>\r\n                <img class=\"img-responsive\" width=\"230\" height=\"200\"");
                BeginWriteAttribute("src", "\r\n                    src=\"", 4423, "\"", 4493, 2);
                WriteAttributeValue("", 4450, "/images/", 4450, 8, true);
#nullable restore
#line 134 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
WriteAttributeValue("", 4458, item.ProformaServi.Servicio.Imagen, 4458, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 4494, "\"", 4535, 1);
#nullable restore
#line 134 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
WriteAttributeValue("", 4500, item.ProformaServi.Servicio.Imagen, 4500, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("  />\r\n                \r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 138 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProformaServi.Servicio.Nombre));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 141 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProformaServi.Precio));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 144 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProformaServi.Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>       \r\n            <td>\r\n");
#nullable restore
#line 147 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
                  
                    decimal subtotals = 0;
                     var contarsubs = 0;
                    subtotals = item.ProformaServi.Precio * item.ProformaServi.Quantity;
                    contarsubs++;
                

#line default
#line hidden
#nullable disable
                WriteLiteral("                <p>S/. ");
#nullable restore
#line 153 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
                  Write(subtotals);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            </td>      \r\n            <td>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1af2e921d830bb9774fc6a9c8559d43e1a05f8922546", async() => {
                    WriteLiteral("Editar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 156 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
                                        WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1af2e921d830bb9774fc6a9c8559d43e1a05f8924891", async() => {
                    WriteLiteral("Eliminar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 157 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 160 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
    }
}

#line default
#line hidden
#nullable disable
                WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
#nullable restore
#line 165 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
  
        decimal totals = 0;
        var contars = 0;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 169 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
     foreach (var item in Model)
    {           
        totals = totals + item.ProformaServi.Precio * item.ProformaServi.Quantity;
        contars++;
           
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n      <p align=\"center\" style=\"font-size: 200%;\">Total S/. ");
#nullable restore
#line 176 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
                                                      Write(totals);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n<!------------------------------------------TOTAL A PAGAR---------------------------------->\r\n\r\n");
#nullable restore
#line 180 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
  
        decimal totaltotal = 0;
        var contartotal = 0;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 184 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
     foreach (var item in Model)
    {           
        totaltotal = totalp + totals;
        contartotal++;
           
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <p align=\"center\" style=\"font-size: 400%;\">TOTAL A PAGAR S/. ");
#nullable restore
#line 191 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
                                                            Write(totaltotal);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1af2e921d830bb9774fc6a9c8559d43e1a05f8929437", async() => {
                    WriteLiteral("Pagar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-monto", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 193 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Proforma\Index.cshtml"
                                                                                     WriteLiteral(totaltotal);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["monto"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-monto", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["monto"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<hostal.Models.Proformass>> Html { get; private set; }
    }
}
#pragma warning restore 1591
