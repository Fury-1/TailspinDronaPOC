#pragma checksum "C:\Kelsa\Tailspin\Tailspin\src\Tailspin.Surveys.Web\Views\Shared\Forbidden.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76ac7781bb4e27419d3b2210c553f811a18ac2c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Forbidden), @"mvc.1.0.view", @"/Views/Shared/Forbidden.cshtml")]
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
#line 1 "C:\Kelsa\Tailspin\Tailspin\src\Tailspin.Surveys.Web\Views\_ViewImports.cshtml"
using Tailspin.Surveys;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Kelsa\Tailspin\Tailspin\src\Tailspin.Surveys.Web\Views\_ViewImports.cshtml"
using Tailspin.Surveys.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Kelsa\Tailspin\Tailspin\src\Tailspin.Surveys.Web\Views\_ViewImports.cshtml"
using Tailspin.Surveys.Data.DataModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Kelsa\Tailspin\Tailspin\src\Tailspin.Surveys.Web\Views\_ViewImports.cshtml"
using Tailspin.Surveys.Data.DTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76ac7781bb4e27419d3b2210c553f811a18ac2c8", @"/Views/Shared/Forbidden.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb54a3c936dfd8180b105a6124b9f1e824e684b7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Forbidden : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Kelsa\Tailspin\Tailspin\src\Tailspin.Surveys.Web\Views\Shared\Forbidden.cshtml"
  
    ViewData["Title"] = "Error: Forbidden";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>");
#nullable restore
#line 4 "C:\Kelsa\Tailspin\Tailspin\src\Tailspin.Surveys.Web\Views\Shared\Forbidden.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<h3 class=\"text-danger\">You do not have permission to access this resource.</h3>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
