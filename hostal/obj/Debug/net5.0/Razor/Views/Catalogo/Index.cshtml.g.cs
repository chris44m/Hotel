#pragma checksum "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Catalogo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4ba0571bf7a8fd146d0049c88d505aa8d4f5ec1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalogo_Index), @"mvc.1.0.view", @"/Views/Catalogo/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4ba0571bf7a8fd146d0049c88d505aa8d4f5ec1", @"/Views/Catalogo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff3a16656f7154a59dda0c221bde40a38494bc10", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalogo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<hostal.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Catalogo\Index.cshtml"
  
    ViewData["Title"] = "Catalogo";  

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
             <h1 class=""mb-3 bread"">Reservas</h1>
            </div>
          </div>
       </div>
</div>    
<!--Fin Banner-->
<br>
<br>
<br>

  <div class=""container"">
    <h1>");
#nullable restore
#line 24 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Catalogo\Index.cshtml"
   Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <div class=\"row\">\r\n      <div class=\"col\">\r\n        <div id=\"products\" class=\"mb-3\">\r\n          <div class=\"row\">\r\n");
#nullable restore
#line 29 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Catalogo\Index.cshtml"
             foreach (var item in Model) {
              
            if(item.Id==0){  

            }else{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-sm-4"">
              <div class=""card text-white bg-dark mb-3"" style=""max-width: 18rem;"">
                <div class=""card-body"">
                  <div class=""card-img-actions"">
                    <img class=""img-responsive"" width=""230"" height=""200""");
            BeginWriteAttribute("src", "\r\n                       src=\"", 1291, "\"", 1341, 2);
            WriteAttributeValue("", 1321, "/images/", 1321, 8, true);
#nullable restore
#line 39 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Catalogo\Index.cshtml"
WriteAttributeValue("", 1329, item.Imagen, 1329, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1342, "\"", 1360, 1);
#nullable restore
#line 39 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Catalogo\Index.cshtml"
WriteAttributeValue("", 1348, item.Imagen, 1348, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  />\r\n                  </div>\r\n                </div>\r\n                <div class=\"card-body\">\r\n                  <h5 class=\"card-title\">");
#nullable restore
#line 43 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Catalogo\Index.cshtml"
                                    Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                  <p class=\"card-text\">");
#nullable restore
#line 44 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Catalogo\Index.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4ba0571bf7a8fd146d0049c88d505aa8d4f5ec17449", async() => {
                WriteLiteral("Reservar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Catalogo\Index.cshtml"
                                                                WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4ba0571bf7a8fd146d0049c88d505aa8d4f5ec19720", async() => {
                WriteLiteral("Detalles");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Catalogo\Index.cshtml"
                                                                    WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                </div>\r\n              </div>\r\n            </div>\r\n");
#nullable restore
#line 50 "D:\PROGRAMACION 1\Proyecto final\Hotel\hostal\Views\Catalogo\Index.cshtml"
            }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("         </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </div>");
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
