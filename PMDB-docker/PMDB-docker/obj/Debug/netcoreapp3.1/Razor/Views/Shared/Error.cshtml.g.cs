#pragma checksum "D:\GitKraken\S2-KillerApp\PMDB-docker\PMDB-docker\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c7f7e2338cc37668adad65982bc87e7de7f1ef5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c7f7e2338cc37668adad65982bc87e7de7f1ef5", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c63435467c89406d2e875dac627f492d504a07d8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""mt-1"">
    <h4>An error occured while processing your request. The support team is notified and we are working on the fix</h4>
    <h5>Please contact us on support@meelsnet.nl</h5>
    <hr />
    <h5>Exception Details:</h5>
    <div class=""alert alert-danger"">
        <h6>Exception Path</h6>
        <hr />
        <p>");
#nullable restore
#line 9 "D:\GitKraken\S2-KillerApp\PMDB-docker\PMDB-docker\Views\Shared\Error.cshtml"
      Write(ViewBag.ExceptionPath);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div class=\"alert alert-danger\">\r\n        <h6>Exception Message</h6>\r\n        <hr />\r\n        <p>");
#nullable restore
#line 14 "D:\GitKraken\S2-KillerApp\PMDB-docker\PMDB-docker\Views\Shared\Error.cshtml"
      Write(ViewBag.ExceptionMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div class=\"alert alert-danger\">\r\n        <h6>Exception Stack Trace</h6>\r\n        <hr />\r\n        <p>");
#nullable restore
#line 19 "D:\GitKraken\S2-KillerApp\PMDB-docker\PMDB-docker\Views\Shared\Error.cshtml"
      Write(ViewBag.StackTrace);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n\r\n</div>");
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
