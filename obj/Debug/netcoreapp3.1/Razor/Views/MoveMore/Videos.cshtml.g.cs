#pragma checksum "E:\Projects\BodiesPilates\Web\Views\MoveMore\Videos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c95a8b4a113ded0245f1d8b8e0faa1c061be33c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MoveMore_Videos), @"mvc.1.0.view", @"/Views/MoveMore/Videos.cshtml")]
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
#line 1 "E:\Projects\BodiesPilates\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects\BodiesPilates\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c95a8b4a113ded0245f1d8b8e0faa1c061be33c5", @"/Views/MoveMore/Videos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_MoveMore_Videos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.Models.MoveMoreViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "MoveMoreNavigation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Projects\BodiesPilates\Web\Views\MoveMore\Videos.cshtml"
  
    ViewData["Title"] = "Move More Members";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c95a8b4a113ded0245f1d8b8e0faa1c061be33c53519", async() => {
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
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 10 "E:\Projects\BodiesPilates\Web\Views\MoveMore\Videos.cshtml"
           int counter = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Projects\BodiesPilates\Web\Views\MoveMore\Videos.cshtml"
         foreach (var video in Model.Videos)
        {
            counter++;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md\">\r\n                <iframe");
            BeginWriteAttribute("src", " src=\"", 350, "\"", 371, 1);
#nullable restore
#line 15 "E:\Projects\BodiesPilates\Web\Views\MoveMore\Videos.cshtml"
WriteAttributeValue("", 356, video.VideoUrl, 356, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100%\" height=\"350\" frameborder=\"0\" allow=\"autoplay; fullscreen\"");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 443, "\"", 461, 0);
            EndWriteAttribute();
            WriteLiteral("></iframe>\r\n            </div>\r\n");
#nullable restore
#line 17 "E:\Projects\BodiesPilates\Web\Views\MoveMore\Videos.cshtml"
             if (counter % 2 == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"w-100\"></div>\r\n");
#nullable restore
#line 20 "E:\Projects\BodiesPilates\Web\Views\MoveMore\Videos.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\Projects\BodiesPilates\Web\Views\MoveMore\Videos.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.Models.MoveMoreViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591