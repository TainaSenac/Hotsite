#pragma checksum "C:\Users\samue\OneDrive\Área de Trabalho\pi3\Views\Home\Slayer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab109d7a7523f5a89502610cbc1c6d26f37ae2e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Slayer), @"mvc.1.0.view", @"/Views/Home/Slayer.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab109d7a7523f5a89502610cbc1c6d26f37ae2e9", @"/Views/Home/Slayer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2a3d20ad84eb5c6a81c98716d9f3ded7ef52694", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Slayer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\samue\OneDrive\Área de Trabalho\pi3\Views\Home\Slayer.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""imagem"">
    <img id=""imagem"" src=""/imagens/camisaslayer.jpg"" width=""500"" height=""500"">
</div>

<div class=""produto"">
    <h1 id=""titulo"">Camiseta Slayer</h1>
    <h2>R$ 70,00</h2>
    <button class=""produto"">Comprar</button>
</div>

<style>
    #conteudo
    {
        margin-top: 30px;
        width: auto;
        margin-top: 50px;
    }
    div.produto
    {
        float: right;
        margin-left: 50px;
        margin-top: 50px;
    }
    div.imagem
    {
        float: left;
        margin-right: 20px;
        margin-top: 70px;
    }

</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
