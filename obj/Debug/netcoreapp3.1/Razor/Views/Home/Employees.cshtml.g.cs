#pragma checksum "C:\Users\n\source\repos\Assessment6Mock\Views\Home\Employees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c8fa691b89d6d266c6960315dcacb1cd663c9d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Employees), @"mvc.1.0.view", @"/Views/Home/Employees.cshtml")]
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
#line 1 "C:\Users\n\source\repos\Assessment6Mock\Views\_ViewImports.cshtml"
using Assessment6Mock;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\n\source\repos\Assessment6Mock\Views\_ViewImports.cshtml"
using Assessment6Mock.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c8fa691b89d6d266c6960315dcacb1cd663c9d0", @"/Views/Home/Employees.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"360f77e6e938adf60b9c8fd0c54c658a4bcc5ab1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Employees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Employee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/RetirementInfo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\n\source\repos\Assessment6Mock\Views\Home\Employees.cshtml"
  
    ViewData["Title"] = "Home Page";



#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Employee</h1>\r\n   \r\n</div>\r\n\r\n<table>\r\n    <tr>\r\n        <th>First Name</th>\r\n        <th>Age</th>\r\n        <th>Salary</th>\r\n    </tr>\r\n");
#nullable restore
#line 20 "C:\Users\n\source\repos\Assessment6Mock\Views\Home\Employees.cshtml"
     foreach (var m in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\n\source\repos\Assessment6Mock\Views\Home\Employees.cshtml"
           Write(m.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\n\source\repos\Assessment6Mock\Views\Home\Employees.cshtml"
           Write(m.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\n\source\repos\Assessment6Mock\Views\Home\Employees.cshtml"
           Write(m.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\n\source\repos\Assessment6Mock\Views\Home\Employees.cshtml"
           Write(m.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 28 "C:\Users\n\source\repos\Assessment6Mock\Views\Home\Employees.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c8fa691b89d6d266c6960315dcacb1cd663c9d05702", async() => {
                WriteLiteral("\r\n    <input type=\"number\" name=\"id\" id=\"id\" />\r\n    <button class=\"btn btn-primary\">Submit</button>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
