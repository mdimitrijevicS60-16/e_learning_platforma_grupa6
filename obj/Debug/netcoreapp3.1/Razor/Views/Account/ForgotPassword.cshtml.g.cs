#pragma checksum "D:\code\c#\RvasProjekatSaIdentity\SolE_Learning_Platforma\E_Learning_Platforma\Views\Account\ForgotPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbed51b2813b9c49b8e0cb321a67446fa56bdd44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ForgotPassword), @"mvc.1.0.view", @"/Views/Account/ForgotPassword.cshtml")]
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
#line 1 "D:\code\c#\RvasProjekatSaIdentity\SolE_Learning_Platforma\E_Learning_Platforma\Views\_ViewImports.cshtml"
using E_Learning_Platforma;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\code\c#\RvasProjekatSaIdentity\SolE_Learning_Platforma\E_Learning_Platforma\Views\_ViewImports.cshtml"
using E_Learning_Platforma.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\code\c#\RvasProjekatSaIdentity\SolE_Learning_Platforma\E_Learning_Platforma\Views\_ViewImports.cshtml"
using E_Learning_Platforma.Models.AccountViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\code\c#\RvasProjekatSaIdentity\SolE_Learning_Platforma\E_Learning_Platforma\Views\_ViewImports.cshtml"
using E_Learning_Platforma.Models.ManageViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\code\c#\RvasProjekatSaIdentity\SolE_Learning_Platforma\E_Learning_Platforma\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbed51b2813b9c49b8e0cb321a67446fa56bdd44", @"/Views/Account/ForgotPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dc0c7b73400c3bde5eb0dd4125daa769c13d877", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ForgotPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<E_Learning_Platforma.Models.AccountViewModels.ForgotPasswordViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\code\c#\RvasProjekatSaIdentity\SolE_Learning_Platforma\E_Learning_Platforma\Views\Account\ForgotPassword.cshtml"
   ViewData["Title"] = "Forgot your password?"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>");
#nullable restore
#line 4 "D:\code\c#\RvasProjekatSaIdentity\SolE_Learning_Platforma\E_Learning_Platforma\Views\Account\ForgotPassword.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</h2>\n<p>\n  For more information on how to enable reset password please see this <a href=\"http://go.microsoft.com/fwlink/?LinkID=532713\">article</a>.\n</p>\n\n");
            WriteLiteral("\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n");
#nullable restore
#line 28 "D:\code\c#\RvasProjekatSaIdentity\SolE_Learning_Platforma\E_Learning_Platforma\Views\Account\ForgotPassword.cshtml"
     await Html.RenderPartialAsync("_ValidationScriptsPartial"); 

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<E_Learning_Platforma.Models.AccountViewModels.ForgotPasswordViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
