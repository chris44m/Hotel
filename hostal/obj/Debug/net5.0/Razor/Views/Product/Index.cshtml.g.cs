#pragma checksum "F:\USMP\2021-II\PROGRAMACION 1\AHORA SII FINALLLLLLLLLL\Hotel\hostal\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c05e7d0236b01e74a9f5b8492c59d3b9cd704b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "F:\USMP\2021-II\PROGRAMACION 1\AHORA SII FINALLLLLLLLLL\Hotel\hostal\Views\_ViewImports.cshtml"
using hostal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\USMP\2021-II\PROGRAMACION 1\AHORA SII FINALLLLLLLLLL\Hotel\hostal\Views\_ViewImports.cshtml"
using hostal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c05e7d0236b01e74a9f5b8492c59d3b9cd704b0", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff3a16656f7154a59dda0c221bde40a38494bc10", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<hostal.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\USMP\2021-II\PROGRAMACION 1\AHORA SII FINALLLLLLLLLL\Hotel\hostal\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--Inicio Banner-->
<div class=""hero-wrap hero-wrap-2"" style=""background-image: url('../images/banner1.jpg'); background-attachment:fixed; height: 400px;"">
      <div class=""overlay"" style=""height: 400px;"" ></div>
        <div class=""container"">
          <div class=""row no-gutters slider-text align-items-center justify-content-center"" data-scrollax-parent=""true"" style=""height: 400px;"">
           <div class=""col-md-8 ftco-animate text-center"">          
             <h1 class=""mb-3 bread"">Mostrar Habitaciones</h1>
            </div>
          </div>
       </div>
</div>    
<!--Fin Banner-->
<br>
<br>
<br>
<p>
    <!--<a asp-action=""Create"">Crear Nuevo</a>-->
</p>
<table class=""table table-hover"">
    <thead class=""thead-dark"">
        <tr>
            <th>
                ");
#nullable restore
#line 29 "F:\USMP\2021-II\PROGRAMACION 1\AHORA SII FINALLLLLLLLLL\Hotel\hostal\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "F:\USMP\2021-II\PROGRAMACION 1\AHORA SII FINALLLLLLLLLL\Hotel\hostal\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "F:\USMP\2021-II\PROGRAMACION 1\AHORA SII FINALLLLLLLLLL\Hotel\hostal\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "F:\USMP\2021-II\PROGRAMACION 1\AHORA SII FINALLLLLLLLLL\Hotel\hostal\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Imagen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "F:\USMP\2021-II\PROGRAMACION 1\AHORA SII FINALLLLLLLLLL\Hotel\hostal\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "F:\USMP\2021-II\PROGRAMACION 1\AHORA SII FINALLLLLLLLLL\Hotel\hostal\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 50 "F:\USMP\2021-II\PROGRAMACION 1\AHORA SII FINALLLLLLLLLL\Hotel\hostal\Views\Product\Index.cshtml"
 foreach (var item in Model) {

    if(item.Id==0){      


    }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "F:\USMP\2021-II\PROGRAMACION 1\AHORA SII FINALLLLLLLLLL\Hotel\hostal\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "F:\USMP\2021-II\PROGRAMACION 1\AHORA SII FINALLLLLLLLLL\Hotel\hostal\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "F:\USMP\2021-II\PROGRAMACION 1\AHORA SII FINALLLLLLLLLL\Hotel\hostal\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <img class=\"img-responsive\" width=\"130\" height=\"100\"");
            BeginWriteAttribute("src", "\r\n                    src=\"", 1991, "\"", 2038, 2);
            WriteAttributeValue("", 2018, "/images/", 2018, 8, true);
#nullable restore
#line 68 "F:\USMP\2021-II\PROGRAMACION 1\AHORA SII FINALLLLLLLLLL\Hotel\hostal\Views\Product\Index.cshtml"
WriteAttributeValue("", 2026, item.Imagen, 2026, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2039, "\"", 2057, 1);
#nullable restore
#line 68 "F:\USMP\2021-II\PROGRAMACION 1\AHORA SII FINALLLLLLLLLL\Hotel\hostal\Views\Product\Index.cshtml"
WriteAttributeValue("", 2045, item.Imagen, 2045, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  />\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 71 "F:\USMP\2021-II\PROGRAMACION 1\AHORA SII FINALLLLLLLLLL\Hotel\hostal\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 74 "F:\USMP\2021-II\PROGRAMACION 1\AHORA SII FINALLLLLLLLLL\Hotel\hostal\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c05e7d0236b01e74a9f5b8492c59d3b9cd704b011176", async() => {
                WriteLiteral("Detalles");
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
#line 77 "F:\USMP\2021-II\PROGRAMACION 1\AHORA SII FINALLLLLLLLLL\Hotel\hostal\Views\Product\Index.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c05e7d0236b01e74a9f5b8492c59d3b9cd704b013446", async() => {
                WriteLiteral("Editar");
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
#line 78 "F:\USMP\2021-II\PROGRAMACION 1\AHORA SII FINALLLLLLLLLL\Hotel\hostal\Views\Product\Index.cshtml"
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
            WriteLiteral("                \r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c05e7d0236b01e74a9f5b8492c59d3b9cd704b015727", async() => {
                WriteLiteral("Eliminar");
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
#line 79 "F:\USMP\2021-II\PROGRAMACION 1\AHORA SII FINALLLLLLLLLL\Hotel\hostal\Views\Product\Index.cshtml"
                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 82 "F:\USMP\2021-II\PROGRAMACION 1\AHORA SII FINALLLLLLLLLL\Hotel\hostal\Views\Product\Index.cshtml"
}
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<hostal.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
