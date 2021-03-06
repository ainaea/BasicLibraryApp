#pragma checksum "C:\CodebitsAcademy\ClassSession\ASP.NETCore\BasicLibraryManagementSystem\Views\Home\DisplayBooks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8742564cbfc12ded9b0941e5ddb4ce3caaa302d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DisplayBooks), @"mvc.1.0.view", @"/Views/Home/DisplayBooks.cshtml")]
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
#line 1 "C:\CodebitsAcademy\ClassSession\ASP.NETCore\BasicLibraryManagementSystem\Views\_ViewImports.cshtml"
using BasicLibraryManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\CodebitsAcademy\ClassSession\ASP.NETCore\BasicLibraryManagementSystem\Views\_ViewImports.cshtml"
using BasicLibraryManagementSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8742564cbfc12ded9b0941e5ddb4ce3caaa302d", @"/Views/Home/DisplayBooks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5318cdf5828a31a6512c302bfb0efc8550f8b12f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DisplayBooks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\CodebitsAcademy\ClassSession\ASP.NETCore\BasicLibraryManagementSystem\Views\Home\DisplayBooks.cshtml"
        
    ViewData["Title"] = "Search result";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\CodebitsAcademy\ClassSession\ASP.NETCore\BasicLibraryManagementSystem\Views\Home\DisplayBooks.cshtml"
 if(Model.Count<Book>() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Oops! No matching found </p> \r\n");
#nullable restore
#line 10 "C:\CodebitsAcademy\ClassSession\ASP.NETCore\BasicLibraryManagementSystem\Views\Home\DisplayBooks.cshtml"
}else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-responsive table-striped mt-5\">\r\n    <tr>\r\n        <th>ISBN</th>\r\n        <th>Title</th>\r\n        <th>Author</th>\r\n        <th>Edition</th>\r\n        <th>Publisher</th>\r\n    </tr>\r\n\r\n\r\n");
#nullable restore
#line 22 "C:\CodebitsAcademy\ClassSession\ASP.NETCore\BasicLibraryManagementSystem\Views\Home\DisplayBooks.cshtml"
     foreach (Book book in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 25 "C:\CodebitsAcademy\ClassSession\ASP.NETCore\BasicLibraryManagementSystem\Views\Home\DisplayBooks.cshtml"
       Write(book.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8742564cbfc12ded9b0941e5ddb4ce3caaa302d5364", async() => {
#nullable restore
#line 26 "C:\CodebitsAcademy\ClassSession\ASP.NETCore\BasicLibraryManagementSystem\Views\Home\DisplayBooks.cshtml"
                                                                              Write(book.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\CodebitsAcademy\ClassSession\ASP.NETCore\BasicLibraryManagementSystem\Views\Home\DisplayBooks.cshtml"
                                                         WriteLiteral(book.BookId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 27 "C:\CodebitsAcademy\ClassSession\ASP.NETCore\BasicLibraryManagementSystem\Views\Home\DisplayBooks.cshtml"
       Write(book.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 28 "C:\CodebitsAcademy\ClassSession\ASP.NETCore\BasicLibraryManagementSystem\Views\Home\DisplayBooks.cshtml"
       Write(book.Edition);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 29 "C:\CodebitsAcademy\ClassSession\ASP.NETCore\BasicLibraryManagementSystem\Views\Home\DisplayBooks.cshtml"
       Write(book.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n");
#nullable restore
#line 31 "C:\CodebitsAcademy\ClassSession\ASP.NETCore\BasicLibraryManagementSystem\Views\Home\DisplayBooks.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n</table>  \r\n");
#nullable restore
#line 36 "C:\CodebitsAcademy\ClassSession\ASP.NETCore\BasicLibraryManagementSystem\Views\Home\DisplayBooks.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
