#pragma checksum "C:\Users\it\Desktop\LinksSharingApp\Pages\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfe89c1858ae01cf71762082ff2bd2dc14cc3d97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LinkShareApp.Pages.Pages_Checkout), @"mvc.1.0.razor-page", @"/Pages/Checkout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Checkout.cshtml", typeof(LinkShareApp.Pages.Pages_Checkout), @"{id}/{date}")]
namespace LinkShareApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\it\Desktop\LinksSharingApp\Pages\_ViewImports.cshtml"
using LinkShareApp;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}/{date}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfe89c1858ae01cf71762082ff2bd2dc14cc3d97", @"/Pages/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcb91a78c21a358fb8554c48fb25a8acdb82390e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Checkout : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\it\Desktop\LinksSharingApp\Pages\Checkout.cshtml"
  
    ViewData["Title"] = "Checkout";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(153, 199, true);
            WriteLiteral("    <div class=\"card col-4 offset-4 bg-white\">\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">Use this code to unlock link!</h5>\r\n            <h1 class=\"card-text text-success\">");
            EndContext();
            BeginContext(353, 19, false);
#line 10 "C:\Users\it\Desktop\LinksSharingApp\Pages\Checkout.cshtml"
                                          Write(Model.Code.CodeTerm);

#line default
#line hidden
            EndContext();
            BeginContext(372, 45, true);
            WriteLiteral("</h1>\r\n\r\n\r\n        </div>\r\n\r\n\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LinkShareApp.Pages.CheckoutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LinkShareApp.Pages.CheckoutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LinkShareApp.Pages.CheckoutModel>)PageContext?.ViewData;
        public LinkShareApp.Pages.CheckoutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
