#pragma checksum "C:\Aula-124\AluguelCarro\AluguelCarro\Views\Shared\Components\Endereco\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0cb14d99a78c80a887091917d78d04cb0846fd4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Endereco_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Endereco/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Endereco/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Endereco_Default))]
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
#line 1 "C:\Aula-124\AluguelCarro\AluguelCarro\Views\_ViewImports.cshtml"
using AluguelCarro;

#line default
#line hidden
#line 2 "C:\Aula-124\AluguelCarro\AluguelCarro\Views\_ViewImports.cshtml"
using AluguelCarro.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0cb14d99a78c80a887091917d78d04cb0846fd4", @"/Views/Shared/Components/Endereco/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d2238d675ed3ec8fac612f13c4b1dbea016e2f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Endereco_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AluguelCarro.Models.Endereco>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Enderecos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("tooltip"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-placement", new global::Microsoft.AspNetCore.Html.HtmlString("top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Atualizar endereço"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Aula-124\AluguelCarro\AluguelCarro\Views\Shared\Components\Endereco\Default.cshtml"
  
    var controller = "Enderecos";

#line default
#line hidden
            BeginContext(94, 112, true);
            WriteLiteral("\r\n<table class=\"table table-hover table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(207, 39, false);
#line 11 "C:\Aula-124\AluguelCarro\AluguelCarro\Views\Shared\Components\Endereco\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.Rua));

#line default
#line hidden
            EndContext();
            BeginContext(246, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(302, 42, false);
#line 14 "C:\Aula-124\AluguelCarro\AluguelCarro\Views\Shared\Components\Endereco\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(344, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(400, 42, false);
#line 17 "C:\Aula-124\AluguelCarro\AluguelCarro\Views\Shared\Components\Endereco\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(442, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(498, 42, false);
#line 20 "C:\Aula-124\AluguelCarro\AluguelCarro\Views\Shared\Components\Endereco\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(540, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(596, 42, false);
#line 23 "C:\Aula-124\AluguelCarro\AluguelCarro\Views\Shared\Components\Endereco\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(638, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 29 "C:\Aula-124\AluguelCarro\AluguelCarro\Views\Shared\Components\Endereco\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(773, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(834, 38, false);
#line 33 "C:\Aula-124\AluguelCarro\AluguelCarro\Views\Shared\Components\Endereco\Default.cshtml"
               Write(Html.DisplayFor(modelItem => item.Rua));

#line default
#line hidden
            EndContext();
            BeginContext(872, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(940, 41, false);
#line 36 "C:\Aula-124\AluguelCarro\AluguelCarro\Views\Shared\Components\Endereco\Default.cshtml"
               Write(Html.DisplayFor(modelItem => item.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(981, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1049, 41, false);
#line 39 "C:\Aula-124\AluguelCarro\AluguelCarro\Views\Shared\Components\Endereco\Default.cshtml"
               Write(Html.DisplayFor(modelItem => item.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(1090, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1158, 41, false);
#line 42 "C:\Aula-124\AluguelCarro\AluguelCarro\Views\Shared\Components\Endereco\Default.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(1199, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1267, 41, false);
#line 45 "C:\Aula-124\AluguelCarro\AluguelCarro\Views\Shared\Components\Endereco\Default.cshtml"
               Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1308, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1375, 213, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51d4c72d3bad4a4ea6b4dd6c39aadc60", async() => {
                BeginContext(1557, 27, true);
                WriteLiteral("<i class=\"far fa-edit\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "C:\Aula-124\AluguelCarro\AluguelCarro\Views\Shared\Components\Endereco\Default.cshtml"
                                                                      WriteLiteral(item.EnderecoId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1588, 130, true);
            WriteLiteral(" &nbsp;\r\n                    <a class=\"btn btn-outline-danger\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Excluir endereço\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1718, "\"", 1791, 9);
            WriteAttributeValue("", 1728, "ConfirmarExclusao(", 1728, 18, true);
#line 49 "C:\Aula-124\AluguelCarro\AluguelCarro\Views\Shared\Components\Endereco\Default.cshtml"
WriteAttributeValue("", 1746, item.EnderecoId, 1746, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 1762, ",", 1762, 1, true);
            WriteAttributeValue(" ", 1763, "\'", 1764, 2, true);
#line 49 "C:\Aula-124\AluguelCarro\AluguelCarro\Views\Shared\Components\Endereco\Default.cshtml"
WriteAttributeValue("", 1765, item.Rua, 1765, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 1774, "\',", 1774, 2, true);
            WriteAttributeValue(" ", 1776, "\'", 1777, 2, true);
#line 49 "C:\Aula-124\AluguelCarro\AluguelCarro\Views\Shared\Components\Endereco\Default.cshtml"
WriteAttributeValue("", 1778, controller, 1778, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 1789, "\')", 1789, 2, true);
            EndWriteAttribute();
            BeginContext(1792, 81, true);
            WriteLiteral("><i class=\"fas fa-trash-alt\"></i></a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 52 "C:\Aula-124\AluguelCarro\AluguelCarro\Views\Shared\Components\Endereco\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(1884, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AluguelCarro.Models.Endereco>> Html { get; private set; }
    }
}
#pragma warning restore 1591