#pragma checksum "C:\Users\HP\Desktop\classwork\classwork\Views\Pharmacy\Drug.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44c14012b6785745ed04b52f81ce1530679fe02e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pharmacy_Drug), @"mvc.1.0.view", @"/Views/Pharmacy/Drug.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\classwork\classwork\Views\_ViewImports.cshtml"
using classwork.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44c14012b6785745ed04b52f81ce1530679fe02e", @"/Views/Pharmacy/Drug.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e591b911cc62cee3eb8938f2c208412fb251a66", @"/Views/_ViewImports.cshtml")]
    public class Views_Pharmacy_Drug : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PharmacyIndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>List of Drugs:</h1>\r\n<ul>\r\n");
#nullable restore
#line 5 "C:\Users\HP\Desktop\classwork\classwork\Views\Pharmacy\Drug.cshtml"
     foreach (var drug in Model.Drugs)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 7 "C:\Users\HP\Desktop\classwork\classwork\Views\Pharmacy\Drug.cshtml"
       Write(drug.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 8 "C:\Users\HP\Desktop\classwork\classwork\Views\Pharmacy\Drug.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n<h1>List of Drug Types:</h1>\r\n\r\n<ul>\r\n");
#nullable restore
#line 14 "C:\Users\HP\Desktop\classwork\classwork\Views\Pharmacy\Drug.cshtml"
     foreach (var drugtype in Model.DrugTypes)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 16 "C:\Users\HP\Desktop\classwork\classwork\Views\Pharmacy\Drug.cshtml"
       Write(drugtype.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 17 "C:\Users\HP\Desktop\classwork\classwork\Views\Pharmacy\Drug.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PharmacyIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
