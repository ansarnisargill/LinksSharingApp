#pragma checksum "C:\Users\Ansar\Desktop\LinksSharingApp\Pages\PurchaseCode.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4a545642a1d2a806c395c3a7067424afc98444f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LinkShareApp.Pages.Pages_PurchaseCode), @"mvc.1.0.razor-page", @"/Pages/PurchaseCode.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/PurchaseCode.cshtml", typeof(LinkShareApp.Pages.Pages_PurchaseCode), @"{Linkid}")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{Linkid}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4a545642a1d2a806c395c3a7067424afc98444f", @"/Pages/PurchaseCode.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcb91a78c21a358fb8554c48fb25a8acdb82390e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_PurchaseCode : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Ansar\Desktop\LinksSharingApp\Pages\PurchaseCode.cshtml"
  
ViewData["Title"] = "PurchaseCode";
Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(150, 273, true);
            WriteLiteral(@"<script src=""https://www.paypal.com/sdk/js?client-id=SB_CLIENT_ID&currency=USD"">
</script>
<script>
  paypal.Buttons({
    createOrder: function(data, actions) {
      return actions.order.create({
        purchase_units: [{
          amount: {
            value: '");
            EndContext();
            BeginContext(424, 22, false);
#line 15 "C:\Users\Ansar\Desktop\LinksSharingApp\Pages\PurchaseCode.cshtml"
               Write(Model.Link.PricePerDay);

#line default
#line hidden
            EndContext();
            BeginContext(446, 290, true);
            WriteLiteral(@"'
          }
        }]
      });
    },
    onApprove: function(data, actions) {
      // Capture the funds from the transaction
      return actions.order.capture().then(function(details) {
        // Show a success message to your buyer
        window.location.href=""/Checkout/");
            EndContext();
            BeginContext(737, 13, false);
#line 24 "C:\Users\Ansar\Desktop\LinksSharingApp\Pages\PurchaseCode.cshtml"
                                   Write(Model.Link.ID);

#line default
#line hidden
            EndContext();
            BeginContext(750, 75, true);
            WriteLiteral("\";\r\n      });\r\n    }\r\n  }).render(\'#paypal-button-container\');\r\n</script>\r\n");
            EndContext();
#line 29 "C:\Users\Ansar\Desktop\LinksSharingApp\Pages\PurchaseCode.cshtml"
   var item = Model.Link;

#line default
#line hidden
            BeginContext(852, 98, true);
            WriteLiteral("<div class=\"card col-4 offset-4 bg-white\">\r\n  <div class=\"card-body\">\r\n    <h5 class=\"card-title\">");
            EndContext();
            BeginContext(951, 12, false);
#line 32 "C:\Users\Ansar\Desktop\LinksSharingApp\Pages\PurchaseCode.cshtml"
                      Write(item.UrlName);

#line default
#line hidden
            EndContext();
            BeginContext(963, 32, true);
            WriteLiteral("</h5>\r\n    <p class=\"card-text\">");
            EndContext();
            BeginContext(996, 16, false);
#line 33 "C:\Users\Ansar\Desktop\LinksSharingApp\Pages\PurchaseCode.cshtml"
                    Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1012, 42, true);
            WriteLiteral(" <br /> Price for next 24 hour access is: ");
            EndContext();
            BeginContext(1055, 30, false);
#line 33 "C:\Users\Ansar\Desktop\LinksSharingApp\Pages\PurchaseCode.cshtml"
                                                                               Write(item.PricePerDay.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(1085, 540, true);
            WriteLiteral(@"</p>
    <!-- Example split danger button -->
    <div class=""btn-group"">
      <button type=""button"" class=""btn btn-outline-success"">Checkout</button>
      <button type=""button"" class=""btn btn-outline-success dropdown-toggle dropdown-toggle-split"" data-toggle=""dropdown""
        aria-haspopup=""true"" aria-expanded=""false"">
        <span class=""sr-only"">Toggle Dropdown</span>
      </button>
      <div class=""dropdown-menu"">
        <div id=""paypal-button-container""></div>
        <a class=""dropdown-item btn btn-outline-dark""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1625, "\"", 1650, 2);
            WriteAttributeValue("", 1632, "/Checkout/", 1632, 10, true);
#line 43 "C:\Users\Ansar\Desktop\LinksSharingApp\Pages\PurchaseCode.cshtml"
WriteAttributeValue("", 1642, item.ID, 1642, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1651, 65, true);
            WriteLiteral(">Via Cash</a>\r\n      </div>\r\n    </div>\r\n\r\n  </div>\r\n\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LinkShareApp.Pages.PurchaseCodeModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LinkShareApp.Pages.PurchaseCodeModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LinkShareApp.Pages.PurchaseCodeModel>)PageContext?.ViewData;
        public LinkShareApp.Pages.PurchaseCodeModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591