#pragma checksum "C:\Users\Curtis\source\repos\Movies\Views\Home\MovieRegistration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4366b7396a78f23853c92064f30c4c04e59695a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MovieRegistration), @"mvc.1.0.view", @"/Views/Home/MovieRegistration.cshtml")]
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
#line 1 "C:\Users\Curtis\source\repos\Movies\Views\_ViewImports.cshtml"
using Movies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Curtis\source\repos\Movies\Views\_ViewImports.cshtml"
using Movies.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4366b7396a78f23853c92064f30c4c04e59695a3", @"/Views/Home/MovieRegistration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40a18b89cee963ad76943c7d00438584920fea09", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MovieRegistration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("../Home/DisplayPage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<h1>Movie Registration</h1>\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\Curtis\source\repos\Movies\Views\Home\MovieRegistration.cshtml"
Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4366b7396a78f23853c92064f30c4c04e59695a34158", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 14 "C:\Users\Curtis\source\repos\Movies\Views\Home\MovieRegistration.cshtml"
Write(Html.LabelFor(m => m.ID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 15 "C:\Users\Curtis\source\repos\Movies\Views\Home\MovieRegistration.cshtml"
Write(Html.ValidationMessageFor(m => m.ID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <input type=\"text\" name=\"ID\"");
                BeginWriteAttribute("value", " value=\"", 365, "\"", 382, 1);
#nullable restore
#line 16 "C:\Users\Curtis\source\repos\Movies\Views\Home\MovieRegistration.cshtml"
WriteAttributeValue("", 373, Model.ID, 373, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n    ");
#nullable restore
#line 18 "C:\Users\Curtis\source\repos\Movies\Views\Home\MovieRegistration.cshtml"
Write(Html.LabelFor(m => m.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 19 "C:\Users\Curtis\source\repos\Movies\Views\Home\MovieRegistration.cshtml"
Write(Html.ValidationMessageFor(m => m.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <input type=\"text\" name=\"Title\"");
                BeginWriteAttribute("value", " value=\"", 515, "\"", 535, 1);
#nullable restore
#line 20 "C:\Users\Curtis\source\repos\Movies\Views\Home\MovieRegistration.cshtml"
WriteAttributeValue("", 523, Model.Title, 523, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n    ");
#nullable restore
#line 22 "C:\Users\Curtis\source\repos\Movies\Views\Home\MovieRegistration.cshtml"
Write(Html.LabelFor(m => m.Genre));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 23 "C:\Users\Curtis\source\repos\Movies\Views\Home\MovieRegistration.cshtml"
Write(Html.ValidationMessageFor(m => m.Genre));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <input type=\"text\" name=\"Genre\"");
                BeginWriteAttribute("value", " value=\"", 668, "\"", 688, 1);
#nullable restore
#line 24 "C:\Users\Curtis\source\repos\Movies\Views\Home\MovieRegistration.cshtml"
WriteAttributeValue("", 676, Model.Genre, 676, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n    ");
#nullable restore
#line 26 "C:\Users\Curtis\source\repos\Movies\Views\Home\MovieRegistration.cshtml"
Write(Html.LabelFor(m => m.Year));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 27 "C:\Users\Curtis\source\repos\Movies\Views\Home\MovieRegistration.cshtml"
Write(Html.ValidationMessageFor(m => m.Year));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <input min=\"1880\"");
                BeginWriteAttribute("max", " max=\"", 805, "\"", 831, 1);
#nullable restore
#line 28 "C:\Users\Curtis\source\repos\Movies\Views\Home\MovieRegistration.cshtml"
WriteAttributeValue("", 811, DateTime.Today.Year, 811, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"number\" name=\"Year\"");
                BeginWriteAttribute("value", " value=\"", 858, "\"", 877, 1);
#nullable restore
#line 28 "C:\Users\Curtis\source\repos\Movies\Views\Home\MovieRegistration.cshtml"
WriteAttributeValue("", 866, Model.Year, 866, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n    ");
#nullable restore
#line 30 "C:\Users\Curtis\source\repos\Movies\Views\Home\MovieRegistration.cshtml"
Write(Html.LabelFor(m => m.Actors));

#line default
#line hidden
#nullable disable
                WriteLiteral("   \r\n    ");
#nullable restore
#line 31 "C:\Users\Curtis\source\repos\Movies\Views\Home\MovieRegistration.cshtml"
Write(Html.ValidationMessageFor(m => m.Actors));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <input type=\"text\" name=\"Actors\" pattern=\".{0}[a-zA-Z0-9 ]+|.{2,50}[a-zA-Z0-9 ]+\" title =\"Either 0 or 2-50 characters\" list=\"actors\"\r\n    >\r\n    <br />\r\n    ");
#nullable restore
#line 35 "C:\Users\Curtis\source\repos\Movies\Views\Home\MovieRegistration.cshtml"
Write(Html.LabelFor(m => m.Actors));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 36 "C:\Users\Curtis\source\repos\Movies\Views\Home\MovieRegistration.cshtml"
Write(Html.ValidationMessageFor(m => m.Actors));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <input type=\"text\" name=\"Actors\" pattern=\".{0}[a-zA-Z0-9 ]+|.{2,50}[a-zA-Z0-9 ]+\" title =\"Either 0 or 2-50 characters\" list=\"actors\"\r\n    >\r\n    <br />\r\n    ");
#nullable restore
#line 40 "C:\Users\Curtis\source\repos\Movies\Views\Home\MovieRegistration.cshtml"
Write(Html.LabelFor(m => m.Actors));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 41 "C:\Users\Curtis\source\repos\Movies\Views\Home\MovieRegistration.cshtml"
Write(Html.ValidationMessageFor(m => m.Actors));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <input type=\"text\" name=\"Actors\" pattern=\".{0}[a-zA-Z0-9 ]+|.{2,50}[a-zA-Z0-9 ]+\" title =\"Either 0 or 2-50 characters\" list=\"actors\"\r\n    >\r\n    <br />\r\n    ");
#nullable restore
#line 45 "C:\Users\Curtis\source\repos\Movies\Views\Home\MovieRegistration.cshtml"
Write(Html.LabelFor(m => m.Directors));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 46 "C:\Users\Curtis\source\repos\Movies\Views\Home\MovieRegistration.cshtml"
Write(Html.ValidationMessageFor(m => m.Directors));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <input type=\"text\" name=\"Directors\" pattern=\".{0}[a-zA-Z0-9 ]+|.{2,50}[a-zA-Z0-9 ]+\" title =\"Either 0 or 2-50 characters\" list=\"actors\"\r\n    >\r\n    <br />\r\n    ");
#nullable restore
#line 50 "C:\Users\Curtis\source\repos\Movies\Views\Home\MovieRegistration.cshtml"
Write(Html.LabelFor(m => m.Directors));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 51 "C:\Users\Curtis\source\repos\Movies\Views\Home\MovieRegistration.cshtml"
Write(Html.ValidationMessageFor(m => m.Directors));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <input type=\"text\" name=\"Directors\" pattern=\".{0}[a-zA-Z0-9 ]+|.{2,50}[a-zA-Z0-9 ]+\" title =\"Either 0 or 2-50 characters\" list=\"actors\"\r\n    >\r\n    <br />\r\n    ");
#nullable restore
#line 55 "C:\Users\Curtis\source\repos\Movies\Views\Home\MovieRegistration.cshtml"
Write(Html.LabelFor(m => m.Directors));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 56 "C:\Users\Curtis\source\repos\Movies\Views\Home\MovieRegistration.cshtml"
Write(Html.ValidationMessageFor(m => m.Directors));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <input type=\"text\" name=\"Directors\" pattern=\".{0}[a-zA-Z0-9 ]+|.{2,50}[a-zA-Z0-9 ]+\" title =\"Either 0 or 2-50 characters\" list=\"actors\"\r\n     >\r\n    <br/>\r\n    <input type=\"submit\" value=\"Add your movie!\" />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591