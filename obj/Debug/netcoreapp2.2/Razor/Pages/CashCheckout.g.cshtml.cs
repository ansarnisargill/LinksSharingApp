#pragma checksum "C:\Users\Ansar\Desktop\LinksSharingApp\Pages\CashCheckout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9121510ad6b99d9a773a06aa1e586dc570810164"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LinkShareApp.Pages.Pages_CashCheckout), @"mvc.1.0.razor-page", @"/Pages/CashCheckout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/CashCheckout.cshtml", typeof(LinkShareApp.Pages.Pages_CashCheckout), @"{id}")]
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
#line 1 "C:\Users\Ansar\Desktop\LinksSharingApp\Pages\_ViewImports.cshtml"
using LinkShareApp;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9121510ad6b99d9a773a06aa1e586dc570810164", @"/Pages/CashCheckout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcb91a78c21a358fb8554c48fb25a8acdb82390e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CashCheckout : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Ansar\Desktop\LinksSharingApp\Pages\CashCheckout.cshtml"
  
    ViewData["Title"] = "Checkout";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(150, 146, true);
            WriteLiteral("    <div class=\"card col-4 offset-4 bg-white\">\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">You can get secret link about ");
            EndContext();
            BeginContext(297, 18, false);
#line 9 "C:\Users\Ansar\Desktop\LinksSharingApp\Pages\CashCheckout.cshtml"
                                                            Write(Model.link.UrlName);

#line default
#line hidden
            EndContext();
            BeginContext(315, 11, true);
            WriteLiteral(" by paying ");
            EndContext();
            BeginContext(327, 36, false);
#line 9 "C:\Users\Ansar\Desktop\LinksSharingApp\Pages\CashCheckout.cshtml"
                                                                                          Write(Model.link.PricePerDay.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(363, 44, true);
            WriteLiteral(" </h5>\r\n\r\n        </div>\r\n\r\n\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LinkShareApp.Pages.CashCheckoutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LinkShareApp.Pages.CashCheckoutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LinkShareApp.Pages.CashCheckoutModel>)PageContext?.ViewData;
        public LinkShareApp.Pages.CashCheckoutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
