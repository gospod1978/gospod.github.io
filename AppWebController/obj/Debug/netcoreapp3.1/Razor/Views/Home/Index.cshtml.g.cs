#pragma checksum "/Users/gospod1978/Desktop/SoftUni/WEB_022020/AppWebController/gospod.github.io/AppWebController/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4397b793e6a5f83440330496b225c1ad5402927c"
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
#line 1 "/Users/gospod1978/Desktop/SoftUni/WEB_022020/AppWebController/gospod.github.io/AppWebController/Views/_ViewImports.cshtml"
using AppWebController;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/gospod1978/Desktop/SoftUni/WEB_022020/AppWebController/gospod.github.io/AppWebController/Views/_ViewImports.cshtml"
using AppWebController.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/gospod1978/Desktop/SoftUni/WEB_022020/AppWebController/gospod.github.io/AppWebController/Views/Home/Index.cshtml"
using AppWebController.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4397b793e6a5f83440330496b225c1ad5402927c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca426e08a42aa38c17cdbc0b3179fc134669e266", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppWebController.ViewModels.Home.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CurrentYearPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("greeting-string", "Hello!!!!", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::AppWebController.TagHelpers.GreetingHeaderTagHelper __AppWebController_TagHelpers_GreetingHeaderTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "/Users/gospod1978/Desktop/SoftUni/WEB_022020/AppWebController/gospod.github.io/AppWebController/Views/Home/Index.cshtml"
  
    /*
    taka moga da podpahna moi leyout

    Layout = "~/Views/Shared/_MyLayout.cshtml";

    */
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4397b793e6a5f83440330496b225c1ad5402927c4462", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<!--the same-->\n");
#nullable restore
#line 15 "/Users/gospod1978/Desktop/SoftUni/WEB_022020/AppWebController/gospod.github.io/AppWebController/Views/Home/Index.cshtml"
Write(await Html.PartialAsync("_CurrentYearPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Welcome</h1>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("h2", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4397b793e6a5f83440330496b225c1ad5402927c5937", async() => {
#nullable restore
#line 19 "/Users/gospod1978/Desktop/SoftUni/WEB_022020/AppWebController/gospod.github.io/AppWebController/Views/Home/Index.cshtml"
                               Write(Model.UpperMessage);

#line default
#line hidden
#nullable disable
            }
            );
            __AppWebController_TagHelpers_GreetingHeaderTagHelper = CreateTagHelper<global::AppWebController.TagHelpers.GreetingHeaderTagHelper>();
            __tagHelperExecutionContext.Add(__AppWebController_TagHelpers_GreetingHeaderTagHelper);
            __AppWebController_TagHelpers_GreetingHeaderTagHelper.GreetingString = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    <h3>");
#nullable restore
#line 20 "/Users/gospod1978/Desktop/SoftUni/WEB_022020/AppWebController/gospod.github.io/AppWebController/Views/Home/Index.cshtml"
   Write(ViewData["name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n    <h4>");
#nullable restore
#line 21 "/Users/gospod1978/Desktop/SoftUni/WEB_022020/AppWebController/gospod.github.io/AppWebController/Views/Home/Index.cshtml"
   Write(ViewBag.Family);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n    <h5>");
#nullable restore
#line 22 "/Users/gospod1978/Desktop/SoftUni/WEB_022020/AppWebController/gospod.github.io/AppWebController/Views/Home/Index.cshtml"
   Write(this.Context.Request.Headers["User-Agent"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n    <h6>");
#nullable restore
#line 23 "/Users/gospod1978/Desktop/SoftUni/WEB_022020/AppWebController/gospod.github.io/AppWebController/Views/Home/Index.cshtml"
   Write(this.User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n    <p>");
#nullable restore
#line 24 "/Users/gospod1978/Desktop/SoftUni/WEB_022020/AppWebController/gospod.github.io/AppWebController/Views/Home/Index.cshtml"
  Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p>");
#nullable restore
#line 25 "/Users/gospod1978/Desktop/SoftUni/WEB_022020/AppWebController/gospod.github.io/AppWebController/Views/Home/Index.cshtml"
  Write(DateTime.UtcNow.DayOfWeek);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n</div>\n\n<ul>\n");
#nullable restore
#line 29 "/Users/gospod1978/Desktop/SoftUni/WEB_022020/AppWebController/gospod.github.io/AppWebController/Views/Home/Index.cshtml"
     foreach (var name in Model.Names)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 31 "/Users/gospod1978/Desktop/SoftUni/WEB_022020/AppWebController/gospod.github.io/AppWebController/Views/Home/Index.cshtml"
       Write(StringManipulation.MakeFirstLetterUpper(name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 32 "/Users/gospod1978/Desktop/SoftUni/WEB_022020/AppWebController/gospod.github.io/AppWebController/Views/Home/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\n\n");
            DefineSection("Links", async() => {
                WriteLiteral("\n    <li class=\"nav-item\">\n        <a class=\"nav-link text-dark\" href=\"https://google.com\">Google ");
#nullable restore
#line 37 "/Users/gospod1978/Desktop/SoftUni/WEB_022020/AppWebController/gospod.github.io/AppWebController/Views/Home/Index.cshtml"
                                                                  Write(DateTime.UtcNow.Year);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\n    </li>\n");
            }
            );
            WriteLiteral("\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    <!-- <script>alert(\'Hello\')</script> -->\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringManipulation StringManipulation { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppWebController.ViewModels.Home.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
