#pragma checksum "C:\Users\it\Desktop\LinksSharingApp\Pages\Verify.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afcd78eeba112e9c27320adda546a016844bb5f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LinkShareApp.Pages.Pages_Verify), @"mvc.1.0.razor-page", @"/Pages/Verify.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Verify.cshtml", typeof(LinkShareApp.Pages.Pages_Verify), @"{Urlid}/{Code?}")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{Urlid}/{Code?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afcd78eeba112e9c27320adda546a016844bb5f8", @"/Pages/Verify.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcb91a78c21a358fb8554c48fb25a8acdb82390e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Verify : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\it\Desktop\LinksSharingApp\Pages\Verify.cshtml"
  
ViewData["Title"] = "Verify Access Code";

#line default
#line hidden
            BeginContext(95, 31, true);
            WriteLiteral("<div class=\"list-group mt-4\">\r\n");
            EndContext();
#line 7 "C:\Users\it\Desktop\LinksSharingApp\Pages\Verify.cshtml"
      
        var item= Model.Link;


#line default
#line hidden
            BeginContext(167, 116, true);
            WriteLiteral("    <div class=\"card col-4 offset-4 bg-white\">\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">");
            EndContext();
            BeginContext(284, 12, false);
#line 12 "C:\Users\it\Desktop\LinksSharingApp\Pages\Verify.cshtml"
                              Write(item.UrlName);

#line default
#line hidden
            EndContext();
            BeginContext(296, 40, true);
            WriteLiteral("</h5>\r\n            <p class=\"card-text\">");
            EndContext();
            BeginContext(337, 16, false);
#line 13 "C:\Users\it\Desktop\LinksSharingApp\Pages\Verify.cshtml"
                            Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(353, 185, true);
            WriteLiteral("</p>\r\n            <div class=\"form-group\">\r\n                <label for=\"code\" class=\"control-label\">Enetr Code</label>\r\n                <input type=\"text\" required id=\"code\" name=\"code\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 538, "\"", 557, 1);
#line 16 "C:\Users\it\Desktop\LinksSharingApp\Pages\Verify.cshtml"
WriteAttributeValue("", 546, Model.code, 546, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(558, 80, true);
            WriteLiteral(" class=\"form-control\" />\r\n                <input type=\"hidden\" id=\"id\" name=\"id\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 638, "\"", 654, 1);
#line 17 "C:\Users\it\Desktop\LinksSharingApp\Pages\Verify.cshtml"
WriteAttributeValue("", 646, item.ID, 646, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(655, 140, true);
            WriteLiteral(" />\r\n\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-outline-success\" onclick=\"GetCode()\">Go</button>\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 795, "\"", 824, 2);
            WriteAttributeValue("", 802, "/PurchaseCode/", 802, 14, true);
#line 21 "C:\Users\it\Desktop\LinksSharingApp\Pages\Verify.cshtml"
WriteAttributeValue("", 816, item.ID, 816, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(825, 103, true);
            WriteLiteral(" class=\"btn btn-outline-primary\" >Purchase Code</a>\r\n\r\n        </div>\r\n        \r\n        \r\n    </div>\r\n");
            EndContext();
            BeginContext(939, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VerifyModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<VerifyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<VerifyModel>)PageContext?.ViewData;
        public VerifyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
