#pragma checksum "C:\Users\Diuel\Desktop\FPFTech\financeiro\financeiro.API\Views\Categorias\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0df6cd88835ee95449bf6ebd176d9f399c929b76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categorias_Create), @"mvc.1.0.view", @"/Views/Categorias/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0df6cd88835ee95449bf6ebd176d9f399c929b76", @"/Views/Categorias/Create.cshtml")]
    public class Views_Categorias_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<financeiro.DLL.Models.Categoria>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Diuel\Desktop\FPFTech\financeiro\financeiro.API\Views\Categorias\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Categoria</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Nome"" class=""control-label""></label>
                <input asp-for=""Nome"" class=""form-control"" />
                <span asp-validation-for=""Nome"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Icone"" class=""control-label""></label>
                <input asp-for=""Icone"" class=""form-control"" />
                <span asp-validation-for=""Icone"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""TipoId"" class=""control-label""></label>
                <select asp-for=""TipoId"" class =""form-control"" asp-items=""ViewBag.TipoId""></select>
            </div>
            <div class=""form-group"">
    ");
            WriteLiteral("            <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 41 "C:\Users\Diuel\Desktop\FPFTech\financeiro\financeiro.API\Views\Categorias\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<financeiro.DLL.Models.Categoria> Html { get; private set; }
    }
}
#pragma warning restore 1591