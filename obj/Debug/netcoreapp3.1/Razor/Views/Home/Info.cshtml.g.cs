#pragma checksum "C:\Users\samue\OneDrive\Área de Trabalho\pi3\Views\Home\Info.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23be87ce22bf8f3c987f2d7cd7f298d5100c9b1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Info), @"mvc.1.0.view", @"/Views/Home/Info.cshtml")]
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
#line 1 "C:\Users\samue\OneDrive\Área de Trabalho\pi3\Views\_ViewImports.cshtml"
using pi3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\samue\OneDrive\Área de Trabalho\pi3\Views\_ViewImports.cshtml"
using pi3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23be87ce22bf8f3c987f2d7cd7f298d5100c9b1a", @"/Views/Home/Info.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2a3d20ad84eb5c6a81c98716d9f3ded7ef52694", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Info : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Contato>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <h2>Listagem do fale conosco</h2>


    <table border=""2"">
        <thead>
            <tr>
                <th>Nome</th>
                <th>Necessidade</th>
                <th>Email</th>
                <th>Telefone</th>
                <th>Data</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 17 "C:\Users\samue\OneDrive\Área de Trabalho\pi3\Views\Home\Info.cshtml"
             foreach (Contato item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 20 "C:\Users\samue\OneDrive\Área de Trabalho\pi3\Views\Home\Info.cshtml"
                   Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 21 "C:\Users\samue\OneDrive\Área de Trabalho\pi3\Views\Home\Info.cshtml"
                   Write(item.Necessidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 22 "C:\Users\samue\OneDrive\Área de Trabalho\pi3\Views\Home\Info.cshtml"
                   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\samue\OneDrive\Área de Trabalho\pi3\Views\Home\Info.cshtml"
                   Write(item.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\samue\OneDrive\Área de Trabalho\pi3\Views\Home\Info.cshtml"
                   Write(item.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 695, "\"", 729, 2);
            WriteAttributeValue("", 702, "/Contato/Editar?Id=", 702, 19, true);
#nullable restore
#line 26 "C:\Users\samue\OneDrive\Área de Trabalho\pi3\Views\Home\Info.cshtml"
WriteAttributeValue("", 721, item.Id, 721, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 765, "\"", 800, 2);
            WriteAttributeValue("", 772, "/Contato/Remover?Id=", 772, 20, true);
#nullable restore
#line 27 "C:\Users\samue\OneDrive\Área de Trabalho\pi3\Views\Home\Info.cshtml"
WriteAttributeValue("", 792, item.Id, 792, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 30 "C:\Users\samue\OneDrive\Área de Trabalho\pi3\Views\Home\Info.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Contato>> Html { get; private set; }
    }
}
#pragma warning restore 1591
