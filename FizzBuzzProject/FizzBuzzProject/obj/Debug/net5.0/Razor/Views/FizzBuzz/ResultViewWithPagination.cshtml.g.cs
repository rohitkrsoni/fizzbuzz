#pragma checksum "C:\Users\krroh\Documents\fizzbuzz\FizzBuzzProject\FizzBuzzProject\Views\FizzBuzz\ResultViewWithPagination.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77a6c26b6c0d9fb5aed672347785b00fc0f36d68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FizzBuzz_ResultViewWithPagination), @"mvc.1.0.view", @"/Views/FizzBuzz/ResultViewWithPagination.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\krroh\Documents\fizzbuzz\FizzBuzzProject\FizzBuzzProject\Views\_ViewImports.cshtml"
using FizzBuzzProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\krroh\Documents\fizzbuzz\FizzBuzzProject\FizzBuzzProject\Views\FizzBuzz\ResultViewWithPagination.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\krroh\Documents\fizzbuzz\FizzBuzzProject\FizzBuzzProject\Views\FizzBuzz\ResultViewWithPagination.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\krroh\Documents\fizzbuzz\FizzBuzzProject\FizzBuzzProject\Views\FizzBuzz\ResultViewWithPagination.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77a6c26b6c0d9fb5aed672347785b00fc0f36d68", @"/Views/FizzBuzz/ResultViewWithPagination.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58b4acacea3ab3d6067fd25b37a4a20ee14ca4a3", @"/Views/_ViewImports.cshtml")]
    public class Views_FizzBuzz_ResultViewWithPagination : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FizzBuzzViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "FizzBuzz", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 5 "C:\Users\krroh\Documents\fizzbuzz\FizzBuzzProject\FizzBuzzProject\Views\FizzBuzz\ResultViewWithPagination.cshtml"
   DateTime dateInput = DateTime.Today;
    DayOfWeek today = dateInput.DayOfWeek; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-sm-12 text-center\">\n    <label class=\"col-sm-2 h5 \">Given Number : ");
#nullable restore
#line 8 "C:\Users\krroh\Documents\fizzbuzz\FizzBuzzProject\FizzBuzzProject\Views\FizzBuzz\ResultViewWithPagination.cshtml"
                                          Write(Model.User_Input);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77a6c26b6c0d9fb5aed672347785b00fc0f36d685294", async() => {
                WriteLiteral("Change");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n<div class=\"container \">\n\n");
#nullable restore
#line 13 "C:\Users\krroh\Documents\fizzbuzz\FizzBuzzProject\FizzBuzzProject\Views\FizzBuzz\ResultViewWithPagination.cshtml"
     foreach (var s in Model.FizzBuzzNumbers)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<h4");
            BeginWriteAttribute("class", " class=\"", 461, "\"", 471, 1);
#nullable restore
#line 15 "C:\Users\krroh\Documents\fizzbuzz\FizzBuzzProject\FizzBuzzProject\Views\FizzBuzz\ResultViewWithPagination.cshtml"
WriteAttributeValue("", 469, s, 469, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "C:\Users\krroh\Documents\fizzbuzz\FizzBuzzProject\FizzBuzzProject\Views\FizzBuzz\ResultViewWithPagination.cshtml"
          Write(s);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>");
#nullable restore
#line 15 "C:\Users\krroh\Documents\fizzbuzz\FizzBuzzProject\FizzBuzzProject\Views\FizzBuzz\ResultViewWithPagination.cshtml"
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 17 "C:\Users\krroh\Documents\fizzbuzz\FizzBuzzProject\FizzBuzzProject\Views\FizzBuzz\ResultViewWithPagination.cshtml"
Write(Html.PagedListPager((IPagedList)ViewBag.PagedList, page => Url.Action("ResultViewWithPagination", new { @page=page, @fizzBuzzViewModel=Model })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FizzBuzzViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591