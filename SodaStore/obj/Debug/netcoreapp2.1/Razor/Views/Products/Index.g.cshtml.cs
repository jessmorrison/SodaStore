#pragma checksum "C:\Users\jessm\Documents\CodingTemple\Week 8 - Entity Framework\SodaStore\SodaStore\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d55376c88a82bb1d650fb35a2bae1c8fb97945c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Index.cshtml", typeof(AspNetCore.Views_Products_Index))]
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
#line 1 "C:\Users\jessm\Documents\CodingTemple\Week 8 - Entity Framework\SodaStore\SodaStore\Views\_ViewImports.cshtml"
using SodaStore;

#line default
#line hidden
#line 2 "C:\Users\jessm\Documents\CodingTemple\Week 8 - Entity Framework\SodaStore\SodaStore\Views\_ViewImports.cshtml"
using SodaStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d55376c88a82bb1d650fb35a2bae1c8fb97945c", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72a468f37e66846834dec3fe7231e945029b9389", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SodaStore.Models.ProductViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\jessm\Documents\CodingTemple\Week 8 - Entity Framework\SodaStore\SodaStore\Views\Products\Index.cshtml"
  
    ViewData["Title"] = Model.Name;

#line default
#line hidden
            BeginContext(86, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(91, 10, false);
#line 5 "C:\Users\jessm\Documents\CodingTemple\Week 8 - Entity Framework\SodaStore\SodaStore\Views\Products\Index.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(101, 11, true);
            WriteLiteral("</h2>\r\n<img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 112, "\"", 147, 1);
#line 6 "C:\Users\jessm\Documents\CodingTemple\Week 8 - Entity Framework\SodaStore\SodaStore\Views\Products\Index.cshtml"
WriteAttributeValue("", 118, Url.Content(Model.ImagePath), 118, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 148, "\"", 165, 1);
#line 6 "C:\Users\jessm\Documents\CodingTemple\Week 8 - Entity Framework\SodaStore\SodaStore\Views\Products\Index.cshtml"
WriteAttributeValue("", 154, Model.Name, 154, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(166, 31, true);
            WriteLiteral(" class=\"img-responsive\" />\r\n<p>");
            EndContext();
            BeginContext(198, 17, false);
#line 7 "C:\Users\jessm\Documents\CodingTemple\Week 8 - Entity Framework\SodaStore\SodaStore\Views\Products\Index.cshtml"
Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(215, 10, true);
            WriteLiteral("</p>\r\n<h3>");
            EndContext();
            BeginContext(226, 25, false);
#line 8 "C:\Users\jessm\Documents\CodingTemple\Week 8 - Entity Framework\SodaStore\SodaStore\Views\Products\Index.cshtml"
Write(Model.Price.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(251, 7, true);
            WriteLiteral("</h3>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SodaStore.Models.ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591