#pragma checksum "F:\USMP\2021-II\PROGRAMACION 1\PROYECTO FINAAAL\Hotel\hostal\Views\Pago\Documento.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6eb7fb01d556d570986d43f9285c2167208fd6d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pago_Documento), @"mvc.1.0.view", @"/Views/Pago/Documento.cshtml")]
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
#line 1 "F:\USMP\2021-II\PROGRAMACION 1\PROYECTO FINAAAL\Hotel\hostal\Views\_ViewImports.cshtml"
using hostal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\USMP\2021-II\PROGRAMACION 1\PROYECTO FINAAAL\Hotel\hostal\Views\_ViewImports.cshtml"
using hostal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6eb7fb01d556d570986d43f9285c2167208fd6d5", @"/Views/Pago/Documento.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff3a16656f7154a59dda0c221bde40a38494bc10", @"/Views/_ViewImports.cshtml")]
    public class Views_Pago_Documento : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<hostal.Models.Proforma>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/nombre.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\USMP\2021-II\PROGRAMACION 1\PROYECTO FINAAAL\Hotel\hostal\Views\Pago\Documento.cshtml"
  
    ViewData["Title"] = "Documento";
    Decimal total = 0;        
    var contar = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\USMP\2021-II\PROGRAMACION 1\PROYECTO FINAAAL\Hotel\hostal\Views\Pago\Documento.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6eb7fb01d556d570986d43f9285c2167208fd6d55731", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>DOCUMENTO</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6eb7fb01d556d570986d43f9285c2167208fd6d56090", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6eb7fb01d556d570986d43f9285c2167208fd6d57268", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6eb7fb01d556d570986d43f9285c2167208fd6d59150", async() => {
                WriteLiteral("\r\n    \r\n\r\n    <center>\r\n        <div class=\"col-sm-4\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6eb7fb01d556d570986d43f9285c2167208fd6d59484", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            <br>
            <br>
        </div>        
   </center>

    <div class=""col-sm-8 text-center"">
            <h1>COMPROBANTE DE PAGO</h1>
            <br>
            <br>
        </div>

<h5> Fecha: 
<script>
    var f = new Date();
    document.write(f.getDate() + ""/"" + (f.getMonth() + 1) + ""/"" + f.getFullYear());
</script>
 </h5>


    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">
                ");
#nullable restore
#line 50 "F:\USMP\2021-II\PROGRAMACION 1\PROYECTO FINAAAL\Hotel\hostal\Views\Pago\Documento.cshtml"
           Write(Html.DisplayNameFor(model => model.Producto.Imagen));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 53 "F:\USMP\2021-II\PROGRAMACION 1\PROYECTO FINAAAL\Hotel\hostal\Views\Pago\Documento.cshtml"
           Write(Html.DisplayNameFor(model => model.Producto.Nombre));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 56 "F:\USMP\2021-II\PROGRAMACION 1\PROYECTO FINAAAL\Hotel\hostal\Views\Pago\Documento.cshtml"
           Write(Html.DisplayNameFor(model => model.Precio));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 59 "F:\USMP\2021-II\PROGRAMACION 1\PROYECTO FINAAAL\Hotel\hostal\Views\Pago\Documento.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>  \r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 64 "F:\USMP\2021-II\PROGRAMACION 1\PROYECTO FINAAAL\Hotel\hostal\Views\Pago\Documento.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("               <tr>\r\n           <td>\r\n                ");
#nullable restore
#line 68 "F:\USMP\2021-II\PROGRAMACION 1\PROYECTO FINAAAL\Hotel\hostal\Views\Pago\Documento.cshtml"
           Write(Html.DisplayFor(modelItem => item.Producto.Imagen));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                \r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 72 "F:\USMP\2021-II\PROGRAMACION 1\PROYECTO FINAAAL\Hotel\hostal\Views\Pago\Documento.cshtml"
           Write(Html.DisplayFor(modelItem => item.Producto.Nombre));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 75 "F:\USMP\2021-II\PROGRAMACION 1\PROYECTO FINAAAL\Hotel\hostal\Views\Pago\Documento.cshtml"
           Write(Html.DisplayFor(modelItem => item.Precio));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 78 "F:\USMP\2021-II\PROGRAMACION 1\PROYECTO FINAAAL\Hotel\hostal\Views\Pago\Documento.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td> \r\n            </tr>\r\n");
#nullable restore
#line 81 "F:\USMP\2021-II\PROGRAMACION 1\PROYECTO FINAAAL\Hotel\hostal\Views\Pago\Documento.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n   \r\n   \r\n");
#nullable restore
#line 86 "F:\USMP\2021-II\PROGRAMACION 1\PROYECTO FINAAAL\Hotel\hostal\Views\Pago\Documento.cshtml"
       foreach (var item in Model){

#line default
#line hidden
#nullable disable
                WriteLiteral("         <tr>\r\n");
#nullable restore
#line 88 "F:\USMP\2021-II\PROGRAMACION 1\PROYECTO FINAAAL\Hotel\hostal\Views\Pago\Documento.cshtml"
              
               total = total + item.Precio * item.Quantity;
                
               contar++;
            

#line default
#line hidden
#nullable disable
                WriteLiteral("         </tr>\r\n");
#nullable restore
#line 94 "F:\USMP\2021-II\PROGRAMACION 1\PROYECTO FINAAAL\Hotel\hostal\Views\Pago\Documento.cshtml"
      }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <div class=\"container\">\r\n         <p align=\"center\" style=\"font-size: 200%;\">Total S/. ");
#nullable restore
#line 97 "F:\USMP\2021-II\PROGRAMACION 1\PROYECTO FINAAAL\Hotel\hostal\Views\Pago\Documento.cshtml"
                                                         Write(total);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    </section>\r\n\r\n\r\n\r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<hostal.Models.Proforma>> Html { get; private set; }
    }
}
#pragma warning restore 1591