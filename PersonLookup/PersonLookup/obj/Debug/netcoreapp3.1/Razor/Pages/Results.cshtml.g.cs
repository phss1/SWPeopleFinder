#pragma checksum "C:\Users\v-peheis\source\repos\PersonLookup\PersonLookup\Pages\Results.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d9891e92d3e52971ccc3f87f193f1b59bbd99be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PersonLookup.Pages.Pages_Results), @"mvc.1.0.razor-page", @"/Pages/Results.cshtml")]
namespace PersonLookup.Pages
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
#line 1 "C:\Users\v-peheis\source\repos\PersonLookup\PersonLookup\Pages\_ViewImports.cshtml"
using PersonLookup;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d9891e92d3e52971ccc3f87f193f1b59bbd99be", @"/Pages/Results.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ad3843b914e4dc3ca8ea6ed0bc414143f1f2627", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Results : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Results</h1>\r\n\r\n<div class=\"card-deck\">\r\n");
#nullable restore
#line 9 "C:\Users\v-peheis\source\repos\PersonLookup\PersonLookup\Pages\Results.cshtml"
     foreach (var people in Model.people)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card-deck m-3\" style=\"min-width: 18rem\">\r\n    <div class=\"card-header text-center text-wrap\">\r\n        <h3>");
#nullable restore
#line 13 "C:\Users\v-peheis\source\repos\PersonLookup\PersonLookup\Pages\Results.cshtml"
       Write(people.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n    <div class=\"card-body text-left\">\r\n        ");
#nullable restore
#line 16 "C:\Users\v-peheis\source\repos\PersonLookup\PersonLookup\Pages\Results.cshtml"
   Write(people.height);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"card-body text-left\">\r\n        ");
#nullable restore
#line 19 "C:\Users\v-peheis\source\repos\PersonLookup\PersonLookup\Pages\Results.cshtml"
   Write(people.mass);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"card-body text-left\">\r\n        ");
#nullable restore
#line 22 "C:\Users\v-peheis\source\repos\PersonLookup\PersonLookup\Pages\Results.cshtml"
   Write(people.species);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n");
            WriteLiteral("</div>            ");
#nullable restore
#line 29 "C:\Users\v-peheis\source\repos\PersonLookup\PersonLookup\Pages\Results.cshtml"
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PersonLookup.Pages.ResultsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PersonLookup.Pages.ResultsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PersonLookup.Pages.ResultsModel>)PageContext?.ViewData;
        public PersonLookup.Pages.ResultsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
