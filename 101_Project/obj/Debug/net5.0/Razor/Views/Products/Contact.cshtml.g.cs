#pragma checksum "D:\Personal project-C#\.NET Full Stack course from Satr.Codes\ASP.NET Core MVC\101_Project\101_Project\Views\Products\Contact.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "641a3256da12ff88020142da7c0a2a9f203e94438da80f349422e5c0ff8ae918"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Contact), @"mvc.1.0.view", @"/Views/Products/Contact.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Personal project-C#\.NET Full Stack course from Satr.Codes\ASP.NET Core MVC\101_Project\101_Project\Views\_ViewImports.cshtml"
using _101_Project

#nullable disable
    ;
#nullable restore
#line 2 "D:\Personal project-C#\.NET Full Stack course from Satr.Codes\ASP.NET Core MVC\101_Project\101_Project\Views\_ViewImports.cshtml"
using _101_Project.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"641a3256da12ff88020142da7c0a2a9f203e94438da80f349422e5c0ff8ae918", @"/Views/Products/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"21c05b9d4cf38f9cba5d3c4386de5a1c9779948f7e6bda9041b920727b265e53", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Products_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Personal project-C#\.NET Full Stack course from Satr.Codes\ASP.NET Core MVC\101_Project\101_Project\Views\Products\Contact.cshtml"
  
    ViewData["Title"] = "Contact Fruit Shop";
    Product product = new Product();
    product = (Product)ViewData["city"];


#line default
#line hidden
#nullable disable

            WriteLiteral("<h1>");
            Write(
#nullable restore
#line 8 "D:\Personal project-C#\.NET Full Stack course from Satr.Codes\ASP.NET Core MVC\101_Project\101_Project\Views\Products\Contact.cshtml"
     ViewData["Title"]

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h1>\r\n<p>Dear valued customer we will be happy to contact with you and serve you ASAP, <br />thro Fruit Shop email.</p>\r\n<a href=\"mailto:abdulelahang@gmail.com\">Mail to Fruit Shop</a>\r\n<br />\r\n<br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
