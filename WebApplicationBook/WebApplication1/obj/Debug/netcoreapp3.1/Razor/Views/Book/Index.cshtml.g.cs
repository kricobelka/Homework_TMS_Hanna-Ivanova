#pragma checksum "C:\Users\hijik\Visual Studio Community\repos\TMS\Homework TMS\Homework_TMS_Hanna-Ivanova\WebApplicationBook\WebApplication1\Views\Book\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b53dc7326af35ec43e57409057ea7ec14327ea63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Index), @"mvc.1.0.view", @"/Views/Book/Index.cshtml")]
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
#line 1 "C:\Users\hijik\Visual Studio Community\repos\TMS\Homework TMS\Homework_TMS_Hanna-Ivanova\WebApplicationBook\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hijik\Visual Studio Community\repos\TMS\Homework TMS\Homework_TMS_Hanna-Ivanova\WebApplicationBook\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b53dc7326af35ec43e57409057ea7ec14327ea63", @"/Views/Book/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<p>Book Info</p>\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\"> Book Information: </h1>\r\n    <h1 class=\"display-4\"> Title: ");
#nullable restore
#line 10 "C:\Users\hijik\Visual Studio Community\repos\TMS\Homework TMS\Homework_TMS_Hanna-Ivanova\WebApplicationBook\WebApplication1\Views\Book\Index.cshtml"
                             Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 10 "C:\Users\hijik\Visual Studio Community\repos\TMS\Homework TMS\Homework_TMS_Hanna-Ivanova\WebApplicationBook\WebApplication1\Views\Book\Index.cshtml"
                                           Write(Model.NumberOfPages);

#line default
#line hidden
#nullable disable
            WriteLiteral(" p.</h1>\r\n    <h1 class=\"display-4\"> Author: ");
#nullable restore
#line 11 "C:\Users\hijik\Visual Studio Community\repos\TMS\Homework TMS\Homework_TMS_Hanna-Ivanova\WebApplicationBook\WebApplication1\Views\Book\Index.cshtml"
                              Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
