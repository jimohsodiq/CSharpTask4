#pragma checksum "C:\Users\Toshiba\WebApplics\Views\WebApplics\SqrRoot.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b28072ad866cdf95555365f81f863fb0ad95d613"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WebApplics_SqrRoot), @"mvc.1.0.view", @"/Views/WebApplics/SqrRoot.cshtml")]
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
#line 1 "C:\Users\Toshiba\WebApplics\Views\_ViewImports.cshtml"
using WebApplics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Toshiba\WebApplics\Views\_ViewImports.cshtml"
using WebApplics.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b28072ad866cdf95555365f81f863fb0ad95d613", @"/Views/WebApplics/SqrRoot.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6b6c38bfc74dcd6db9b055f0661f6f718c7c6a2", @"/Views/_ViewImports.cshtml")]
    public class Views_WebApplics_SqrRoot : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "WebApplics", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SqrRoot", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\Toshiba\WebApplics\Views\WebApplics\SqrRoot.cshtml"
  
    ViewData["Title"] = "Square Root Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">The Square Root Calculator</h1>\r\n    \r\n</div>\r\n");
#nullable restore
#line 9 "C:\Users\Toshiba\WebApplics\Views\WebApplics\SqrRoot.cshtml"
  
if(ViewBag.firstNumbers<0 && ViewBag.secondNumbers<0)
{
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p> The number entered is invalid, pls change to a positive number</p>\r\n");
#nullable restore
#line 14 "C:\Users\Toshiba\WebApplics\Views\WebApplics\SqrRoot.cshtml"
    
}
else if(ViewBag.result == ViewBag.result2)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 18 "C:\Users\Toshiba\WebApplics\Views\WebApplics\SqrRoot.cshtml"
  Write(ViewBag.firstNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" has the same input ");
#nullable restore
#line 18 "C:\Users\Toshiba\WebApplics\Views\WebApplics\SqrRoot.cshtml"
                                          Write(ViewBag.result);

#line default
#line hidden
#nullable disable
            WriteLiteral(" as the second number ");
#nullable restore
#line 18 "C:\Users\Toshiba\WebApplics\Views\WebApplics\SqrRoot.cshtml"
                                                                               Write(ViewBag.result2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Pls enter another sets of numbers</p>\r\n");
#nullable restore
#line 20 "C:\Users\Toshiba\WebApplics\Views\WebApplics\SqrRoot.cshtml"
}
else if(ViewBag.result > ViewBag.result2)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>The first number as the highest square root of ");
#nullable restore
#line 23 "C:\Users\Toshiba\WebApplics\Views\WebApplics\SqrRoot.cshtml"
                                             Write(ViewBag.firstNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" which is ");
#nullable restore
#line 23 "C:\Users\Toshiba\WebApplics\Views\WebApplics\SqrRoot.cshtml"
                                                                           Write(ViewBag.result);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 24 "C:\Users\Toshiba\WebApplics\Views\WebApplics\SqrRoot.cshtml"
}
else if (ViewBag.result2 > ViewBag.result)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>The second number as the highest square root of ");
#nullable restore
#line 27 "C:\Users\Toshiba\WebApplics\Views\WebApplics\SqrRoot.cshtml"
                                              Write(ViewBag.secondNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" which is ");
#nullable restore
#line 27 "C:\Users\Toshiba\WebApplics\Views\WebApplics\SqrRoot.cshtml"
                                                                             Write(ViewBag.result2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 28 "C:\Users\Toshiba\WebApplics\Views\WebApplics\SqrRoot.cshtml"
}
else if(ViewBag.firstNumber==null & ViewBag.secondNumber==null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p> Your boxes are empty, pls input a number</p>\r\n");
#nullable restore
#line 32 "C:\Users\Toshiba\WebApplics\Views\WebApplics\SqrRoot.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b28072ad866cdf95555365f81f863fb0ad95d6137853", async() => {
                WriteLiteral("\r\n<input type=\"number\" PlaceHolder = \"First Number\" name= \"firstNumber\"/>\r\n<input type=\"number\" PlaceHolder = \"Second Number\" name = \"secondNumber\"/>\r\n<button type=\"submit\">Submit<button/> \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
