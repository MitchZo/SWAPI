#pragma checksum "C:\Users\Grand Circus Student\source\repos\MZ\SWAPI\SWAPI\Views\Home\PlanetResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31092bb4a054b571a96f55bb527418bd08664add"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PlanetResults), @"mvc.1.0.view", @"/Views/Home/PlanetResults.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/PlanetResults.cshtml", typeof(AspNetCore.Views_Home_PlanetResults))]
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
#line 1 "C:\Users\Grand Circus Student\source\repos\MZ\SWAPI\SWAPI\Views\_ViewImports.cshtml"
using SWAPI;

#line default
#line hidden
#line 2 "C:\Users\Grand Circus Student\source\repos\MZ\SWAPI\SWAPI\Views\_ViewImports.cshtml"
using SWAPI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31092bb4a054b571a96f55bb527418bd08664add", @"/Views/Home/PlanetResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67a2a7524a3e15c6deb36b004187595012c6cbad", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PlanetResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SWAPI.Models.SWPlanet.Planet>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Grand Circus Student\source\repos\MZ\SWAPI\SWAPI\Views\Home\PlanetResults.cshtml"
  
    ViewData["Title"] = "Planets Results";

#line default
#line hidden
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(92, 38, true);
            WriteLiteral("\r\n<h1>Planet Results</h1>\r\n\r\nclimate: ");
            EndContext();
            BeginContext(131, 13, false);
#line 10 "C:\Users\Grand Circus Student\source\repos\MZ\SWAPI\SWAPI\Views\Home\PlanetResults.cshtml"
    Write(Model.climate);

#line default
#line hidden
            EndContext();
            BeginContext(144, 12, true);
            WriteLiteral("\r\ndiameter: ");
            EndContext();
            BeginContext(157, 14, false);
#line 11 "C:\Users\Grand Circus Student\source\repos\MZ\SWAPI\SWAPI\Views\Home\PlanetResults.cshtml"
     Write(Model.diameter);

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SWAPI.Models.SWPlanet.Planet> Html { get; private set; }
    }
}
#pragma warning restore 1591