#pragma checksum "C:\Users\Grand Circus Student\source\repos\MZ\SWAPI\SWAPI\Views\Home\PersonResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f94d4377c874618966080bc4c4fbf79530e33670"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PersonResults), @"mvc.1.0.view", @"/Views/Home/PersonResults.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/PersonResults.cshtml", typeof(AspNetCore.Views_Home_PersonResults))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f94d4377c874618966080bc4c4fbf79530e33670", @"/Views/Home/PersonResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67a2a7524a3e15c6deb36b004187595012c6cbad", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PersonResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SWPerson.Person>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Grand Circus Student\source\repos\MZ\SWAPI\SWAPI\Views\Home\PersonResults.cshtml"
  
    ViewData["Title"] = "PersonResults";

#line default
#line hidden
            BeginContext(51, 26, true);
            WriteLiteral("\r\n<h1>PersonResults</h1>\r\n");
            EndContext();
            BeginContext(101, 13, true);
            WriteLiteral("\r\neye color: ");
            EndContext();
            BeginContext(115, 15, false);
#line 9 "C:\Users\Grand Circus Student\source\repos\MZ\SWAPI\SWAPI\Views\Home\PersonResults.cshtml"
      Write(Model.eye_color);

#line default
#line hidden
            EndContext();
            BeginContext(130, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SWPerson.Person> Html { get; private set; }
    }
}
#pragma warning restore 1591