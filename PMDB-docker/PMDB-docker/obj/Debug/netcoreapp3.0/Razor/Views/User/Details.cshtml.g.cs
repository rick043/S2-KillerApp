#pragma checksum "D:\GitKraken\S2-KillerApp\PMDB-docker\PMDB-docker\Views\User\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01d725d3a9089d4afc58b12a6aa111494f46cd74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Details), @"mvc.1.0.view", @"/Views/User/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01d725d3a9089d4afc58b12a6aa111494f46cd74", @"/Views/User/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c63435467c89406d2e875dac627f492d504a07d8", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\GitKraken\S2-KillerApp\PMDB-docker\PMDB-docker\Views\User\Details.cshtml"
  
    ViewData["Title"] = "Details";
    var photoPath = $"~/img/profile/{@Model.User.ProfileImage ?? "noimage-face.png"}";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row m-4\">\r\n    <div class=\"col-3\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "01d725d3a9089d4afc58b12a6aa111494f46cd743960", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 9 "D:\GitKraken\S2-KillerApp\PMDB-docker\PMDB-docker\Views\User\Details.cshtml"
                            WriteLiteral(photoPath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 9 "D:\GitKraken\S2-KillerApp\PMDB-docker\PMDB-docker\Views\User\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <div class=\"form-group mt-2\">\r\n            <input type=\"submit\" value=\"Edit Profile\" class=\"btn btn-primary btn-block\" />\r\n        </div>\r\n    </div>\r\n    <div class=\"col\">\r\n        <h3>Hello ");
#nullable restore
#line 15 "D:\GitKraken\S2-KillerApp\PMDB-docker\PMDB-docker\Views\User\Details.cshtml"
             Write(Model.User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 15 "D:\GitKraken\S2-KillerApp\PMDB-docker\PMDB-docker\Views\User\Details.cshtml"
                                   Write(Model.User.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", how are you doing today</h3>\r\n        <hr/>\r\n        <table class=\"table table-borderless\">\r\n            <tbody>\r\n                <tr>\r\n                    <th>Username</th>\r\n                    <td class=\"text-muted\">");
#nullable restore
#line 21 "D:\GitKraken\S2-KillerApp\PMDB-docker\PMDB-docker\Views\User\Details.cshtml"
                                      Write(Model.User.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>First Name</th>\r\n                    <td class=\"text-muted\">");
#nullable restore
#line 25 "D:\GitKraken\S2-KillerApp\PMDB-docker\PMDB-docker\Views\User\Details.cshtml"
                                      Write(Model.User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Last Name</th>\r\n                    <td class=\"text-muted\">");
#nullable restore
#line 29 "D:\GitKraken\S2-KillerApp\PMDB-docker\PMDB-docker\Views\User\Details.cshtml"
                                      Write(Model.User.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Gender</th>\r\n                    <td class=\"text-muted\">");
#nullable restore
#line 33 "D:\GitKraken\S2-KillerApp\PMDB-docker\PMDB-docker\Views\User\Details.cshtml"
                                      Write(Model.User.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Date of Birth</th>\r\n                    <td class=\"text-muted\">");
#nullable restore
#line 37 "D:\GitKraken\S2-KillerApp\PMDB-docker\PMDB-docker\Views\User\Details.cshtml"
                                      Write(Model.User.DateOfBirth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Email</th>\r\n                    <td class=\"text-muted\">");
#nullable restore
#line 41 "D:\GitKraken\S2-KillerApp\PMDB-docker\PMDB-docker\Views\User\Details.cshtml"
                                      Write(Model.User.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Street</th>\r\n                    <td class=\"text-muted\">");
#nullable restore
#line 45 "D:\GitKraken\S2-KillerApp\PMDB-docker\PMDB-docker\Views\User\Details.cshtml"
                                      Write(Model.User.Street);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>House nr.</th>\r\n                    <td class=\"text-muted\">");
#nullable restore
#line 49 "D:\GitKraken\S2-KillerApp\PMDB-docker\PMDB-docker\Views\User\Details.cshtml"
                                      Write(Model.User.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Postalcode</th>\r\n                    <td class=\"text-muted\">");
#nullable restore
#line 53 "D:\GitKraken\S2-KillerApp\PMDB-docker\PMDB-docker\Views\User\Details.cshtml"
                                      Write(Model.User.PostalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Date of Registration</th>\r\n                    <td class=\"text-muted\">");
#nullable restore
#line 57 "D:\GitKraken\S2-KillerApp\PMDB-docker\PMDB-docker\Views\User\Details.cshtml"
                                      Write(Model.User.DateOfRegistration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591