#pragma checksum "D:\GitKraken\S2-KillerApp\PMDB-docker\PMDB-docker\Views\User\UserNotFound.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7ecf6961d1f06214909be28ec34d20a335489ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_UserNotFound), @"mvc.1.0.view", @"/Views/User/UserNotFound.cshtml")]
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
#line 1 "D:\GitKraken\S2-KillerApp\PMDB-docker\PMDB-docker\Views\_ViewImports.cshtml"
using PMDB_docker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitKraken\S2-KillerApp\PMDB-docker\PMDB-docker\Views\_ViewImports.cshtml"
using PMDB_docker.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\GitKraken\S2-KillerApp\PMDB-docker\PMDB-docker\Views\_ViewImports.cshtml"
using PMDB_docker.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7ecf6961d1f06214909be28ec34d20a335489ed", @"/Views/User/UserNotFound.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c63435467c89406d2e875dac627f492d504a07d8", @"/Views/_ViewImports.cshtml")]
    public class Views_User_UserNotFound : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\GitKraken\S2-KillerApp\PMDB-docker\PMDB-docker\Views\User\UserNotFound.cshtml"
  
    ViewBag.Title = "404 Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-danger mt-1 mb-1\">\r\n    <h4>404 Not Found Error: </h4>\r\n    <hr/>\r\n    <h5>\r\n        User with Id = ");
#nullable restore
#line 10 "D:\GitKraken\S2-KillerApp\PMDB-docker\PMDB-docker\Views\User\UserNotFound.cshtml"
                  Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(" cannot be found\r\n    </h5>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
