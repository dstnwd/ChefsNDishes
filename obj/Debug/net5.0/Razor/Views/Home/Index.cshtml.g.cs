#pragma checksum "/Users/atlas/Coding Dojo /C#/ChefsNDishes/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19dc0c5e3fcdc5a22fdbcd3d072e09458b9decc4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/atlas/Coding Dojo /C#/ChefsNDishes/Views/_ViewImports.cshtml"
using ChefsNDishes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/atlas/Coding Dojo /C#/ChefsNDishes/Views/_ViewImports.cshtml"
using ChefsNDishes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19dc0c5e3fcdc5a22fdbcd3d072e09458b9decc4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3683dbd783bea45b88d0b0d3ee52e8ec1e5d61", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Chef>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/atlas/Coding Dojo /C#/ChefsNDishes/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""text-center"">
    <h1>Chefs | <a href=""/dishes"">Dishes</a></h1><br>
    <h2>Check out our roster of Chefs!</h2>
</div><br>
<div class=""col-6"">
        <table class=""table table-striped"">
            <tr>
                <th>Name</th>
                <th>Age</th>
                <th># of Dishes</th>
            </tr>
");
#nullable restore
#line 16 "/Users/atlas/Coding Dojo /C#/ChefsNDishes/Views/Home/Index.cshtml"
                  
                    foreach (Chef x in ViewBag.AllChefs)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 20 "/Users/atlas/Coding Dojo /C#/ChefsNDishes/Views/Home/Index.cshtml"
                           Write(x.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 20 "/Users/atlas/Coding Dojo /C#/ChefsNDishes/Views/Home/Index.cshtml"
                                        Write(x.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 21 "/Users/atlas/Coding Dojo /C#/ChefsNDishes/Views/Home/Index.cshtml"
                            Write(DateTime.Today.Year - @x.DOB.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 22 "/Users/atlas/Coding Dojo /C#/ChefsNDishes/Views/Home/Index.cshtml"
                           Write(x.MyDishes.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 24 "/Users/atlas/Coding Dojo /C#/ChefsNDishes/Views/Home/Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n</div><br>\r\n<a href=\"/new\">Add a Chef</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Chef> Html { get; private set; }
    }
}
#pragma warning restore 1591
