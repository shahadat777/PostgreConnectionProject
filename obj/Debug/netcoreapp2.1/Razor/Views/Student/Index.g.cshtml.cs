#pragma checksum "C:\Users\User\source\repos\MvcTestApp\MvcTestApp\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a769d7fe3fd4e4f6c14444b8f4c2b90205e23d77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/Index.cshtml", typeof(AspNetCore.Views_Student_Index))]
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
#line 1 "C:\Users\User\source\repos\MvcTestApp\MvcTestApp\Views\_ViewImports.cshtml"
using MvcTestApp;

#line default
#line hidden
#line 2 "C:\Users\User\source\repos\MvcTestApp\MvcTestApp\Views\_ViewImports.cshtml"
using MvcTestApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a769d7fe3fd4e4f6c14444b8f4c2b90205e23d77", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ab52c79a628e4e217140d33fcfb7c7da17c95bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MvcTestApp.Models.Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\User\source\repos\MvcTestApp\MvcTestApp\Views\Student\Index.cshtml"
  
    ViewData["Title"] = "Index";
    List<Student> students = (List<Student>) ViewBag.student;

#line default
#line hidden
            BeginContext(146, 51, true);
            WriteLiteral("\r\n<h2></h2>\r\n<table class=\"table table-bordered\">\r\n");
            EndContext();
#line 10 "C:\Users\User\source\repos\MvcTestApp\MvcTestApp\Views\Student\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(238, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(269, 15, false);
#line 13 "C:\Users\User\source\repos\MvcTestApp\MvcTestApp\Views\Student\Index.cshtml"
           Write(item.StudenName);

#line default
#line hidden
            EndContext();
            BeginContext(284, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(308, 10, false);
#line 14 "C:\Users\User\source\repos\MvcTestApp\MvcTestApp\Views\Student\Index.cshtml"
           Write(item.RegNo);

#line default
#line hidden
            EndContext();
            BeginContext(318, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(342, 10, false);
#line 15 "C:\Users\User\source\repos\MvcTestApp\MvcTestApp\Views\Student\Index.cshtml"
           Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(352, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(376, 9, false);
#line 16 "C:\Users\User\source\repos\MvcTestApp\MvcTestApp\Views\Student\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(385, 38, true);
            WriteLiteral("</td>\r\n            \r\n\r\n        </tr>\r\n");
            EndContext();
#line 20 "C:\Users\User\source\repos\MvcTestApp\MvcTestApp\Views\Student\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(430, 10, true);
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MvcTestApp.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
